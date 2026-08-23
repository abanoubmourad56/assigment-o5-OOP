using System.ComponentModel;
using System.Data.Common;
using System.Drawing;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assigment_o5_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a) What happens when you assign one object variable to another object variable?
            //both variables point to the same object.

            //b) Does assigning one object to another create a new object? Explain.
            //b) No, it does not create a new object.It only copies the reference.

            //c) What is the difference between copying an object and copying its reference?
            //Copying a reference: Both variables point to the same object.
            //Copying an object: A new object is created with its own data.

            //a) What is a Shallow Copy?
            //a) Shallow Copy: Copies the object, but reference - type members still point to the same objects.

            //b) What is a Deep Copy?
            //Deep Copy: Creates a new object and also creates new copies of reference-type members.

            //c) What happens to reference-type members when a Shallow Copy is created?
            //c) In a Shallow Copy, reference-type members point to the same objects.

            //d) What happens to reference-type members when a Deep Copy is created?
            // In a Deep Copy, reference-type members point to new separate objects.

            //e) Give one situation where Deep Copy would be safer than Shallow Copy.
            //Deep Copy is safer when you want to change the copied object without affecting the original object.

            //a) What is a static field, and how is it different from an instance field ?
            //a) A static field belongs to the class and is shared by all objects.
            // An instance field belongs to each object separately.

            //b) What is a static method? Can a static method directly access instance members ?
            //b) A static method belongs to the class.
            //No, it cannot directly access instance members.

            //c) What is a static constructor, and when is it executed ?
            //c) A static constructor initializes static members.It runs automatically once, before the class is first used.

            //d) What is a static class? Can you create an object from a static class?
            //  A static class contains only static members.
            //No, you cannot create an object from a static class

            //a) What is an Extension Method?
            //a) An Extension Method is a method that adds new functionality to an existing class without changing the class.

            //b) What keyword must be used in the first parameter of an extension method ?
            //b) The first parameter must use the this keyword.

            //c) Where must an extension method be declared ?
            //c) It must be declared inside a static class.

            //d) Can an extension method access private members of the class it extends?
            //d) No, it cannot access private members of the class it extends.

        }

    }
}
