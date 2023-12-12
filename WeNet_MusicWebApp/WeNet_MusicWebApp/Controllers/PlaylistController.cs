using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeNet_MusicWebApp.DAL;
using WeNet_MusicWebApp.Models;

namespace WeNet_MusicWebApp.Controllers
{
    public class PlaylistController : Controller
    {
        public List<Music> musics = DataAccess.GetMusics();

        public ActionResult Index()
        {
            return View(musics);
        }

        public ActionResult Test()
        {
            return View();
        }

        public ActionResult MIndex()
        {
            return View("StyledIndex", musics);
        }

        public ActionResult Delete(int id)
        {
            DataAccess.DeleteMusic(id);
            return View("Index", musics);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Music music = DataAccess.GetMusic(id);
            return View(music);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Music music = DataAccess.GetMusic(id);
            return View(music);
        }

        [HttpPost]
        public ActionResult Edit(Music music)
        {
            bool result = DataAccess.UpdateMusic(music);
            if (result)
                return View("Index", musics);
            else
                return Content("Error");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Music music)
        {
            bool result = DataAccess.AddMusic(music);
            if (result)
                return View("Index", musics);
            else
                return Content("Error");
        }




    }
}