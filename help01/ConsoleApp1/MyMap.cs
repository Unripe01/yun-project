using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyMap
    {
        public static Dictionary<char, char> GetMap()
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
            return myDic;
        }
    }
}
