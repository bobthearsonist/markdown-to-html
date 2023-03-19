using System.Reflection;
using FluentAssertions;

namespace markdown_to_html.tests;

using markdown_to_html_lib;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Example1()
    {
        using var input = new MemoryStream();
        using var expected = new MemoryStream();
        
        Assembly.GetExecutingAssembly()
                .GetManifestResourceStream("markdown_to_html.tests.example.markdown.example1.md")
                ?.CopyTo(input);
        Assembly.GetExecutingAssembly()
            .GetManifestResourceStream("markdown_to_html.tests.example.html.example1.html")
            ?.CopyTo(expected);

        using var actual = MarkDownToHtml.Convert(input);
        
        actual.ToArray().Should().BeEquivalentTo(expected.ToArray());
    }
}