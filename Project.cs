using System;
using System.Collections.Generic;

namespace TrelloKursova
{
    public class Project
    {
        public string Name { get; set; }
        public DateTime Deadline { get; set; }

        // три списки для простого варіанту
        public List<TaskItem> ToDo { get; set; } = new List<TaskItem>();
        public List<TaskItem> InProgress { get; set; } = new List<TaskItem>();
        public List<TaskItem> Done { get; set; } = new List<TaskItem>();
    }
}
