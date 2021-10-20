using System;
using MarsRover.Entity.Utils;
using MarsRover.Entity.Extension;

namespace MarsRover.Entity
{
    public class Rover
    {
        private int x { get; set; }

        private int y { get; set; }

        private int maxRow;

        private int maxCol;

        private string direction;

        private Rover() { }

        public Rover(string location, int maxRow, int maxCol)
        {
            string[] splittedLocations = location.Split(Constants.WhiteSpace);

            if (splittedLocations != null && splittedLocations.Length == 3)
            {
                this.x = Convert.ToInt32(splittedLocations[0]);
                this.y = Convert.ToInt32(splittedLocations[1]);

                direction = splittedLocations[2];

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
            Console.WriteLine(string.Format("{0} {1} {2}", x, y, direction));
        }

        private void TurnLeft()
        {
            int index = Array.IndexOf(Constants.Directions, direction);
            if (index > -1 && index < Constants.Directions.Length)
            {
                direction = Constants.Directions[(index - 1 + Constants.Directions.Length) % Constants.Directions.Length];
            }
        }

        private void TurnRight()
        {
            int index = Array.IndexOf(Constants.Directions, direction);

            if (index > -1 && index < Constants.Directions.Length)
            {
                direction = Constants.Directions[(index + 1) % Constants.Directions.Length];
            }
        }

        private void Move()
        {
            if (direction == Direction.North.GetDescription() && y < maxRow)
            {
                y = y + 1;
            }
            else if (direction == Direction.West.GetDescription() && x > 0)
            {
                x = x - 1;
            }
            else if (direction == Direction.South.GetDescription() && y > 0)
            {
                y = y - 1;
            }
            else if (direction == Direction.East.GetDescription() && x < maxCol)
            {
                x = x + 1;
            }
        }
    }
}
