using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Recruiter
{
    class Repository
    {
        private static MySqlConnection connection = DBConnection.Instance.Connection;


        public static string[] GetKierunki()
        {
            try
            {
                List<string> list = new List<string>();
                string nazwa;
                using (MySqlCommand command = new MySqlCommand(@"SELECT nazwa FROM kierunki", connection))
                {
                    connection.Open();
                    MySqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        nazwa = dataReader["nazwa"].ToString();
                        list.Add(nazwa);
                    }
                }
                return list.ToArray();
            }
            catch (Exception)
            {
                Console.WriteLine("\nBłąd podczas dodawania rekordu do bazy\nSprawdź połączenie z bazą\n");
                return new List<string>().ToArray(); ;
            }
            finally
            {
                connection.Close();
            }
        }

        public static string[] GetUczelnie()
        {
            try
            {
                List<string> list = new List<string>();
                string nazwa;
                using (MySqlCommand command = new MySqlCommand(@"SELECT nazwa FROM uczelnie", connection))
                {
                    connection.Open();
                    MySqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        nazwa = dataReader["nazwa"].ToString();
                        list.Add(nazwa);
                    }
                }
                return list.ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nBłąd podczas dodawania rekordu do bazy\nSprawdź połączenie z bazą\n");
                return new List<string>().ToArray(); ;
            }
            finally
            {
                connection.Close();
            }
        }

        public static string[] GetTechnologie()
        {
            try
            {
                List<string> list = new List<string>();
                string nazwa;
                using (MySqlCommand command = new MySqlCommand(@"SELECT nazwa FROM technologie", connection))
                {
                    connection.Open();
                    MySqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        nazwa = dataReader["nazwa"].ToString();
                        list.Add(nazwa);
                    }
                }
                return list.ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nBłąd podczas dodawania rekordu do bazy\nSprawdź połączenie z bazą\n");
                return new List<string>().ToArray(); ;
            }
            finally
            {
                connection.Close();
            }
        }

        public int F2()
        {
            try
            {
                int ID;
                string TestName;
                string Category;
                int Time;
                using (MySqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = "INSERT INTO CARS(manufacturer,model,capacity) VALUES(@manufacturer, @model, @capacity)";
                    // command.Parameters.AddWithValue("@manufacturer", f.Manufacturer);
                    // command.Parameters.AddWithValue("@model", f.Model);
                    // command.Parameters.AddWithValue("@capacity", f.Capacity);
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
