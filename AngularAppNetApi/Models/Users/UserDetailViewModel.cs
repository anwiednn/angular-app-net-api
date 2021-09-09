namespace AngularAppNetApi.Models.Users
{
    public class UserDetailViewModel
    {
        public int Id { get; set; }
        public DetailModel Detail { get; set; }

        public class DetailModel
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public bool Active { get; set; }            
        }        
    }
}