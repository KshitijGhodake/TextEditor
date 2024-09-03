/******************************************************************************
 * Filename    = DeleteTextCommand.cs
 *
 * Author      = Kshitij Mahendra Ghodake
 *
 * Product     = TextEditorApp
 * 
 * Project     = DeleteTextCommand
 *
 * Description = Implements Command interface for deletion of text commands.
 *****************************************************************************/

using TextEditor.Receiver;

namespace TextEditor.Command
{
    /// <summary>
    /// Deletes the text from the end of the document.
    /// </summary>
    public class DeleteTextCommand : ICommand
    {
        private readonly TextDocument _textDocument; // The text document to delete the text from.
        private readonly int _length; // The length by which the document should be truncated.

        /// <summary>
        /// Deletes the text from the text document
        /// </summary>
        /// <param name="textDocument">The text document instance from which the text should be deleted.</param>
        /// <param name="length">The length by which the document should be truncated from the end.</param>
        /// <exception cref="ArgumentNullException">Text Document cannot be null.</exception>
        public DeleteTextCommand( TextDocument textDocument , int length )
        {
            _textDocument = textDocument ?? throw new ArgumentNullException();
            _length = length;
        }

        /// <summary>
        /// Executes the deletion of the text.
        /// </summary>
        public void Execute()
        {
            _textDocument.DeleteText( _length );
        }

        /// <summary>
        /// Undos the delete operation. Presently, appends _UNDO_ at the end of the document.
        /// </summary>
        public void Undo()
        {
            _textDocument.InsertText( "_UNDO_" );
        }
    }
}
