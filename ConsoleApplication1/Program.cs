using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Petshop.IDataAccessLayer.ICategory categoryDAL = new Petshop.SQLServerDAL.Category();

            foreach (Petshop.Model.Category category in categoryDAL.GetCategories())
            {
                Console.WriteLine(category.CategoryId);
            }
        }
    }
}
