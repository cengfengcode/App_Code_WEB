
namespace CengFeng_API.Models
{
    public class ListArticlesSearch:CengFeng_Model.Articles
    {
        /// <summary>
        /// 查询关键词
        /// </summary>
        public string KeyWords { get; set; }
        /// <summary>
        /// 当前页码
        /// </summary>
        public int PageIndex { get; set; }
        /// <summary>
        /// 每页显示条数
        /// </summary>
        public int PageSize { get; set; }
    }
}