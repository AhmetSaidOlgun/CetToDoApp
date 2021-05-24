using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CetToDoApp.Models
{
    public class Todo
    {
        public Todo()
        {
            CreatedDate = DateTime.Now;
        }
        public int ID { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [MaxLength(1500)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public bool isCompleted { get; set; }
        public DateTime DueDate { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreatedDate { get; set; }

        public int RemainingTime
        {
            get
            {
                var remainingTime = (DateTime.Now - DueDate);
                return (int)remainingTime.TotalHours;
            }
        }

        [ScaffoldColumn(false)]
        public DateTime CompletedDate { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
