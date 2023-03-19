using HtmlAgilityPack;
using Markdig.Syntax;

namespace markdown_to_html_lib;

//TODO there is a pattern here that can be simplified.
public abstract class Formatter
{
    public static HtmlNode Header(IBlock block)
    {
        var headingBlock = (block as HeadingBlock);
        var headingText = headingBlock?.Inline!.First();
        var level = headingBlock!.Level; 
        return HtmlNode.CreateNode($"<h{level}>{headingText}</h{level}>");
    }
    
    public static HtmlNode Link(IBlock block)
    {
        string link = "";
        string text = "";
        return HtmlNode.CreateNode($"<a href={link}>{text}</a>");
    }
    
    public static HtmlNode Paragraph(IBlock block)
    {
        string text = "";
        return HtmlNode.CreateNode($"<p>{text}</p>");
    }
    
    public static HtmlNode Blank(IBlock block)
    {
        return HtmlNode.CreateNode("");
    }
}