using System;

namespace FactoryMethodExample
{

    public interface ITransport
    {
        void Drive();
    }


    public class Car : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Car is driving.");
        }
    }

    public class Motorcycle : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Motorcycle is driving.");
        }
    }


    public abstract class TransportFactory
    {
        public abstract ITransport CreateTransport();
    }


    public class CarFactory : TransportFactory
    {
        public override ITransport CreateTransport()
        {
            return new Car();
        }
    }


    public class MotorcycleFactory : TransportFactory
    {
        public override ITransport CreateTransport()
        {
            return new Motorcycle();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            TransportFactory carFactory = new CarFactory();
            ITransport myCar = carFactory.CreateTransport();
            myCar.Drive();

            TransportFactory motorcycleFactory = new MotorcycleFactory();
            ITransport myMotorcycle = motorcycleFactory.CreateTransport();
            myMotorcycle.Drive();

            Console.Read();
        }
    }
}