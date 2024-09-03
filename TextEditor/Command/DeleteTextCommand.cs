

using TextEditor.Receiver;

namespace TextEditor.Command;

public class DeleteTextCommand : ICommand
{
    private readonly TextDocument _textDocument;
    private readonly int _length;

    public DeleteTextCommand(TextDocument textDocument, int length)
    {
        if(textDocument == null) throw new ArgumentNullException();
        _textDocument = textDocument;
        _length = length;
    }

    public void Execute()
    {
        _textDocument.DeleteText(_length);
    }

    public void Undo()
    {
        Console.WriteLine("DELETE UNDO");
    }
}
