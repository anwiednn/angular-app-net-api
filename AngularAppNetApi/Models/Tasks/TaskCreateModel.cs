using System;

namespace AngularAppNetApi.Models.Tasks
{
    public class TaskCreateModel
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public DateTime ReminderDate { get; set; }        
    }
}