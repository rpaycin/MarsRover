using System;

namespace MarsRoverSolution.Entity
{
    public class Rover
    {

        public int x { get; set; } // Rover x
        public int y { get; set; } // Rover y
        private int row_max;
        private int col_max;

        public string dir; // Rover direction
        string[] str_dir = { "N", "E", "S", "W" };

        public Rover(string loc, int row_max, int col_max)
        {
            string[] str = loc.Split(" ");
            this.x = Int32.Parse(str[0]);
            this.y = Int32.Parse(str[1]);
            dir = str[2];
            this.row_max = row_max;
            this.col_max = col_max;
        }

        public void TurnLeft()
        {
            int index = Array.IndexOf(str_dir, dir);
            if (index > -1 && index < str_dir.Length)
            {
                dir = str_dir[(index - 1 + str_dir.Length) % str_dir.Length];
            }
            else
            {
                // throw new ArgumentException();  
            }
        }

        public void TurnRight()
        {
            int index = Array.IndexOf(str_dir, dir);
            if (index > -1 && index < str_dir.Length)
            {
                dir = str_dir[(index + 1) % str_dir.Length];
            }
            else
            {
                // throw new ArgumentException();  
            }
        }

        public void Move()
        {
            switch (dir)
            {
                case "N":
                    if (y < row_max)
                        y = y + 1;
                    break;
                case "W":
                    if (x > 0)
                        x = x - 1;
                    break;
                case "S":
                    if (y > 0)
                        y = y - 1;
                    break;
                case "E":
                    if (x < col_max)
                        x = x + 1;
                    break;
                default:
                    // throw new ArgumentException();
                    break;
            }
        }

        public void Move(string strMessages)
        {
            char[] messages = strMessages.ToCharArray();

            for (int i = 0; i < messages.Length; i++)
            {
                switch (messages[i])
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'M':
                        Move();
                        break;
                    default:
                        // throw new ArgumentException();
                        break;
                }
            }
        }
    }
}
