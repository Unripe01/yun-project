using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// ルールを統括するクラス
    /// 共通項目用、最終出力用でルールを分けてもいいかもしれないあと、型はcharとかstringじゃなくてジェネリクスつかうと良き。
    /// </summary>
    class Rules
    {
        //変換表から変換結果を返すルール
        public string Rule1ofCommon(char c)
        {
            var myMap = MyMap.GetMap();
            return myMap[c].ToString();
        }

        /// <summary>
        /// ★で囲うルール
        /// </summary>
        public string Rule1ofLast(string s)
        {
            return string.Format("★{0}★", s);
        }

    }
}
