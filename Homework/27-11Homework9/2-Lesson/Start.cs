namespace ItAcademiaCsh.Homework._27_11Homework9._2_Lesson;

public class Start
{
    public void StartingProgram()
    {
        var devices = new List<IMultimediaDevice>
        {
            new MP3Player(),
            new DVDPlayer(),
            new Radio()
        };

        var continueProgram = true;
        while (continueProgram)
        {
            Console.WriteLine("Выберите устройство для воспроизведения:");
            for (var i = 0; i < devices.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {devices[i].GetType().Name}");
            }

            var choice = int.Parse(Console.ReadLine());
            IMultimediaDevice selectedDevice = devices[choice - 1];

            ControlDevice(selectedDevice);

            Console.WriteLine("Нажмите клавишу Esc чтобы выйти или любую другую клавишу чтобы продолжить");
            if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                continueProgram = false;
            Console.Clear();
        }
    }

    private void ControlDevice(IMultimediaDevice device)
    {
        Console.Clear();
        Console.WriteLine("1. Воспроизведение\n2. Остановка\n3. Пауза\n4. Следующий трек\n5. Увеличение громкости" +
                          "\n6. Уменьшение громкости\nEsc - отмена");
        Console.Write("Введите номер действия: ");

        var continueProgram = true;
        while (continueProgram)
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                    device.Play();
                    break;
                case ConsoleKey.D2:
                    device.Stop();
                    break;
                case ConsoleKey.D3:
                    device.Pause();
                    break;
                case ConsoleKey.D4:
                    device.Next();
                    break;
                case ConsoleKey.D5:
                    device.IncreaseVolume();
                    break;
                case ConsoleKey.D6:
                    device.DecreaseVolume();
                    break;
                case ConsoleKey.Escape:
                    continueProgram = false;
                    break;
            }
        }
    }
}