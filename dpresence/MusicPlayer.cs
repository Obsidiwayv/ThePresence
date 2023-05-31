using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace dpresence
{
    class MusicPlayer
    {
        private static SoundPlayer player;
        public static void InitMusicPlayer()
        {
            player = new SoundPlayer(Properties.Resources.POWERSOUND);
            player.Play();
        }
    }
}
