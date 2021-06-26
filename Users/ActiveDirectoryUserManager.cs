using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
            /*UserPrincipal.Current.
            using (PrincipalContext context = new PrincipalContext(ContextType.Machine))
            {
                UserPrincipal user = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, "login");
                foreach (var group in user.GetGroups())
                {
                    Console.WriteLine(group.Name);
                }
            }*/
        }
    }
}
