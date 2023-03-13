using Markdig

namespace markdown_to_html_lib;
public static class MarkDownToHtml
{
    public static Stream Convert(Stream input)
    {
        return new MemoryStream(System.Text.Encoding.ASCII.GetBytes("nope"));
    }
}
