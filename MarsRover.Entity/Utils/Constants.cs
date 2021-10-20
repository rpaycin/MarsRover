using MarsRover.Entity.Extension;

namespace MarsRover.Entity.Utils
{
    public class Constants
    {
        public const char WhiteSpace = ' ';

        public static readonly string[] Directions = { Direction.North.GetDescription(), Direction.East.GetDescription(), Direction.South.GetDescription(), Direction.West.GetDescription() };
    }
}
