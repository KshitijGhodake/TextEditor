/******************************************************************************
 * Filename    = TextEditorTests.cs
 *
 * Author      = Kshitij Mahendra Ghodake
 *
 * Product     = TextEditorApp
 * 
 * Project     = TextEditorTests
 *
 * Description = Unit tests for the text editor app.
 *****************************************************************************/

using TextEditor.Command;
using TextEditor.Receiver;
using TextEditor.Invoker;
namespace TextEditorApp.Tests.Receiver
{
    /// <summary>
    /// Unit tests for the text editor.
    /// </summary>
    [TestClass]
    public class TextEditorTests
    {
        /// <summary>
        /// Tests the execution of the insertion command.
        /// </summary>
        [TestMethod]
        public void ExecuteCommandShouldExecuteAndStoreCommand()
        {
            TextDocument document = new();
            TextEditorApplication editor = new();
            InsertTextCommand command = new( document , "Hello, world!" );
            editor.ExecuteCommand( command );

            Assert.AreEqual( "Hello, world!" , document.Content );
        }

        /// <summary>
        /// Tests the undo command after executing an insert command.
        /// </summary>
        [TestMethod]
        public void UndoShouldUndoLastExecutedCommand()
        {
            TextDocument document = new();
            TextEditorApplication editor = new();
            InsertTextCommand command = new( document , "Hello, world!" );
            editor.ExecuteCommand( command );
            editor.Undo();

            Assert.AreEqual( string.Empty , document.Content );
        }

        /// <summary>
        /// Tests undoing when there is no previous command.
        /// </summary>
        [TestMethod]
        public void UndoShouldNotFailWhenNoCommandsExecuted()
        {
            TextEditorApplication editor = new();
            editor.Undo();

            Assert.IsTrue( true );
        }
    }
}
