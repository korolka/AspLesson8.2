
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AspLesson8._2.Infrastructure.TagHelpers
{
    [HtmlTargetElement("div")]
    public class BorderTagHelper:TagHelper
    {
        public string MyBorderColor { get; set; }
        public BorderTagHelper()
        {
            MyBorderColor = "black";
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", $"my-border-{MyBorderColor}");
        }
    }
}
