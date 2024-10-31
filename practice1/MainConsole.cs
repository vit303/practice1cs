using System;
using System.Collections.Generic;

namespace practice1
{
    internal static class MainConsole
    {
        public static void PrintInfo(List<FileDescription> files)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();

            // Верхняя рамка
            Console.Write("\u2554");
            for (int i = 1; i <= 18; i++) Console.Write("\u2550");
            Console.Write("\u2564");
            for (int i = 1; i <= 5; i++) Console.Write("\u2550");
            Console.Write(@" C:\NC ");
            for (int i = 1; i <= 6; i++) Console.Write("\u2550");
            Console.Write("\u2564");
            for (int i = 1; i <= 18; i++) Console.Write("\u2550");
            Console.Write("\u2557");
            Console.Write("\u2554");
            for (int i = 1; i <= 18; i++) Console.Write("\u2550");
            Console.Write("\u2564");
            for (int i = 1; i <= 5; i++) Console.Write("\u2550");
            Console.Write(@" C:\NC ");
            for (int i = 1; i <= 6; i++) Console.Write("\u2550");
            Console.Write("\u2564");
            for (int i = 1; i <= 10; i++) Console.Write("\u2550");
            Console.Write("\u2564");
            for (int i = 1; i <= 6; i++) Console.Write("\u2550");
            Console.Write("\u2557");
            Console.WriteLine();

            // Заголовки
            Console.Write("\u2551");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(CenterText("C: Name", 18));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\u2502");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(CenterText("Name", 18));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\u2502");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(CenterText("Name", 18));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\u2551\u2551");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(CenterText("C: Name", 18));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\u2502");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(CenterText("Size", 18));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\u2502");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(CenterText("Date", 10));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\u2502");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(CenterText("Time", 6));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\u2551");
            Console.WriteLine();

            // Содержимое рамки
            for (int index = 0; index < files.Count - 4; index+=4)
            {
                var file = files[index];
                Console.Write("\u2551");
                Console.Write(LeftRightText(file.Name, file.FileExtension, 18));
                var file1 = files[index+1];
                Console.Write("\u2502");
                Console.Write(LeftRightText(file1.Name, file.FileExtension, 18));
                var file2 = files[index+2];
                Console.Write("\u2502");
                Console.Write(LeftRightText(file2.Name, file.FileExtension, 18));
                Console.Write("\u2551\u2551");
                var file3 = files[index+3];
                Console.Write(LeftRightText(file3.Name, file.FileExtension, 18));
                Console.Write("\u2502");
                if (file3.IsDirectory == true)
                {
                    Console.Write(RightText("КАТАЛОГ", 18));
                }
                else
                {
                    Console.Write(RightText(file3.Size.ToString(), 18));
                }
                Console.Write("\u2502");
                Console.Write(RightText(file3.Date, 10));
                Console.Write("\u2502");
                Console.Write(RightText(file3.Time, 6));
                Console.Write("\u2551");
                Console.WriteLine();
            }

            // Нижняя рамка
            Console.Write("\u255F");
            for (int i = 1; i <= 18; i++) Console.Write("\u2500");
            Console.Write("\u2534");
            for (int i = 1; i <= 18; i++) Console.Write("\u2500");
            Console.Write("\u2534");
            for (int i = 1; i <= 18; i++) Console.Write("\u2500");
            Console.Write("\u2562\u255F");
            for (int i = 1; i <= 18; i++) Console.Write("\u2500");
            Console.Write("\u2534");
            for (int i = 1; i <= 18; i++) Console.Write("\u2500");
            Console.Write("\u2534");
            for (int i = 1; i <= 10; i++) Console.Write("\u2500");
            Console.Write("\u2534");
            for (int i = 1; i <= 6; i++) Console.Write("\u2500");
            Console.Write("\u2562");
            Console.WriteLine();
            Console.Write("\u2551");
            Console.Write(CenterText("..          КАТАЛОГ   11.10.02    19:48", 56));
            Console.Write("\u2551\u2551");
            Console.Write(CenterText("..          КАТАЛОГ   11.10.02    19:48", 55));
            Console.Write("\u2551");
            Console.WriteLine();
            Console.Write("\u255A");
            for (int i = 1; i <= 56; i++) Console.Write("\u2550");
            Console.Write("\u255D");
            Console.Write("\u255A");
            for (int i = 1; i <= 55; i++) Console.Write("\u2550");
            Console.Write("\u255D");
            Console.ReadLine();

        }

        private static string CenterText(string text, int width)
        {
            return text.PadLeft((width - text.Length) / 2 + text.Length).PadRight(width);
        }

        private static string LeftText(string text, int width)
        {
            return text.PadRight(width);
        }

        private static string RightText(string text, int width)
        {
            return text.PadLeft(width);
        }

        private static string LeftRightText(string textLeft, string textRight, int width)
        {
            return LeftText(textLeft, width - textRight.Length) + textRight;
        }
    }
}
