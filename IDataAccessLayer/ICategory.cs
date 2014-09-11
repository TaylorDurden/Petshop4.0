using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Petshop.IDataAccessLayer
{
    /// <summary>
    /// 通过各种数据库的DAL层去实现，例如 SQLServerDAL类库
    /// </summary>
    public interface ICategory
    {
        //默认为Public访问

        //获取所有的分类信息，注意返回类型为可遍历的集合
        IEnumerable<Petshop.Model.Category> GetCategories();

        //获取某种分类的详细信息
        Petshop.Model.Category GetCategoryById(string categoryId);
    }
}
