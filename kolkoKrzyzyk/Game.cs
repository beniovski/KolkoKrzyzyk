using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolkoKrzyzyk
{
    public class Game
    {
        public User KolejkaGracz { get; protected set; }
        private User Gracz1;
        private User Gracz2;

        public Game(User gracz1, User gracz2)
        {
            KolejkaGracz = gracz1;
            Gracz1 = gracz1;
            Gracz2 = gracz2;
        }

        public void ChangUser()
        {
            if (KolejkaGracz == Gracz1)
                KolejkaGracz = Gracz2;
            else
                KolejkaGracz = Gracz1;     
        }

        public string PicturePath()
        {
            return KolejkaGracz.PicturePath;
        }
        public string UserNick()
        {
            return KolejkaGracz.Nick;
        }

        public void Round()
        {
            pictureBox2.Image = Image.FromFile(Form2.game.KolejkaGracz.PicturePath);
            pictureBox2.Enabled = false;
            Form2.game.ChangUser();
            pictureBox14.Image = Image.FromFile(Form2.game.KolejkaGracz.PicturePath);
            label1.Text = Form2.game.UserNick();
        }
        
    }
}
