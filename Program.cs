class Program
{
    static int[] oneOctave = new int[] { 261, 293, 329, 349, 392, 440, 493 };
    static int[] twoOctave = new int[] { 523, 587, 659, 698, 783, 880, 987 };

    static int[] vOctave = oneOctave;

    static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать");
        PlayPiano();
    }

    static void PlaySound(int frequency, int duration)
    {
        Console.Beep(frequency, duration);
    }

    static int[] ChangeOctave(ConsoleKey key)
    {
        switch (key)
        {
            case ConsoleKey.F1:
                return oneOctave;
            case ConsoleKey.F2:
                return twoOctave;
            default:
                return vOctave;
        }
    }

    static void PlayPiano()
    {
        while (true)
        {
            Console.WriteLine("Выберите октаву: F1, F2");
            ConsoleKey key = Console.ReadKey(true).Key; 
            vOctave = ChangeOctave(key);

            Console.WriteLine("\nУправление: белые клавиши - A, S, D, F, G, H, J");
            Console.WriteLine("Черные клавиши - W, E, R, T, Y");
            Console.WriteLine("Для выхода нажмите Esc\n");

            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true); 
                if (keyInfo.Key == ConsoleKey.Escape)
                    return;

                int index = -1;
                switch (keyInfo.Key)
                {
                    case ConsoleKey.A:
                        index = 0;
                        break;
                    case ConsoleKey.S:
                        index = 1;
                        break;
                    case ConsoleKey.D:
                        index = 2;
                        break;
                    case ConsoleKey.F:
                        index = 3;
                        break;
                    case ConsoleKey.G:
                        index = 4;
                        break;
                    case ConsoleKey.H:
                        index = 5;
                        break;
                    case ConsoleKey.J:
                        index = 6;
                        break;
                    case ConsoleKey.W:
                        index = 0;
                        break;
                    case ConsoleKey.E:
                        index = 1;
                        break;
                    case ConsoleKey.R:
                        index = 5;
                        break;
                    case ConsoleKey.T:
                        index = 3;
                        break;
                    case ConsoleKey.Y:
                        index = 4;
                        break;

                }
                if (index != -1)
                {
                    PlaySound(vOctave[index], 500);
                }
            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}