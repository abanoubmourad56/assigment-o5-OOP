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

            /*
            1. Create CopyShipment() method:
            public Shipment CopyShipment()
{
    return new Shipment
    {
        Weight = this.Weight,
        DeliveryFee = this.DeliveryFee,
        DeliveryAddress = this.DeliveryAddress
    };
}
            2. Assigning one object to another:
            Shipment shipment2 = shipment1;
            Both variables refer to the same object.

            3. Creating an actual copy:
            Shipment shipment2 = shipment1.CopyShipment();
            shipment1 and shipment2 are different objects.

            */

            /*
            Q2 — Shallow Copy
            1. Create ShallowCopy() method:
            public Shipment ShallowCopy()
{
    return (Shipment)this.MemberwiseClone();
}
            2. Create the shallow copy:
            Shipment shipment2 = shipment1.ShallowCopy();
            shipment1 and shipment2 are different Shipment objects.

            3. Check the DeliveryAddress:
            shipment1.DeliveryAddress == shipment2.DeliveryAddress
            shipment1.DeliveryAddress == shipment2.DeliveryAddress

            4. Change the address:
            shipment2.DeliveryAddress.City = "Alexandria";
            The address of shipment1 will also change because both shipments share the same DeliveryAddress object.
            */

            /*
            public Shipment DeepCopy()
{
    return new Shipment
    {
        Weight = this.Weight,
        DeliveryFee = this.DeliveryFee,
        DeliveryAddress = new DeliveryAddress
        {
            City = this.DeliveryAddress.City
        }
    };
}

            Demonstration
Before change:
Original: Cairo
Copied: Cairo
Same DeliveryAddress object? False
            After changing copied address:
            Original: Cairo
Copied: Giza
Same DeliveryAddress object? False
            Result: Deep Copy creates a new Shipment and a new DeliveryAddress.

            */

            /*
            4 — Static Field
              Add a static field to Shipment:
            public static int TotalShipmentsCreated = 0;
            Increment it whenever a Shipment is created:
            public Shipment()
           {
               TotalShipmentsCreated++;
           }
            Answer: The value is shared between all Shipment objects.

            */

            /*
            5 — Static Constructor
            static Shipment()
{
    TotalShipmentsCreated = 0;
    Console.WriteLine("Shipment System Initialized");
}
            Answer: The static constructor runs automatically once and cannot be called manually.
            output : Shipment System Initialized
            */

            /*
            6 — Static Method
            public static int GetTotalShipmentsCreated()
            {      
               return TotalShipmentsCreated;
             } 
            Call it without creating an object:
            Console.WriteLine(
    "Total Shipments Created : " + Shipment.GetTotalShipmentsCreated()
);
            */
        }

    }
}
