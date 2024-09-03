using TextEditor.Command;

namespace TextEditor.Invoker;

public class TextEditorApplication
{
    private readonly Stack<ICommand> _commands = new Stack<ICommand>();

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        _commands.Push(command);
    }

    public void Undo()
    {
        if (_commands.Count > 0)
        {
            ICommand command = _commands.Pop();
            command.Undo();
        }
        else
        {
            Console.WriteLine("STACK EMPTY");
        }
    }
}