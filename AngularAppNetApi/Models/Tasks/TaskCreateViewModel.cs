using System;

namespace AngularAppNetApi.Models.Tasks
{
    public class TaskCreateViewModel
    {
        public DetailModel Detail { get; set; }
        public UserOptionModel[] UserOptions { get; set; }

        public class DetailModel
        {
            public int UserId { get; set; }
            public string Name { get; set; }
            public string Notes { get; set; }
            public DateTime ReminderDate { get; set; }
        }

        public class UserOptionModel
        {
            public int Id { get; set; }
            public string Name { get; set; }            
        }
    }
}