using MarsRover.Entity;
using MarsRover.Entity.Utils;
using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "5 5";
            string input2 = "1 2 N";
            string input3 = "LMLMLMLMM";
            string input4 = "3 3 E";
            string input5 = "MMRMMRMRRM";

            string[] str = input1.Split(Constants.WhiteSpace);
            int row = Convert.ToInt32(str[0]);
            int col = Convert.ToInt32(str[1]);

            var rover1 = new Rover(input2, row, col);
            rover1.Move(input3);
            rover1.DisplayPosition();

            var rover2 = new Rover(input4, row, col);
            rover2.Move(input5);
            rover2.DisplayPosition();

            Console.ReadLine();
        }
    }
}
