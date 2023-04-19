using System;
using System.IO;

namespace PII_Game_Of_Life
{
    public class ReadFile
    {
        public static string url = "C:/Users/Tadeo Ki Ucu/Documents/Program2/GIT/Game_Of_Life\assets/board";
        public static string content = File.ReadAllText(url);
        public static string[] contentLines = content.Split('\n');
        public static bool[,] board = new bool[contentLines.Length, contentLines[0].Length];

    }
}
