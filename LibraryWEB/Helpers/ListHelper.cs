using Microsoft.AspNetCore.Html;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LibraryWEB.Helpers
{
    public static class ListHelper
    {
        public static HtmlString CreateList(this IHtmlHelper html, List<List<string>> optCheckList, List<List<string>> radioList)
        {
            TagBuilder div = new TagBuilder("div");
            int t = 0;
            for (int i = 0; i < optCheckList.Count; i++)
            {
                TagBuilder p = new TagBuilder("p");
                p.InnerHtml.Append(optCheckList[i][0]);
                div.InnerHtml.AppendHtml(p);
                TagBuilder ul = new TagBuilder("ul");
                for (int j = 1; j < optCheckList[i].Count; j++)
                {
                    TagBuilder ol = new TagBuilder("ol");
                    TagBuilder input = new TagBuilder("input");
                    input.MergeAttribute("type", "checkbox");
                    input.MergeAttribute("name", t.ToString());
                    input.MergeAttribute("isChecked", "false");
                    input.MergeAttribute("value", $"@Request.Form[\"${t}\"]");
                    input.InnerHtml.Append(optCheckList[i][j]);
                    ol.InnerHtml.Append(input.ToString());
                    ul.InnerHtml.AppendHtml(ol);
                    t++;
                }

                div.InnerHtml.AppendHtml(ul);
            }

            for (int i = 0; i < radioList.Count; i++)
            {
                TagBuilder p = new TagBuilder("p");
                p.InnerHtml.Append(radioList[i][0]);
                div.InnerHtml.AppendHtml(p);
                TagBuilder ul = new TagBuilder("ul");
                for (int j = 1; j < radioList[i].Count; j++)
                {
                    TagBuilder ol = new TagBuilder("ol");
                    TagBuilder input = new TagBuilder("input");
                    input.MergeAttribute("type", "radio");
                    input.MergeAttribute("name", "age");
                    input.MergeAttribute("value", j.ToString());
                    input.InnerHtml.Append(radioList[i][j]);
                    ol.InnerHtml.Append(input.ToString());
                    ul.InnerHtml.AppendHtml(ol);
                }

                div.InnerHtml.AppendHtml(ul);
            }
            return new HtmlString(div.ToString());
        }
    }
}
