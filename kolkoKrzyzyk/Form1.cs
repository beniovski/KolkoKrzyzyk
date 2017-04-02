using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolkoKrzyzyk
{
    public partial class Form1 : Form
    {
        public static Form1 form;

        public Form1()
        {
            InitializeComponent();
            form = this;
        }

        public void MainPictureSet(string path)
        {
            pictureBox14.Image = Image.FromFile(path);
        }

        public void Label1SetValue(string value)
        {
            label1.Text = value;
        }


        private void zakońxczToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Form2.game.KolejkaGracz.PicturePath);
            pictureBox1.Enabled = false;
            Form2.game.ChangUser();
            pictureBox14.Image = Image.FromFile(Form2.game.KolejkaGracz.PicturePath);
            label1.Text = Form2.game.UserNick();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nowaGraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();           
            form2.Show(); 
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile(Form2.game.KolejkaGracz.PicturePath);
            pictureBox3.Enabled = false;
            Form2.game.ChangUser();
            pictureBox14.Image = Image.FromFile(Form2.game.KolejkaGracz.PicturePath);
            label1.Text = Form2.game.UserNick();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile(Form2.game.KolejkaGracz.PicturePath);
            pictureBox2.Enabled = false;
            Form2.game.ChangUser();
            pictureBox14.Image = Image.FromFile(Form2.game.KolejkaGracz.PicturePath);
            label1.Text = Form2.game.UserNick();
        }
    }
}
