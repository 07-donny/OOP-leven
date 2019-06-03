using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLeven_Donny
{
    public partial class Form1 : Form
    {
        List<Lifeform> lijst = new List<Lifeform>();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
            label2.Text = lijst.Count.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            pictureBox1.Invalidate();
            Random r = new Random();
            Amoebe a = new Amoebe(r.Next(0, pictureBox1.Width), r.Next(0, pictureBox1.Height));
            Virus v = new Virus(r.Next(0, pictureBox1.Width), r.Next(0, pictureBox1.Height));
            lijst.Add(a);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var count = lijst.Count;
            for (int i = 0; i < count; i++)
            {
                Amoebe a = new Amoebe(lijst[i].XPos, lijst[i].YPos);
                lijst.Add(a);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (Lifeform a in lijst)
            {
                a.Update();
                a.Draw(g);
            }
        }
              
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
