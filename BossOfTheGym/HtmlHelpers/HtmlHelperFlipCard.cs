using System.Text;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BossOfTheGym.HtmlHelpers
{
    public static class HtmlHelperFlipCard
    {
        public static HtmlString CreateFlipCard(this IHtmlHelper html)
        {
            StringBuilder result = new StringBuilder();
            result.Append("<div class='col-4 d-flex justify-content-center'>");
            result.Append("<div class='coacher-card__wrapper'>");
            result.Append("<div class='coacher-card__top'>");
            result.Append("<div class='coacher-img' style=background:url('" + "''" + "') 50% 50% / cover no-repeat></div>");
            result.Append("</div>");
            result.Append("<div class='coacher-card__back d-flex flex-column justify-content-center align-items-center'>");
            result.Append("<div class='underline-text__wrapper'>");
            result.Append("<h5 class='unline-text'>Something</h5><div class='unline bulgarianRose'></div>");
            result.Append("</div><p>Something</p>");
            result.Append("</div></div></div>");

            HtmlString htmlResult = new HtmlString(result.ToString());
            return htmlResult;
        }
    }
}
