﻿namespace ReadBin4 {
    class AreaFileManager {
        public static void WriteFile(Area[] areas, string fileName) {
            StreamWriter sw = new StreamWriter(fileName);
            foreach (Area area in areas) {
                sw.WriteLine("AREA:");
                sw.WriteLine(area.name);
                sw.WriteLine($"{area.coordinates[0]} {area.coordinates[1]} {area.coordinates[2]} {area.coordinates[3]}");
                foreach (Pattern p in area.patterns) {
                    sw.WriteLine("PATTERN:");
                    sw.WriteLine($"{p.rows} {p.columns}");
                    for (int i = 0; i < p.pattern.Length; i++) {
                        sw.Write($"{p.pattern[i]}, ");
                        if (i % p.columns == p.columns - 1) sw.WriteLine();
                    }
                    sw.WriteLine();
                }
                sw.WriteLine();
            }
            sw.Close();
        }

        public static Area[] ReadFile(string fileName) {
            StreamReader sr = new StreamReader(fileName);
            string line;
            string areaName = "";
            string[] lineArray;
            int[] coordinates = new int[4];
            string[] stringArray;
            List<string> stuff = new List<string>();
            List<Pattern> patternList = new List<Pattern>();
            List<Area> areas = new List<Area>();
            while ((line = sr.ReadLine()) != null) {
                if (line.Length < 1) continue;
                if (line == "AREA:") {
                    if (patternList.Count > 0) {
                        areas.Add(new Area(CopyIntArray(coordinates), CopyPatternList(patternList), areaName));
                    }
                    patternList.Clear();
                    line = sr.ReadLine();
                    if (line != null) areaName = line;
                    stringArray = sr.ReadLine().Split(' ');
                    for (int i = 0; i < 4; i++) coordinates[i] = int.Parse(stringArray[i]);
                }
                if (line == "PATTERN:") {
                    line = sr.ReadLine();
                    string[] rowsColumns = line.Split(' ');
                    for (int r = 0; r < Convert.ToInt32(rowsColumns[0]); r++) {
                        line = sr.ReadLine();
                        for (int i = line.Length - 1; i >= 0; i--) { // Remove trailing spaces and commas
                            if (line[i] == ' ' || line[i] == ',') {
                                line = line.Remove(i);
                            }
                            else break;
                        }
                        lineArray = line.Replace(" ", "").Split(',');
                        foreach (string s in lineArray) {
                            stuff.Add(s);
                        }
                    }
                    patternList.Add(new Pattern(Convert.ToInt32(rowsColumns[0]), Convert.ToInt32(rowsColumns[1]), CopyToStringArray(stuff)));
                    stuff.Clear();
                }
            }
            areas.Add(new Area(coordinates, patternList, areaName));
            sr.Close();

            Area[] areaArray = new Area[areas.Count];
            for (int i = 0; i < areas.Count; i++) {
                areaArray[i] = areas[i];
            }
            return areaArray;
        }

        private static string[] CopyToStringArray(List<string> stuff) {
            string[] s = new string[stuff.Count];
            for (int i = 0; i < stuff.Count; i++) {
                s[i] = stuff[i];
            }
            return s;
        }

        private static int[] CopyIntArray(int[] ints) {
            int[] i = new int[ints.Length];
            ints.CopyTo(i, 0);
            return i;
        }

        private static List<Pattern> CopyPatternList(List<Pattern> list) {
            List<Pattern> list2 = new List<Pattern>();
            foreach (Pattern pattern in list) {
                list2.Add(pattern);
            }
            return list2;
        }

        public static void WriteTextFile(string yeetFile, string txtFile) {
            Area[] areas = ReadFile(yeetFile);
            StreamWriter sw = new StreamWriter(txtFile);
            int colStart, rowStart, colNumber, rowNumber, colJump, rowJump, colEnd, rowEnd;
            foreach (Area area in areas) {
                foreach (Pattern pattern in area.patterns) {
                    colJump = pattern.columns;
                    rowJump = pattern.rows;
                    for (int r = 0; r < pattern.rows; r++) {
                        rowStart = area.coordinates[1] + r;
                        rowEnd = area.coordinates[3] - pattern.rows + r + 1;
                        for (int c = 0; c < pattern.columns; c++) {
                            string s = pattern.pattern[r * pattern.columns + c];
                            if (s == "N")
                                continue;
                            colStart = area.coordinates[0] + c;
                            colEnd = area.coordinates[2] - pattern.columns + c + 1;
                            colNumber = (area.coordinates[2] - area.coordinates[0]) / pattern.columns + 1;
                            rowNumber = (area.coordinates[3] - area.coordinates[1]) / pattern.rows + 1;
                            sw.WriteLine($"{area.name}_{s},{colStart},{rowStart},{colNumber},{rowNumber},{colJump},{rowJump},{colEnd},{rowEnd}");
                        }
                    }
                }
            }
            sw.Close();
        }
    }
}
