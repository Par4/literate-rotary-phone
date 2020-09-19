using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piyoject
{
    public partial class Form1 : Form
    {
        public enum StatusEnum { stop, start }
        private string text1;
        public string Text1 
        { 
            get { return text1; } 
            set { text1 = value; } 
        }

        private StatusEnum status = StatusEnum.stop;
        public StatusEnum Status
        {
            get { return status; }
            set { status = value; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Status = Status == StatusEnum.start ? StatusEnum.stop : StatusEnum.start;
            lblHelloWorld.Text = Enum.GetName(typeof(StatusEnum), Status);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Text1 = textBox1.Text;
            cb.Checked = String.IsNullOrEmpty(Text1) ? false : true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            // 幅0.5倍、高さ0.5倍のイメージを作成する
            Bitmap bmp = new Bitmap(
                pictureBox1.Image,
                (int)(pictureBox1.Image.Width * 0.25),
                (int)(pictureBox1.Image.Height * 0.25));

            pictureBox1.Image = bmp;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox2.Text = "ぴよ";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
