

namespace TextEditor.Command;

public interface ICommand
{
    void Execute();
    void Undo();
}
