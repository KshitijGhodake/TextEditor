/******************************************************************************
 * Filename    = Program.cs
 *
 * Author      = Kshitij Mahendra Ghodake
 *
 * Product     = TextEditorApp
 * 
 * Project     = ClientProgram
 *
 * Description = Client program to run the editor app
 *****************************************************************************/

using TextEditor.Command;
using TextEditor.Invoker;
using TextEditor.Receiver;

class ClientProgram
{
    /// <summary>
    /// Client program to test run the app.
    /// </summary>
    public static void Main()
    {
        var document = new TextDocument();
        var editor = new TextEditorApplication();
        var command_1 = new InsertTextCommand(document, "Hello, ");
        var command_2 = new InsertTextCommand(document, "World!");

        editor.ExecuteCommand(command_1);
        editor.ExecuteCommand(command_2);

        
        Console.WriteLine("Undoing last command");

        editor.Undo();
        
    }
}
