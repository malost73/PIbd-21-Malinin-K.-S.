﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace WindowsFormsBus
{
    interface ITransport
    {
        void SetPosition(int x, int y, int width, int height);

        void MoveTransport(Direction direction);

        void DrawBus(Graphics g);
    }
}
