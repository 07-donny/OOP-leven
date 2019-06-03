using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace OOPLeven_Donny
{
    class Amoebe : Lifeform
    {
        public Amoebe(int x, int y) : base(x, y)
        {

        }

        public override void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            Random r = new Random();
            int size = r.Next(10, 20);
            g.FillEllipse(b, XPos - size / 2, YPos - size / 2, size, size);

        }
    }
}
