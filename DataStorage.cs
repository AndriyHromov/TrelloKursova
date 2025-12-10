using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;   // Пакет: Newtonsoft.Json

namespace TrelloKursova
{
    public static class DataStorage
    {
        private static readonly string FilePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "projects.json");

        // --- ЗАВАНТАЖЕННЯ ПРОЕКТІВ ---
        public static List<Project> LoadProjects()
        {
            try
            {
                if (!File.Exists(FilePath))
                {
                    // Якщо немає файла — створюємо пустий
                    SaveProjects(new List<Project>());
                    return new List<Project>();
                }

                string json = File.ReadAllText(FilePath);

                var list = JsonConvert.DeserializeObject<List<Project>>(json);

                return list ?? new List<Project>();
            }
            catch
            {
                // якщо файл битий — створюємо новий
                SaveProjects(new List<Project>());
                return new List<Project>();
            }
        }

        // --- ЗБЕРЕЖЕННЯ ПРОЕКТІВ ---
        public static void SaveProjects(List<Project> projects)
        {
            string json = JsonConvert.SerializeObject(projects, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }
    }
}
