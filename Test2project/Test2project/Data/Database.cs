using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel;
using System.Linq;

using System.Threading.Tasks;
using Xamarin.Forms;

using SQLite;
using SQLitePCL;

namespace Test2project
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Person>().Wait();
            
            
        }

        

        public Task<Person> GetPeopleAsync()
        {
            return _database.Table<Person>().FirstOrDefaultAsync();

        }

        public Task<int> SavePersonAsync(Person person)
        {
            return _database.InsertAsync(person);
        }

        public Task<int> UpdatePersonAsync(Person person)
        {
            return _database.UpdateAsync(person);
        }
        public Task<int> DeletePersonAsync(Person person)
        {
            return _database.DeleteAsync(person);
        }






    }
}
