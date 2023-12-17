using dobreluciacorinalab7.Data;
using System;
using System.IO;

namespace dobreluciacorinalab7
{
    public partial class App : Application
    {
        private static ShoppingListDatabase _database;

        public static ShoppingListDatabase Database
        {
            get
            {
                if (_database == null)
                {
                    var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ShoppingList.db3");
                    _database = new ShoppingListDatabase(dbPath);
                }

                return _database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }
    }
}
