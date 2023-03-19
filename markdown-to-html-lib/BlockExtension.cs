using HtmlAgilityPack;
using Markdig.Syntax;
using Markdig.Syntax.Inlines;

namespace markdown_to_html_lib;

public static class BlockExtension
{
    private static readonly Dictionary<Type, Func<IBlock, HtmlNode>> BlockTypeToHtmlTagLookup = new()
    {
        { typeof(HeadingBlock), Formatter.Header },
        
        // TODO find what these types are
        { typeof(ParagraphBlock), Formatter.Paragraph },
        // { typeof(HeadingBlock), Formatter.Link },
        // { typeof(HeadingBlock), Formatter.Blank },
    };

    public static HtmlNode Map(this IBlock block)
    {
        try
        {
            var node = BlockTypeToHtmlTagLookup[block.GetType()](block);
            return node;
        }
        catch (KeyNotFoundException)
        {
            // TODO handle this gracefully? how? skip unsupported nodes and return exception collection?
            throw new NotImplementedException("Converting elements of "
                                              + block.GetType()
                                              + " is not supported.");
        }
    }
}