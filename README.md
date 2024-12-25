# C# NullReferenceException: Accessing Member of a Null Object

This repository demonstrates a common C# error: the `NullReferenceException`. This exception is thrown when you try to access a member (property, method, or field) of an object that is currently null.  This example shows how it can occur and how to effectively mitigate it.

## Bug Description:
The `Bug.cs` file contains a class with a method that might throw a `NullReferenceException` if a property is not initialized before access.

## Bug Solution:
The `BugSolution.cs` file provides a solution by adding null checks before accessing the property.