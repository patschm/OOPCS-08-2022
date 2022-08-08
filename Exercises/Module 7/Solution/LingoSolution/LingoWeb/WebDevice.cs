using LingoGame;
using System.Text;

namespace LingoWeb;

public class WebDevice : IDevice
{
    private StringBuilder _builder = new StringBuilder();

    public void DrawDefault(char c)
    {
        _builder.Append($"<div class=\"square\">{c}</div>\r\n");
    }

    public void DrawExact(char c)
    {
        _builder.Append($"<div class=\"square\"><div class=\"correct\">{c}</div></div>\r\n");
    }

    public void DrawPartial(char c)
    {
        _builder.Append($"<div class=\"square\"><div class=\"wrongplace\">{c}</div></div>\r\n");
    }

    public override string ToString()
    {
        return _builder.ToString();
    }
}
