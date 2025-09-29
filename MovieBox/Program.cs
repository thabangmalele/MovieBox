using System;
using NAudio.Wave;
using KustoLoco.Rendering.SixelSupport;
internal class Program
{
    private static void Main(string[] args)
    {
        DisplayHeader();

        var path = "D:/media/Music/Genres/METAL/TOOL - 10,000 Days/01 TOOL - Vicarious.mp3";

         var audioFile = new AudioFileReader(path);
         var outputDevice = new WaveOutEvent();

        outputDevice.Init(audioFile);
        outputDevice.Play();

        // wait until playback stops
        while(outputDevice.PlaybackState == PlaybackState.Playing)
        {
            System.Threading.Thread.Sleep(1000); // Chill until done
        }

        Console.WriteLine("Playback Finished.");
    }

    private static void DisplayHeader()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@"
  __  __            _      ____            
 |  \/  |          (_)    |  _ \           
 | \  / | _____   ___  ___| |_) | _____  __
 | |\/| |/ _ \ \ / / |/ _ \  _ < / _ \ \/ /
 | |  | | (_) \ V /| |  __/ |_) | (_) >  < 
 |_|  |_|\___/ \_/ |_|\___|____/ \___/_/\_\
                                           
Terminal tool for browsing and launching your
local media collection — complete with optional 
subtitle preview,metadata reading, and seamless 
playback.

");
        Console.WriteLine("╔════════════════════════════════════════════╗\r\n║                MOVIE BOX                   ║\r\n╚════════════════════════════════════════════╝\r\n\r\n");
        Console.WriteLine("Press any key to continue. . .");
        Console.ReadKey();
        Console.Clear();
        Console.ResetColor();
    }
}
