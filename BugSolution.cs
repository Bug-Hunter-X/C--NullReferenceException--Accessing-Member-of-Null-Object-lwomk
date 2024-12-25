public class ExampleClass
{
    public int? MyProperty { get; set; } //Using nullable type

    public ExampleClass(int? value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Null check before accessing MyProperty
        if (MyProperty.HasValue)
        {
            Console.WriteLine(MyProperty.Value.ToString());
        }
        else
        {
            Console.WriteLine("MyProperty is null");
        }
    }
} 