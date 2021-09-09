namespace AngularAppNetApi.Models.Users
{
    public class UserIndexViewModel
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
            public UserModel[] Users { get; set; }

            public class UserModel
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public string Email { get; set; }
                public bool Active { get; set; }   
            }
        }
    }
}