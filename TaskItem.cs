using System;

namespace TrelloKursova
{
    public class TaskItem
    {
        public string Title { get; set; }         // коротка назва/заголовок
        public string Description { get; set; }   // детальний текст
        public DateTime Deadline { get; set; }    // дедлайн
    }
}
