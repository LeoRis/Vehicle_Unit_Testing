using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Data.Entity;

namespace Vehicle.Mocking
{
    public class VideoService
    {
        private IFileReader _fileReader;
        public VideoService(IFileReader fileReader = null)
        {
            // If fileReader is not null, we will use it to set _fileReader.
            // Else, if it's null, we will create new FileReader object.
            _fileReader = fileReader ?? new FileReader();
        }
        public string ReadVideoTitle()
        {
            var str = _fileReader.Read("video.txt");
            var video = JsonConvert.DeserializeObject<Video>(str);
            if (video == null)
            {
                return "Error parsing the video.";
            }
            return video.Title;
        }

        public string GetUnprocessedVideosAsCsv()
        {
            var videoIds = new List<int>();

            using(var context = new VideoContext())
            {
                var videos =
                    (from video in context.Videos
                     where !video.IsProcessed
                     select video).ToList();

                foreach(var v in videos)
                {
                    videoIds.Add(v.Id);
                }
                return String.Join(",", videoIds);
            }
        }

        public class Video
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public bool IsProcessed { get; set; }
        }

        public class VideoContext : DbContext
        {
            public DbSet<Video> Videos { get; set; }
        }
    }
}
