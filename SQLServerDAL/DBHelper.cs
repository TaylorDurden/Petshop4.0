using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.SQLServerDAL
{
    public sealed class DBHelper
    {
        public static string ConnectionString
        {
            get {
                return System.Configuration.ConfigurationManager.AppSettings["w"].ToString();//获取数据库连接字符串
            }
        }
    }
}
