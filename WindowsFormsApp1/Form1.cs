using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//2D Shearing
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Point[] originalShape = { new Point(50, 50), new Point(100, 100), new Point(150, 50) };
        private Point[] transformedShape;
        int shX = 2;
        int shY = 3;

        public Form1()
        {
            InitializeComponent();
            transformedShape = new Point[originalShape.Length];
            ApplyShearing();
        }

        private void ApplyShearing()
        {
            // Shear 2 units against x and 3 units against y
            for (int i = 0; i < originalShape.Length; i++)
            {
                int x = originalShape[i].X + shX * originalShape[i].Y;
                int y = originalShape[i].Y + shY * originalShape[i].X;
                transformedShape[i] = new Point(x, y);
            }
        }

        //Shearing
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen1 = new Pen(Color.Black);
            Pen pen2 = new Pen(Color.Blue);
            g.DrawPolygon(pen1, originalShape);
            g.DrawPolygon(pen2, transformedShape);
        }
    }
}
