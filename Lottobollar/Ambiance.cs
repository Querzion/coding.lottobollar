using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Lottobollar
{
    internal class Ambiance
    {
        public static void PlayMusic(string filepath)
        {

            SoundPlayer BGM = new SoundPlayer();

            BGM.SoundLocation = filepath;
            BGM.PlayLooping();
        }
    }
}
