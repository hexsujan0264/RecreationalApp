using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WinFormsApp1
{
    public static class Utility
    {
        private static string _filePath = @"C:\Users\HexSujan\Downloads\visitor.txt";
        public static string WriteToText(string data)
        {
            if (!File.Exists(_filePath))
            {
                using (File.Create(_filePath)) ;
            }
            using (StreamWriter outputFile = new StreamWriter(_filePath))
            {
                outputFile.WriteLine(data);
            }
            return "success";
        }
        public static string ReadFromFile()
        {
            if(File.Exists(_filePath))
            {
                string data = File.ReadAllText(_filePath);
                return data;
            }
            return null;
        }
    }
}
