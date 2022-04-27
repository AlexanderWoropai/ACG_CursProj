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
        string selectetCharacter = "Line";

        bool mdown;
        String mode;
        int catch_character_index;
        bool point_focused;
        int catch_point_lindex;

        List<PointF[]> p;
        List<Character> someCharacters;
        
        public Form1()
        {
            mode = "Рисуем";
            point_focused = false;
            catch_point_lindex = -1;
            catch_character_index = -1;
            mdown = false;

            InitializeComponent();
            p = new List<PointF[]>();
            someCharacters = new List<Character>();
        }


        private void MainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mdown = false;
            if (mode == "Изменяем")
            {
                var point = new PointF();
                point.X = e.X;
                point.Y = e.Y;
                someCharacters[catch_character_index].ChangeCoordinates(catch_point_lindex, point);
            }
            MainPanel.Invalidate();
            mode = "Рисуем";
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mdown = true;
            if (mode == "Изменяем")
            {
                var point = new PointF();
                point.X = e.X;
                point.Y = e.Y;
                someCharacters[catch_character_index].ChangeCoordinates(catch_point_lindex, point);
            }
        }

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mdown)
            {
                if (mode == "Изменяем")
                {
                    var point = new PointF();
                    point.X = e.X;
                    point.Y = e.Y;
                    someCharacters[catch_character_index].ChangeCoordinates(catch_point_lindex, point);
                }
            }
            else
            {
                mode = "Рисуем";
                point_focused = false;
                catch_point_lindex = -1;
                catch_character_index = -1;
                for (int i = 0; i < someCharacters.Count; i++) 
                {
                    var coordinates = someCharacters[i].GetCoordinates();
                    for (int j = 0; j < coordinates.Length; j++) 
                    {
                        if (Math.Abs(coordinates[j].X - e.X) < 5 && Math.Abs(coordinates[j].Y - e.Y) < 5)
                        {
                            point_focused = true;
                            catch_point_lindex = j;
                            catch_character_index = i;
                            mode = "Изменяем";
                            break;
                        }
                    }


                    /*if (Math.Abs(p[i][0].X - e.X) < 5 && Math.Abs(p[i][0].Y - e.Y) < 5) 
                    {
                        point_focused = true;
                        catch_point_lindex = 0;
                        catch_character_index = i;
                        mode = "Изменяем";
                    }
                    if (Math.Abs(p[i][1].X - e.X) < 5 && Math.Abs(p[i][1].Y - e.Y) < 5)
                    {
                        point_focused = true;
                        catch_point_lindex = 1;
                        catch_character_index = i;
                        mode = "Изменяем";
                    }*/
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
                g.DrawRectangle(new Pen(Color.Red), someCharacters[catch_character_index].GetCoordinates(catch_point_lindex).X - 5, someCharacters[catch_character_index].GetCoordinates(catch_point_lindex).Y - 5, 10, 10);
            }
            for (int i = 0; i < someCharacters.Count; i++) 
            {
                someCharacters[i].Paint(e);
                someCharacters[i].PaintBorders(e);
            }
        }

        private void MainPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (selectetCharacter == "") { MessageBox.Show("Выберите тип фигуры!"); return; }
            //MessageBox.Show(String.Format("X : {0} ; Y : {1}", e.Location.X, e.Location.Y));
            CharacterFactory charFactory = new CharacterFactory();
            if (mode == "Рисуем")
            {
                var mas = new PointF();
                mas.X = e.Location.X;
                mas.Y = e.Location.Y;
                someCharacters.Add(charFactory.Create(selectetCharacter, mas));
            }
        }

        private void toolStripMenuItemLine_Click(object sender, EventArgs e)
        {
            selectetCharacter = "Line";
            toolStripMenuItemLine.BackColor = Color.Red;
        }
    }
}
