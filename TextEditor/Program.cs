using TextEditor.Command;
using TextEditor.Invoker;
using TextEditor.Receiver;

class ClientProgram
{
    public static void Main(string[] args)
    {
        var document = new TextDocument();
        var editor = new TextEditorApplication();
        var command_1 = new InsertTextCommand(document, "Hello, ");
        var command_2 = new InsertTextCommand(document, "World!");

        editor.ExecuteCommand(command_1);
        editor.ExecuteCommand(command_2);

        //Console.WriteLine(document.Content);
        Console.WriteLine("Undoing last command");

        editor.Undo();
        //Console.WriteLine(document.Content);
    }
}