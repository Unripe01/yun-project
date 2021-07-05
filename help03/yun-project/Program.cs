using System;
using System.Collections.Generic;
using System.Linq;

namespace yun_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //フルコード
            var fullCodes = new List<string>();
            fullCodes.Add("44440000");
            fullCodes.Add("22221111");
            fullCodes.Add("44448888");
            fullCodes.Add("11118888");
            fullCodes.Sort();

            //マスタ
            var masters = new Dictionary<string, Master>();
            masters.Add("22221111", new Master("22221111","4444", "3333"));//ここがフルコードとヒット
            masters.Add("12341111", new Master("12341111", "2222", "8888"));
            masters.Add("99999999", new Master("99999999", "2222", "8888"));
            masters.Add("44448888", new Master("44448888", "1111", "XXXX"));//ここがフルコードとヒット

            //フルコードのキーとマッチするmasters　を絞り込む
            var useChildCodeWhere = masters.Where(master => fullCodes.Contains(master.Key))
                                           .Select(n => n.Value)
                                           .OrderBy(n => n.key)
                                           .ToDictionary(n => n.sort, m => m.addParent);
            //useChildCodeWhere では、以下のコードと一致する結果を取得して、都合のいい形に整形している。

            //実際にはフルコードの下に、マスタwhereをがちゃがちゃくっつけていくのでこう
            //次のコードがみたいのでforで頑張ってます
            for (int i = 0; i < fullCodes.Count(); i++)
            {
                var fullCode = fullCodes[i];
                Console.WriteLine("parent - {0}", fullCode);

                if (fullCodes.Count <= i + 1 ||
                    (fullCodes.Count > i && fullCodes[i+1].GetParentPart() != fullCode.GetParentPart())
                   )
                {
                    //最後のループか、
                    //親コードがキーブレイクしたら、紐づく子コードを流し込んでいく
                    if (useChildCodeWhere.ContainsKey(fullCode.GetParentPart()))
                    {
                        Console.WriteLine("child - {0}", fullCode.GetParentPart() + useChildCodeWhere[fullCode.GetParentPart()]);
                    }
                }
            }
        }
    }

    /// <summary>
    /// フルコードの上4桁を取る拡張メソッド
    /// </summary>
    static class Extensions
    {
        public static string GetParentPart(this string str)
        {
            return str.Substring(0, 4);
        }
    }

    //マスタ
    class Master
    {
        public string key { get; set; }
        public string sort { get; set; }
        public string addParent { get; set; }
        public Master(string k,string s,string a)
        {
            this.key = k;
            this.sort = s;
            this.addParent = a;
        }
    }
}
