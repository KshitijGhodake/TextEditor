/******************************************************************************
 * Filename    = InsertTextCommand.cs
 *
 * Author      = Kshitij Mahendra Ghodake
 *
 * Product     = TextEditorApp
 * 
 * Project     = InsertTextCommand
 *
 * Description = Inserts text to a document
 *****************************************************************************/

using TextEditor.Receiver;

namespace TextEditor.Command
{
    /// <summary>
    /// Inserts text into content.
    /// </summary>
    public class InsertTextCommand : ICommand
    {
        private readonly TextDocument _textDocument; // The text document to modify.
        private readonly string _text; // The text to insert.

        /// <summary>
        /// Inserts text to document.
        /// </summary>
        /// <param name="textDocument">The document instance that the text should be inserted to.</param>
        /// <param name="text">The text that hast to be inserted.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public InsertTextCommand( TextDocument textDocument , string text )
        {
            if (textDocument == null || text == null)
            {
                throw new ArgumentNullException();
            }
            _textDocument = textDocument;
            _text = text;
        }

        /// <summary>
        /// Executes the insertion of the text into the document.
        /// </summary>
        public void Execute()
        {
            _textDocument.InsertText( _text );
        }

        /// <summary>
        /// Undos the insert of the text from the document.
        /// </summary>
        public void Undo()
        {
            _textDocument.DeleteText( _text.Length );
        }
    }
}
