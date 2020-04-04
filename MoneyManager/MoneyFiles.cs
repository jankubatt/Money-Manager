using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MoneyManager
{
    class MoneyFiles
    {
        public void files()
        {
            string dirMain = @"C:\Users\Public\moneymanagerData";

            if (!Directory.Exists(dirMain))
            {
                Directory.CreateDirectory(@"C:\Users\Public\moneymanagerData");
            }

            int dirCount = Directory.GetFiles(dirMain).Length;

            if (dirCount < 9)
            {
                Directory.CreateDirectory(@"C:\Users\Public\moneymanagerData");
                if (!File.Exists(@"C:\Users\Public\moneymanagerData\money_data.txt")) { File.Create(@"C:\Users\Public\moneymanagerData\money_data.txt").Close(); }
                if (!File.Exists(@"C:\Users\Public\moneymanagerData\money_data1.txt")) { File.Create(@"C:\Users\Public\moneymanagerData\money_data1.txt").Close(); }
                if (!File.Exists(@"C:\Users\Public\moneymanagerData\money_data2.txt")) { File.Create(@"C:\Users\Public\moneymanagerData\money_data2.txt").Close(); }
                if (!File.Exists(@"C:\Users\Public\moneymanagerData\money2_data.txt")) { File.Create(@"C:\Users\Public\moneymanagerData\money2_data.txt").Close(); }
                if (!File.Exists(@"C:\Users\Public\moneymanagerData\money2_data1.txt")) { File.Create(@"C:\Users\Public\moneymanagerData\money2_data1.txt").Close(); }
                if (!File.Exists(@"C:\Users\Public\moneymanagerData\money2_data2.txt")) { File.Create(@"C:\Users\Public\moneymanagerData\money2_data2.txt").Close(); }
                if (!File.Exists(@"C:\Users\Public\moneymanagerData\currency.txt")) { File.Create(@"C:\Users\Public\moneymanagerData\currency.txt").Close(); }
                if (!File.Exists(@"C:\Users\Public\moneymanagerData\currency1.txt")) { File.Create(@"C:\Users\Public\moneymanagerData\currency1.txt").Close(); }
                if (!File.Exists(@"C:\Users\Public\moneymanagerData\currency2.txt")) { File.Create(@"C:\Users\Public\moneymanagerData\currency2.txt").Close(); }
            }
        }
    }
}
