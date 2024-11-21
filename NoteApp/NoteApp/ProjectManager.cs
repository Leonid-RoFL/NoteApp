using System;
using System.IO;
using Newtonsoft.Json;

namespace NoteApp
{
    public class ProjectManager
    {
        private const string FILE_PATH = @"%USERPROFILE%\Documents\NoteApp.notes";

        // Метод сохранения заметок в файл

        public void SaveProject(Project project)
        {
            string json = JsonConvert.SerializeObject(project);                             // - сериализация класса (class -> json)
            string filePath = Environment.ExpandEnvironmentVariables(FILE_PATH);       // - метод, который замещает имя каждой переменной среды

            try
            {
                File.WriteAllText(filePath, json);                                  // - запись данных в файл
            }
            catch { }
        }

        // Метод выгрузки заметок из файла

        public Project LoadProject()
        {
            string filePath = Environment.ExpandEnvironmentVariables(FILE_PATH);

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);                                   // - чтение данных из файла
                return JsonConvert.DeserializeObject<Project>(json);                        // - десериализация (json -> class)
            }
            return new Project();
        }
    }
}