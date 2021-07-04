using DatabaseManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Users;
using WindowsForms;

namespace MainPackage
{
    public class MainManager
    {
        private IDataManager dataManager;
        private IUserManager userManager;
        private DatabaseManager.Users currentUser;

        /// <summary>
        /// Задает значение, которое указывает тип соединения (true - БД в файле, false - БД на сервере)
        /// </summary>
        public bool LocalConnection { get; set; }

        /// <summary>
        /// Указывает режим, в котором будет работаь программа (true - режим администратора, false - режим пользователя)
        /// </summary>
        public bool AdministratorMode { get; set; }

        /// <summary>
        /// Указывает режим, в котором будет работать Windows-авторизация(true - режим доменной авторизации, false - режим авторизации NT)
        /// </summary>
        public bool ActiveDirectoryMode { get; set; }

        private void Initialization()
        {
            string serverConncetion = this.LocalConnection ? "LocalModelAscon" : "ServerModelAscon";
            
            this.dataManager = new EFDataManager(serverConncetion);
            
            this.userManager = this.ActiveDirectoryMode ? 
                (IUserManager)new ActiveDirectoryUserManager() : (IUserManager)new MashineUserManager();

            this.currentUser = this.dataManager.GetUsers().FirstOrDefault(item => item.UserName.Equals(this.userManager.GetCurrentUserName()));
        }

        private void Dummy()
        {
            //Заглушка. Если в базе данных нет пользователя для администрирования, то добавляется первый вошедший
            if (this.dataManager.GetUsers().Count(item => item.IsAdmin) == 0)
            {
                this.dataManager.AddUser(this.userManager.GetCurrentUserName(), 100000);
                this.dataManager.SetUserRole(this.dataManager.GetUsers().FirstOrDefault().userId, true);
            }
        }

        public void Run()
        {
            this.Initialization();

            this.Dummy();

            Form currentForm  = (this.AdministratorMode && this.currentUser.IsAdmin) ? (Form)new Administrator(this.dataManager, this.userManager)
                : (Form) new CashManager(this.dataManager, this.userManager);
            
            currentForm.ShowDialog();
        }

        public MainManager()
        {
            //this.Initialization();
        }
    }
}
