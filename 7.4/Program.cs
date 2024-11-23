using System;

namespace DecoratorPattern
{
    abstract class ChristmasTree
    {
        public abstract void Decorate();
    }

    class BasicChristmasTree : ChristmasTree
    {
        public override void Decorate()
        {
            Console.WriteLine("Decorating the basic Christmas tree.");
        }
    }

    abstract class ChristmasTreeDecorator : ChristmasTree
    {
        protected ChristmasTree tree;

        public ChristmasTreeDecorator(ChristmasTree tree)
        {
            this.tree = tree;
        }

        public override void Decorate()
        {
            tree.Decorate();
        }
    }

    class WithOrnaments : ChristmasTreeDecorator
    {
        public WithOrnaments(ChristmasTree tree) : base(tree) { }

        public override void Decorate()
        {
            base.Decorate();
            AddOrnaments();
        }

        private void AddOrnaments()
        {
            Console.WriteLine("Adding ornaments to the Christmas tree.");
        }
    }

    class WithLights : ChristmasTreeDecorator
    {
        public WithLights(ChristmasTree tree) : base(tree) { }

        public override void Decorate()
        {
            base.Decorate();
            AddLights();
        }

        private void AddLights()
        {
            Console.WriteLine("Adding lights to the Christmas tree.");
        }
    }

    class WithOrnamentsAndLights : ChristmasTreeDecorator
    {
        public WithOrnamentsAndLights(ChristmasTree tree) : base(tree) { }

        public override void Decorate()
        {
            base.Decorate();
            AddOrnaments();
            AddLights();
        }

        private void AddOrnaments()
        {
            Console.WriteLine("Adding ornaments to the Christmas tree.");
        }

        private void AddLights()
        {
            Console.WriteLine("Adding lights to the Christmas tree.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ChristmasTree myTree = new BasicChristmasTree();
            myTree.Decorate();

            Console.WriteLine("\nDecorating with ornaments:");
            ChristmasTree treeWithOrnaments = new WithOrnaments(myTree);
            treeWithOrnaments.Decorate();

            Console.WriteLine("\nDecorating with ornaments and lights:");
            ChristmasTree treeWithOrnamentsAndLights = new WithOrnamentsAndLights(myTree);
            treeWithOrnamentsAndLights.Decorate();

            Console.WriteLine("\nDecorating with lights only:");
            ChristmasTree treeWithLights = new WithLights(myTree);
            treeWithLights.Decorate();

            Console.ReadKey();
        }
    }
}