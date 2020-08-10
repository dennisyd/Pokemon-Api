using System;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Pokemon_API.DataBaseInterface
{
    public abstract class TableQueries<T> : ITableQueries<T>
    {
        public string Database = "";
        public string TableName = "";
        public string GetValue = "";
        public string DeleteValue = "";
        
        public async Task<T> Get(object value)
        {
            DatabaseConnector connection = DatabaseConnector.Instance();
            if (await connection.IsConnected())
            {
                string query = $"Select * From {this.TableName} WHERE {GetValue} = ";
                MySqlCommand command = new MySqlCommand(query);
            }
        }

        public Task<T> Insert(T obj)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(object value)
        {
            DatabaseConnector connection = DatabaseConnector.Instance();
            if (await connection.IsConnected())
            {
                string query = $"DELETE * From {this.TableName} WHERE {DeleteValue} = ";
                MySqlCommand command = new MySqlCommand(query);
            }
            throw new NotImplementedException();
        }
    }
}
