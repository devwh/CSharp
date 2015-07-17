using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用Python脚本
{
    class Program
    {
        static void Main(string[] args)
        {
            string totalItems = "10";
            string totalAmt = "2.34";
            string scriptToUse;
            bool costRadioButtonChecked = true;
            if (costRadioButtonChecked)
            {
                scriptToUse = "AmountDisc.py";
            }
            else
            {
                scriptToUse = "CountDisc.py";
            }
            // 创建运行时
            ScriptRuntime scriptRuntime = ScriptRuntime.CreateFromConfiguration();
        }
    }
}
