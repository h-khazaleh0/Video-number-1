//ادخل الاسم ثم قم بطباعته
using ex1;
using System;


class Program
{
  
    static void Main(string[] args)
    {
      Name.printName();
      OddEven.lkjvyhvb_();
      Drive1.Wage_();// طريقه 1 اسهله من طريقه 2
      Drive2.ReadInfo();
      Drive2 drive2 = new Drive2();
      Drive2.stInfo info = Drive2.ReadInfo();
      drive2.PrintResult(info);
      Drive3.Wage_();// طريقه 3 اضافه توصيه



    }

}