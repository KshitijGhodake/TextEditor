using TextEditor.Command;
using TextEditor.Receiver;
using TextEditor.Invoker;
namespace TextEditorApp.MSTests.Invoker
{
    [TestClass]
    public class TextEditorTests
    {
        [TestMethod]
        public void ExecuteCommand_ShouldExecuteAndStoreCommand()
        {
            // Arrange
            var document = new TextDocument();
            var editor = new TextEditorApplication();
            var command = new InsertTextCommand(document, "Hello, world!");

            // Act
            editor.ExecuteCommand(command);

            // Assert
            Assert.AreEqual("Hello, world!", document.Content);
        }

        [TestMethod]
        public void Undo_ShouldUndoLastExecutedCommand()
        {
            // Arrange
            var document = new TextDocument();
            var editor = new TextEditorApplication();
            var command = new InsertTextCommand(document, "Hello, world!");

            editor.ExecuteCommand(command);

            // Act
            editor.Undo();

            // Assert
            Assert.AreEqual(string.Empty, document.Content);
        }

        [TestMethod]
        public void Undo_ShouldNotFailWhenNoCommandsExecuted()
        {
            // Arrange
            var editor = new TextEditorApplication();

            // Act & Assert
            try
            {
                editor.Undo();
                Assert.IsTrue(true); // Pass the test if no exception is thrown
            }
            catch
            {
                Assert.Fail("Undo should not throw an exception when no commands are executed.");
            }
        }
    }
}
