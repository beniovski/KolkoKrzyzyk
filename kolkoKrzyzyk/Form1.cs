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
            Form2.game.OneRound(pictureBox1, 1);        
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
            Form2.game.OneRound(pictureBox3, 3);
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2.game.OneRound(pictureBox2, 2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form2.game.OneRound(pictureBox4, 4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form2.game.OneRound(pictureBox5, 5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form2.game.OneRound(pictureBox6, 6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form2.game.OneRound(pictureBox7, 7);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form2.game.OneRound(pictureBox8, 8);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form2.game.OneRound(pictureBox9, 9);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2.game.pictureReset();
            Form2.game.pictureEnables();
            Form2.game.pointReset();            
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }
    }
}
