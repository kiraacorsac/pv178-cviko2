using System;

namespace BaseConcepts_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inheritance - sample in TypesAndConversions, note that multiple inheritance is not allowed in C#
            AbstractClassDemo();
            PolymorphismDemo();
            InterfaceDemo();
        }

        /// <summary>
        /// abstract classes cannot be instantiated, marked as sealed
        /// </summary>
        private static void AbstractClassDemo()
        {
            var instance = new DerivedClass();
            instance.Add(2, 3);         // uses implementation from abstract class
            instance.Multiply(2, 3);
        }

        /// <summary>
        /// sample to demonstrate polymorphism concept
        /// </summary>
        public static void PolymorphismDemo()
        {
            var dObj = new DrawingObject[3];

            dObj[0] = new Line();
            dObj[1] = new Circle();
            dObj[2] = new Square();

            foreach (var drawObj in dObj)
            {
                drawObj.Draw();
            }
        }

        /// <summary>
        /// simple I-face demo
        /// </summary>
        private static void InterfaceDemo()
        {
            IVehicle skoda = new Car(null);  // param can be omitted
            IVehicle hjondee = new Car(5);
            IVehicle man = new Truck(45, 12.5f);

            // treat instances of various classes generally
            skoda.Accelerate();
            hjondee.Accelerate();
            man.Accelerate();

            // access more specific properties via derived interface IHeavyWeightVehicle
            var truckInstance = (IHeavyWeightVehicle) man;
            // Another C# 6.0 feature: Elvis operator (?. <=> if(... != null))
            // use Elvis operator if truckInstance could be null (not in this case though :) )
            Console.WriteLine(truckInstance?.MaximalLoadInKg);

            Console.ReadKey();
        }
    }

    
}
