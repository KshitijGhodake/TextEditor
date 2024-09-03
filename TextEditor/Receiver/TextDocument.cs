
namespace TextEditor.Receiver;

public class TextDocument
{
    public string Content { get; private set; } = string.Empty;

    public void InsertText(string text)
    {
        Content += text;
        Console.WriteLine(Content);
    }

    public void DeleteText(int length)
    {
        if(length <= Content.Length)
        {
            Content = Content.Substring(0,Content.Length - length);
            Console.WriteLine(Content);
        }
    }
}