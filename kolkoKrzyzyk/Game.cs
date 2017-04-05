﻿using System;
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
        public void Resut()
        {
            if (ChckResult())
            {
                MessageBox.Show($"Wygrana zawodnika {KolejkaGracz.Nick}");
                pictureDisable();
            }           
                    
        }

        public void pictureDisable()
        {
            var pictureToDisable = Form1.form.pictureBoxes;
            foreach(var ptd in pictureToDisable)
            {
                ptd.Enabled = false;
            }
        }
        public void pictureEnables()
        {
            var pictureToDisable = Form1.form.pictureBoxes;
            foreach (var ptd in pictureToDisable)
            {
                ptd.Enabled = true;
            }
        }

        public void pictureReset()
        {
            var pictureToReset = Form1.form.pictureBoxes;
            foreach (var ptc in pictureToReset)
            {
                ptc.Image = null;
            }
        }

        public void pointReset()
        {
            foreach(var point in KolejkaGracz.Score)
            {

            }


        }


        private bool ChckResult()
        {
            if ((KolejkaGracz.Score[1] == true && KolejkaGracz.Score[2] == true && KolejkaGracz.Score[3] == true) ||
                (KolejkaGracz.Score[4] == true && KolejkaGracz.Score[5] == true && KolejkaGracz.Score[6] == true) ||
                (KolejkaGracz.Score[7] == true && KolejkaGracz.Score[8] == true && KolejkaGracz.Score[9] == true) ||
                (KolejkaGracz.Score[1] == true && KolejkaGracz.Score[4] == true && KolejkaGracz.Score[7] == true) ||
                (KolejkaGracz.Score[2] == true && KolejkaGracz.Score[5] == true && KolejkaGracz.Score[8] == true) ||
                (KolejkaGracz.Score[3] == true && KolejkaGracz.Score[6] == true && KolejkaGracz.Score[9] == true) ||
                (KolejkaGracz.Score[1] == true && KolejkaGracz.Score[5] == true && KolejkaGracz.Score[9] == true) ||
                (KolejkaGracz.Score[7] == true && KolejkaGracz.Score[5] == true && KolejkaGracz.Score[3] == true))
            {
                return true;
            }
            else
                return false;
        }
        
    }
}
