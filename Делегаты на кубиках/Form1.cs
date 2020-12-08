using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Делегаты_на_кубиках
{
    public delegate void DelegateShow(int a, int b);

    public partial class Form1 : Form
    {
        Dice dice;

        public Form1()
        {
            InitializeComponent();
        }

        public void Init()
        {
            DelegateShow show;
            show = ShowBox;
            show += ShowDice;
            show += ShowSum;
            dice = new Dice(show);
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            dice.Go();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void ShowDice(int a, int b)
        {
            textDices.Text = a + ":" + b;
        }

        private void ShowSum(int a, int b)
        {
            int sum = a + b;
            labelSum.Text = sum.ToString();
        }

        private void ShowBox(int a, int b)
        {
            box1.Image = box(a);
            box2.Image = box(b);
        }

        private Image box(int nr)
        {
            switch (nr)
            {
                case 1:return Properties.Resources._1;
                case 2: return Properties.Resources._2;
                case 3: return Properties.Resources._3;
                case 4: return Properties.Resources._4;
                case 5: return Properties.Resources._5;
                case 6: return Properties.Resources._6;
            }
            return null;
        }
    }
}
