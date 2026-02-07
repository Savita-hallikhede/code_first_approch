using code_first_approch.Models;
using code_first_approch.MyDbContext;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Reflection;

namespace code_first_approch.Controllers
{
    public class RegisterController : Controller
    {
        private readonly MyDataBaseContext _myDataBaseContext;
        public RegisterController(MyDataBaseContext  myDataBaseContext)
        {
            _myDataBaseContext = myDataBaseContext;

        }



        public IActionResult RegisterdataShow()
        {


                  List<Register> registers_Tabledata    = _myDataBaseContext.Registers.ToList();  


            return View(registers_Tabledata);
        }

        [HttpGet]
        public IActionResult gettinguserdata()
        {
            return View();
        }


        [HttpPost]
        public IActionResult gettinguserdata(string name,string email, string password, long phoneNumber ,  string address , DateTime dateOfBirth , string Gender)
        {


            Register obj = new Register();

            obj.Name = name;
            obj.Email = email;
            obj.Password = password;
            obj.PhoneNumber = phoneNumber;
            obj.Address = address;
            obj.DateOfBirth = dateOfBirth;
            obj.gender = Gender;
            
            _myDataBaseContext.Registers.Add(obj);


            _myDataBaseContext.SaveChanges();   

            return RedirectToAction("RegisterdataShow");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {

            // string genderdata = HttpContext.Request.Query["Gender"];

           Register Singlerowdata = _myDataBaseContext.Registers.Where(r => r.Id == id).FirstOrDefault();

            return     View(Singlerowdata);

        }

        [HttpPost]
        public IActionResult Edit(Register DATA )
        {

            _myDataBaseContext.Registers.Update(DATA);


            _myDataBaseContext.SaveChanges();

            return RedirectToAction("RegisterdataShow");
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            Register Singlerowdata = _myDataBaseContext.Registers.Where(r => r.Id == id).FirstOrDefault();
            //_myDataBaseContext.Registers.Remove(Singlerowdata);
            //_myDataBaseContext.SaveChanges();   

            return View(Singlerowdata);
        }
        [HttpPost]
        public IActionResult Delete(Register Singlerowdata)
        {
           
           _myDataBaseContext.Registers.Remove(Singlerowdata);
            _myDataBaseContext.SaveChanges();   

            return RedirectToAction("RegisterdataShow");
        }

      

        
    }
}
