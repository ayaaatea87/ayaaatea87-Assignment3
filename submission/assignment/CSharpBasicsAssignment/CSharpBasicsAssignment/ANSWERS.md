 ## PART G: SHORT ANSWER
 ## 1- .CSPROJ FILE CONTENTS :

 ```
 <Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
```
## 2- Do #region / #endregion change the compiled output? Why might you still use them?

region , endregion don't change the compile output 
you can use them to organize your code by grouping related line of code under a name region

## 3- When would you reach for /// XML doc comments instead of a plain //?

I would use `///` XML documentation comments when I want to document a class, method, or property and explain its purpose or usage.

Unlike a regular `//` comment, XML documentation can be displayed by the IDE to provide information about the code.


## 4- Why does C# have no true global variables, and what's the closest equivalent?

C# has no true global variables because variables are organized inside types such as classes and structs.

The closest equivalent is a `static` field inside a class. A static field can be accessed without creating an object, for example: `ClassName.VariableName`.


