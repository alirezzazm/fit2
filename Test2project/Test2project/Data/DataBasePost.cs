using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLitePCL;

namespace Test2project.Data
{
    public class DataBasePost
    {
        readonly SQLiteAsyncConnection databasepost;

        public DataBasePost(string dbPath)
        {
            databasepost = new SQLiteAsyncConnection(dbPath);
            databasepost.CreateTableAsync<PostData>().Wait();
        }



        public Task<PostData> GetPeopleAsync()
        {
            return databasepost.Table<PostData>().FirstOrDefaultAsync();

        }

        public Task<int> SavePersonAsync(PostData postData)
        {
            return databasepost.InsertAsync(postData);
        }

       


    
}
}   
