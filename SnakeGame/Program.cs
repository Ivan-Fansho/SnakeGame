using SnakeGame;

Coord gridDimensions = new Coord(50, 20);
Coord snakePossition = new Coord(10, 1);
Random random = new Random();
Coord applePossition = new Coord(random.Next(1, gridDimensions.X-1), random.Next(1, gridDimensions.Y -1));
int frameDelayM = 100;
Direction moveDirection = Direction.Down;
List<Coord> snakePossHistory = new List<Coord>();
int tailLenght = 1;
int score = 0;


while (true)
{
    Console.Clear();
    Console.WriteLine($"Score: {score}");
    snakePossition.ApplyMoveDirection(moveDirection);
    for (int y = 0; y < gridDimensions.Y; y++)
    {
        for (int x = 0; x < gridDimensions.X; x++)
        {
            Coord currentCoord = new Coord(x, y);
            if (snakePossition.Equals(currentCoord) || snakePossHistory.Contains(currentCoord))
            { Console.Write("■"); }

            else if (applePossition.Equals(currentCoord))
            { Console.Write("@"); }

            else if (x == 0 || y == 0 || x == gridDimensions.X - 1 || y == gridDimensions.Y - 1)
                Console.Write("#");
            else 
                Console.Write(" ");

        }
        Console.WriteLine();
    }

    if (snakePossition.Equals(applePossition))
    {
        tailLenght++;
        applePossition = new Coord(random.Next(1, gridDimensions.X - 1), random.Next(1, gridDimensions.Y - 1));
        score++;

    }
    else if (snakePossition.X == 0 || snakePossition.Y == 0 || snakePossition.X == gridDimensions.X-1 || snakePossition.Y == gridDimensions.Y-1 || snakePossHistory.Contains(snakePossition))
    {
        score = 0;
        tailLenght = 1;
        snakePossition = new Coord(10, 1);
        snakePossHistory.Clear();
        moveDirection = Direction.Down;
        continue;
    }

    snakePossHistory.Add(new Coord(snakePossition.X, snakePossition.Y));

    if (snakePossHistory.Count > tailLenght)
    {
        snakePossHistory.RemoveAt(0);
    }

    DateTime time = DateTime.Now;
    while ((DateTime.Now - time).TotalMilliseconds < frameDelayM)
    {
        if (Console.KeyAvailable)
        {
            ConsoleKey key = Console.ReadKey().Key;

            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    moveDirection = Direction.Left;
                    break;
                case ConsoleKey.UpArrow:
                    moveDirection = Direction.Up;
                    break;
                case ConsoleKey.RightArrow:
                    moveDirection = Direction.Right;
                    break;
                case ConsoleKey.DownArrow:
                    moveDirection = Direction.Down;
                    break;
            }

        }

    }

}