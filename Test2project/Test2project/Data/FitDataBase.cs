using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using FitDataBase.ModelFitDataBase;
using System;

namespace FitDataBase.Data
{
    public class FitDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public FitDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Fit>().Wait();
        }

        //public Task<List<FitDatabase>> GetFitAsync()
        //{
        //    return _database.Table<Fit>().ToListAsync();
        //}

        public Task<Fit> GetFitAsync(int id)
        {
            return _database.Table<Fit>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        internal Task SaveFitAsync(object fitDataBase)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveFitAsync(Fit fit)
        {
            if (fit.ID != 0)
            {
                return _database.UpdateAsync(fit);
            }
            else
            {
                return _database.InsertAsync(fit);
            }
        }

      
    }
}
