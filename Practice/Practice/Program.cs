using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //學生資料
            string[] names = { "葉俊廷", "張澤瑜", "王程捷 的咩？", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋", "周詮", "王湘婷", "蕭宇成", "Max Cheung(BANG)", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新林星彤", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "我是陳柏霖2號", "张钰慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新遲正雯", "世新周詮" };
            string[] stars = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "處女", "", "", "摩羯", "天蠍", "雙子", "", "獅子", "天蠍", "射手", "金牛" };
            string[] bloodTypes = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "A", "O" };
            string[] gender = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "女", "男" };
            int[] height = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 168, 173 };

            int sumB = 0;
            int perB = 0;
            int men = 0;
            int sumG = 0;
            int perG = 0;
            int women = 0;
            int countO = 0;
            int countA = 0;
            int countB = 0;
            int countAB = 0;

            //算式
            for (int i = 0; i < gender.Length; i++)
            {
                if (gender[i] == "女" && height[i] > 100)
                {
                    sumG += height[i];
                    perG += 1;
                }
                else if (gender[i] == "男" && (height[i] > 100 && height[i] < 300))
                {
                    sumB += height[i];
                    perB += 1;
                }
                if (gender[i] == "女")
                {
                    women += 1;
                }
                if (gender[i] == "男")
                {
                    men += 1;
                }
            }
            for (int i = 0; i < bloodTypes.Length; i++)
            {
                if(bloodTypes[i] == "O")
                {
                    countO++; 
                }
                else if (bloodTypes[i] == "A")
                {
                    countA++;
                }
                else if (bloodTypes[i] == "B")
                {
                    countB++;
                }
                else if (bloodTypes[i] == "AB")
                {
                    countAB++;
                }
            }
            for (int i = 0; i < names.Length; i++)
            {
                if (stars[i] == "天蠍" && bloodTypes[i] == "O")
                {
                    Console.WriteLine("天蠍O型:" + names[i]);
                }
            }

            double highG = sumG / perG;
            double highB = sumB / perB;
            double percentB = ((double)men / ((double)men + (double)women)) * 100;
            double percentG = ((double)women / ((double)men + (double)women)) * 100;
            double perO = ((double)countO / ((double)men + (double)women)) * 100;
            double perA = ((double)countA / ((double)men + (double)women)) * 100;
            double perBB = ((double)countB / ((double)men + (double)women)) * 100;
            double perAB = ((double)countAB / ((double)men + (double)women)) * 100;

            //印出文字
            Console.WriteLine("\n男生總數" + men + "個");
            Console.WriteLine("百分比為" + percentB + "%");
            Console.WriteLine("男生總身高" + sumB + "公分");
            Console.WriteLine("平均為" + highB + "公分\n");

            Console.WriteLine("女生總數" + women + "個");
            Console.WriteLine("百分比為" + percentG + "%");
            Console.WriteLine("女生總身高" + sumG + "公分");
            Console.WriteLine("平均為" + highG + "公分\n");

            Console.WriteLine("全班總數" + (women+men) + "個");
            Console.WriteLine("全班總身高" + (sumG+sumB) + "公分");
            Console.WriteLine("平均為" + (highG+highB)/2 + "公分\n");

            Console.WriteLine("O型的有" + countO + "人");
            Console.WriteLine("百分比:" + perO + "%");
            Console.WriteLine("A型的有" + countA + "人");
            Console.WriteLine("百分比:" + perA + "%");
            Console.WriteLine("B型的有" + countB + "人");
            Console.WriteLine("百分比:" + perBB + "%");
            Console.WriteLine("AB型的有" + countAB + "人");
            Console.WriteLine("百分比:" + perAB + "%");

            //暫停看字
            Console.ReadLine();
        }
    }
}
