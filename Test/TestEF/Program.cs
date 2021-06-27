using DatabaseManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users;
using WindowsForms;

namespace TestEF
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ModelAscon model = new ModelAscon();
            List<Users> users = model.Users.ToList();
            List<Categories> categories = model.Categories.ToList();
            model.Users.Add(new Users { Cash = 0, Firstname = "Иван", Lastname = "Иванов" });
            model.SaveChanges();*/

            IDataManager dataManager = new EFDataManager();
            //dataManager.CreateDatabase();
            IUserManager userManager = new MashineUserManager();

            Administrator administrator = new Administrator(dataManager, userManager);
            administrator.ShowDialog();
        }
    }
}
