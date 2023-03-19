using Markdig;
using HtmlAgilityPack;
using JetBrains.ReSharper.TestRunner.Abstractions.Extensions;
using Markdig.Syntax;

namespace markdown_to_html_lib;
public static class MarkDownToHtml
{

    // TODO use Create *** to imply the caller needs to close the stream returned
    public static MemoryStream Convert(MemoryStream stream)
    {
        var markdown = Markdown.Parse(System.Text.Encoding.ASCII.GetString(stream.ToArray()));

        var htmlNodes = markdown.ToList().Select<Block,HtmlNode>(element => element.Map());

        // TODO clean this up. its icky.
        var doc = new HtmlDocument();
        var nodeCol = new HtmlNodeCollection(doc.DocumentNode);
        htmlNodes.ForEach(node=>nodeCol.Add(node));
        doc.DocumentNode.AppendChildren(nodeCol);
        
        using var htmlStream = new MemoryStream();
        doc.Save(htmlStream);
        return htmlStream;
    }
}
