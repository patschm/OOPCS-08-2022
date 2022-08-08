using LingoGame;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace LingoWeb.TagHelpers;

[HtmlTargetElement("lingo-word")]
public class LingoTagHelper : TagHelper
{
    public LingoWord?  Word { get; set; }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        var device = new WebDevice();
        Word?.Show(device);
        output.TagName = "div";
        output.Content.SetHtmlContent(device.ToString());
    }
}
