using System;
using MarsRover.Entity.Utils;
using MarsRover.Entity.Extension;

namespace MarsRover.Entity
{
    public class Rover
    {
        public int X { get; set; }

        public int Y { get; set; }

        public string Direction;

        private int maxRow;

        private int maxCol;

        private Rover() { }

        public Rover(string location, int maxRow, int maxCol)
        {
            string[] splittedLocations = location.Split(Constants.WhiteSpace);

            if (splittedLocations != null && splittedLocations.Length == 3)
            {
                this.X = Convert.ToInt32(splittedLocations[0]);
                this.Y = Convert.ToInt32(splittedLocations[1]);

                Direction = splittedLocations[2];

                this.maxRow = maxRow;
                this.maxCol = maxCol;
            }
        }

        public void Move(string intructions)
        {
            foreach (char instruction in intructions.ToCharArray())
            {
                if (instruction == Instruction.Left.GetDescription()[0])
                {
                    TurnLeft();
                }
                else if (instruction == Instruction.Rigth.GetDescription()[0])
                {
                    TurnRight();
                }
                else if (instruction == Instruction.Move.GetDescription()[0])
                {
                    Move();
                }
            }
        }

        public void DisplayPosition()
        {
            Console.WriteLine(string.Format("{0} {1} {2}", X, Y, Direction));
        }

        private void TurnLeft()
        {
            int index = Array.IndexOf(Constants.Directions, Direction);
            if (index > -1 && index < Constants.Directions.Length)
            {
                Direction = Constants.Directions[(index - 1 + Constants.Directions.Length) % Constants.Directions.Length];
            }
        }

        private void TurnRight()
        {
            int index = Array.IndexOf(Constants.Directions, Direction);

            if (index > -1 && index < Constants.Directions.Length)
            {
                Direction = Constants.Directions[(index + 1) % Constants.Directions.Length];
            }
        }

        private void Move()
        {
            if (Direction == Entity.Direction.North.GetDescription() && Y < maxRow)
            {
                Y = Y + 1;
            }
            else if (Direction == Entity.Direction.West.GetDescription() && X > 0)
            {
                X = X - 1;
            }
            else if (Direction == Entity.Direction.South.GetDescription() && Y > 0)
            {
                Y = Y - 1;
            }
            else if (Direction == Entity.Direction.East.GetDescription() && X < maxCol)
            {
                X = X + 1;
            }
        }
    }
}
