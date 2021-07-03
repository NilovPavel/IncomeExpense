using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Users
{
    public class ActiveDirectoryUserManager : IUserManager
    {
        string IUserManager.GetCurrentUserName()
        {
            WindowsPrincipal windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            return windowsPrincipal.Identity.Name;
            throw new NotImplementedException();
        }

        string[] IUserManager.GetUserNames()
        {
            List<string> usernames = new List<string>();
            using (var context = new PrincipalContext(ContextType.Domain, "yourdomain.com"))
            {
                using (var searcher = new PrincipalSearcher(new UserPrincipal(context)))
                {
                    foreach (var result in searcher.FindAll())
                    {
                        DirectoryEntry de = result.GetUnderlyingObject() as DirectoryEntry;
                        /*Console.WriteLine("First Name: " + de.Properties["givenName"].Value);
                        Console.WriteLine("Last Name : " + de.Properties["sn"].Value);
                        Console.WriteLine("SAM account name   : " + de.Properties["samAccountName"].Value);
                        Console.WriteLine("User principal name: " + de.Properties["userPrincipalName"].Value);
                        Console.WriteLine();*/
                        usernames.Add(de.Properties["samAccountName"].Value.ToString());
                    }
                }
            }
            return usernames.ToArray();
        }
    }
}
