using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Pokemon_API.Extensions
{
    public abstract class TableQueries<T>
    {
        public string Database = "";
        public string TableName = "";
        //connector.setDatabase(Schema);

        public virtual async Task<List<T>> Get(Dictionary<string, object> values)
        {
            DatabaseConnector connection = DatabaseConnector.Instance();
            connection.setDatabase(Database);
            if(!await connection.IsConnected())
            {
                Console.WriteLine($"Failed to connect to {Database} | {TableName}");
                return null;
            }
            try
            {
                string query = $"Select * From {this.TableName} WHERE ";
                foreach (KeyValuePair<string, object> pair in values)
                {
                    query += $"{pair.Key}=@{pair.Key} AND";
                }
                query = query.Substring(0, query.Length - 3);

                MySqlCommand cmd = new MySqlCommand(query, connection.Connection);
                foreach (KeyValuePair<string, object> pair in values)
                {
                    if(pair.Value == null) { continue; }
                    cmd.Parameters.AddWithValue($"@{pair.Value}", pair.Value);
                }

                MySqlDataReader reader = cmd.ExecuteReader();
                List<T> list = new List<T>();
                while (reader.Read())
                {
                    list.Add(DataReaderConverter(reader));
                }

                await connection.Disconnect();
                return list;

            }
            catch(Exception ex)
            {
                Console.WriteLine($":: {Database} | {TableName} | GET | {ex.Message} ::");
                return null;
            }
        }

        public async Task<int?> Insert(Dictionary<string, object> values)
        {
            DatabaseConnector connection = DatabaseConnector.Instance();
            connection.setDatabase(Database);

            if (!await connection.IsConnected())
            {
                Console.WriteLine($"Failed to connect to {Database} | {TableName}");
                return null;
            }
            try
            {
                string query = $"INSERT INTO {TableName} (";
                foreach(KeyValuePair<string, object> pair in values)
                {
                    query += $"{pair.Key}, ";
                }
                query.Remove(query.LastIndexOf(','), 1);
                query += ") VALUES (";

                foreach (KeyValuePair<string, object> pair in values)
                {
                    query += $"@{pair.Key}, ";
                }
                query.Remove(query.LastIndexOf(','), 1);
                query += "); SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, connection.Connection);
                foreach (KeyValuePair<string, object> pair in values)
                {
                    cmd.Parameters.AddWithValue(pair.Key, pair.Value);
                }
                object row = await cmd.ExecuteScalarAsync();
                int id = Int32.Parse(row.ToString());

                await connection.Disconnect();
                return id;
            }
            catch(Exception ex)
            {
                Console.WriteLine($":: {Database} | {TableName} | INSERT | {ex.Message} ::");
                return null;
            }
        }

        public async Task<int?> Delete(Dictionary<string, object> values)
        {
            DatabaseConnector connection = DatabaseConnector.Instance();
            connection.setDatabase(Database);

            if (!await connection.IsConnected())
            {
                Console.WriteLine($"Failed to connect to {Database} | {TableName}");
                return null;
            }
            try
            {
                string query = $"DELETE FROM {TableName} WHERE ";
                foreach (KeyValuePair<string, object> pair in values)
                {
                    query += $"{pair.Key}=@{pair.Key} AND";
                }
                query = query.Remove(query.LastIndexOf("AND"), 3);

                MySqlCommand cmd = new MySqlCommand(query, connection.Connection);
                foreach (KeyValuePair<string, object> pair in values)
                {
                    if (pair.Value == null) { continue; }
                    cmd.Parameters.AddWithValue($"@{pair.Value}", pair.Value);
                }

                int id = await cmd.ExecuteNonQueryAsync();
                await connection.Disconnect();
                return id;
            }
            catch (Exception ex)
            {
                Console.WriteLine($":: {Database} | {TableName} | DELETE | {ex.Message} ::");
                return null;
            }
        }

        public T DataReaderConverter(MySqlDataReader reader)
        {
            return default(T);
        }
    }
}
