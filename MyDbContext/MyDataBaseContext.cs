using code_first_approch.Models;
using Microsoft.EntityFrameworkCore;

namespace code_first_approch.MyDbContext
{
    public class MyDataBaseContext : DbContext
    {

        public MyDataBaseContext(DbContextOptions<MyDataBaseContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<code_first_approch.Models.Register> Registers { get; set; }


        protected  override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Register register = new Register()
            {
                Id = 1,
                Name = "Admin",
                Email = "Admin@gmail.com",
                Password = "Admin@123",
                Address = "India",
                PhoneNumber = 1234567890,
                DateOfBirth = DateTime.Now,
                gender = "male"



            };


            Register register2 = new Register()
            {
                Id = 2,
                Name = "Admi2n",
                Email = "Admin2@gmail.com",
                Password = "Admin2@123",
                Address = "India2",
                PhoneNumber = 12234567890,
                DateOfBirth = DateTime.Now,
                gender = "male"



            };
            modelBuilder.Entity<Register>().HasData(register, register2);
        }

    }
}
