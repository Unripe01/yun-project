using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ファイルを想定
            const string FILE = "1234567890ABCDEFGHIJ";

            //変換先を想定
            const string CHANGE = ".?<>#!'()|abcdefghij";

            //変換リスト作成
            Dictionary<char, char> myDic = new Dictionary<char, char>();
            var i = 0;
            foreach (var item in FILE)
            {
                myDic.Add(item, CHANGE[i]);
                i++;
            }

            //変換確認
            Console.WriteLine(myDic['1']);
            Console.WriteLine(myDic['2']);
            Console.WriteLine(myDic['3']);
            Console.WriteLine(myDic['4']);
            Console.WriteLine(myDic['A']);
            Console.WriteLine(myDic['B']);
            Console.WriteLine(myDic['C']);
            //->>> log
            //?
            //<
            //>
            //a
            //b
            //c


        }
    }
}
