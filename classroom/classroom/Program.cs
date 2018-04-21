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

            // 宣告用來計算女/男生性別人數的變數
            int gendergirl = 0;
            int genderboy = 0;

            // 宣告用來計算O/A/B/AB/其他型血人數的變數
            int bloodtypeO = 0;
            int bloodtypeA = 0;
            int bloodtypeB = 0;
            int bloodtypeAB = 0;
            int bloodtypeother = 0;

            // 設女/男生身高總和
            int heightgirl = 0;
            int heightboy = 0;

            // 全班身高最小/大值變數，預設為最大/小值，方便之後比較大小不漏判
            int min = 999;
            int max = -999;

            // 宣告用來計算男/女生平均身高的變數
            int genderboyheight = 0;
            int gendergirlheight = 0;

            // 設存放全班身高/血型/性別/名字/星座的陣列
            int[] height = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };
            string[] bloodtype = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };
            string[] gender = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
            string[] name = { "葉俊廷", "張澤瑜", "王程捷 的咩？", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "世新徐偉哲", "张钰慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新遲正雯", "世新周詮" };
            string[] zodiac = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "處女", "", "", "摩羯", "天蠍", "雙子", "", "獅子", "天蠍", "射手", "金牛" };

            for (int i = 0; i < name.Length; i++)
            {
                // 計算最高/矮身高，並把錯誤的身高剔除
                if (height[i] > max && height[i]<200)
                {
                    max = height[i];
                }
                if (height[i] < min && height[i]>0)
                {
                    min = height[i];
                }

                // 分別把男/女生身高加總，把錯誤的身高剔除
                if (gender[i] == "女" && height[i] > 0 && height[i] < 200)
                {
                    gendergirlheight++;
                    heightgirl += height[i];
                }
                if (gender[i] == "男" && height[i] > 0 && height[i] < 200)
                {
                    genderboyheight++;
                    heightboy += height[i];
                }

                // 分別計算男/女生人數
                if (gender[i] == "男")
                {
                    genderboy++;
                }
                if (gender[i] == "女")
                {
                    gendergirl++;
                }

                // 計算O,A,B,AB,其他型血人數
                if (bloodtype[i] == "O")
                {
                    bloodtypeO++;

                    // 找出星座為天蠍座的人
                    if (zodiac[i] == "天蠍")
                    {
                        Console.WriteLine("星座為天蠍座，血型為O的人有 :"+name[i]);
                    }
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

            // 計算O/A/B/AB/其他型血人數百分比
            double bloodtypeOpersent = (double)bloodtypeO / (double)bloodtype.Length * 100;
            double bloodtypeApersent = (double)bloodtypeA / (double)bloodtype.Length * 100;           
            double bloodtypeBpersent = (double)bloodtypeB / (double)bloodtype.Length * 100;           
            double bloodtypeABpersent = (double)bloodtypeAB / (double)bloodtype.Length * 100;          
            double bloodtypeotherpersent = (double)bloodtypeother / (double)bloodtype.Length * 100;

            // 計算男/女生身高平均
            double heightgirlpinjun = (double)heightgirl / (double)gendergirlheight;
            double heightboypinjun = (double)heightboy / (double)genderboyheight;

            // 計算女/男生人數平均
            double girlpinjun = (double)gendergirl / (double)gender.Length * 100;
            double boypinjun = (double)genderboy / (double)gender.Length * 100;

            // 顯示女/男生人數與百分比
            Console.WriteLine("女生人數 :" + gendergirl + "個。百分比為 :" + Math.Round(girlpinjun)+"%");
            Console.WriteLine("男生人數 :" + genderboy + " 個。百分比為 :" + Math.Round(boypinjun) + "%");

            // 顯示O/A/B/AB/其他型血人數與百分比
            Console.WriteLine("O :" + bloodtypeO + " " + Math.Round(bloodtypeOpersent) + "%");
            Console.WriteLine("A :" + bloodtypeA + " " + Math.Round(bloodtypeApersent) + "%");
            Console.WriteLine("B :" + bloodtypeB + " " + Math.Round(bloodtypeBpersent) + "%");
            Console.WriteLine("AB :" + bloodtypeAB + " " + Math.Round(bloodtypeABpersent) + "%");
            Console.WriteLine("其他血型 :" + bloodtypeother + " " + Math.Round(bloodtypeotherpersent) + "%");

            // 顯示女/男生平均身高
            Console.WriteLine("女生身高平均為 :" + heightgirlpinjun);
            Console.WriteLine("男生身高平均為 :" + heightboypinjun);

            // 顯示全部最矮/高的身高
            Console.WriteLine("全部最矮身高為 :" + min);
            Console.WriteLine("全部最高身高為 ::" + max);

            // 按任意鍵退出
            Console.ReadKey();
        }
    }
}
