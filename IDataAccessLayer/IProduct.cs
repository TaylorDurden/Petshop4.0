using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.IDataAccessLayer
{
    public interface IProduct
    {
        IEnumerable<Model.Product> GetProducts();

        IEnumerable<Model.Product> GetProductsByCategoryID(string categoryID);
    }
}
