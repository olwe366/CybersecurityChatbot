using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CybersecurityChatbotApplication
{
    internal class AudioPlayer
    {
      
            public static void PlayGreeting()
            {
                string path = "Greeting.wav";

                if (File.Exists(path))
                {
                    SoundPlayer player = new SoundPlayer(path);
                    player.Play();
                }
            }

        
    }
}
