using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Cities.Infrastructure.TagHelpers {

    [HtmlTargetElement("div", Attributes = "title")]
    public class ContentWrapperTagHelper : TagHelper {

        public bool IncludeHeader { get; set; } = true;
        public bool IncludeFooter { get; set; } = true;

        public string Title { get; set; }

        public override void Process(TagHelperContext context,
                                     TagHelperOutput output) {

            output.Attributes.SetAttribute("class", "panel-body");

            TagBuilder title = new TagBuilder("h1");
            title.InnerHtml.Append(Title);

            TagBuilder container = new TagBuilder("div");
            container.Attributes["class"] = "bg-info panel-body";

            container.InnerHtml.AppendHtml(title);

            if (IncludeHeader) {
                output.PreElement.SetHtmlContent(container);
            }

            if (IncludeFooter) {
                output.PostElement.SetHtmlContent(container);
            }
        }
    }
}
