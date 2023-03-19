using HtmlAgilityPack;
using Markdig.Syntax;
using Markdig.Syntax.Inlines;

namespace markdown_to_html_lib;

public static class BlockExtension
{

    public static HtmlNode Map(this Block block)
    {
        //TODO implement the actual mappings.
        var node = HtmlNode.CreateNode("<h1>" 
                                       + (block as HeadingBlock)?.Inline!.First() 
                                       + "</h1>"
                                );
        return node;
    }
}