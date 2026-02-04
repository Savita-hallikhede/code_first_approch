namespace code_first_approch.Models
{
    public class Register
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string gender { get; set; }

        public string Address { get; set; }

        public long PhoneNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

    }
}
