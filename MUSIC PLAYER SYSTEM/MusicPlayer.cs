using System;
using System.Collections.Generic;
using System.Text;

namespace MUSIC_PLAYER_SYSTEM
{
    internal class MusicPlayer
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string CurrentSong { get; set; }
        public bool IsPlaying { get; set; }
        public int BatteryPercent { get; set; }
        public int Volume {  get; set; }
        public MusicPlayer(string brand, string model, int volume, string currentSong, bool isPlaying, int batteryPercent)
        {
            Brand = brand;
            Model = model;
            Volume = volume;
            CurrentSong = currentSong;
            IsPlaying = isPlaying;
            BatteryPercent = batteryPercent;
        }
        public void Play()
        {
            if (CurrentSong == null)
            {
                Console.WriteLine("Mahni yoxdur");
                return;
            }
            if (IsPlaying)
                Console.WriteLine("Song is already playing!");
            IsPlaying = true;
        }
        public void Pause()
        {
            if (CurrentSong == null)
            {
                Console.WriteLine("Mahni yoxdur");
                return;
            }
            if (!IsPlaying)
                Console.WriteLine("Song is already paused!");
            IsPlaying = false;
        }
        public void IncreaseVolume()
        {
            Volume = Math.Min(Volume + 1, 100);
        }
        public void DecreaseVolume()
        {
            Volume = Math.Max(Volume - 1, 0);
        }
        public void ChangeSong(string songName)
        {
            CurrentSong = songName;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, CurrentSong: {CurrentSong}, Is Playing: {IsPlaying}, BatteryPercent: {BatteryPercent}, Volume: {Volume}");
        }
        public override string ToString()
        {
            return $"Brand: {Brand}, Model: {Model}, CurrentSong: {CurrentSong}, Is Playing: {IsPlaying}, BatteryPercent: {BatteryPercent}, Volume: {Volume}";
        }
    }
}