using CengFeng_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using Newtonsoft.Json;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
namespace CengFeng_API.Controllers
{
    public class ListArticlesSearchController : ApiController
    {
        [System.Web.Http.HttpGet]
        [System.Web.Http.HttpPost]
        public CengFeng_Model.PageModel Get(Models.ListArticlesSearch _search)
        {
            int PageCount, TotalCount;
            IMongoQuery _query = MongoDB.Driver.Builders.Query.Matches("Title", "/" + _search.KeyWords + ".*/"); ;
            CengFeng_BLL.Articles bll = new CengFeng_BLL.Articles();
            var _list = bll.List_Page(_query, _search.PageIndex, _search.PageSize, null, out PageCount, out TotalCount);
            var _page_model = new CengFeng_Model.PageModel{ PageIndex= _search.PageIndex, PageCount = PageCount, TotalCount = TotalCount, data = JsonConvert.SerializeObject(_list) };

            //    CengFeng_Model.PageModel _page_model = new CengFeng_Model.PageModel();
            //_page_model.PageIndex = _search.PageIndex;
            //_page_model.PageCount = PageCount;
            //_page_model.TotalCount = TotalCount;
            //_page_model.data = JsonConvert.SerializeObject(_list);
            return _page_model;
        }

    }
}
