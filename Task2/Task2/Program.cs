using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    
    class Program
    {
      
        static void Main(string[] args)
        {
            World world = new World();
            world.lint();
            foreach (Creture target in world.creatureList)
            {
                if(target is iswimmable)
                {
                    (target as iswimmable).Swim();
                }
            }
        }
        interface iswimmable
        {
            void Swim();
        }

        abstract class Creture//생물체
        {
            
        }
        abstract class Mammal: Creture//포유류
        {
            
        }
        abstract class Birds : Creture//조류
        {

        }
        abstract class Fish : Creture//어류
        {

        }
        class Monkey : Mammal//원숭이
        {
          
        }
        class Whale : Mammal, iswimmable//고래
        {
            public void Swim()
            {
                Console.WriteLine("{Whale}수영을 했어요");
            }
        }
        class Dolphin: Mammal, iswimmable//돌고래
        {
            public void Swim()
            {
                Console.WriteLine("{Dolphin}수영을 했어요");
            }
        }
        class Eagle: Birds//독수리
        {

        }
        class Sparrow : Birds//참새
        {

        }
        class Pigeon : Birds//비둘기
        {

        }
        class Penguin : Birds, iswimmable//펭귄
        {
            public void Swim()
            {
                Console.WriteLine("{Penguin}수영을 했어요");

            }
        }
        class Goldfish : Fish, iswimmable//금붕어
        {
            public void Swim()
            {
                Console.WriteLine("{Goldfish}수영을 했어요");

            }
        }
        class Eel : Fish, iswimmable//장어
        {
            public void Swim()
            {
                Console.WriteLine("{Eel}수영을 했어요");

            }
        }
        class World
        {
            public List<Creture> creatureList = new List<Creture>();
            public void lint()
            {
                creatureList.Add(new Monkey());
                creatureList.Add(new Monkey());
                creatureList.Add(new Monkey());

                creatureList.Add(new Whale());
                creatureList.Add(new Whale());
                creatureList.Add(new Whale());

                creatureList.Add(new Dolphin());
                creatureList.Add(new Dolphin());
                creatureList.Add(new Dolphin());

                creatureList.Add(new Eagle());
                creatureList.Add(new Eagle());
                creatureList.Add(new Eagle());

                creatureList.Add(new Sparrow());
                creatureList.Add(new Sparrow());
                creatureList.Add(new Sparrow());

                creatureList.Add(new Pigeon());
                creatureList.Add(new Pigeon());
                creatureList.Add(new Pigeon());

                creatureList.Add(new Penguin());
                creatureList.Add(new Penguin());
                creatureList.Add(new Penguin());

                creatureList.Add(new Goldfish());
                creatureList.Add(new Goldfish());
                creatureList.Add(new Goldfish());

                creatureList.Add(new Eel());
                creatureList.Add(new Eel());
                creatureList.Add(new Eel());
            }

        }
    }
}
