# Overview

The command design pattern is a behavorial pattern that turns a request into a stand-alone object which contains all the information regarding that request. This helps us to parameterize methods with different requests and support undo operations.
<br>

In this project, the command design pattern is demonstrated by implementation of a text editor. The text editor allows operations such as insertion or deletion of text, alongwith the functionality to undo those operations.


# Design

The components of the project are: ICommmand interface, TextEditorApplication class which is also an invoker class. Two concrete command classes called InsertTextCommand and DeleteTextCommand.

![UML diagram](https://github.com/KshitijGhodake/TextEditor/blob/94a1cfe32a28ef1bc98b23b28965a524091fc5ee/assets/SoftwareEngineeringUML.drawio%20(1).png)

# Environment

The project builds and runs with Visual Studio Community 2022 when the required workloads are installed.
