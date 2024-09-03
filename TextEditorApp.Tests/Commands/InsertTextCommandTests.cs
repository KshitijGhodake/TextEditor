/******************************************************************************
 * Filename    = InsertTextCommandTests.cs
 *
 * Author      = Kshitij Mahendra Ghodake
 *
 * Product     = TextEditorApp
 * 
 * Project     = InsertTextCommandTests
 *
 * Description = Unit tests for checking insertion of text command.
 *****************************************************************************/

using System.Diagnostics.CodeAnalysis;
using TextEditor.Command;
using TextEditor.Receiver;
namespace TextEditorApp.Tests.Commands
{
    /// <summary>
    /// Unit tests for the insert text command.
    /// </summary>
    [TestClass]
    public class InsertTextCommandTests
    {
        /// <summary>
        /// Tests the insertion of text into the document
        /// </summary>
        [TestMethod]
        public void ShouldInsertTextIntoDocument()
        {
            var document = new TextDocument();
            var command = new InsertTextCommand( document , "Hello, world!" );
            command.Execute();

            Assert.AreEqual( "Hello, world!" , document.Content );
        }

        /// <summary>
        /// Tests undo after insertion in the document.
        /// </summary>
        [TestMethod]
        public void UndoShouldRemoveInsertedTextFromDocument()
        {
            var document = new TextDocument();
            var command = new InsertTextCommand( document , "Hello, world!" );
            command.Execute();
            command.Undo();

            Assert.AreEqual( string.Empty , document.Content );
        }

        /// <summary>
        /// Tests the constructor check of input document.
        /// </summary>
        [TestMethod]
        [ExpectedException( typeof( ArgumentNullException ) )]
        [ExcludeFromCodeCoverage]
        public void ConstructorShouldThrowExceptionWhenTextDocumentIsNull()
        {
            _ = new InsertTextCommand( null , "Test" );
        }

        /// <summary>
        /// Tests the constructor check of text to insert.
        /// </summary>
        [TestMethod]
        [ExpectedException( typeof( ArgumentNullException ) )]
        [ExcludeFromCodeCoverage]
        public void ConstructorShouldThrowExceptionWhenTextIsNull()
        {
            var document = new TextDocument();
            _ = new InsertTextCommand( document , null );
        }
    }
}

