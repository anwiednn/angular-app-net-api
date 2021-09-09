using System;

namespace AngularAppNetApi.Models.Tasks
{
    public class TaskDetailViewModel
    {
        public int Id { get; set; }
        public DetailModel Detail { get; set; }
        public UserOptionModel[] UserOptions { get; set; }

        public class DetailModel
        {
            public int UserId { get; set; }
            public string Name { get; set; }
            public string Notes { get; set; }
            public DateTime ReminderDate { get; set; }
            public bool Completed { get; set; }     
        }

        public class UserOptionModel
        {
            public int Id { get; set; }
            public string Name { get; set; }            
        }   
    }
}