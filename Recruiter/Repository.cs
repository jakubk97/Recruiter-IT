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

        public static int SendPersonalData()
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
        public static int SendEducation()
        {
            try
            {
                Forma f = Forma.Instance;
                int ID;
                using (MySqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = @"INSERT INTO studia(tryb,id_kier,id_uczelni) 
                    VALUES(@tryb, (SELECT id_kierunku From kierunki where nazwa=@id_kier)
                    , (SELECT id_uczelni From uczelnie where nazwa=@id_uczelni))";
                    command.Parameters.AddWithValue("@tryb", f.Trybstudiow);
                    command.Parameters.AddWithValue("@id_kier", f.Kierunek);
                    command.Parameters.AddWithValue("@id_uczelni", f.Nazwauczelni);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                using (MySqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = @"UPDATE dane_osobowe set tytul_zawodowy=@tytul_zawodowy where id_osoby=@id_osoby";
                    command.Parameters.AddWithValue("@tytul_zawodowy", f.Tytzawodowy);
                    command.Parameters.AddWithValue("@id_osoby", f.ID1);
                    command.ExecuteNonQuery();
                    connection.Close();
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
        public static int SendPrevWork()
        {
            try
            {
                Forma f = Forma.Instance;
                int ID;
                if (f.Nazwa == "" && f.Stanowisko == "")
                {
                    using (MySqlCommand command = connection.CreateCommand())
                    {
                        connection.Open();
                        command.CommandText = @"INSERT INTO pop_praca(id_osoby,nazwa,stanowisko,data_od,data_do) 
                    VALUES(@id_osoby,@nazwa,@stanowisko,@data_od,@data_do)";
                        command.Parameters.AddWithValue("@id_osoby", f.ID1);
                        command.Parameters.AddWithValue("@nazwa", " ");
                        command.Parameters.AddWithValue("@stanowisko", " ");
                        command.Parameters.AddWithValue("@data_od", DateTime.Now.ToShortDateString());
                        command.Parameters.AddWithValue("@data_do", DateTime.Now.ToShortDateString());
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                else
                {
                    using (MySqlCommand command = connection.CreateCommand())
                    {
                        connection.Open();
                        command.CommandText = @"INSERT INTO pop_praca(id_osoby,nazwa,stanowisko,data_od,data_do) 
                    VALUES(@id_osoby,@nazwa,@stanowisko,@data_od,@data_do)";
                        command.Parameters.AddWithValue("@id_osoby", f.ID1);
                        command.Parameters.AddWithValue("@nazwa", f.Nazwa);
                        command.Parameters.AddWithValue("@stanowisko", f.Stanowisko);
                        command.Parameters.AddWithValue("@data_od", f.Data_od);
                        command.Parameters.AddWithValue("@data_do", f.Data_do);
                        command.ExecuteNonQuery();
                        connection.Close();
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
        public static int SendLinks()
        {
            try
            {
                Forma f = Forma.Instance;
                int ID;
                using (MySqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = @"UPDATE dane_osobowe set linki=@linki where id_osoby=@id_osoby";
                    command.Parameters.AddWithValue("@linki", f.Linki);
                    command.Parameters.AddWithValue("@id_osoby", f.ID1);
                    command.ExecuteNonQuery();
                    connection.Close();
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
        public static int SendAddInfo()
        {
            try
            {
                Forma f = Forma.Instance;
                int ID;
                using (MySqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = @"INSERT INTO dodatkowe_info(czas_pracy,wynagrodzenie,od_kiedy
                    ,skad_wiesz,dod_info,zainteresowania) 
                    VALUES(@czas_pracy,@wynagrodzenie,@od_kiedy,@skad_wiesz,@dod_info,@zainteresowania)";
                    command.Parameters.AddWithValue("@czas_pracy", f.Prefczaspracy);
                    command.Parameters.AddWithValue("@wynagrodzenie", f.Wynagrodzenie);
                    command.Parameters.AddWithValue("@od_kiedy", f.Prefczaspracy);
                    command.Parameters.AddWithValue("@skad_wiesz", f.Skadwiesz);
                    command.Parameters.AddWithValue("@dod_info", f.Infodlarekrutera);
                    command.Parameters.AddWithValue("@zainteresowania", f.Zainteresowania);
                    command.ExecuteNonQuery();
                    connection.Close();
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
        public static int CreateFormul()
        {
            try
            {
                Forma f = Forma.Instance;
                int ID;
                using (MySqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandText = @"INSERT INTO formularze(id_osoby,id_pop_pracy,id_dod_info
                    ,id_studiow,technologie,jezyki,stanowisko) 
                    VALUES(@id_osoby,(SELECT MAX(id_pracy) FROM pop_praca)
                    ,(SELECT MAX(id_info) FROM dodatkowe_info),(SELECT MAX(id_studiow) FROM studia),@technologie,@jezyki,@stanowisko)";
                    command.Parameters.AddWithValue("@id_osoby", f.ID1);
                    command.Parameters.AddWithValue("@technologie", f.Technologie);
                    command.Parameters.AddWithValue("@jezyki", f.Jezyki);
                    command.Parameters.AddWithValue("@stanowisko", f.Prefstanowisko);
                    command.ExecuteNonQuery();
                    connection.Close();
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
