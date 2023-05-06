using HtmlAgilityPack;
using NAudio.Wave;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer.Classes
{
    public class Song
    {
        public string path;
        public string title;
        public string artist;
        public string album;
        public string lyrics;
        public Bitmap cover;
        public string track;
        public string trackCount;
        public string year;
        public string artists;
        public string genres;

        private AudioFileReader AudioReader;
        private WaveOutEvent WaveEvent;

        public Song(string path, bool IsForPlaying = true)
        {
            this.path = path;
            this.title = Song.GetTitle(path);
            this.artist = Song.GetArtist(path);
            this.album = Song.GetAlbum(path);
            this.lyrics = Song.GetLyrics(path);
            this.cover = Song.GetCover(path);
            this.track = Song.GetTrack(path);
            this.trackCount = Song.GetTrackCount(path);
            this.year = Song.GetYear(path);
            this.artists = Song.GetArtists(path);
            this.genres = Song.GetGenres(path);

            if (IsForPlaying)
            {
                if (WaveEvent != null)
                    WaveEvent.Dispose();
                if (AudioReader != null)
                    AudioReader.Dispose();

                using (var reader = new MediaFoundationReader(path))
                {
                    if (!Directory.Exists("TempFiles/"))
                        Directory.CreateDirectory("TempFiles/");

                    //  Save the 'wav' audio on the Temp File
                    WaveFileWriter.CreateWaveFile("TempFiles/temp.wav", reader);
                }

                AudioReader = new AudioFileReader("TempFiles/temp.wav");
                WaveEvent = new WaveOutEvent();
                WaveEvent.Init(AudioReader);
            }
        }

        public Song(string title, string artist, string album, string lyrics, Bitmap cover = null, string path = "")
        {
            this.title = title;
            this.artist = artist;
            this.album = album;
            this.lyrics = lyrics;
            this.path = path;

            if (cover != null)
                this.cover = cover;
        }

        public void Play()
        {
            WaveEvent.Play();
        }

        public void Pause()
        {
            WaveEvent.Pause();
        }

        public static string GetTitle(string path)
        {
            return TagLib.File.Create(path).Tag.Title;
        }

        public static string GetArtist(string path)
        {
            return String.Join(",", TagLib.File.Create(path).Tag.AlbumArtists);
        }

        public static string GetAlbum(string path)
        {
            return TagLib.File.Create(path).Tag.Album;
        }

        public static string GetLyrics(string path)
        {
            return TagLib.File.Create(path).Tag.Lyrics;
        }

        public static Bitmap GetCover(string path)
        {
            TagLib.File file = TagLib.File.Create(path);

            if (file.Tag.Pictures.Length > 0)
            {
                TagLib.IPicture pic = file.Tag.Pictures[0];  //pic contains data for image.

                using (MemoryStream stream = new MemoryStream(pic.Data.Data))
                {
                    return new Bitmap(stream);
                }
            }
            else
                return null;
        }

        public static string GetTrack(string path)
        {
            return TagLib.File.Create(path).Tag.Track.ToString();
        }

        public static string GetTrackCount(string path)
        {
            return TagLib.File.Create(path).Tag.TrackCount.ToString();
        }

        public static string GetYear(string path)
        {
            return TagLib.File.Create(path).Tag.Year.ToString();
        }

        public static string GetArtists(string path)
        {
            return String.Join(",", TagLib.File.Create(path).Tag.AlbumArtists);
        }

        public static string GetGenres(string path)
        {
            return String.Join(",", TagLib.File.Create(path).Tag.Genres);
        }


        public static void SetTitle(string path, string title)
        {
            TagLib.File file = TagLib.File.Create(path);

            file.Tag.Title = title;
            file.Save();
        }

        public static void SetArtists(string path, string artists)
        {
            TagLib.File file = TagLib.File.Create(path);

            file.Tag.AlbumArtists = artists.Split(',');
            file.Save();
        }

        public static void SetAlbum(string path, string album)
        {
            TagLib.File file = TagLib.File.Create(path);

            file.Tag.Album = album;
            file.Save();
        }

        public static void SetLyrics(string path, string lyrics)
        {
            TagLib.File file = TagLib.File.Create(path);

            file.Tag.Lyrics = lyrics;
            file.Save();
        }

        public static void SetCover(string path, Bitmap cover)
        {
            TagLib.File file = TagLib.File.Create(path);

            file.Tag.Pictures = new TagLib.Picture[]
            {
                new TagLib.Picture(new TagLib.ByteVector((byte[])new ImageConverter().ConvertTo(cover, typeof(byte[]))))
                {
                    Type = TagLib.PictureType.FrontCover,
                    Description = "Cover",
                    MimeType = System.Net.Mime.MediaTypeNames.Image.Jpeg
                }
            };

            file.Save();
        }

        public static void SetTrack(string path, string track)
        {
            TagLib.File file = TagLib.File.Create(path);

            file.Tag.Track = Convert.ToUInt16(track);
            file.Save();
        }

        public static void SetTrackCount(string path, string trackCount)
        {
            TagLib.File file = TagLib.File.Create(path);

            file.Tag.TrackCount = Convert.ToUInt16(trackCount);
            file.Save();
        }

        public static void SetYear(string path, string year)
        {
            TagLib.File file = TagLib.File.Create(path);

            if (DateTime.TryParse(year, out DateTime result_dt))
                file.Tag.Year = (uint)result_dt.Year;
            else if (uint.TryParse(year, out uint result_uint))
                file.Tag.Year = result_uint;

            file.Save();
        }

        public static void SetGenre(string path, string genre)
        {
            TagLib.File file = TagLib.File.Create(path);

            file.Tag.Genres = genre.Split(',');
            file.Save();
        }


        public TimeSpan GetSongLength()
        {
            //return Convert.ToInt32(ConvertFrom.TimeToSeconds(AudioReader.TotalTime));
            return AudioReader.TotalTime;
        }

        public TimeSpan GetCurrentTime()
        {
            //return Convert.ToInt32(AudioReader.CurrentTime);
            return AudioReader.CurrentTime;
        }

        public void SetSongVolume(float volume)
        {
            AudioReader.Volume = volume;
        }

        public void SetSongPosition(int position)
        {
            AudioReader.CurrentTime = ConvertFrom.SecondsToTime(position);
        }


        override public string ToString()
        {
            string val = "path: " + path + "\n";
            val += "title: " + title + "\n";
            val += "artist: " + artist + "\n";
            val += "album: " + album + "\n";

            if (lyrics.Length >= 100)
                val += "lyrics: " + lyrics.Substring(0, 90);
            else
                val += "lyrics: " + lyrics;

            return val;
        }

        public void Dispose()
        {
            if (WaveEvent != null)
                WaveEvent.Dispose();
            if (AudioReader != null)
                AudioReader.Dispose();

            this.path = null;
            this.title = null;
            this.artist = null;
            this.album = null;
            this.lyrics = null;
            this.cover = null;
        }


        public static Song GetSong_FromGenius(string id)
        {
            Song song = null;
            string value = "";

            try
            {
                using (WebClient client = new WebClient())
                {
                    client.Headers.Add("Authorization", "Bearer fxjPUENH-tGJthT1vzpZtH4EcdZAOTfj_zIDA1xicETAQXc7xhuBVs1j1sr3yb68");
                    value = client.DownloadString("https://api.genius.com/songs/" + id);

                    dynamic Answer = JsonConvert.DeserializeObject(value);

                    if (Answer.meta.status == 200)
                    {
                        Newtonsoft.Json.Linq.JObject song_response = Answer.response.song;

                        string url_img = "";
                        string song_title = "";
                        string song_daterelease = "";
                        string artist_name = "";
                        string album_name = "";
                        string url = "";
                        string song_lyrics = "";

                        if (song_response.ContainsKey("song_art_image_url"))
                            url_img = song_response.Value<string>("song_art_image_url");

                        if (song_response.ContainsKey("title_with_featured"))
                            song_title = song_response.Value<string>("title_with_featured");

                        if (song_response.ContainsKey("release_date"))
                            song_daterelease = song_response.Value<string>("release_date");

                        if (song_response.ContainsKey("primary_artist"))
                        {
                            var primary_artist = song_response.Value<Newtonsoft.Json.Linq.JObject>("primary_artist");

                            if (primary_artist.ContainsKey("name"))
                                artist_name = primary_artist.Value<string>("name");
                        }

                        if (song_response.ContainsKey("album"))
                        {
                            var song_album = song_response.Value<Newtonsoft.Json.Linq.JObject>("album");

                            if (song_album != null)
                            {
                                if (song_album.ContainsKey("name"))
                                    album_name = song_album.Value<string>("name");
                            }
                        }

                        if (song_response.ContainsKey("url"))
                            url = song_response.Value<string>("url");

                        try { song_daterelease = Convert.ToDateTime(song_daterelease).Year.ToString(); }
                        catch (Exception ex) { MessageBox.Show(ex.ToString()); }

                        song_lyrics = GetLyrics_FromGenius(url);

                        song = new Song(song_title, artist_name, album_name, song_lyrics, null, "");

                        MessageBox.Show(song.ToString());

                    }
                    else
                    {
                        string filename = "song_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".json";

                        string errorMsg = "Error code: " + Answer.meta.status + "\n";
                        errorMsg += "Error Message: " + Answer.meta.message + "\n";
                        errorMsg += "Errore in the response json file, check the file \"" + filename + "\"";

                        MessageBox.Show(errorMsg);

                        StreamWriter sw = new StreamWriter(filename, false);
                        sw.Write(value);
                        sw.Close();

                    }

                }
            }
            catch (Exception exception)
            {
                StaticData.ShowException(exception);

                string filename = "song_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".json";

                MessageBox.Show("Errore in the response json file, check the file \"" + filename + "\"");

                StreamWriter sw = new StreamWriter(filename, false);
                sw.Write(value);
                sw.Close();
            }

            return song;
        }

        public static string GetLyrics_FromGenius(string url)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string htmlCode = client.DownloadString(url);

                    StreamWriter sw = new StreamWriter("html.html", false);
                    sw.WriteLine("<!-- " + url + " -->");
                    sw.WriteLine(htmlCode);
                    sw.Close();

                    HtmlAgilityPack.HtmlDocument dc = new HtmlAgilityPack.HtmlDocument();
                    dc.LoadHtml(htmlCode);

                    return dc.DocumentNode.SelectSingleNode("//div[@id=\"lyrics-root-pin-spacer\"]").InnerText;
                }
            }
            catch (Exception exception)
            {
                StaticData.ShowException(exception);
                return "";
            }
        }


        public static Song GetSong_FromSpotify()
        {
            return new Song("");
        }
    }
}
