using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeNet_MusicWebApp.Models
{
    public class Music
    {
        public int MusicId { get; set; }
        public string MusicFilePath { get; set; }
        public string MusicName { get; set; }
        public string ProposedBy { get; set; }
        public DateTime DateAdded { get; set; }
        public string Description { get; set; }
        public HttpPostedFileBase MusicFile { get; set; }
    }
}
