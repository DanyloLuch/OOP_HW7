using System;

namespace FacadeExample
{

    class CPU
    {
        public void Start() => Console.WriteLine("CPU is starting...");
        public void Shutdown() => Console.WriteLine("CPU is shutting down...");
    }

    class Memory
    {
        public void Load() => Console.WriteLine("Memory is loading...");
        public void Clear() => Console.WriteLine("Memory is cleared.");
    }


    class Disk
    {
        public void Read() => Console.WriteLine("Reading from disk...");
        public void Write() => Console.WriteLine("Writing to disk...");
    }

    // Facade
    class ComputerFacade
    {
        private CPU _cpu;
        private Memory _memory;
        private Disk _disk;

        public ComputerFacade()
        {
            _cpu = new CPU();
            _memory = new Memory();
            _disk = new Disk();
        }

        public void StartComputer()
        {
            _cpu.Start();
            _memory.Load();
            _disk.Read();
            Console.WriteLine("Computer is ready!");
        }

        public void ShutdownComputer()
        {
            _cpu.Shutdown();
            _memory.Clear();
            _disk.Write();
            Console.WriteLine("Computer is shut down.");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ComputerFacade computer = new ComputerFacade();

            // Старт комп'ютера
            computer.StartComputer();

            // Вимкнення комп'ютера
            computer.ShutdownComputer();

            Console.Read();
        }
    }
}