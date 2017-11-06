using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses_ex
{
    partial class Human //宣告Human為部分類別
    {   //定義年齡屬性
        public int Age
        { get; set; }

        //定義走路方法
        public string ToWalk()
        {
            return "正在走路中....";
        }
    }
}
