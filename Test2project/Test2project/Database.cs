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
            
            _database.CreateTableAsync<PostData>().Wait();
        }

        

        public Task<Person> GetPeopleAsync()
        {
            return _database.Table<Person>().FirstOrDefaultAsync();

        }

        public Task<int> SavePersonAsync(Person person)
        {
            return _database.InsertAsync(person);
        }

        public Task<PostData> GetPostDataAsync()
        {
            return _database.Table<PostData>().FirstOrDefaultAsync();

        }
       public Task<List<PostData>> GetPostDataAllAsync()
        {
            return _database.Table<PostData>().ToListAsync();
                    }
      
        public Task<int> SavePostDataAsync(PostData postData)
        {
            return _database.InsertAsync(postData);
        }


    }
}
