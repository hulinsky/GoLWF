using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GoLWF
{
    class Player
    {
        private Universe universe;
        private const ushort sizeOfUniverse = 50;
        private const int velikost = 6;
        private const int mezera = 2;
        private int[] speed = new int[] { 1, 100, 500 };

        public Player()
        {
            universe = new Universe(sizeOfUniverse);
            universe.Genesis(Universe.TypeOfGenesis.Chaos,10);
        }

        public void Show (Graphics g)
        {
            Brush brush;

            CellState[,] cells = universe.GetCellsState();

            for (int j = 0; j < cells.GetLength(1); j++)
            {
                for (int i = 0; i < cells.GetLength(0); i++)
                {
                    if (cells[i, j] == CellState.Alive)
                        brush = Brushes.Black;
                    else
                        brush = Brushes.White;
                    g.FillRectangle(brush, i * (velikost + mezera), j * (velikost + mezera), velikost, velikost);
                }
            }
        }

        public void Move()
        {
            universe.Evolve();
        }

        public int GetNumberOfMoves()
        {
            return universe.Age;
        }

        public int GetNumberOfPopulation()
        {
            return universe.Population;
        }

        public int GetNumberOfVary()
        {
            return universe.Vary;
        }

        public void Genesis(Universe.TypeOfGenesis typeOfGenesis, int chaosProbability)
        {
            universe.Genesis(typeOfGenesis, chaosProbability);
        }

        public int GetPlayerSpeed(int speedIndex)
        {
            return speed[speedIndex];
        }

    }
}
