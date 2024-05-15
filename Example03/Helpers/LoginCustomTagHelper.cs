using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Example03TagHelper.Helpers
{
    [HtmlTargetElement("login-form")]
    public class LoginCustomTagHelper : TagHelper
    {
        
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div"; //<div></div>
            output.TagMode = TagMode.StartTagAndEndTag;

            string loginForm = "<form action='/Home/Login' method='post'>";

            loginForm += "<input type='text' name='username'/>";
            loginForm += "<input type='password' name='password'/>";
            loginForm += "<input type='submit' name='Giriş'/>";

            loginForm += "</form>";

            output.PreContent.SetHtmlContent(loginForm);
        }
    }
}
