using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeNet_MusicWebApp.Models;

namespace WeNet_MusicWebApp.DAL
{
    public class DataAccess
    {
        public static List<Music> musics = new List<Music>()
        {
              new Music() { MusicId = 1, Description = "Music by Andrea Bocelli", ProposedBy = "H.Amini", MusicName = "Quizas", MusicFilePath = "/MusicFiles/Quizas.mp3", DateAdded = new DateTime(2023, 10, 1) },
            new Music() { MusicId = 2, Description = "Music by Hans Zimmer", ProposedBy = "S.Javanbakht", MusicName = "Day One", MusicFilePath = "/MusicFiles/Day One.mp3", DateAdded = new DateTime(2023,10,1) },
            new Music() { MusicId = 3, Description = "Music by Majid Razavi", ProposedBy = "F.Hosseini", MusicName = "Asemoon", MusicFilePath = "/MusicFiles/Asemoon.mp3", DateAdded = new DateTime(2023,10,1) },
            new Music() { MusicId = 4, Description = "Music by Dariush", ProposedBy = "M.Davtalab", MusicName = "Donyaye In Roozaye Man", MusicFilePath = "/MusicFiles/Donyaye In Roozaye Man.mp3", DateAdded = new DateTime(2023,10,1) },
            new Music() { MusicId = 5, Description = "Music by Alireza Ghorbani", ProposedBy = "A.Darvishi", MusicName = "Oftade Dare Meykhaneh", MusicFilePath = "/MusicFiles/Oftade Dare Meykhaneh.mp3", DateAdded = new DateTime(2023,10,1) },
            new Music() { MusicId = 6, Description = "Music by Mohammadreza Shajarian", ProposedBy = "M.Zarei", MusicName = "Baroon", MusicFilePath = "/MusicFiles/Baroon.mp3", DateAdded = new DateTime(2023,10,1) },
            new Music() { MusicId = 7, Description = "Music by A2", ProposedBy = "M.Sharifi", MusicName = "Dashte Ghasedak", MusicFilePath = "/MusicFiles/Dashte Ghasedak.mp3", DateAdded = new DateTime(2023,10,1) },
            new Music() { MusicId = 8, Description = "Music by Nick Cave", ProposedBy = "K.Safarnia", MusicName = "Red Right Hand", MusicFilePath = "/MusicFiles/Red Right Hand.mp3", DateAdded = new DateTime(2023,10,1) },
            new Music() { MusicId = 9, Description = "Music by Ali Yasini", ProposedBy = "H.Alamian", MusicName = "Behtar Az Mane", MusicFilePath = "/MusicFiles/Behtar Az Mane.mp3", DateAdded = new DateTime(2023,10,1) },
            new Music() { MusicId = 10, Description = "Music by Erfan Tahmasbi", ProposedBy = "M.Ashtiany", MusicName = "To", MusicFilePath = "/MusicFiles/To.mp3", DateAdded = new DateTime(2023,10,1) },
            new Music() { MusicId = 11, Description = "Music by Ahmet Kaya", ProposedBy = "M.Abdi", MusicName = "Safak türküsü", MusicFilePath = "/MusicFiles/Safak türküsü.mp3", DateAdded = new DateTime(2023,10,1) },
            new Music() { MusicId = 12, Description = "Music by Behnam Safavi", ProposedBy = "H.Ghorbani", MusicName = "Elahi", MusicFilePath = "/MusicFiles/Elahi.mp3", DateAdded = new DateTime(2023,10,1) },
            new Music() { MusicId = 13, Description = "Music by Soul Nidus", ProposedBy = "A.Gholizade", MusicName = "I Shout Love", MusicFilePath = "/MusicFiles/I Shout Love.mp3", DateAdded = new DateTime(2023,10,1) },
            new Music() { MusicId = 14, Description = "Music by Dedublüman", ProposedBy = "S.Mohammadi", MusicName = "Belki", MusicFilePath = "/MusicFiles/Belki.mp3", DateAdded = new DateTime(2023,10,1) }
        };

        public static List<Music> GetMusics()
        {
            return musics;
        }

        public static Music GetMusic(int id)
        {
            Music music = musics.Find(r => r.MusicId == id);
            return music;
        }
        public static bool DeleteMusic(int id)
        {
            musics.RemoveAll(r => r.MusicId == id);
            return true;
        }

        public static bool UpdateMusic(Music editedMusic)
        {
            Music music = musics.Find(r => r.MusicId == editedMusic.MusicId);
            music.MusicName = editedMusic.MusicName;
            music.Description = editedMusic.Description;
            music.ProposedBy = editedMusic.ProposedBy;
            return true;
        }


        public static bool AddMusic(Music newMusic)
        {
            int curId = musics.Count + 1;
            newMusic.MusicId = curId;
            newMusic.DateAdded = DateTime.Now;
            string FielPath = $"D:/Me/Sample/Code/WeNet_MusicWebApp/WeNet_MusicWebApp/MusicFiles/{newMusic.MusicName}.mp3";
            newMusic.MusicFilePath = $"/MusicFiles/{newMusic.MusicName}.mp3";
            newMusic.MusicFile.SaveAs(FielPath);
            musics.Add(newMusic);
            return true;
        }
    }
}