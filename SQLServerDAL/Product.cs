using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Petshop.SQLServerDAL
{
    public class Product:Petshop.IDataAccessLayer.IProduct
    {

        public IEnumerable<Model.Product> GetProducts()
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Model.Product> GetProductsByCategoryID(string categoryID)
        {
            string sql = "";

            string connectionString = DBHelper.ConnectionString;

            SqlParameter pID = new SqlParameter("@id", SqlDbType.VarChar, 10);
            pID.Value = categoryID;

            List<Petshop.Model.Product> list = new List<Model.Product>();

            using (SqlDataReader reader=DBUtility.SqlHelper.ExecuteReader(connectionString,CommandType.Text,sql,pID))
            {
                while (reader.Read())
                {
                    Model.Product product = new Model.Product()
                    {
                        //为相应属性赋值
                    };
                    list.Add(product);
                }
                reader.Close();
            }
            return list;
        }
    }
}
