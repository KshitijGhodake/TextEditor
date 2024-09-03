

using TextEditor.Receiver;

namespace TextEditor.Command;

public class InsertTextCommand : ICommand
{
    private readonly TextDocument _textDocument;
    private readonly string _text;

    public InsertTextCommand(TextDocument textDocument, string text)
    {
        if (textDocument == null || text == null)
        {
            throw new ArgumentNullException();
        }
        _textDocument = textDocument;
        _text = text;
    }

    public void Execute()
    {
        _textDocument.InsertText(_text);
    }

    public void Undo()
    {
        _textDocument.DeleteText(_text.Length);
    }
}