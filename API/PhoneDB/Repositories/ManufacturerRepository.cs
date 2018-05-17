using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PhoneDB.Models;

namespace PhoneDB.Repositories
{
    public class ManufacturerRepository
    {
        public List<Manufacturer> GetAll()
        {
            List<Manufacturer> Manufacturerlist = new List<Manufacturer>();
            using (SqlConnection conn = new SqlConnection("Server = DESKTOP-FH5G1I2\\SQLEXPRESS; Database = PhoneDB; Trusted_Connection = True;"))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select* FROM Manufacturer";
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Manufacturerlist.Add(new Manufacturer()
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Name = reader["Name"].ToString(),
                        Country = reader["Country"].ToString()
                    });
                }
            }
            return Manufacturerlist;
        }
    }
}