internal class Program
{
    private static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("  __  __            _      ____             \r\n |  \\/  |          (_)    |  _ \\            \r\n | \\  / | _____   ___  ___| |_) | _____  __ \r\n | |\\/| |/ _ \\ \\ / / |/ _ \\  _ < / _ \\ \\/ / \r\n | |  | | (_) \\ V /| |  __/ |_) | (_) >  <  \r\n |_|  |_|\\___/ \\_/ |_|\\___|____/ \\___/_/\\_\\ \r\n                                            \r\n                                            ");
        Console.WriteLine(@"
Terminal tool for browsing and launching your
local media collection — complete with optional 
subtitle preview,metadata reading, and seamless 
playback.

");
        Console.WriteLine("╔════════════════════════════════════════════╗\r\n║                MOVIE BOX                   ║\r\n╚════════════════════════════════════════════╝\r\n\r\n");
        Console.WriteLine("Press any key to continue. . .");
        Console.ReadKey();
        Console.Clear();
    }
}