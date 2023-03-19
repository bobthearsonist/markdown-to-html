using System.Text;
using markdown_to_html_lib;

namespace markdown_to_html.tests;

[TestFixture]
public class HeadingTest
{
    [Test]
    public void Header1_Converts()
    {
        // TODO write a helper method so you can have lots of tests with less code
        using var input = new MemoryStream(Encoding.UTF8.GetBytes("# heading 1 example"));
        using var actual = MarkDownToHtml.Convert(input);
        
        var decoded = Encoding.UTF8.GetString(actual.ToArray());
        
        decoded.Should().BeEquivalentTo("<h1>heading 1 example</h1>");
    }
}