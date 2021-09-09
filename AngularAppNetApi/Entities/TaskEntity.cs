using System;

namespace AngularAppNetApi.Entities
{
    public class TaskEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public DateTime ReminderDate { get; set; }
        public bool Completed { get; set; }
    }
}