using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using PCLExt.FileStorage;
using PCLExt.FileStorage.Folders;
using SearchPrice.App.Database.Abstracts;
using SearchPrice.App.Models;
using SQLite;

namespace SearchPrice.App.Database.Concretes
{
    public class DatabaseSQLite<T> : IDatabase<T> where T : BaseModel, new()
    {
        private static SQLiteConnection _sqliteconnection;
        public const string DbFileName = "price.db";

        public DatabaseSQLite()
        {
            var pasta = new LocalRootFolder();
            var arquivo = pasta.CreateFile(DbFileName, CreationCollisionOption.OpenIfExists);
            _sqliteconnection = new SQLiteConnection(arquivo.Path);
            _sqliteconnection.CreateTable<T>();
        }

        public Task<List<T>> GetAllAsync() => Task.Run(() => _sqliteconnection.Table<T>().ToList());
        public Task<List<T>> GetAllAsync(Expression<Func<T, bool>> where) => Task.Run(() => _sqliteconnection.Table<T>().Where(where).ToList());
        public Task<T> GetByIdAsync(int id) => Task.Run(() => _sqliteconnection.Table<T>().FirstOrDefault(x => x.Id == id));
        public Task<int> DeleteAsync(int id) =>  Task.Run(() => _sqliteconnection.Delete<T>(id));
        public Task<int> InsertAsync(T value) => Task.Run(() => _sqliteconnection.Insert(value));
        public Task<int> InsertAsync(List<T> values) => Task.Run(() => _sqliteconnection.InsertAll(values));
        public Task<int> UpdateAsync(T value) => Task.Run(() => _sqliteconnection.Update(value));
        public void Dispose()
        {
            _sqliteconnection?.Dispose();
        }
    }
}