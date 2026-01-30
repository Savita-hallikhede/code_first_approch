using Microsoft.EntityFrameworkCore;

namespace code_first_approch.MyDbContext
{
    public class MyDataBaseContext:DbContext
    {
    public MyDataBaseContext(DbContextOptions<MyDataBaseContext>  dbContextOptions):base(dbContextOptions)
        {

        }
       
    }


}
