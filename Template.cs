using System;

namespace Template
{
    
    abstract class AbstractBuilder
    {
 
        public void TemplateMethod()
        {
            this.PreparePlace();
            this.MakeFoundation();
            this.BuildWalls();
            this.BuildRoof();
            this.BuildGarage();

        }

       
        protected void PreparePlace()
        {
            Console.WriteLine("BuilderClass - The place for the building was prepared");
        }

        protected void MakeFoundation()
        {
            Console.WriteLine("Builder Class - The foundation was maked");
        }



        protected abstract void BuildWalls();

        protected abstract void BuildRoof();

      
        protected virtual void BuildGarage( ) {

            Console.WriteLine("Was built the standart garage for 2 cars");
        }

   
    }

  
    class ConcreteHouse1 : AbstractBuilder
    {
        protected override void BuildWalls()
        {
            Console.WriteLine("Concrete House1 - brick building");
        }

        protected override void BuildRoof()
        {
            Console.WriteLine("ConcreteHouse1 - roof tiles");
        }

        protected override void BuildGarage()
        {
            Console.WriteLine("ConcreteHouse1 - was built garage for one car\n");
        }


    }

  
    class ConcreteHouse2 : AbstractBuilder
    {
        protected override void BuildWalls()
        {
            Console.WriteLine("Concrete House2 - stone walls");
        }

        protected override void BuildRoof()
        {
            Console.WriteLine("ConcreteHouse2 - wooden roof");
        }

        protected override void BuildGarage()
        {
            Console.WriteLine("ConcreteHouse2 - was created diferent garage because client has many cars\n");
        }
    }

    class Client
    {
        
        public static void ClientCode(AbstractBuilder abstractHouse)
        {            
            abstractHouse.TemplateMethod();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("House 1 was built");

            Client.ClientCode(new ConcreteHouse1());

            Console.Write("\n");

            Console.WriteLine("House 2 was built");
            Client.ClientCode(new ConcreteHouse2());
        }
    }
}