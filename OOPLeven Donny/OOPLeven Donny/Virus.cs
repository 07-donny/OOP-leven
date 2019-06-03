using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOPLeven_Donny
{
    class Virus : Lifeform
    {
        public Virus(int x, int y) : base(x, y){}

        public override void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillRectangle(b, XPos, YPos, 10, 10);
        }

        public override void DecideWhatToDo()
        {
            Random r = new Random();
            ticksBusy = r.Next(5, 50);
            xDirection = r.Next(-4, 5);
            yDirection = r.Next(-4, 5);
        }
    }
}
