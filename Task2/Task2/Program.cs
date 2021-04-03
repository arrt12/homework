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
        }


        abstract class Creture//생물체
        {
            bool iSwimmable = true;
        }
        abstract class Mammal: Creture//포유류
        {
            Creture Mammalswim = new Creture();
        }
        abstract class Birds : Creture//조류
        {

        }
        abstract class Fish : Creture//어류
        {

        }
        class Monkey: Mammal//원숭이
        {
           
        }
        class Whale: Mammal//고래
        {

        }
        class Dolphin: Mammal//돌고래
        {

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
        class Penguin : Birds//펭귄
        {

        }
        class Goldfish : Fish//금붕어
        {

        }
        class Eel : Fish//장어
        {

        }
        class World
        {
            static void Main(string[] args)
            {
                List<Creture> list = new List<Creture>();
                list.Add(new Monkey());
                list.Add(new Monkey());
                list.Add(new Monkey());

                list.Add(new Whale());
                list.Add(new Whale());
                list.Add(new Whale());

                list.Add(new Dolphin());
                list.Add(new Dolphin());
                list.Add(new Dolphin());

                list.Add(new Eagle());
                list.Add(new Eagle());
                list.Add(new Eagle());

                list.Add(new Sparrow());
                list.Add(new Sparrow());
                list.Add(new Sparrow());

                list.Add(new Pigeon());
                list.Add(new Pigeon());
                list.Add(new Pigeon());

                list.Add(new Penguin());
                list.Add(new Penguin());
                list.Add(new Penguin());

                list.Add(new Goldfish());
                list.Add(new Goldfish());
                list.Add(new Goldfish());

                list.Add(new Eel());
                list.Add(new Eel());
                list.Add(new Eel());
            }

        }
    }
}
