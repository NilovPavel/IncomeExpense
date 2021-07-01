using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManager
{
    public interface IDataManager
    {
        void ResetDatabase();
        void CreateDatabase();

        ObservableCollection<Categories> GetCategories();
        void AddNewCategory(string category);
        void UpdateCategory(int idCategory, string category, bool enable);

        ObservableCollection<Data> GetData();
        void AddUserOperation(int userId, int categoryId, int recipient, int amount);

        ObservableCollection<Recepients> GetRecepients();

        ObservableCollection<Users> GetUsers();
        void AddUser(string username, int startCash);
        void SetUserRole(int userId, bool isAdmin);
    }
}
