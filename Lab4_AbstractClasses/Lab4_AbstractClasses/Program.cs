using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab4_AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
            Random random =new Random();
     
            int n= random.Next(50,100);
            
            
            for (int i=0;i<n;i++)
            {
                
                int y = random.Next(0,115);
               
                int x = random.Next(0,115);
                

                Dog dog = new Dog("@");
               
                double weight=random.Next(5,100);
                dog.BeBorn(x,y,weight);
                if (dog.Weight > 55)
                    dog.Color = ConsoleColor.Magenta;
                Console.ForegroundColor= dog.Color;
                Console.SetCursorPosition(dog.X,dog.Y); 
                Console.WriteLine(dog.Face);
                Thread.Sleep(100);

                int xHed=random.Next(0,115);
                int yHed = random.Next(0,115);
                double weightHed = random.Next(10, 100);
                Hedgehog hedgehog = new Hedgehog("ж",ConsoleColor.Gray);
                hedgehog.BeBorn(xHed, yHed, weightHed);
                Console.ForegroundColor = hedgehog.MColor;
                Console.SetCursorPosition(hedgehog.X, hedgehog.Y);
                Console.WriteLine(hedgehog.MFace);
                Thread.Sleep(100);


            }

            Console.ReadKey();
        }
    }
}
