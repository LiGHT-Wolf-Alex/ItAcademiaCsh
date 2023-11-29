namespace ItAcademiaCsh.Homework._27_11Homework9._2_Lesson;

public class MP3Player : IMultimediaDevice
{
    public void Play()
    {
        Console.WriteLine("MP3Player: Воспроизведение");
    }

    public void Stop()
    {
        Console.WriteLine("MP3Player: Остановка");
    }

    public void Pause()
    {
        Console.WriteLine("MP3Player: Пауза");
    }

    public void Next()
    {
        Console.WriteLine("MP3Player: Следующий трек");
    }

    public void IncreaseVolume()
    {
        Console.WriteLine("MP3Player: Увеличение громкости");
    }

    public void DecreaseVolume()
    {
        Console.WriteLine("MP3Player: Уменьшение громкости");
    }
}