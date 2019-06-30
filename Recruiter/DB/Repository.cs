﻿using MySql.Data.MySqlClient;
using System;

namespace Recruiter
{
    class Repository
    {
        private static MySqlConnection connection = DBConnection.Instance.Connection;

        public static int F2(string imie, string drugie, string nazwisko, string data_urodzenia, string email
            , string telefon, string adres, string zdjecie)
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
        public static int F3(string krajstudiow, string nazwauczelni, string wydzial, string kierunek
            , string trybstudiow, string tytzawodowy, string d_roz_studiow, string d_zak_studiow)
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
        public static int F4(string jezyki)
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
        public static int F5(string nazwa, string stanowisko, string data_od, string data_do)
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
        public static int F6(string technologie, string linki)
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
        public static int F7(string prefstanowisko, string prefoddzial, string prefczaspracy
            , string wynagrodzenie, string pracaodkiedy, string skadwiesz)
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
        public static int F8(string zainteresowania, string infodlarekrutera)
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

        //public int TS()
        //{
        //    {
        //        try
        //        {
        //            List<string> trybystudiow = new List<string>();
        //            string manufacturer, model, capacity;
        //            using (MySqlCommand command = new MySqlCommand(@"SELECT * FROM CARS ORDER BY MANUFACTURER", connection))
        //            {
        //                connection.Open();
        //                MySqlDataReader dataReader = command.ExecuteReader();
        //                while (dataReader.Read())
        //                {
        //                    manufacturer = dataReader["manufacturer"].ToString();
        //                    model = dataReader["model"].ToString();
        //                    capacity = dataReader["capacity"].ToString();
        //                    cars.Add(new Cars(manufacturer, model, capacity));
        //                }
        //            }
        //            return cars.ToArray();
        //        }
        //        catch (Exception)
        //        {
        //            Console.WriteLine("\nBłąd podczas dodawania rekordu do bazy\nSprawdź połączenie z bazą\n");
        //            return new List<Cars>().ToArray(); ;
        //        }
        //        finally
        //        {
        //            connection.Close();
        //        }
        //    }
        //}
    }
}