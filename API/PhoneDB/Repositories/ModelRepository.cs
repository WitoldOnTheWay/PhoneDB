using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PhoneDB.Models;

namespace PhoneDB.Repositories
{
    public class ModelRepository
    {
        public List<Model> GetAll()
        {
            List<Model> modelList = new List<Model>();
            using (SqlConnection conn = new SqlConnection("Server=DESKTOP-FH5G1I2\\SQLEXPRESS;Database=PhoneDB;Trusted_Connection=True;"))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select* FROM Model";
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    modelList.Add(new Model()
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Name = reader["Name"].ToString(),
                        System = reader["System"].ToString(),
                        Description = reader["Description"].ToString()
                    });
                }
            }
            return modelList;
        }
    }
}