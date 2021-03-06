using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManager
{
    public class EFDataManager : IDataManager
    {
        private ModelAscon modelAscon;

        public EFDataManager(string serverConncetion)
        {
            this.modelAscon = new ModelAscon(serverConncetion);    
        }

        void IDataManager.AddNewCategory(string category)
        {
            this.modelAscon.Categories.Add(new Categories { CategoryName = category, enable = false });
            this.modelAscon.SaveChanges();
        }

        void IDataManager.AddUser(string username, int startCash)
        {
            this.modelAscon.Users.Add(new Users { UserName = username, StartCash = startCash });
            this.modelAscon.SaveChanges();
        }

        void IDataManager.CreateDatabase()
        {
            this.modelAscon.CreateDatabase();
            ((IDataManager)this).AddNewCategory("Категория 1");
            this.modelAscon.Recepients.Add(new Recepients { Description = "Работодатель" }) ;
            this.modelAscon.Recepients.Add(new Recepients { Description = "Торговый центр" });
            this.modelAscon.SaveChanges();
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
            Users user = this.modelAscon.Users.FirstOrDefault(item => item.userId == userId);
            user.IsAdmin = isAdmin;
            this.modelAscon.SaveChanges();
        }

        void IDataManager.AddUserOperation(int userId, int categoryId, int recipientId, int amount)
        {
            Data data = new Data { userId = userId, categoryId = categoryId, recepientId = recipientId, CashChange = amount };
            this.modelAscon.Data.Add(data);
            this.modelAscon.SaveChanges();
        }
    }
}
