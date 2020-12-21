using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Pokemon_API.Extensions
{
    public abstract class TableQueries<T>
    {
        public abstract string Database { get; }
        public abstract string TableName { get; }
        public DatabaseConnector connection { get { return GetDatabaseConnector().Result; } }


#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async virtual Task<DatabaseConnector> GetDatabaseConnector()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            return connection;
        }

        internal async Task<List<T>> Get(Dictionary<string, object> values)
        {
            if(!await connection.IsConnected())
            {
                Console.WriteLine($"Failed to connect to {Database} | {TableName}");
                return null;
            }

            if(values.Count == 0)
            {
                return null;
            }

            string query = $"Select * From {TableName} WHERE ";
            try
            {
                foreach (KeyValuePair<string, object> pair in values)
                {
                    query += $"{pair.Key}=@{pair.Key} AND";
                }
                query = query.Substring(0, query.Length - 3);
                query += ";";

                MySqlCommand cmd = new MySqlCommand(query, connection.Connection);
                foreach (KeyValuePair<string, object> pair in values)
                {
                    if(pair.Value == null) { continue; }
                    cmd.Parameters.AddWithValue($"@{pair.Key}", pair.Value);
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
                Exception e = new Exception($":: {Database} | {TableName} | GET | {ex.Message} | QUERY | {query} ::");
                return null;
            }
        }

        internal async Task<int?> Insert(Dictionary<string, object> values)
        {
            if (!await connection.IsConnected())
            {
                Console.WriteLine($"Failed to connect to {Database} | {TableName}");
                return null;
            }

            if(values.Count == 0)
            {
                return null;
            }

            string query = $"INSERT INTO {TableName} (";
            try
            {
                
                foreach(KeyValuePair<string, object> pair in values)
                {
                    query += $"{pair.Key}, ";
                }
                query = query.Remove(query.LastIndexOf(','), 1);
                query += ") VALUES (";

                foreach (KeyValuePair<string, object> pair in values)
                {
                    query += $"@{pair.Key}, ";
                }
                query = query.Remove(query.LastIndexOf(','), 1);
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
                Exception e = new Exception($":: {Database} | {TableName} | INSERT | {ex.Message} | QUERY | {query} ::");
                throw e;
            }
        }

        internal async Task<int?> Delete(Dictionary<string, object> values)
        {
            if (!await connection.IsConnected())
            {
                Console.WriteLine($"Failed to connect to {Database} | {TableName}");
                return null;
            }

            if(values.Count == 0)
            {
                return null;
            }

            string query = $"DELETE FROM {TableName} WHERE ";
            try
            {
                
                foreach (KeyValuePair<string, object> pair in values)
                {
                    query += $"{pair.Key}=@{pair.Key} AND";
                }
                query = query.Remove(query.LastIndexOf("AND"), 3);
                query += ";";

                MySqlCommand cmd = new MySqlCommand(query, connection.Connection);
                foreach (KeyValuePair<string, object> pair in values)
                {
                    if (pair.Value == null) { continue; }
                    cmd.Parameters.AddWithValue($"@{pair.Key}", pair.Value);
                }

                int id = await cmd.ExecuteNonQueryAsync();
                await connection.Disconnect();
                return id;
            }
            catch (Exception ex)
            {
                Exception e = new Exception($":: {Database} | {TableName} | DELETE | {ex.Message} | QUERY | {query} ::");
                throw e;
            }
        }

        public virtual T DataReaderConverter(MySqlDataReader reader)
        {
            return default(T);
        }

        public Dictionary<string, object> SerializeReader(MySqlDataReader reader)
        {
            var results = new Dictionary<string, object>();
            var cols = new List<string>();
            for (var i = 0; i < reader.FieldCount; i++) { 
                cols.Add(reader.GetName(i));
                reader.GetValue(i);
                results.Add(reader.GetName(i), reader.GetValue(i));
            }
            return results;
        }
    }
}
