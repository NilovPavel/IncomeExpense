using System;
using System.Collections.Generic;
//using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Management;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public class MashineUserManager : IUserManager
    {
        string IUserManager.GetCurrentUserName()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT UserName FROM Win32_ComputerSystem");
            ManagementObjectCollection collection = searcher.Get();
            string username = Environment.UserDomainName + "\\" + Environment.UserName;
            //(string)collection.Cast<ManagementBaseObject>().First()["UserName"];
            return username;
        }

        string[] IUserManager.GetUserNames()
        {
            List<string> usernames = new List<string>();
            SelectQuery query = new SelectQuery("Win32_UserAccount");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            foreach (ManagementObject envVar in searcher.Get())
                usernames.Add((string)envVar["Domain"] + "\\" + (string)envVar["Name"]);

            return usernames.ToArray();
        }
    }
}
