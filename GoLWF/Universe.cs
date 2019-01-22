using System;
using System.Collections.Generic;
using System.Text;

namespace GoLWF
{
    public class Universe
    {
        public int Dimension { get; private set; }
        public int Width =>  Dimension;
        public int Height => Dimension;
        public int Age { get; private set; }
        public int Population { get; private set; }
        public int Vary { get; private set; }

        public enum TypeOfGenesis { Chaos, Heaven, Emptiness };


        // Matrixes for state of cells in the universe
        public CellState[,] CurrentState { get; private set; }
        public CellState[,] NextState { get; private set; }

        public Universe(ushort dimension)
        {
            Dimension = dimension;

            CurrentState = new CellState[Width, Height];
            NextState = new CellState[Width, Height];
            Age = 0;
            Population = 0;
            Vary = 0;
        }

        public CellState[,] GetCellsState()
        {
            return CurrentState;
        }

        public void ShowOnConsole()
        {
            Console.Clear();
            string _row;

            for (int y = 0; y < Height; y++)
            {
                _row = "";
                for (int x = 0; x < Width; x++)
                {
                    _row = _row + (CurrentState[x, y] == CellState.Alive ? "O" : ".");
                }
                Console.WriteLine(_row);
            }
        }

        public void Genesis(TypeOfGenesis typeOfGenesis, int chaosProbability)
        {
            Random rand = new Random();
            Age = 0;
            Population = 0;
            Vary = 0;

            switch (typeOfGenesis)
            {
                case TypeOfGenesis.Chaos:
                    // For all cells in the universe
                    for (int y = 0; y < Height; y++)
                    {
                        for (int x = 0; x < Width; x++)
                        {
                            // Set a cell state based on random
                            CurrentState[x, y] = rand.Next(100) < chaosProbability ? CellState.Alive : CellState.Dead;
                            Population += CurrentState[x, y] == CellState.Alive ? 1 : 0;
                        }
                    }
                    break;
                case TypeOfGenesis.Heaven:
                    break;
                case TypeOfGenesis.Emptiness:
                    break;
            }
        }

        // Evolve all cells in the universe
        public void Evolve()
        {
            Population = 0;
            Vary = 0;
            // For all cells in the universe
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    // Get a new cell state based on rules
                    NextState[x, y] = Rules(CurrentState[x, y], LiveNeighbor(x, y));
                    Population += NextState[x, y] == CellState.Alive ? 1 : 0;
                    Vary += CurrentState[x, y] != NextState[x, y] ? 1 : 0;
                }
            }

            // Copy the next state to the current state
            CurrentState = NextState.Clone() as CellState[,];

            Age += 1;

            //for (int y = 0; y < Height; y++)
            //{
            //    for (int x = 0; x < Width; x++)
            //    {
            //        // Get a new cell state based on rules
            //        CurrentState[x, y] = NextState[x, y];
            //    }
            //}
        }

        // CA Rules S23/B3
        public CellState Rules(CellState cellState, int liveNeighbor)
        {
            bool _beAlive;
            // Everybody dies
            _beAlive = false;
            // Alive cell stays alive
            if (liveNeighbor == 2 && cellState == CellState.Alive) { _beAlive = true; }
            // Cell stays alive, or a new cell is born
            if (liveNeighbor == 3) { _beAlive = true; }
            // If underpopulated or overpopulated, cell dies or no new is born
            if (liveNeighbor < 2 || liveNeighbor > 3) { _beAlive = false; }
            
            // Returning decision by rules
            return _beAlive ? CellState.Alive : CellState.Dead;
        }

        public int LiveNeighbor(int x, int y)
        {
            int _liveNeighbor = 0;
            int _x = 0;
            int _y = 0;

            // -1,-1|-1, 0|-1, 1
            //  0,-1|     | 0, 1
            //  1,-1| 1, 0| 1, 1
            //
            for (int j = -1; j < 2; j++)
            {
                for (int i = -1; i < 2; i++)
                {
                    _x = x + i;
                    _y = y + j;
                    // if neighbor's position is out of bounds skip to next
                    if (IsOutOfBounds(_x, _y)) { continue; }
                    // if neighbor's position is verified one skip to next
                    if ((x == _x) && (y == _y)) { continue; }
                    // if cell is alive on neighbor's position, count it
                    if (IsCellAlive(_x, _y))
                    {
                        _liveNeighbor++;
                    }
                }
            }
            return _liveNeighbor;
        }

        private bool IsOutOfBounds(int x, int y)
        {
            return x < 0 || x > Width - 1 || y < 0 || y > Height - 1;
        }

        public bool IsCellAlive(int x, int y)
        {
            return CurrentState[x, y] == CellState.Alive;
        }

    }
}