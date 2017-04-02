using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolkoKrzyzyk
{
  public  class User
    {
       public string Nick { get; protected set; }

       public string PicturePath { get; protected set; }

       public int Score { get; set; }   
        

       public User(string nick, string picturePath)
        {
            Nick = nick;
            PicturePath = picturePath;
        }

    }


}
