using System.Drawing;
using System.IO;

namespace MusicPlayer
{
    class TagFile
    {
        public static string Title(string MusicPath)
        {
            try
            {
                return TagLib.File.Create(MusicPath).Tag.Title;
            }
            catch
            {
                return "";
            }
        }

        public static string Artist(string MusicPath)
        {
            try
            {
                return TagLib.File.Create(MusicPath).Tag.FirstAlbumArtist;
            }
            catch
            {
                return "";
            }
        }

        public static string Artists(string MusicPath)
        {
            if (TagLib.File.Create(MusicPath).Tag.AlbumArtists.Length > 1)
            {
                string artists = "";

                foreach (var art in TagLib.File.Create(MusicPath).Tag.AlbumArtists)
                    artists += art + ", ";
                return artists;
            }
            else
                return TagLib.File.Create(MusicPath).Tag.FirstAlbumArtist;
        }

        public static string Album(string MusicPath)
        {
            try
            {
                return TagLib.File.Create(MusicPath).Tag.Album;
            }
            catch
            {
                return "";
            }
        }

        public static string Year(string MusicPath)
        {
            return TagLib.File.Create(MusicPath).Tag.Year.ToString();
        }

        public static string Track(string MusicPath)
        {
            if (TagLib.File.Create(MusicPath).Tag.Track.ToString().Length == 1)
                return ("0" + TagLib.File.Create(MusicPath).Tag.Track.ToString());
            else
                return TagLib.File.Create(MusicPath).Tag.Track.ToString();
        }

        public static string TrackCount(string MusicPath)
        {
            return TagLib.File.Create(MusicPath).Tag.TrackCount.ToString();
        }

        public static string Disc(string MusicPath)
        {
            return TagLib.File.Create(MusicPath).Tag.Disc.ToString();
        }

        public static string DiscCount(string MusicPath)
        {
            return TagLib.File.Create(MusicPath).Tag.DiscCount.ToString();
        }

        public static string Composers(string MusicPath)
        {
            if (TagLib.File.Create(MusicPath).Tag.Composers.Length > 1)
            {
                string Composers = "";

                foreach (var Composer in TagLib.File.Create(MusicPath).Tag.Composers)
                    Composers += Composer + ", ";
                return Composers;
            }
            else
            {
                try
                {
                    return TagLib.File.Create(MusicPath).Tag.Composers[0];
                }
                catch
                {
                    return "";
                }
            }
        }

        public static string Genre(string MusicPath)
        {
            try
            {
                return TagLib.File.Create(MusicPath).Tag.Genres[0];
            }
            catch
            {
                return "";
            }
        }

        public static string Grouping(string MusicPath)
        {
            try
            {
                return TagLib.File.Create(MusicPath).Tag.Grouping;
            }
            catch
            {
                return "";
            }

        }

        public static string Lyrics(string MusicPath)
        {
            try
            {
                return TagLib.File.Create(MusicPath).Tag.Lyrics;
            }
            catch
            {
                return "";
            }

        }

        public static Image Cover(string MusicPath)
        {
            try
            {
                TagLib.IPicture pic = TagLib.File.Create(MusicPath).Tag.Pictures[0];  //pic contains data for image.
                MemoryStream stream = new MemoryStream(pic.Data.Data);  // create an image in memory stream
                return new Bitmap(stream);
            }
            catch
            {
                return Properties.Resources.MusicTon;
            }
        }

    }
}