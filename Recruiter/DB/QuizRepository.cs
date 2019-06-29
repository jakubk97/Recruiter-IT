using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace Recruiter
{
    class QuizRepository
    {
        private static MySqlConnection connection = DBConnection.Instance.Connection;

        public static int GetTests(Forma f)
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
