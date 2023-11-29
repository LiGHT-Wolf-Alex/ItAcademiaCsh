namespace ItAcademiaCsh.Homework._27_11Homework9._2_Lesson;

public class DVDPlayer : IMultimediaDevice
{
    public void Play()
    {
        Console.WriteLine("DVDPlayer: Воспроизведение");
    }

    public void Stop()
    {
        Console.WriteLine("DVDPlayer: Остановка");
    }

    public void Pause()
    {
        Console.WriteLine("DVDPlayer: Пауза");
    }

    public void Next()
    {
        Console.WriteLine("DVDPlayer: Следующий трек");
    }

    public void IncreaseVolume()
    {
        Console.WriteLine("DVDPlayer: Увеличение громкости");
    }

    public void DecreaseVolume()
    {
        Console.WriteLine("DVDPlayer: Уменьшение громкости");
    }
}