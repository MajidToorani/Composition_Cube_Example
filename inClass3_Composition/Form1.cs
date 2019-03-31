using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//-----------------------------------
//Majid Tooranisama
//# 7725070
//inClass# 3
//2018-07-10
//-----------------------------------

namespace inClass3_Composition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Point
        {
            private int x;
            private int y;
            private int z;
            public int X
            {
                set { x = value; }
                get { return x; }
            }
            public int Y
            {
                set { y = value; }
                get { return y; }
            }
            public int Z
            {
                set { z = value; }
                get { return z; }
            }
            public Point(int a,int b,int c)
            {
                x = a;
                y = b;
                z = c;
            }
        }
        public class Line
        {
            private Point point1;
            private Point point2;
            public Point Point1
            {
                set { point1 = value; }
                get { return point1; }
            }
            public Point Point2
            {
                set { point2 = value; }
                get { return point2; }
            }
        }
        public class Box
        {
            private Line ln1;
            private Line ln2;
            private Line ln3;
            private Line ln4;
            private Line ln5;
            private Line ln6;
            private Line ln7;
            private Line ln8;
            private Line ln9;
            private Line ln10;
            private Line ln11;
            private Line ln12;
            public Line Ln1
            {
                set { ln1 = value; }
                get { return ln1; }
            }
            public Line Ln2
            {
                set { ln2 = value; }
                get { return ln2; }
            }
            public Line Ln3
            {
                set { ln3 = value; }
                get { return ln3; }
            }
            public Line Ln4
            {
                set { ln4 = value; }
                get { return ln4; }
            }
            public Line Ln5
            {
                set { ln5 = value; }
                get { return ln5; }
            }
            public Line Ln6
            {
                set { ln6 = value; }
                get { return ln6; }
            }
            public Line Ln7
            {
                set { ln7 = value; }
                get { return ln7; }
            }
            public Line Ln8
            {
                set { ln8= value; }
                get { return ln8; }
            }
            public Line Ln9
            {
                set { ln9 = value; }
                get { return ln9; }
            }
            public Line Ln10
            {
                set { ln10 = value; }
                get { return ln10; }
            }
            public Line Ln11
            {
                set { ln11 = value; }
                get { return ln11; }
            }
            public Line Ln12
            {
                set { ln12 = value; }
                get { return ln12; }
            }
        }
        Box myBox = new Box();
        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            myBox.Ln1 = new Line();
            myBox.Ln2 = new Line();
            myBox.Ln3 = new Line();
            myBox.Ln4 = new Line();
            myBox.Ln5 = new Line();
            myBox.Ln6 = new Line();
            myBox.Ln7 = new Line();
            myBox.Ln8 = new Line();
            myBox.Ln9 = new Line();
            myBox.Ln10 = new Line();
            myBox.Ln11 = new Line();
            myBox.Ln12 = new Line();
            try
            {
                myBox.Ln1.Point1 = new Point(Convert.ToInt16(textBoxX1.Text), Convert.ToInt16(textBoxY1.Text), Convert.ToInt16(textBoxZ1.Text));
                myBox.Ln1.Point2 = new Point(Convert.ToInt16(textBoxX2.Text), Convert.ToInt16(textBoxY2.Text), Convert.ToInt16(textBoxZ2.Text));
                myBox.Ln2.Point1 = new Point(Convert.ToInt16(textBoxX2.Text), Convert.ToInt16(textBoxY2.Text), Convert.ToInt16(textBoxZ2.Text));
                myBox.Ln2.Point2 = new Point(Convert.ToInt16(textBoxX3.Text), Convert.ToInt16(textBoxY3.Text), Convert.ToInt16(textBoxZ3.Text));
                myBox.Ln3.Point1 = new Point(Convert.ToInt16(textBoxX3.Text), Convert.ToInt16(textBoxY3.Text), Convert.ToInt16(textBoxZ3.Text));
                myBox.Ln3.Point2 = new Point(Convert.ToInt16(textBoxX4.Text), Convert.ToInt16(textBoxY4.Text), Convert.ToInt16(textBoxZ4.Text));
                myBox.Ln4.Point1 = new Point(Convert.ToInt16(textBoxX4.Text), Convert.ToInt16(textBoxY4.Text), Convert.ToInt16(textBoxZ4.Text));
                myBox.Ln4.Point2 = new Point(Convert.ToInt16(textBoxX1.Text), Convert.ToInt16(textBoxY1.Text), Convert.ToInt16(textBoxZ1.Text));
                myBox.Ln5.Point1 = new Point(Convert.ToInt16(textBoxX1.Text), Convert.ToInt16(textBoxY1.Text), Convert.ToInt16(textBoxZ1.Text));
                myBox.Ln5.Point2 = new Point(Convert.ToInt16(textBoxX5.Text), Convert.ToInt16(textBoxY5.Text), Convert.ToInt16(textBoxZ5.Text));
                myBox.Ln6.Point1 = new Point(Convert.ToInt16(textBoxX2.Text), Convert.ToInt16(textBoxY2.Text), Convert.ToInt16(textBoxZ2.Text));
                myBox.Ln6.Point2 = new Point(Convert.ToInt16(textBoxX6.Text), Convert.ToInt16(textBoxY6.Text), Convert.ToInt16(textBoxZ6.Text));
                myBox.Ln7.Point1 = new Point(Convert.ToInt16(textBoxX3.Text), Convert.ToInt16(textBoxY3.Text), Convert.ToInt16(textBoxZ3.Text));
                myBox.Ln7.Point2 = new Point(Convert.ToInt16(textBoxX7.Text), Convert.ToInt16(textBoxY7.Text), Convert.ToInt16(textBoxZ7.Text));
                myBox.Ln8.Point1 = new Point(Convert.ToInt16(textBoxX4.Text), Convert.ToInt16(textBoxY4.Text), Convert.ToInt16(textBoxZ4.Text));
                myBox.Ln8.Point2 = new Point(Convert.ToInt16(textBoxX8.Text), Convert.ToInt16(textBoxY8.Text), Convert.ToInt16(textBoxZ8.Text));
                myBox.Ln9.Point1 = new Point(Convert.ToInt16(textBoxX5.Text), Convert.ToInt16(textBoxY5.Text), Convert.ToInt16(textBoxZ5.Text));
                myBox.Ln9.Point2 = new Point(Convert.ToInt16(textBoxX6.Text), Convert.ToInt16(textBoxY6.Text), Convert.ToInt16(textBoxZ6.Text));
                myBox.Ln10.Point1 = new Point(Convert.ToInt16(textBoxX6.Text), Convert.ToInt16(textBoxY6.Text), Convert.ToInt16(textBoxZ6.Text));
                myBox.Ln10.Point2 = new Point(Convert.ToInt16(textBoxX7.Text), Convert.ToInt16(textBoxY7.Text), Convert.ToInt16(textBoxZ7.Text));
                myBox.Ln11.Point1 = new Point(Convert.ToInt16(textBoxX7.Text), Convert.ToInt16(textBoxY7.Text), Convert.ToInt16(textBoxZ7.Text));
                myBox.Ln11.Point2 = new Point(Convert.ToInt16(textBoxX8.Text), Convert.ToInt16(textBoxY8.Text), Convert.ToInt16(textBoxZ8.Text));
                myBox.Ln12.Point1 = new Point(Convert.ToInt16(textBoxX8.Text), Convert.ToInt16(textBoxY8.Text), Convert.ToInt16(textBoxZ8.Text));
                myBox.Ln12.Point2 = new Point(Convert.ToInt16(textBoxX5.Text), Convert.ToInt16(textBoxY5.Text), Convert.ToInt16(textBoxZ5.Text));

                labelPt1.Text = "(" + myBox.Ln1.Point1.X + " , " + myBox.Ln1.Point1.Y + " , " + myBox.Ln1.Point1.Z + ")";
                labelPt2.Text = "(" + myBox.Ln2.Point1.X + " , " + myBox.Ln2.Point1.Y + " , " + myBox.Ln2.Point1.Z + ")";
                labelPt3.Text = "(" + myBox.Ln3.Point1.X + " , " + myBox.Ln3.Point1.Y + " , " + myBox.Ln3.Point1.Z + ")";
                labelPt4.Text = "(" + myBox.Ln4.Point1.X + " , " + myBox.Ln4.Point1.Y + " , " + myBox.Ln4.Point1.Z + ")";
                labelPt5.Text = "(" + myBox.Ln5.Point2.X + " , " + myBox.Ln5.Point2.Y + " , " + myBox.Ln5.Point2.Z + ")";
                labelPt6.Text = "(" + myBox.Ln6.Point2.X + " , " + myBox.Ln6.Point2.Y + " , " + myBox.Ln6.Point2.Z + ")";
                labelPt7.Text = "(" + myBox.Ln7.Point2.X + " , " + myBox.Ln7.Point2.Y + " , " + myBox.Ln7.Point2.Z + ")";
                labelPt8.Text = "(" + myBox.Ln8.Point2.X + " , " + myBox.Ln8.Point2.Y + " , " + myBox.Ln8.Point2.Z + ")";
            }
            catch (Exception)
            {
                MessageBox.Show("Input format is not the correct format, please enter integers only!");
            }
        }
        public double Distance(Point a, Point b)
        {
            double d = 0;
            d = Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2) + Math.Pow(a.Z - b.Z, 2));
            return d;
        }
        private void buttonArea_Click(object sender, EventArgs e)
        {
            try
            {
                double d1 = Distance(myBox.Ln1.Point1, myBox.Ln1.Point2);
                double d2 = Distance(myBox.Ln2.Point1, myBox.Ln2.Point2);
                double d3 = Distance(myBox.Ln6.Point1, myBox.Ln6.Point2);
                double s = Math.Round(2 * ((d1 * d2) + (d1 * d3) + (d2 * d3)), 4);
                labelSurfaceArea.Text = s.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("please enter data for the box's points first");
            }
        }
        private void buttonVolume_Click(object sender, EventArgs e)
        {
            try
            {
                double d1 = Distance(myBox.Ln1.Point1, myBox.Ln1.Point2);
                double d2 = Distance(myBox.Ln2.Point1, myBox.Ln2.Point2);
                double d3 = Distance(myBox.Ln6.Point1, myBox.Ln6.Point2);
                double v = Math.Round(d1 * d2 * d3, 4);
                labelVolume.Text = v.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("please enter data for the box's points first");
            }
        }
        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            textBoxX2.Text = textBoxX1.Text;
            textBoxX5.Text = textBoxX1.Text;
            textBoxX6.Text = textBoxX1.Text;
        }
        private void textBoxY1_TextChanged(object sender, EventArgs e)
        {
            textBoxY4.Text = textBoxY1.Text;
            textBoxY5.Text = textBoxY1.Text;
            textBoxY8.Text = textBoxY1.Text;
        }
        private void textBoxZ1_TextChanged(object sender, EventArgs e)
        {
            textBoxZ2.Text = textBoxZ1.Text;
            textBoxZ3.Text = textBoxZ1.Text;
            textBoxZ4.Text = textBoxZ1.Text;
        }
        private void textBoxY2_TextChanged(object sender, EventArgs e)
        {
            textBoxY3.Text = textBoxY2.Text;
            textBoxY6.Text = textBoxY2.Text;
            textBoxY7.Text = textBoxY2.Text;
        }
        private void textBoxX3_TextChanged(object sender, EventArgs e)
        {
            textBoxX4.Text = textBoxX3.Text;
            textBoxX7.Text = textBoxX3.Text;
            textBoxX8.Text = textBoxX3.Text;
        }
        private void textBoxZ5_TextChanged(object sender, EventArgs e)
        {
            textBoxZ6.Text = textBoxZ5.Text;
            textBoxZ7.Text = textBoxZ5.Text;
            textBoxZ8.Text = textBoxZ5.Text;
        }
    }
}
