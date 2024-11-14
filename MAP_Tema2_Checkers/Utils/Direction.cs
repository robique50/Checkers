using System;
using System.Collections.Generic;

namespace MAP_Tema2_Checkers.Utils
{
    class DirectionControl
    {
        private static readonly Dictionary<Direction, Tuple<int, int>> directionDict = new Dictionary<Direction, Tuple<int, int>>
        {
            { Direction.NW, new Tuple<int, int>(-1, -1) },
            { Direction.NE, new Tuple<int, int>(-1, 1) },
            { Direction.SE, new Tuple<int, int>(1, -1) },
            { Direction.SW, new Tuple<int, int>(1, 1) }
        };

        public static Tuple<int, int> Get(Direction direction)
        {
            return directionDict[direction];
        }
    }

    enum Direction
    {
        NW, NE, SE, SW
    }
}
