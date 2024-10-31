using System;
using System.Collections.Generic;
using System.IO;


namespace practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MainConsole.PrintInfo();
            Parsing parser = new Parsing();
            string projectRoot = Directory.GetCurrentDirectory();
            projectRoot = Directory.GetParent(projectRoot).Parent.FullName;
            string filePath = System.IO.Path.Combine(projectRoot, "files.json");
            List<FileDescription> files = parser.ParseJsonFile(filePath);
            MainConsole.PrintInfo(files);
        }
    }
}
