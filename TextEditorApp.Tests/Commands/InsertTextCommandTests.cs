using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextEditor;
using TextEditor.Command;
using TextEditor.Receiver;
namespace TextEditorApp.MSTests.Commands
{
    [TestClass]
    public class InsertTextCommandTests
    {
        [TestMethod]
        public void Execute_ShouldInsertTextIntoDocument()
        {
            // Arrange
            var document = new TextDocument();
            var command = new InsertTextCommand(document, "Hello, world!");

            // Act
            command.Execute();

            // Assert
            Assert.AreEqual("Hello, world!", document.Content);
        }

        [TestMethod]
        public void Undo_ShouldRemoveInsertedTextFromDocument()
        {
            // Arrange
            var document = new TextDocument();
            var command = new InsertTextCommand(document, "Hello, world!");
            command.Execute();

            // Act
            command.Undo();

            // Assert
            Assert.AreEqual(string.Empty, document.Content);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_ShouldThrowException_WhenTextDocumentIsNull()
        {
            // Arrange, Act & Assert
            var command = new InsertTextCommand(null, "Test");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_ShouldThrowException_WhenTextIsNull()
        {
            // Arrange
            var document = new TextDocument();

            // Act & Assert
            var command = new InsertTextCommand(document, null);
        }
    }
}

