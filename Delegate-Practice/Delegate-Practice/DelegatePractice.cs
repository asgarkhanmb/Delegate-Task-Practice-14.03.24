﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Practice
{
    internal class DelegatePractice
    {
        //public delegate bool CheckNums(int a);

        //public delegate void ChangeStr(string str);

        //public delegate int CalculateLength(string str,int num);

        //public bool CheckOddNums(int num)
        //{
        //    return  num% 2 != 0;    
        //}
        //public bool CheckEvenNums(int num)
        //{
        //    return num % 2 == 0;
        //}

        //public void StrToUpper(string str)
        //{
        //    Console.WriteLine(str.ToUpper());
        //}
        //public void StrToLower(string str) 
        //{
        //    Console.WriteLine(str.ToLower());  
        //}
        //public int GetLength(string str, int num)
        //{
        //    return str.Length+num;
        //}
        //public bool CheckNums(int num1,int num2,int num3) 
        //{
        //    return num1>5&&num2>5&&num3>5;
        //}

        public void Execute()
        {
            //List<int> list = new List<int> {1,4,5,7,8,9 };


            //SumOfNumsByCondition(list,m=>m%2!=0);
            //SumOfNumsByCondition(list, m => m % 2 == 0);


            //ShowText("Salam", StrToUpper);
            //ShowText("SALAM", StrToLower);

            //Action<string> del1 = StrToUpper;
            //Action<string> del2 = StrToLower;
            //del1("sagol");
            //del2("Sagol");

            //GetLengthOfStr("salam", GetLength);

            //Func<string,int,int> func=GetLength;
            //var m=func("Hello", 100);
            //Console.WriteLine(m);

            //SumOfNumsByCondition(10, 11, 12, CheckNums);

        }

        //public void SumOfNumsByCondition(int num1,int num2,int num3,Func<int, int, int, bool> expression)
        //{
        //    if(expression(num1,num2,num3)) 
        //    {
        //        Console.WriteLine(num1+num2+num3);
        //    }
        //}

        //public void GetLengthOfStr(string str,Func<string,int,int> func)
        //{
        //    int count =func(str,10);
        //    Console.WriteLine(count);
        //}

        //public void ShowText(string text,Action<string> func)
        //{
        //    func(text);
        //}


        //public void SumOfNumsByCondition(List<int> nums,Predicate<int> func)
        //{

        //    int sum = 0;
        //    foreach (var item in nums)
        //    {
        //       if(func(item))
        //        {
        //            sum += item;
        //        }
        //    }
        //    Console.WriteLine(sum);
        //}

       
        
        
    }
}
