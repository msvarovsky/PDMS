using PDMS.Models;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace PDMS.HtmlHelpers
{
    public static class MSHelpers
    {
        //http://www.c-sharpcorner.com/UploadFile/3194c4/custom-html-helpers-in-mvc/

        public static IHtmlString File(this HtmlHelper helper, string id)
        {
            TagBuilder tb = new TagBuilder("input");
            tb.Attributes.Add("type", "file");
            tb.Attributes.Add("id", id);
            return new MvcHtmlString(tb.ToString());
        }

        public static IHtmlString MSLabel(this HtmlHelper helper, string text, string szClass)
        {
            TagBuilder tb = new TagBuilder("label");
            tb.SetInnerText(text);
            tb.Attributes.Add("class", szClass);
            return new MvcHtmlString(tb.ToString());
        }

        public static IHtmlString MSLabelTextBox(this HtmlHelper helper, string lText, string tbHolterText, string lClass, string tbClass, string tbId)
        {
            TagBuilder tbLabel = new TagBuilder("label");
            tbLabel.SetInnerText(lText);
            tbLabel.AddCssClass(lClass);

            TagBuilder tbTB = new TagBuilder("input");
            tbTB.Attributes.Add("type", "text");
            tbTB.Attributes.Add("id", tbId);
            tbTB.AddCssClass(tbClass);
            return new MvcHtmlString(tbLabel.ToString() + System.Environment.NewLine + tbTB.ToString());
        }

        public static IHtmlString Field(this HtmlHelper helper, Field f)
        {
            return new MvcHtmlString(f.HtmlText());
        }




    }
}