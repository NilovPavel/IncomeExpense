using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManager
{
    public class EFDataManager : IDataManager
    {
        private ModelAscon modelAscon;

        public EFDataManager()
        {
            this.modelAscon = new ModelAscon();    
        }

        void IDataManager.AddNewCategory(string category)
        {
            throw new NotImplementedException();
        }

        void IDataManager.AddUser(string username, int startCash)
        {
            throw new NotImplementedException();
        }

        void IDataManager.CreateDatabase()
        {
            SqlConnection myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=Ascon");
        }

        List<Categories> IDataManager.GetCategories()
        {
            return this.modelAscon.Categories.ToList();
        }

        List<Data> IDataManager.GetData()
        {
            return this.modelAscon.Data.ToList();
        }

        List<Recepients> IDataManager.GetRecepients()
        {
            return this.modelAscon.Recepients.ToList();
        }

        List<Users> IDataManager.GetUsers()
        {
            return this.modelAscon.Users.ToList();
        }

        void IDataManager.ResetDatabase()
        {
            throw new NotImplementedException();
        }

        void IDataManager.SetEnableCategory(int idCategory, string enable)
        {
            Categories category = this.modelAscon.Categories.Where(item => item.categoryId == idCategory).FirstOrDefault();
            
        }

        void IDataManager.SetUserRole(int userId, bool isAdmin)
        {
            throw new NotImplementedException();
        }
    }
}
