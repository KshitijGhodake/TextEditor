/******************************************************************************
 * Filename    = TextDocument.cs
 *
 * Author      = Kshitij Mahendra Ghodake
 *
 * Product     = TextEditorApp
 * 
 * Project     = TextDocument
 *
 * Description = Contains a text document, a receiver of the commands
 *****************************************************************************/

namespace TextEditor.Receiver
{
    /// <summary>
    /// Inserts or deletes text from a text document.
    /// </summary>
    public class TextDocument
    {
        public string Content { get; private set; } = string.Empty; // the text document

        /// <summary>
        /// Inserts text to content.
        /// </summary>
        /// <param name="text">The text that should be inserted</param>
        public void InsertText( string text )
        {
            Content += text;
            Console.WriteLine( Content );
        }

        /// <summary>
        /// Deletes the text from the content
        /// </summary>
        /// <param name="length">The length it should truncate from the end.</param>
        public void DeleteText( int length )
        {
            if (length <= Content.Length)
            {
                Content = Content.Substring( 0 , Content.Length - length );
                Console.WriteLine( Content );
            }
        }
    }
}
