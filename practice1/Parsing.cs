using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace practice1
{
    internal class Parsing
    {
        public List<FileDescription> ParseJsonFile(string filePath)
        {
            // Читаем JSON файл
            string jsonData = File.ReadAllText(filePath);

            // Десериализация JSON в Dictionary
            var fileDict = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(jsonData);
            List<FileDescription> fileList = new List<FileDescription>();

            // Перебираем элементы словаря и создаем экземпляры FileDescription
            foreach (var file in fileDict)
            {
                var fileDetails = file.Value;

                var fileDescription = new FileDescription
                {
                    Name = file.Key,
                    Size = fileDetails.GetProperty("Size").GetInt64(),
                    FileExtension = fileDetails.GetProperty("FileExtension").GetString(),
                    Date = fileDetails.GetProperty("Date").GetString(),
                    Time = fileDetails.GetProperty("Time").GetString(),
                    IsDirectory = fileDetails.GetProperty("IsDirectory").GetBoolean()
                };

                fileList.Add(fileDescription);
            }

            return fileList;
        }
    }
}