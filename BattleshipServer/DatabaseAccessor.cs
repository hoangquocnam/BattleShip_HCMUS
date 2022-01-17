using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Text;

namespace BattleshipServer
{
    class DatabaseAccessor
    {
        public List<ClientInfo> GetData()
        {
            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM Clients", connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    List<ClientInfo> lst = new List<ClientInfo>();

                    foreach (DataRow row in table.Rows)
                    {
                        lst.Add(new ClientInfo(row[0].ToString(), Encrypt.HexToString(row[1].ToString()), row[2].ToString(), row[3].ToString(), row[4].ToString(), Convert.ToInt32(row[5].ToString())));
                    }

                    return lst;
                }
            }
        }

        public void Insert(ClientInfo client)
        {
            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    connection.Open();
                    cmd.CommandText = string.Format("INSERT INTO Clients (Username, Password, FullName, DateOfBirth, Note, Point) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', {5})", client.Username, Encrypt.StringToHex(client.Password), client.FullName, client.DateOfBirth, client.Note, client.Point);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Update(ClientInfo client)
        {
            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    connection.Open();
                    cmd.CommandText = string.Format("UPDATE Clients SET Password='{0}', FullName='{1}', DateOfBirth='{2}', Note='{3}', Point='{4}' WHERE Username='{5}'", Encrypt.StringToHex(client.Password), client.FullName, client.DateOfBirth, client.Note, client.Point, client.Username);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(ClientInfo client)
        {
            using (SQLiteConnection connection = new SQLiteConnection(GetConnectionString()))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(connection))
                {
                    connection.Open();
                    cmd.CommandText = string.Format("DELETE FROM Clients WHERE Username='{0}'", client.Username);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private string GetConnectionString()
        {
            return "Data Source=.\\Database.db;Version=3;";
        }
    }

}
