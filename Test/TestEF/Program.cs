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
            MainManager mainManager = new MainManager();
            mainManager.ActiveDirectoryMode = false;
            mainManager.AdministratorMode = true;
            mainManager.LocalConnection = true;

            mainManager.Run();
        }
    }
}
