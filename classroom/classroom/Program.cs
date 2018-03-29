using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classroom
{
    class Program
    {
        static void Main(string[] args)
        {
            int gendergirl = 0;
            int genderboy= 0;
            int bloodtypeO = 0;
            int bloodtypeA = 0;
            int bloodtypeB = 0;
            int bloodtypeAB = 0;
            int bloodtypeother = 0;
            int heightgirl = 0;
            int heightboy = 0;
            int min = 0;
            int max = 0;
            int[] height = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };
            string[] bloodtype = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };
            string[] gender = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
            string[] name = { "葉俊廷", "張澤瑜", "王程捷 的咩？", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "世新徐偉哲", "张钰慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新遲正雯", "世新周詮" };
            for (int i = 0; i < name.Length; i++)
            {
                if (height[i] > max)
                {
                    max = height[i];
                }
                if (height[i] < min)
                {
                    min = height[i];
                }
                Console.WriteLine(name[i]);
                if (gender[i] == "女")
                {
                    gendergirl++;
                    heightgirl += height[i];
                }
                if (gender[i] == "男")
                {
                    genderboy++;
                    heightboy += height[i];
                }
                if (bloodtype[i] == "O")
                {
                    bloodtypeO++;
                }
                else if (bloodtype[i] == "A")
                {
                    bloodtypeA++;
                }
                else if (bloodtype[i] == "B")
                {
                    bloodtypeB++;
                }
                else if (bloodtype[i] == "AB")
                {
                    bloodtypeAB++;
                }
                else
                {
                    bloodtypeother++;
                }
            }
            double bloodtypeOpersent = (double)bloodtypeO / (double)bloodtype.Length * 100;
            double bloodtypeApersent = (double)bloodtypeA / (double)bloodtype.Length * 100;
            double bloodtypeBpersent = (double)bloodtypeB / (double)bloodtype.Length * 100;
            double bloodtypeABpersent = (double)bloodtypeAB / (double)bloodtype.Length * 100;
            double bloodtypeotherpersent = (double)bloodtypeother / (double)bloodtype.Length * 100;
            double heightgirlpinjun = (double)heightgirl / (double)gendergirl;

            Console.WriteLine("girl :" + gendergirl);
            Console.WriteLine("O :" + bloodtypeO + " " + Math.Round(bloodtypeOpersent) + "%");
            Console.WriteLine("A :" + bloodtypeA + " " + Math.Round(bloodtypeApersent) + "%");
            Console.WriteLine("B :" + bloodtypeB + " " + Math.Round(bloodtypeBpersent) + "%");
            Console.WriteLine("AB :" + bloodtypeAB + " " + Math.Round(bloodtypeABpersent) + "%");
            Console.WriteLine("Other :" + bloodtypeother + " " + Math.Round(bloodtypeotherpersent) + "%");
            Console.WriteLine("height girl total is : " + heightgirl);
            Console.WriteLine("height boy total is : " + heightboy);
            Console.WriteLine("heightpingjun is " + heightgirlpinjun);
            Console.WriteLine("min height is:" + min);
            Console.WriteLine("max height is:" + max);
            Console.ReadKey();
        }
    }
}
