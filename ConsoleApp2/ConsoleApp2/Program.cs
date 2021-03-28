using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Character a = new Character();

            int resut = a.피격(100, 20);
            Console.WriteLine($"플레이어가 공격을 받아 Hp:{resut} 남았습니다.");

            int resut2 = a.공격(100, 60);
            Console.WriteLine($"플레이어가 공격을 해 몬스터Hp:{resut2} 남았습니다.");

        }
        class Character
        {

            public int 공격(int monsterHp, int op)
            {
                return monsterHp - op;

            }
            public int 피격(int Hp, int damage)
            {


                return Hp - damage;

            }
        }
    
 
        //static void Main(string[] args)
        //{
        //    Person me = new Person();
        //    Calculator calc = new Calculator();

        //    DodSome(me);
        //    DodSome(calc);

        //}

        //static void DodSome(iSum target)
        //{
        //    int result = target.sum(100,200);
        //    Console.WriteLine(result);
        //}




        //class Person : iSum
        //{
        //    public int sum(int a, int b)
        //    {
        //        return a + b + 1;
        //    }
        //}

        //class Calculator : iSum
        //{
        //    public int sum(int a, int b)
        //    {
        //        return a + b;
        //    }
        //}


        //interface iSum
        //{
        //    int sum(int a ,int b);
        //}


    }
}
