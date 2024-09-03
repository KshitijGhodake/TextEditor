/******************************************************************************
 * Filename    = DeleteTextCommandTests.cs
 *
 * Author      = Kshitij Mahendra Ghodake
 *
 * Product     = TextEditorApp
 * 
 * Project     = DeleteTextCommandTests
 *
 * Description = Unit tests for the checking deletion of text command.
 *****************************************************************************/

using TextEditor.Command;
using TextEditor.Receiver;

namespace TextEditorApp.Tests.Commands
{
    /// <summary>
    /// Unit tests for the delete text commands.
    /// </summary>
    [TestClass]
    public class DeleteTextCommandTests
    {
        /// <summary>
        /// Tests deletion of text.
        /// </summary>
        [TestMethod]
        public void ShouldDeleteTextFromDocument()
        {
            TextDocument document = new();
            InsertTextCommand insertCommand = new( document , "Hello, world!" );
            insertCommand.Execute();
            DeleteTextCommand deleteCommand = new( document , 7 );
            deleteCommand.Execute();

            Assert.AreEqual( "Hello," , document.Content );
        }

        /// <summary>
        /// Tests the constructor check of inputs.
        /// </summary>
        [TestMethod]
        [ExpectedException( typeof( ArgumentNullException ) )]
        public void ShouldThrowExceptionWhenTextDocumentIsNull()
        {
            _ = new DeleteTextCommand( null , 5 );
        }

        /// <summary>
        /// Tests undo after delete operation.
        /// </summary>
        [TestMethod]
        public void ShouldRestoreTextAfterDelete()
        {
            TextDocument document = new();
            document.InsertText( "Hello, world!" );
            DeleteTextCommand deleteCommand = new( document , 1 );
            deleteCommand.Undo();

            Assert.AreEqual( "Hello, world!_UNDO_" , document.Content );
        }
    }
}
