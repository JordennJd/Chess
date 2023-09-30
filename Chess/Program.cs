
using Chess;

class Program
{
    public static void Main()
    {
        PlayGround playGround = new PlayGround();
        playGround.PrintBoard();
        while (true)
        {
            Console.WriteLine("Выбирите фигуру которую хотите сдвинуть");
            int figureRow; 
            int figureColumn; 
            Console.WriteLine("Введите колонну фигуры");

            if(!int.TryParse(Console.ReadLine(),out figureRow))
            {
                Console.WriteLine("неверные данные");
                continue;
            }
            Console.WriteLine("Введите строку фигуры");

            if(!int.TryParse(Console.ReadLine(),out figureColumn))
            {
                Console.WriteLine("неверные данные");
                continue;
            }
            int placeRow; 
            int placeColumn; 
            Console.WriteLine("Выбирите место на которое хотите сдвинуть");
            Console.WriteLine("Введите колонну места");

            if(!int.TryParse(Console.ReadLine(),out placeRow))
            {
                Console.WriteLine("неверные данные");
                continue;
            }
            Console.WriteLine("Введите строку места");

            if(!int.TryParse(Console.ReadLine(),out placeColumn))
            {
                Console.WriteLine("неверные данные");
                continue;
            }

            if (!playGround.MoveFigure(figureRow, figureColumn, placeRow, placeColumn))
            {
                Console.WriteLine("неверные данные");

            }
            playGround.PrintBoard();

        }
    }
}