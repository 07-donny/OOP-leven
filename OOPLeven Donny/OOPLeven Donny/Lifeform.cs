using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace OOPLeven_Donny
{
    class Lifeform
    {
        protected int ticksBusy;
        protected int xDirection;
        protected int yDirection;

        public Color Color { get; set; }
        public int XPos { get; set; }
        public int YPos { get; set; }
        
        public Lifeform(int x, int y)
        {
            Random r = new Random();
            Color = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));

            XPos = x;
            YPos = y;
            DecideWhatToDo();
        }

        public virtual void DecideWhatToDo()
        {
            Random r = new Random();
            ticksBusy = r.Next(25, 250);
            xDirection = r.Next(-1, 2);
            yDirection = r.Next(-1, 2);
        }

        public void Update()
        {
            if(ticksBusy <= 0)
            {
                DecideWhatToDo();
            }
            XPos += xDirection;
            YPos += yDirection;

            ticksBusy--;
        }

        public virtual void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, XPos, YPos, 10, 10);

        }
    }
}
