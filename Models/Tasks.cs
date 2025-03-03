using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime NextDue { get; set; }
        public DateTime LastCompleted { get; set; }
        public int Frequency { get; set; }
        public double EstimatedHours { get; set; }
        public string PreferredTime { get; set; }
        public string? PreferredPlace { get; set; }
    }

    

}
