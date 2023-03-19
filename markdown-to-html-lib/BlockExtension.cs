using HtmlAgilityPack;
using Markdig.Syntax;

namespace markdown_to_html_lib;

public static class BlockExtension
{

    public static HtmlNode Map(this Block block)
    {
        //TODO implement the actual mappings.
        var node = HtmlNode.CreateNode("<h1>" + block + "</h1>");
        return node;
    }
}