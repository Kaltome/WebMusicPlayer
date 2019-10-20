using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicPlayer.Models;
using MusicPlayer.Services.MusicPlayer;

namespace MusicPlayer.Controllers.MusicPlayer
{
    public class MusicController : Controller
    {
        public static List<Music> musicList;

        public MusicController()
        {
            musicList = MusicRepository.getMusic();
        }

        public IActionResult MusicPlayer()
        {
            return View(musicList[0]);
        }

        public Music nextMusic()
        {

            int no = int.Parse(Request.Form["no"]);
            return (musicList[(no+1) % musicList.Count]);
        }

        public Music lastMusic()
        {

            int lastno = int.Parse(Request.Form["no"]) - 1;

            return (lastno < 0)? musicList[musicList.Count - 1] : musicList[lastno];
        }
    }
}