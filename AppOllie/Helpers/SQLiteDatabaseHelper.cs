using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using AppOllie.Models;

namespace AppOllie.Helpers
{
    internal class SQLiteDatabaseHelper
    {
        readonly SQLiteAsyncConnection _conn;
        public SQLiteDatabaseHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Usuario>().Wait();
        }

        public Task<List<Usuario>> Update(Usuario u) 
        {
            string sql = "UPDATE Usuario SET Nomeres=?, Nascres=?, Estcivil=?, Parentesco=?, Nomecri=?, Nasccri=?, Email=?, Senha=? WHERE Id=?";
        
            return _conn.QueryAsync<Usuario>(
                sql, u.Nomeres, u.Nascres, u.Estcivil, u.Parentesco, u.Nomecri, u.Nasccri, u.Email, u.Senha, u.Id);
        }
        
        public Task<List<Usuario>> GetAll()
        {
            return _conn.Table<Usuario>().ToListAsync();
        }
    }
}
