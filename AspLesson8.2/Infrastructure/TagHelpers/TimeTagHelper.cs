using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AspLesson8._2.Infrastructure.TagHelpers
{
    [HtmlTargetElement("current-time", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class TimeTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var currentTime = DateTime.Now;
            output.TagName = "span";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Content.SetContent(currentTime.ToString("t"));
        }
    }
}
