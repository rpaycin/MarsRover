using System.ComponentModel;

namespace MarsRover.Entity
{
    public enum Direction
    {
        [Description("N")]
        North,
        [Description("E")]
        East,
        [Description("S")]
        South,
        [Description("W")]
        West
    }

    public enum Instruction
    {
        [Description("L")]
        Left,
        [Description("R")]
        Rigth,
        [Description("M")]
        Move
    }
}
