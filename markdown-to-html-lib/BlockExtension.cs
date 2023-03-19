using HtmlAgilityPack;
using Markdig.Syntax;
using Markdig.Syntax.Inlines;

namespace markdown_to_html_lib;

public static class BlockExtension
{
    private static Dictionary<Type, Func<IBlock, HtmlNode>> _blockTypeToHtmlTagLookup = new()
    {
        { typeof(HeadingBlock), FormatHeader },
        
        // TODO find what these types are
        // { typeof("Text"),"p"},
        // { typeof("Link"),"a"},
        // { typeof("Blank"),""}
    };

    private static HtmlNode FormatHeader(IBlock block)
    {
        var headingBlock = (block as HeadingBlock);
        var headingText = headingBlock?.Inline!.First();
        var level = headingBlock!.Level; 
        return HtmlNode.CreateNode("<h" + level + ">" + headingText + "</h" + level + ">");
    }

    public static HtmlNode Map(this IBlock block)
    {
        //TODO implement the actual mappings.
        var node = HtmlNode.CreateNode("<h1>" 
                                       + (block as HeadingBlock)?.Inline!.First() 
                                       + "</h1>"
                                );
        return node;
    }
}