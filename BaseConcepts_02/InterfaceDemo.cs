using System;

namespace BaseConcepts_04
{
    public interface IVehicle
    {
        void Accelerate();
    }

    public interface ICargoVehicle : IVehicle
    {
        int GoodsCapacity { get; }
    }

    public interface IPersonalVehicle : IVehicle
    {
        int PassengerCapacity { get; set; }
    }

    public interface IHeavyWeightVehicle
    {
        float MaximalLoadInKg { get;}
    }

    public class Truck : ICargoVehicle, IHeavyWeightVehicle
    {       
        public int GoodsCapacity { get; }
        // interface declares only get method, but we could also declare a private setter
        public float MaximalLoadInKg { get; private set; }


        public Truck(int goodsCapacity, float maxLoad)
        {
            GoodsCapacity = goodsCapacity;
            MaximalLoadInKg = maxLoad;
        }

        public void Accelerate()
        {
            Console.WriteLine("Accelerating slowly...");
        }
    }

    public class Car : IPersonalVehicle
    {
        // if property had initializer, it would be ignored
        public int PassengerCapacity { get; set; }

        // CTOR with default value
        public Car(int? capacity = null)
        {
            PassengerCapacity = capacity ?? 5;
        }

        public void Accelerate()
        {
            Console.WriteLine("Accelerating fast...");
        }
    }
}
