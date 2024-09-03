using TextEditor.Command;
using TextEditor.Receiver;

namespace TextEditorApp.MSTests.Commands
{
    [TestClass]
    public class DeleteTextCommandTests
    {
        [TestMethod]
        public void Execute_ShouldDeleteTextFromDocument()
        {
            // Arrange
            var document = new TextDocument();
            var insertCommand = new InsertTextCommand(document, "Hello, world!");
            insertCommand.Execute();

            var deleteCommand = new DeleteTextCommand(document, 7);

            // Act
            deleteCommand.Execute();

            // Assert
            Assert.AreEqual("Hello,", document.Content);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_ShouldThrowException_WhenTextDocumentIsNull()
        {
            // Arrange, Act & Assert
            var command = new DeleteTextCommand(null, 5);
        }
    }
}
