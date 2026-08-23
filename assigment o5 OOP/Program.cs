using System.Drawing;
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
        }

    }
}
