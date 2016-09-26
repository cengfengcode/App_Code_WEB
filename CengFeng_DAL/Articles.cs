using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CengFeng_DBUtility;
using CengFeng_Model;
using MongoDB.Bson;
using MongoDB.Driver;
namespace CengFeng_DAL
{
    /// <summary>
    /// 文章信息
    /// </summary>
   public class Articles
    {
        MongoDBHelper _mddb = new MongoDBHelper();
        public List<CengFeng_Model.Articles> List_Page(IMongoQuery _query, int pageindex, int pagesize, SortByDocument sort, out int pageCount, out int TotalCount)
        {
            List<CengFeng_Model.Articles>  _list = _mddb.Find<CengFeng_Model.Articles>(_query, pageindex, pagesize, sort, out pageCount, out TotalCount);
            return _list;
        }
    }
}
