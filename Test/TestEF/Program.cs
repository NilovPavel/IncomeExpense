using DatabaseManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users;
using WindowsForms;

namespace MainPackage
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool localConnect = true;
            
            if(args.Length == 2)
            {
                isAdmin = args[0].Equals("admin");
                localConnect = !args[1].Equals("server");
            }

            MainManager mainManager = new MainManager();
            mainManager.AdministratorMode = isAdmin;
            mainManager.LocalConnection = localConnect;

            mainManager.Run();
        }
    }
}
