using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            this.modelAscon.Categories.Add(new Categories { CategoryName = category, enable = false });
            this.modelAscon.SaveChanges();
        }

        void IDataManager.AddUser(string username, int startCash)
        {
            throw new NotImplementedException();
        }

        void IDataManager.CreateDatabase()
        {
            ModelAscon modelAscon = new ModelAscon();
            modelAscon.CreateDatabase();
        }

        ObservableCollection<Categories> IDataManager.GetCategories()
        {
            return new ObservableCollection<Categories>(this.modelAscon.Categories);
        }

        ObservableCollection<Data> IDataManager.GetData()
        {
            return new ObservableCollection<Data>(this.modelAscon.Data);
        }

        ObservableCollection<Recepients> IDataManager.GetRecepients()
        {
            return new ObservableCollection<Recepients>(this.modelAscon.Recepients);
        }

        ObservableCollection<Users> IDataManager.GetUsers()
        {
            return new ObservableCollection<Users>(this.modelAscon.Users);
        }

        void IDataManager.ResetDatabase()
        {
            throw new NotImplementedException();
        }

        void IDataManager.UpdateCategory(int idCategory, string category, bool enable)
        {
            Categories currentCategory = this.modelAscon.Categories.Where(item => item.categoryId == idCategory).FirstOrDefault();
            currentCategory.CategoryName = category;
            currentCategory.enable = enable;
            this.modelAscon.SaveChanges();
        }

        void IDataManager.SetUserRole(int userId, bool isAdmin)
        {
            throw new NotImplementedException();
        }
    }
}
