using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManager
{
    public interface IDataManager
    {
        void ResetDatabase();
        void CreateDatabase();

        List<Categories> GetCategories();
        void AddNewCategory(string category);
        void SetEnableCategory(int idCategory, string enable);

        List<Data> GetData();
        List<Recepients> GetRecepients();
        
        List<Users> GetUsers();
        void AddUser(string username, int startCash);
        void SetUserRole(int userId, bool isAdmin);
    }
}
