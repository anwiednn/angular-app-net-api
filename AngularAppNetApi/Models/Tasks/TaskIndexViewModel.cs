using System;

namespace AngularAppNetApi.Models.Tasks
{
    public class TaskIndexViewModel
    {
        public PredicateModel Predicate { get; set; }
        public PageModel Page { get; set; }

        public class PredicateModel
        {
            public int PageNumber { get; set; }
            public int PageSize { get; set; }
            public string SearchText { get; set; }
            public bool? Completed { get; set; }            
        }

        public class PageModel
        {
            public int Total { get; set; }
            public TaskModel[] Tasks { get; set; }

            public class TaskModel
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public string Notes { get; set; }
                public DateTime ReminderDate { get; set; }
                public bool Completed { get; set; } 
                public string UserName { get; set; }        
            }
        }
    }
}