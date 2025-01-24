using System;

namespace LebronJames_PROJECT_2.Models
{
    public class Comment
    {
        public int Id { get; set; } // Уникален идентификатор за всеки коментар
        public string Username { get; set; } // Потребителско име
        public string Content { get; set; } // Съдържание на коментара
        public DateTime CreatedAt { get; set; } // Дата на създаване
    }
}