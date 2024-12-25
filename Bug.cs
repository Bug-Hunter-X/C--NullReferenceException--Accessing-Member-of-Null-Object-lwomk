public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Accessing a member of a null object can lead to NullReferenceException
        Console.WriteLine(MyProperty.ToString()); // Potential NullReferenceException if MyProperty is not initialized
    }
}