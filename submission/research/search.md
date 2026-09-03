
 *
 * ## .csproj:
 * Contains the target framework (.NET 10?),
 * enables or disables features in your project,
 * and contains package versions.
 *
 * ## Program.cs:
 * The main C# source code and the file that starts the execution.
 *
 * ## obj/:
 * Contains intermediate files generated during the build process.
 *
 * ## bin/:
 * Contains the final output files generated after building the project
 * (.exe, .dll).
 *
 * --------------------------------------------------------------
 *
 * ## File-scoped namespace:
 * Applies to the entire file, so we don't need braces or an extra indentation level.
 * (namespace CSharpBasicsAssignment;)
 *
 * --------------------------------------------------------------
 *
 * ## My project uses the newer .slnx file format.
 * One advantage of the classic .sln format is that it has wider compatibility
 * with older tools and Visual Studio versions.
 */


## 3- When would you reach for /// XML doc comments instead of a plain //?

I would use `///` XML documentation comments when I want to document a class, method, or property and explain its purpose or usage.

Unlike a regular `//` comment, XML documentation can be displayed by the IDE to provide information about the code.


## 4- Why does C# have no true global variables, and what's the closest equivalent?

C# has no true global variables because variables are organized inside types such as classes and structs.

The closest equivalent is a `static` field inside a class. A static field can be accessed without creating an object, for example: `ClassName.VariableName`.


