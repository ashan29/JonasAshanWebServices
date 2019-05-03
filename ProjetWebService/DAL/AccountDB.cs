using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public static class AccountDB
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["JonasAshanWebServices"].ConnectionString;

        public static void addAmount(float Amount, string Name)
        {
          
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Hotel WHERE IdHotel = " + IdHotel;
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            hotel = new Hotel
                            {
                                IdHotel = (int)dr["IdHotel"],
                                Category = (int)dr["Category"],
                                Description = (string)dr["Description"],
                                Email = (string)dr["Email"],
                                HasParking = (bool)dr["HasParking"],
                                HasWifi = (bool)dr["HasWifi"],
                                Location = (string)dr["Location"],
                                Name = (string)dr["Name"],
                                Phone = (string)dr["Phone"],
                                Website = (string)dr["Website"]
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
         
        }
    }
}
