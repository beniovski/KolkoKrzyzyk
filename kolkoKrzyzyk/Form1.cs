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

        public List<PictureBox> pictureBoxes { get; private set; }

        public Form1()
        {
            pictureBoxes = new List<PictureBox>();
            InitializeComponent();
            form = this;
            pictureBoxes.Add(pictureBox1);
            pictureBoxes.Add(pictureBox2);
            pictureBoxes.Add(pictureBox3);
            pictureBoxes.Add(pictureBox4);
            pictureBoxes.Add(pictureBox5);
            pictureBoxes.Add(pictureBox6);
            pictureBoxes.Add(pictureBox7);
            pictureBoxes.Add(pictureBox8);
            pictureBoxes.Add(pictureBox9);
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
            Form2.game.KolejkaGracz.Score[1] = true;
            Form2.game.Resut();
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
            Form2.game.KolejkaGracz.Score[3] = true;
            Form2.game.Resut();
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
            Form2.game.KolejkaGracz.Score[2] = true;
            Form2.game.Resut();
            Form2.game.ChangUser();
            pictureBox14.Image = Image.FromFile(Form2.game.KolejkaGracz.PicturePath);
            label1.Text = Form2.game.UserNick();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Image.FromFile(Form2.game.KolejkaGracz.PicturePath);
            pictureBox4.Enabled = false;
            Form2.game.KolejkaGracz.Score[4] = true;
            Form2.game.Resut();
            Form2.game.ChangUser();
            pictureBox14.Image = Image.FromFile(Form2.game.KolejkaGracz.PicturePath);
            label1.Text = Form2.game.UserNick();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Image.FromFile(Form2.game.KolejkaGracz.PicturePath);
            pictureBox5.Enabled = false;
            Form2.game.KolejkaGracz.Score[5] = true;
            Form2.game.Resut();
            Form2.game.ChangUser();
            pictureBox14.Image = Image.FromFile(Form2.game.KolejkaGracz.PicturePath);
            label1.Text = Form2.game.UserNick();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile(Form2.game.KolejkaGracz.PicturePath);
            pictureBox6.Enabled = false;
            Form2.game.KolejkaGracz.Score[6] = true;
            Form2.game.Resut();
            Form2.game.ChangUser();
            pictureBox14.Image = Image.FromFile(Form2.game.KolejkaGracz.PicturePath);
            label1.Text = Form2.game.UserNick();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Image.FromFile(Form2.game.KolejkaGracz.PicturePath);
            pictureBox7.Enabled = false;
            Form2.game.KolejkaGracz.Score[7] = true;
            Form2.game.Resut();
            Form2.game.ChangUser();
            pictureBox14.Image = Image.FromFile(Form2.game.KolejkaGracz.PicturePath);
            label1.Text = Form2.game.UserNick();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = Image.FromFile(Form2.game.KolejkaGracz.PicturePath);
            pictureBox8.Enabled = false;
            Form2.game.KolejkaGracz.Score[8] = true;
            Form2.game.Resut();
            Form2.game.ChangUser();
            pictureBox14.Image = Image.FromFile(Form2.game.KolejkaGracz.PicturePath);
            label1.Text = Form2.game.UserNick();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Image.FromFile(Form2.game.KolejkaGracz.PicturePath);
            pictureBox9.Enabled = false;
            Form2.game.KolejkaGracz.Score[9] = true;
            Form2.game.Resut();
            Form2.game.ChangUser();
            pictureBox14.Image = Image.FromFile(Form2.game.KolejkaGracz.PicturePath);
            label1.Text = Form2.game.UserNick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2.game.pictureReset();
            Form2.game.pointReset();            
        }
    }
}
