using System;

interface IMusicPlayer {
    void Play(string song);
    void Pause();
    void Stop();

}
class SpotifyPlayer : IMusicPlayer {
    public void Play(string song) {
        Console.WriteLine("Playing " + song + " on Spotify");
    }
    public void Pause() { Console.WriteLine("Spotify playback paused"); }
    public void Stop() { Console.WriteLine("Spotify playback stopped"); }
}
class AppleMusicPlayer : IMusicPlayer {
    public void Play(string song) {
        Console.WriteLine("Playing " + song + " on Apple Music"); }
    
public void Pause() {
    Console.WriteLine("Apple Music playback paused");
}
public void Stop() {
    Console.WriteLine("Apple music playback stopped");
}

}
internal class Program {
    static void Main(string[] args) {
        IMusicPlayer player = new AppleMusicPlayer();
        IMusicPlayer player2 = new SpotifyPlayer();

        player.Play("Night Changes");
        player.Pause();
        player.Stop();

        player2.Play("Story of My Life");
        player2.Pause();
        player2.Stop();
    }
}