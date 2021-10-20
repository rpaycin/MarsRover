using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover.Entity.Utils;
using MarsRover.Entity;

namespace MarsRover.Test
{
    [TestClass]
    public class RoverTest
    {
        [TestMethod]
        public void Rover1Test()
        {
            string input2 = "1 2 N";
            string input3 = "LMLMLMLMM";

            var information = GetRowCol();
            var rover1 = new Rover(input2, information.Item1, information.Item1);
            rover1.Move(input3);

            Assert.AreEqual(1, rover1.X);
            Assert.AreEqual(3, rover1.Y);
            Assert.AreEqual("N", rover1.Direction);
        }

        [TestMethod]
        public void Rover2Test()
        {
            string input4 = "3 3 E";
            string input5 = "MMRMMRMRRM";

            var information = GetRowCol();
            var rover1 = new Rover(input4, information.Item1, information.Item1);
            rover1.Move(input5);

            Assert.AreEqual(5, rover1.X);
            Assert.AreEqual(1, rover1.Y);
            Assert.AreEqual("E", rover1.Direction);
        }

        Tuple<int, int> GetRowCol()
        {
            string input1 = "5 5";

            string[] str = input1.Split(Constants.WhiteSpace);
            int row = Convert.ToInt32(str[0]);
            int col = Convert.ToInt32(str[1]);

            return Tuple.Create<int, int>(row, col);
        }
    }
}
