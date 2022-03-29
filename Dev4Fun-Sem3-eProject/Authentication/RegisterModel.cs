namespace WebApplication6.Authentication
{
    public class RegisterModel
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int Role { get; set; } // 1 admin // 2 user // 3 mentor // 4 Hr // 5 Dev
        
    }

}
