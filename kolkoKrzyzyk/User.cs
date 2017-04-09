using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolkoKrzyzyk
{
  public class User
    {
       public string Nick { get; protected set; }

       public string PicturePath { get; protected set; }

       public bool[] Score = new bool[10];
       

       public User(string nick, string picturePath)
        {
            CheckNick(nick);
            PicturePath = picturePath;
        }

        private void CheckNick(string nick)
        {
            try
            {
                if (String.IsNullOrEmpty(nick))
                {
                    throw new ArgumentNullException("Nazwa gracza nie może być pusta");
                    
                }
                Nick = nick;
            }
            catch (ArgumentNullException arg)
            {
                MessageBox.Show(arg.Message.ToString());
                
            }
            Form2.form2.Show();
        }

    }


}
