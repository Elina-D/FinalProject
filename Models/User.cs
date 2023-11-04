namespace GroupProject.Models
{
    public class User
    {

        private string Id { get; set; }
        private string Name { get; set; }
        private string Email {get; set;}
        private string Password { get; set;}
        private string Username { get; set;}

        public User(string id, string name, string email, string password, string username)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Username = username;
        }
       


    }
}
