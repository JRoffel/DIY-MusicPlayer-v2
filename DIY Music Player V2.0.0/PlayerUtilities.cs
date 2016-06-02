using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using WMPLib;

namespace DIY_Music_Player_V2._0._0
{
    class PlayerUtilities
    {
        public PlayerUtilities(Window window)
        {
            _window = window;
            Player.settings.autoStart = false;
            Player.PlayStateChange += new _WMPOCXEvents_PlayStateChangeEventHandler(player_PlayStateChange);
        }

        public void GetAllSongsFromDirectory(string directory, SearchOption searchOption)
        {
            var fileNames = Directory.GetFiles(directory, ".mp3", searchOption);
            AllSongs = fileNames.AsQueryable().OrderBy(s => s).ToList();
        }

        public void PlayPause()
        {

        }

        public void GetNextSong()
        {

        }

        private void player_PlayStateChange(int NewState)
        {
            if (NewState == (int)WMPPlayState.wmppsMediaEnded)
            {
                GetNextSong();
            }
        }

        private Window _window;
        private WindowsMediaPlayer Player = new WindowsMediaPlayer();
        private List<string> AllSongs = new List<string>();
    }
}