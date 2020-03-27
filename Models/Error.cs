using System;
namespace videos.Models
{
    public class Error{
        public int Id { get; set; }
        public string ErrorMessage { get; set; }
        public string StackTrace { get; set; }
        public string ErrorPath { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}