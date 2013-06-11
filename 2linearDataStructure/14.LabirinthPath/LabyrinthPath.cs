using System;
using System.Collections.Generic;
using System.Linq;

class Lybirnth
{
    private static string[,] labyrinth = 
    {
        { "0", "0", "0", "X", "0", "X" },
        { "0", "X", "0", "X", "0", "X" },
        { "0", "*", "X", "0", "X", "0" },
        { "0", "X", "0", "0", "0", "0" },
        { "0", "0", "0", "X", "X", "0" },
        { "0", "0", "0", "X", "0", "X" }
    };

    public struct Coordinate
    {
        public int X;
        public int Y;
        public int Value;

        public Coordinate(int x, int y, int value)
        {
            this.X = x;
            this.Y = y;
            this.Value = value;
        }
    }

    static void Main(string[] args)
    {
        var startCoordinate = new Coordinate(2, 1, 0);
        FillLabyrinth(labyrinth, startCoordinate);
        PrintLabyirinth(labyrinth);
    }

    private static void FillLabyrinth(string[,] labyrinth, Coordinate startCoordinate)
    {
        Queue<Coordinate> coordinates = new Queue<Coordinate>();
        coordinates.Enqueue(startCoordinate);
        BreathFirstSearch(coordinates, labyrinth);

        //Stack<Coordinate> cordiantes = new Stack<Coordinate>();
        //cordiantes.Push(startCoordinate);
        //DepthFirstSearch(cordiantes, labyrinth);

        FillUnreachableCells(labyrinth);
    }

    private static void BreathFirstSearch(Queue<Coordinate> coordinates, string[,] labyrinth)
    {
        while (coordinates.Count != 0)
        {
            var currentCordinate = coordinates.Dequeue();
            var x = currentCordinate.X;
            var y = currentCordinate.Y;
            var value = currentCordinate.Value + 1;

            if (x + 1 < labyrinth.GetLength(0) && labyrinth[x + 1, y] == "0")
            {
                labyrinth[x + 1, y] = value.ToString();
                coordinates.Enqueue(new Coordinate(x + 1, y, value));
            }

            if (x - 1 >= 0 && labyrinth[x - 1, y] == "0")
            {
                labyrinth[x - 1, y] = value.ToString();
                coordinates.Enqueue(new Coordinate(x - 1, y, value));
            }

            if (y + 1 < labyrinth.GetLength(1) && labyrinth[x, y + 1] == "0")
            {
                labyrinth[x, y + 1] = value.ToString();
                coordinates.Enqueue(new Coordinate(x, y + 1, value));
            }

            if (y - 1 >= 0 && labyrinth[x, y - 1] == "0")
            {
                labyrinth[x, y - 1] = value.ToString();
                coordinates.Enqueue(new Coordinate(x, y - 1, value));
            }
        }
    }

    private static void DepthFirstSearch(Stack<Coordinate> coordinates, string[,] labyrinth)
    {
        while (coordinates.Count != 0)
        {
            var currentCordinate = coordinates.Pop();
            var x = currentCordinate.X;
            var y = currentCordinate.Y;
            var value = currentCordinate.Value + 1;

            if (x + 1 < labyrinth.GetLength(0) && labyrinth[x + 1, y] == "0")
            {
                labyrinth[x + 1, y] = value.ToString();
                coordinates.Push(new Coordinate(x + 1, y, value));
            }

            if (x - 1 >= 0 && labyrinth[x - 1, y] == "0")
            {
                labyrinth[x - 1, y] = value.ToString();
                coordinates.Push(new Coordinate(x - 1, y, value));
            }

            if (y + 1 < labyrinth.GetLength(1) && labyrinth[x, y + 1] == "0")
            {
                labyrinth[x, y + 1] = value.ToString();
                coordinates.Push(new Coordinate(x, y + 1, value));
            }

            if (y - 1 >= 0 && labyrinth[x, y - 1] == "0")
            {
                labyrinth[x, y - 1] = value.ToString();
                coordinates.Push(new Coordinate(x, y - 1, value));
            }
        }
    }

    private static void FillUnreachableCells(string[,] labyrinth)
    {
        for (int row = 0; row < labyrinth.GetLength(0); row++)
        {
            for (int col = 0; col < labyrinth.GetLength(1); col++)
            {
                if (labyrinth[row, col] == "0")
                {
                    labyrinth[row, col] = "u";
                }
            }
        }
    }

    public static void PrintLabyirinth(string[,] labyrinth)
    {
        int rows = labyrinth.GetLength(0);
        int cols = labyrinth.GetLength(1);

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("{0,4}", labyrinth[row, col]);
            }

            Console.WriteLine();
        }
    }
}