using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACG_KursProject_
{
    public partial class Form1 : Form
    {
        int cnt = 0;
        bool mdown;
        String mode;
        int catch_line_lindex;
        bool point_focused;
        int catch_point_lindex;

        //List<Point[]> p;
        Point [][] p;
        
        public Form1()
        {
            mode = "Рисуем";
            point_focused = false;
            catch_point_lindex = -1;
            catch_line_lindex = -1;
            mdown = false;
            InitializeComponent();    
            p = new Point[100][];
            for (int i = 0; i < 100; i++) 
            {
                p[i] = new Point[2];
            }
        }


        private void MainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mdown = false;
            if (mode == "Рисуем")
            {
                p[cnt][1].X = e.X;
                p[cnt][1].Y = e.Y;
                cnt++;
            }
            if (mode == "Изменяем")
            {
                p[catch_line_lindex][catch_point_lindex].X = e.X;
                p[catch_line_lindex][catch_point_lindex].Y = e.Y;
            }
            MainPanel.Invalidate();
            mode = "Рисуем";
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mdown = true;
            if (mode == "Рисуем")
            {
                p[cnt][0].X = e.X;
                p[cnt][0].Y = e.Y;
            }
            if (mode == "Изменяем") 
            {
                p[catch_line_lindex][catch_point_lindex].X = e.X;
                p[catch_line_lindex][catch_point_lindex].Y = e.Y;
            }
        }

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mdown)
            {
                if (mode == "Рисуем")
                {
                    p[cnt][1].X = e.X;
                    p[cnt][1].Y = e.Y;
                }
                if (mode == "Изменяем")
                {
                    p[catch_line_lindex][catch_point_lindex].X = e.X;
                    p[catch_line_lindex][catch_point_lindex].Y = e.Y;
                }
            }
            else
            {
                mode = "Рисуем";
                point_focused = false;
                catch_point_lindex = -1;
                catch_line_lindex = -1;
                for (int i = 0; i < cnt; i++) 
                {
                    if (Math.Abs(p[i][0].X - e.X) < 5 && Math.Abs(p[i][0].Y - e.Y) < 5) 
                    {
                        point_focused = true;
                        catch_point_lindex = 0;
                        catch_line_lindex = i;
                        mode = "Изменяем";
                    }
                    if (Math.Abs(p[i][1].X - e.X) < 5 && Math.Abs(p[i][1].Y - e.Y) < 5)
                    {
                        point_focused = true;
                        catch_point_lindex = 1;
                        catch_line_lindex = i;
                        mode = "Изменяем";
                    }
                }
            }
            MainPanel.Invalidate();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            /*
            // Create pen.
            Pen blackPen = new Pen(Color.Black);

            // Create points for curve.
            Point start = new Point(100, 100);
            Point control1 = new Point(200, 10);
            Point control2 = new Point(350, 50);
            Point end = new Point(500, 100);

            // Draw arc to screen.
            g.DrawBezier(blackPen, start, control1, control2, end);//*/

            /*
            // Create pen.
            Pen blackPen = new Pen(Color.Black);

            // Create location and size of ellipse.
            int x = 200;
            int y = 200;
            int width = 200;
            int height = 100;

            // Draw ellipse to screen.
            e.Graphics.DrawEllipse(blackPen, x, y, width, height);//*/



            if (point_focused) 
            {
                g.DrawRectangle(new Pen(Color.Red), p[catch_line_lindex][catch_point_lindex].X - 5, p[catch_line_lindex][catch_point_lindex].Y - 5, 10, 10);
            }
            for (int i = 0; i < cnt; i++) 
            {
                g.DrawLine(new Pen(Color.Black), p[i][0].X, p[i][0].Y, p[i][1].X, p[i][1].Y);
            }
            if (mdown) 
            {
                g.DrawLine(new Pen(Color.Black), p[cnt][0].X, p[cnt][0].Y, p[cnt][1].X, p[cnt][1].Y);
                //доп фигуры для отрисовки : кривые бизье , элипс , прямоугольник (Rectangle), многоугольник (Polygon)
            }
        }

        private void MainPanel_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(String.Format("X : {0} ; Y : {1}", e.Location.X, e.Location.Y));
        }
    }
}
