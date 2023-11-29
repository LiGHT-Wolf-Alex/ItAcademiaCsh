namespace ItAcademiaCsh.Homework._27_11Homework9._2_Lesson;

public class Radio : IMultimediaDevice
{
    public void Play()
    {
        Console.WriteLine("Radio: Воспроизведение");
    }

    public void Stop()
    {
        Console.WriteLine("Radio: Остановка");
    }

    public void Pause()
    {
        Console.WriteLine("Radio: Пауза");
    }

    public void Next()
    {
        Console.WriteLine("Radio: Следующий трек");
    }

    public void IncreaseVolume()
    {
        Console.WriteLine("Radio: Увеличение громкости");
    }

    public void DecreaseVolume()
    {
        Console.WriteLine("Radio: Уменьшение громкости");
    }
}