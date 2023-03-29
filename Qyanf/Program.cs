using System;
using System.Linq;

// Autoer-Qyanf
namespace Qyanf
{
    public class Autoer
    {
        public static void Main() {
            Etc etc = new Etc();
            Check check = new Check();

            check.CheckAuto();

            double autoerVersion = 0.1;
            string autoerEditon = "alpha";
            Console.WriteLine("Autoer\nVersion: "+autoerVersion.ToString()+"-"+autoerEditon);
            // モード選択
            Console.Write("モードを選択してください\n作成モード[Make]\n管理モード[Control]\nソフトウェアを終了[Exit]\n[M,C,E]: ");
            var userInputMode = Console.ReadLine();

            if (userInputMode != null)
            {
                if (userInputMode.ToLower().Contains("m")) { }
            }
        }
    }
}