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

        public static int Send()
        {
            try
            {
                Forma f = Forma.Instance;
                int ID;
                using (MySqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = @"SET GLOBAL max_allowed_packet=1024*1024*1024";
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                using (MySqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = @"INSERT INTO dane_osobowe(imie,drugie_imie
                        ,nazwisko,data_urodzenia,adres,telefon,email,zdj) VALUES(@imie, @drugie_imie, @nazwisko, @data_urodzenia, @adres
                        , @telefon, @email, @zdj)";
                    command.Parameters.AddWithValue("@imie", f.Imie);
                    command.Parameters.AddWithValue("@drugie_imie", f.Drugie);
                    command.Parameters.AddWithValue("@nazwisko", f.Nazwisko);
                    command.Parameters.AddWithValue("@data_urodzenia", f.Data_urodzenia);
                    command.Parameters.AddWithValue("@adres", f.Adres);
                    command.Parameters.AddWithValue("@telefon", f.Telefon);
                    command.Parameters.AddWithValue("@email", f.Email);
                    command.Parameters.AddWithValue("@zdj", f.Zdjecie);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                using (MySqlCommand command = new MySqlCommand(@"SELECT MAX(id_osoby) FROM dane_osobowe", connection))
                {
                    connection.Open();
                    MySqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        f.ID1 = dataReader["MAX(id_osoby)"].ToString();
                    }
                }
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
