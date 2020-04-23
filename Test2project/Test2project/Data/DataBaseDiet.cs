using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLitePCL;

using System.Threading.Tasks;
using Test2project.Models;

namespace Test2project.Data
{
  public  class DataBaseDiet
    {
        readonly SQLiteAsyncConnection databasediet;
        public DataBaseDiet(string dbPath)
        {
            databasediet = new SQLiteAsyncConnection(dbPath);
            databasediet.CreateTableAsync<DietModels>().Wait();    
        }
        public Task<List<DietModels>> GetDietModelsAllAsync()
        {
            return databasediet.Table<DietModels>().ToListAsync();
        }


        public Task<int> SavePersonAsync(DietModels DietModels)
        {
            return databasediet.InsertAsync(DietModels);
        }

      
    }
}
