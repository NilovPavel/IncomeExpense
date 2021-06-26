using DatabaseManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEF
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelAscon model = new ModelAscon();
            List<Users> users = model.Users.ToList();
            List<Categories> categories = model.Categories.ToList();
            model.Users.Add(new Users { Cash = 0, Firstname = "Иван", Lastname = "Иванов" });
            model.SaveChanges();
        }
    }
}
