using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CengFeng_Model
{
   public class Articles:BaseModel
    {
            /// <summary>
            /// 文章类别路径
            /// </summary>
            public string ArticleCategoryFullPath { get; set; }
            /// <summary>
            /// 类别ID
            /// </summary>
            public int CategoryId { get; set; }
            /// <summary>
            /// 内容
            /// </summary>
            public string Content { get; set; }
            /// <summary>
            /// ICON图标URL
            /// </summary>
            public string IconUrl { get; set; }
            /// <summary>
            /// IsRelease
            /// </summary>
            public bool IsRelease { get; set; }
            /// <summary>
            /// SEO描述
            /// </summary>
            public string Meta_Description { get; set; }
            /// <summary>
            /// SEO关键词
            /// </summary>
            public string Meta_Keywords { get; set; }
            /// <summary>
            /// SEO标题
            /// </summary>
            public string Meta_Title { get; set; }
            /// <summary>
            /// 标题
            /// </summary>
            public string Title { get; set; }
        

    }
}
