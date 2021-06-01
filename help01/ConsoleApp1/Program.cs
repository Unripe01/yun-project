using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myMap = MyMap.GetMap();

            //ファイル読み込んだ
            //ベタな変換方法
            var readLine = "12";
            foreach (var item in readLine)
            {
                var changer = new Item(item);
                Console.WriteLine(changer.ToCommonFormat());
                Console.WriteLine(changer.ToLastFormat());
                //00001
                //this is 00001 !
                //00002
                //this is 00002 !
            }

            //高度な変換、ルールを外から与える
            var readLine2 = "AB";
            foreach (var item in readLine2)
            {
                //こんな風に直接ラムダ式を書くのもあり
                //var changer = new Item(item, (char c) => { return "aaaa"; }, (string c) => { return "aaaa"; });
                var changer = new Item(item, new Rules().Rule1ofCommon, new Rules().Rule1ofLast);
                Console.WriteLine(changer.ToCommonFormat());
                Console.WriteLine(changer.ToLastFormat());
                //a
                //★a★
                //b
                //★b★
            }
        }


    }
}
