﻿using System;
using System.Data.SQLite;
using System.Web;

namespace saugusPrisijungimas
{
    public class ConnectionUtility
    {
        private static string dbPath = "~/database/MyTestDatabase.sqlite3";
        private static string getConnectionString()
        {
            return "Data Source=" + HttpContext.Current.Server.MapPath(dbPath) + ";Version=3;";
        }

        public static bool checkDBConnection()
        {
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(getConnectionString()))
                {
                    connection.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }

        public static bool checkUser(string username)
        {
            using (SQLiteConnection connection = new SQLiteConnection(getConnectionString()))
            {
                connection.Open();

                SQLiteCommand cmd = new SQLiteCommand("SELECT 1 FROM Users WHERE Username=@Name", connection);
                cmd.Parameters.AddWithValue("@Name", username);

                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[0].ToString() == "1")
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool checkPassword(string username, string password)
        {
            using (SQLiteConnection connection = new SQLiteConnection(getConnectionString()))
            {
                connection.Open();

                SQLiteCommand cmd = new SQLiteCommand("SELECT Password FROM Users WHERE Username=@Name", connection);
                cmd.Parameters.AddWithValue("@Name", username);

                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[0].ToString() == "1")
                    {
                        return true;
                    }
                }

            }

            return false;
        }
    }
}