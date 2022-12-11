﻿namespace HistoryBoothApp.Models
{
    public class UserRecording
    {
        public string fullName { get; set; }

        public string storyDecade { get; set; }

        public bool wasStudent { get; set; }

        //property for the recording mp3 itself
        public TagLib.File recording { get; set; }

        public TagLib.File ReadRecording()
        {
            return recording;
        }

        public bool WriteRecording(TagLib.File value)
        {
            return true;
        }
    }
}
