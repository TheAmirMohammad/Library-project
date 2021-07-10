namespace Library_Manager
{
    public class User
    {
        string name;
        string phoneNumber;
        string email;
        string password;
        public string Name { get => name; set => name = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public User()
        {

        }
        public User(string name, string email, string phonenumber, string password)
        {
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.PhoneNumber = phonenumber;
        }
        public User(string name, string email, string phonenumber)
        {
            this.Name = name;
            this.Email = email;
            this.PhoneNumber = phonenumber;
        }
    }
}