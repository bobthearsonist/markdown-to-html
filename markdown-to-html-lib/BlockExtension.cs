using HtmlAgilityPack;
using Markdig.Syntax;
using Markdig.Syntax.Inlines;

namespace markdown_to_html_lib;

public static class BlockExtension
{
    //use values that are function pointers and return the parsed/formatted html? Func<HtmlNode>()
    static Dictionary<Type, string> blockTypeToHtmlTagLookup = new()
    {
        // TODO you will need to pars what level heading it is somehow and then do the other levels
        { typeof(HeadingBlock), "h1" },
        // TODO find what these types are
        // { typeof("Text"),"p"},
        // { typeof("Link"),"a"},
        // { typeof("Blank"),""}
    };

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