using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public int Frequency { get; set; }
        public double EstimatedHours { get; set; }
        public DateTime PreferredTime { get; set; }
        public string? PreferredPlace { get; set; }
    }

    

}
