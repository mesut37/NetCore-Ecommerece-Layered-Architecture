using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtradeApp.MvcWebUI.TagHelpers
{
    [HtmlTargetElement("account-list")]
    public class AccountListTagHelper : TagHelper
    {
        private string _pageName { get; set; }

        [HtmlAttributeName("page-name")]
        public string PageName
        {
            get
            {
                return _pageName;
            }

            set
            {
                _pageName = value.Replace("/","");
            }
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<ul class='nav flex-column dashboard-list'>");

            string[] menu = new string[3] { "Siparişlerim", "Fatura Adresim", "Hesap Ayarları" };


            for (int i = 0; i < menu.Length; i++)
            {
                var value = menu[i].Replace("ş", "s").Replace("ı", "i").ToLower().Replace(" ", string.Empty);
                stringBuilder.AppendFormat("<li>");
                stringBuilder.AppendFormat("<a href='/{0}' class='nav-link {1}' >{2}</a>",value, (value == _pageName) ? "active" : "", menu[i]);
                stringBuilder.Append("</li>");
            }
            stringBuilder.Append("</ul>");

            output.Content.SetHtmlContent(stringBuilder.ToString());

            base.Process(context, output);


        }
    }
}
