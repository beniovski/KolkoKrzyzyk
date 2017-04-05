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
     public partial class Form2 : Form
    {
        public static Game game { get; private  set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User Gracz1 = new User(textBox1.Text, "../../ikony/krzyzyk.jpg");
            User Gracz2 = new User(textBox2.Text, "../../ikony/koło.jpg");
            Game Game = new Game(Gracz1, Gracz2);
            game = Game;
            game.pictureReset();
            game.pictureEnables();
            Form1.form.Label1SetValue(textBox1.Text);
            Form1.form.MainPictureSet(Gracz1.PicturePath);
            Form1.form.Refresh();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
