using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doyokouza_bakudan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public static int 乱数生成(int 初めの値, int 終わりの値)
        {
            Random p = new Random();
            int 出力値 = p.Next(初めの値, 終わりの値 + 1);
            return 出力値;
        }

        public static int 爆弾位置 = 乱数生成(1, 9);

        public static int カウンター = 0; //ボタンが押されたら1を足す, 8回押されたらおしまい

        public static void 爆弾判定(object sender, EventArgs e) //引数には各ボタンのメタデータが代入される
        {
            int 押されたボタン = int.Parse(((Button)sender).Text); //int.Parseはint型に変換する

            if(押されたボタン == 爆弾位置)
            {
                MessageBox.Show("爆弾を踏んだ！\nご愁傷さまだ……");
                Application.Exit();
            }
            else
            {
                ((Button)sender).Enabled = false;
                カウンター++;
            }

            if (カウンター == 8)
            {
                MessageBox.Show("おめでとう！\n難を逃れた。");
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            爆弾判定(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            爆弾判定(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            爆弾判定(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            爆弾判定(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            爆弾判定(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            爆弾判定(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            爆弾判定(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            爆弾判定(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            爆弾判定(sender, e);
        }

        /*
        public static void 爆弾設置没()
        {
            byte[,] フィールド = new byte[,] {
                { 0, 0, 0 },
                { 0, 0, 0 },
                { 0, 0, 0 }
            };

            int 爆弾設置の横列 = 乱数生成(1, 3);
            int 爆弾設置の縦列 = 乱数生成(1, 3);

            フィールド[爆弾設置の縦列, 爆弾設置の横列] = 1;
        }
        */


    }
}
