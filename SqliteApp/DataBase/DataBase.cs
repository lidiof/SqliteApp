using SQLite;
using SqliteApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SqliteApp.DataBase
{
    public class DataBase
    {
        SQLiteAsyncConnection _sqlitedata;

        public DataBase(string dbPath)
        {
            _sqlitedata = new SQLiteAsyncConnection(dbPath);
            _sqlitedata.CreateTableAsync<Company>().Wait();
        }
        public Task<List<Company>> GetCompanyAsync()
        {
            return _sqlitedata.Table<Company>().ToListAsync();
        }

        public Task<Company> GetCompanyAsync(int id)
        {
            return _sqlitedata.Table<Company>()
                            .Where(i => i.Id == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveCompanyAsync(Company company)
        {
            if (company.Id != 0)
            {
                return _sqlitedata.UpdateAsync(company);
            }
            else
            {
                return _sqlitedata.InsertAsync(company);
            }
        }

        public Task<int> DeleteCompanyAsync(Company company)
        {
            return _sqlitedata.DeleteAsync(company);
        }
       
    }
}
