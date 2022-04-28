﻿using System;
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
        string selectetCharacter = "";

        bool mdown;
        String mode;
        int catch_character_index;
        bool point_focused;
        int catch_point_lindex;
        List<Character> someCharacters;
        
        public Form1()
        {
            mode = "Рисуем";
            point_focused = false;
            catch_point_lindex = -1;
            catch_character_index = -1;
            mdown = false;

            InitializeComponent();
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
                }
            }
            MainPanel.Invalidate();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

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
            CancelAll();
            toolStripMenuItemLine.BackColor = Color.Red;
        }

        private void toolStripMenuItemBezier_Click(object sender, EventArgs e)
        {
            selectetCharacter = "Bezier";
            CancelAll();
            toolStripMenuItemBezier.BackColor = Color.Red;
        }

        private void toolStripMenuItemEllipse_Click(object sender, EventArgs e)
        {
            selectetCharacter = "Ellipse";
            CancelAll();
            toolStripMenuItemEllipse.BackColor = Color.Red;
        }

        private void toolStripMenuItemTriangle_Click(object sender, EventArgs e)
        {
            selectetCharacter = "Triangle";
            CancelAll();
            toolStripMenuItemTriangle.BackColor = Color.Red;
        }

        private void toolStripMenuItemRectangle_Click(object sender, EventArgs e)
        {
            selectetCharacter = "Rectangle";
            CancelAll();
            toolStripMenuItemRectangle.BackColor = Color.Red;
        }

        private void toolStripMenuItemPentagon_Click(object sender, EventArgs e)
        {
            selectetCharacter = "Pentagon";
            CancelAll();
            toolStripMenuItemPentagon.BackColor = Color.Red;
        }

        private void toolStripMenuItemHexagon_Click(object sender, EventArgs e)
        {
            selectetCharacter = "Hexagon";
            CancelAll();
            toolStripMenuItemHexagon.BackColor = Color.Red;
        }

        private void CancelAll() 
        {
            toolStripMenuItemLine.BackColor = Color.DarkGray;
            toolStripMenuItemBezier.BackColor = Color.DarkGray;
            toolStripMenuItemEllipse.BackColor = Color.DarkGray;
            toolStripMenuItemTriangle.BackColor = Color.DarkGray;
            toolStripMenuItemRectangle.BackColor = Color.DarkGray;
            toolStripMenuItemPentagon.BackColor = Color.DarkGray;
            toolStripMenuItemHexagon.BackColor = Color.DarkGray;
        }
    }
}
