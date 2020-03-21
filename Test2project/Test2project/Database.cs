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

        public Task<List<Person>> GetPeopleAsync()
        {
            return _database.Table<Person>().ToListAsync();
        }

        public Task<int> SavePersonAsync(Person person)
        {
            return _database.InsertAsync(person);
        }
    }
}
