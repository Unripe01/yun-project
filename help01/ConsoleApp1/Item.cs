using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// １項目を表現するクラス
    /// </summary>
    class Item
    {
        public char _OriginalValue { get; set; }
        private readonly Func<char, string> _ruleOfCommon;
        private readonly Func<string, string> _ruleOfLast;

        /// <summary>
        /// ベタなルール、0で5桁埋め
        /// </summary>
        private string myRule1(char c)
        {
            return c.ToString().PadLeft(5,'0');
        }

        /// <summary>
        /// ベタなルール、びっくりをつける
        /// </summary>
        private string myRule2(string s)
        {
            return string.Format("this is {0} !", s);
        }

        /// <summary>
        /// 引数なしコンストラクタは隠蔽しておく
        /// </summary>
        private Item() { }

        public Item(char c)
        {
            //変換ルールが指定されない場合はデフォルトルールをセット
            this._OriginalValue = c;
            this._ruleOfCommon = myRule1;
            this._ruleOfLast = myRule2;
        }

        //外部から内部に影響を与えるルールを適用しつつitemインスタンスを構築します
        public Item(char c, Func<char,string> ruleOfCommon, Func<string, string> ruleOfLast)
        {
            this._OriginalValue = c;
            this._ruleOfCommon = ruleOfCommon;
            this._ruleOfLast = ruleOfLast;
        }

        /// <summary>
        /// 共通フォーマットに変換した値を取得します。
        /// </summary>
        public string ToCommonFormat()
        {
            return this._ruleOfCommon(this._OriginalValue);
        }

        /// <summary>
        /// 最終フォーマットに変換した値を取得します。
        /// </summary>
        public string ToLastFormat()
        {
            return this._ruleOfLast(this.ToCommonFormat());
        }
    }
}
