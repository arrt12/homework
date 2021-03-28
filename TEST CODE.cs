using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hellowworld
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Queue
            //Queue<int> someQueue = new Queue<int>();
            //someQueue.Enqueue(5);
            //someQueue.Enqueue(4);
            //someQueue.Enqueue(3);
            //someQueue.Enqueue(2);
            //someQueue.Enqueue(1);
            //while (someQueue.Count >0)
            //{
            //    Console.WriteLine(someQueue.Dequeue());
            //}



            ////Dictionary
            //Dictionary<string, string> dict = new Dictionary<string, string>();
            //dict["사과"] = "빨간 사과네";
            //dict.Add("배","노란색 계통의 열매입니다.");

            //dict["사과"] = "빨강색깔 계통의 열매입니다. ";

            //foreach(KeyValuePair<string,string> item in dict )
            //{
            //    Console.WriteLine($"{item.Key} : {item.Value}");
            //}



            ////리스트
            //List<int> someList = new List<int>();
            //someList.Add(1);
            //someList.Add(2);
            //someList.Add(3);
            //someList.Add(4);
            //someList.Add(5);
            ////someList.Add(""); //에러

            //foreach(int item in someList)
            //{
            //    Console.WriteLine(item);
            //}

            ////someList.Remove(4); //4번 삭제
            ////someList.Clear(); //모두 삭제

            //for(int i = 0; i < someList.Count; i++ )
            //{
            //    Console.WriteLine(someList[i]);
            //}





            //Calculator cal = new Calculator();
            //cal.Print();
            //float result = cal.Sum(100, 200);
            //Console.WriteLine(result);

            //float result1 = cal.Subtract(100, 200);
            //Console.WriteLine(result1);

            //float result2 = cal.Divide(100,200);
            //Console.WriteLine(result2);

            //float result3 = cal.Multiply(100, 200);
            //Console.WriteLine(result3);

            //float result4 = cal.Modulo(100, 200);
            //Console.WriteLine(result4);

        }
    }


    //
    //계산기 클래스
    //
    class Calculator
    {
        private int calc = 0;

       public float Sum(float a, float b)
        {
            return a + b;
        }
        public float Subtract(float a, float b)
        {
            return a - b;
        }
        public float Divide(float a, float b)
        { 
            return a / b;
        }
        public float Multiply(float a, float b)
        {
            return a * b;
        }
        public float Modulo(float a, float b)
        {
            return a % b;
        }



        public void Print()
        {
            Console.WriteLine($"총 {calc}회 계산이 되었습니다.");
        }




    }






}

