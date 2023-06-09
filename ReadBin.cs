using Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Windows.Forms;
using Range = Microsoft.Office.Interop.Excel.Range;

namespace ReadBin4 {
    internal class ReadBin {
        public static void Read(string folderPath, string filePath, MainForm form) {
            Stopwatch sw = new Stopwatch();
            Debug.WriteLine("Hello");
            string[] inFiles = Directory.GetFiles(folderPath);

            List<string> fileNameList = new List<string>();
            List<string> fields = new List<string>();
            Area[] areas = AreaFileManager.ReadFile(filePath);
            foreach (Area area in areas) {
                foreach (Pattern pattern in area.patterns) {
                    foreach (string field in pattern.data.Keys) {
                        fields.Add($"{area.name}_{field}");
                    }
                }
            }
            
            int fileCount = 0;
            foreach (string file in inFiles) {
                if (file.Contains(".bin")) {
                    fileCount++;
                    fileNameList.Add(file);
                }
            }
            double[][] zooweemama = new double[fileNameList.Count][];
            Debug.WriteLine($"fileName = {fileNameList[0]}");

            List<int> testList = new List<int>();
            testList.AddRange(Enumerable.Range(0, fileNameList.Count));
            Parallel.ForEach(testList, x => ProcessData(x, fileNameList, zooweemama, areas, form));
            form.SetProgressBar(100);
            sw.Restart();
            WriteExcel(fields.ToArray(), zooweemama, fileNameList.ToArray());
            sw.Stop(); Debug.WriteLine("Write Excel " + sw.ElapsedMilliseconds);
        }

        private static void ProcessData(int iteration, List<string> fileNameList, double[][] zooweemama, Area[] areasOG, MainForm form) {
            Stopwatch sw = new Stopwatch();
            form.UpdateProgressBar(100 / fileNameList.Count);
            form.Update();
            string inFile = fileNameList[iteration];
            Area[] areas = new Area[areasOG.Length];

            for (int i = 0; i < areasOG.Length; i++) {
                Area a = new Area(areasOG[i].coordinates, areasOG[i].name);
                List<Pattern> patterns = new List<Pattern>();
                foreach (Pattern p in areasOG[i].patterns) {
                    patterns.Add(p.Copy());
                }
                a.AddPatterns(patterns);
                areas[i] = a;
            }

            sw.Restart();
            // Read file and get total number of columns and rows from first four bytes of file
            byte[] fileBytes = File.ReadAllBytes(inFile);
            int fileColumns = Convert.ToInt16(fileBytes[0] + fileBytes[1] * 256);
            int fileRows = Convert.ToInt16(fileBytes[2] + fileBytes[3] * 256);
            sw.Stop(); Debug.WriteLine("Read image file " + sw.ElapsedMilliseconds);

            sw.Restart();
            // Create a 2D array of pixels for entire file (minus first four bytes which represent picture size)
            short[,] fileInts = new short[fileRows, fileColumns];
            int column = 0;
            int row = 0;
            for (int i = 4; i < fileBytes.Length; i += 2) {
                fileInts[row, column] = Convert.ToInt16(fileBytes[i] + fileBytes[i + 1] * 256);
                column = (column + 1) % fileColumns;
                if (column == 0) row++;
            }
            sw.Stop(); Debug.WriteLine("Create fileInts " + sw.ElapsedMilliseconds);

            sw.Restart();
            // Gather pixel data
            foreach (Area area in areas) {
                int r = 0;
                for (int i1 = area.coordinates[1] - 1; i1 < area.coordinates[3]; i1++) {
                    int c = 0;
                    for (int j1 = area.coordinates[0] - 1; j1 < area.coordinates[2]; j1++) {
                        short value = fileInts[i1, j1];
                        foreach (Pattern pattern in area.patterns) {
                            string field = pattern.pattern[(r % pattern.rows) * pattern.columns + (c % pattern.columns)];
                            if (field == "N") continue;
                            pattern.data[field] += value;
                            pattern.dataCount[field]++;
                        }
                        c++;
                    }
                    r++;
                }
            }
            sw.Stop(); Debug.WriteLine("Gather pixel data " + sw.ElapsedMilliseconds);

            // Divide pixel data by number to get averages and create list of all column names
            List<double> values = new List<double>();
            foreach (Area area in areas) {
                foreach (Pattern pattern in area.patterns) {
                    foreach (string field in pattern.data.Keys) {
                        pattern.data[field] /= pattern.dataCount[field];
                        values.Add(pattern.data[field]);
                    }
                }
            }
            zooweemama[iteration] = values.ToArray();
            Debug.WriteLine(zooweemama[iteration][0]);
        }

        private static void WriteExcel(string[] fields, double[][] values, string[] files) {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Open("C:\\Users\\7000033387\\OneDrive - Sony\\Desktop\\poop.xlsx");
            Worksheet ws = wb.Worksheets[1];
            ws.Cells.ClearContents();

            string excelColumn = GetExcelColumnName(fields.Length + 1);
            Range cellRange = ws.Range[$"B1:{excelColumn}1"];
            cellRange.set_Value(XlRangeValueDataType.xlRangeValueDefault, fields);

            for (int i = 0; i < files.Length; i++) {
                try {
                    cellRange = ws.Range[$"A{i + 2}"];
                    cellRange.set_Value(XlRangeValueDataType.xlRangeValueDefault, files[i]);
                    cellRange = ws.Range[$"B{i + 2}:{excelColumn}{i + 2}"];
                    cellRange.set_Value(XlRangeValueDataType.xlRangeValueDefault, values[i]);
                }
                catch (Exception ex) {
                    wb.Close();
                    throw;
                }
            }
            wb.Save();
            wb.Close();
            excel.Quit();
        }

        private static string GetExcelColumnName(int columnNumber) {
            string columnName = "";

            while (columnNumber > 0) {
                int modulo = (columnNumber - 1) % 26;
                columnName = Convert.ToChar('A' + modulo) + columnName;
                columnNumber = (columnNumber - modulo) / 26;
            }

            return columnName;
        }
    }
}
