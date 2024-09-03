/******************************************************************************
 * Filename    = ICommand.cs
 *
 * Author      = Kshitij Mahendra Ghodake
 *
 * Product     = TextEditorApp
 * 
 * Project     = ICommand
 *
 * Description = Contains an interface for the invoker to send commands to..
 *****************************************************************************/

namespace TextEditor.Command
{
    /// <summary>
    /// Interface for a command which the invokers use to send actions to the receivers.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Implemented by the concrete command classes to execute an action
        /// </summary>
        void Execute();

        /// <summary>
        /// Implemented by the concrete command classes to undo their action.
        /// </summary>
        void Undo();
    }
}
