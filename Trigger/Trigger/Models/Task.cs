using System;
using System.Collections.Generic;
using System.Text;

namespace Trigger.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public bool IsCompleted { get; set; }
    }
}
