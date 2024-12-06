public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property before it's assigned can cause unexpected behavior.
        Console.WriteLine(MyProperty); // This might print 0, or throw an exception, depending on how the property is handled. 
    }
}