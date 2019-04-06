﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze.Model.Cell
{
    class Ground : AnyCell
    {
        public const ConsoleColor GroundColor = ConsoleColor.DarkYellow;

        public Ground(int x, int y) : base(x, y, '.', GroundColor) { }

        public override bool TryToStep(Maze maze)
        {
            return true;
        }
    }
}
