using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLeven_Donny
{
    class Pacman : Lifeform
    {
        public Pacman(int x, int y) : base(x, y)
        {

        }

        public void DrawImagePoint(PaintEventArgs e)
        {
            Image newImage = Image.FromFile("cell.png");
            Point ulCorner = new Point(100, 100);

            e.Graphics.DrawImage(newImage,ulCorner);
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
