using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration; 

namespace Petshop.SQLServerDAL
{
    //基于 SQLServer 的数据访问实现
    public class Category:IDataAccessLayer.ICategory
    {
        public IEnumerable<Model.Category> GetCategories()
        {
            string sql = "";
            string connectionString = ConfigurationSettings.AppSettings["petshop4"].ToString();

            List<Model.Category> list = new List<Model.Category>();

            using (SqlDataReader reader = DBUtility.SqlHelper.ExecuteReader(connectionString, System.Data.CommandType.Text, sql))
            {
                while (reader.Read())
                {
                    Model.Category category = new Model.Category()
                    {
                        CategoryId = reader.GetString(0),
                        CategoryName = reader.GetString(1),
                        Description = reader.GetString(2)
                    };

                    list.Add(category);

                }
                reader.Close();
            }

            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    conn.Open();
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        Model.Category category = new Model.Category() { 
            //            CategoryId=reader.GetString(0),
            //            CategoryName=reader.GetString(1),
            //            Description=reader.GetString(2)
            //        };

            //        list.Add(category);

            //    }
            //    reader.Close();
            //}
            return list;
        }

        public Model.Category GetCategoryById(string categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
