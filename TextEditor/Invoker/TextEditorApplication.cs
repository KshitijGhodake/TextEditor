/******************************************************************************
 * Filename    = TextEditorApplication.cs
 *
 * Author      = Kshitij Mahendra Ghodake
 *
 * Product     = TextEditorApp
 * 
 * Project     = TextEditorApplication
 *
 * Description = Contains the command history with the ability to execute or undo actions.
 *****************************************************************************/

using TextEditor.Command;

namespace TextEditor.Invoker
{
    /// <summary>
    /// Creates a text editor app with execute and undo method.
    /// </summary>
    public class TextEditorApplication
    {
        private readonly Stack<ICommand> _commands = new(); // The stack of commands for undo.

        /// <summary>
        /// Executes the command and remembers it by pushing it to the stack.
        /// </summary>
        /// <param name="command">The command that should be executed</param>
        public void ExecuteCommand( ICommand command )
        {
            command.Execute();
            _commands.Push( command );
        }

        /// <summary>
        /// Undos the last command.
        /// </summary>
        public void Undo()
        {
            if (_commands.Count > 0)
            {
                ICommand command = _commands.Pop();
                command.Undo();
            }
            else
            {
                Console.WriteLine( "STACK EMPTY" );
            }
        }
    }
}
