using System.ComponentModel.DataAnnotations;
using System;

namespace GroupProject.Models
{
    public class TaskModel
    {
        public int Id { get; set; }

        [Required]
        public string TaskName { get; set; }

        [DataType(DataType.Date)]
        public DateTime CompletionDate { get; set; }
    }
}






