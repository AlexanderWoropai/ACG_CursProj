
namespace ACG_KursProject_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemLine = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemBezier = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEllipse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTriangle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPentagon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHexagon = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.menuStrip1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(910, 498);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            this.MainPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseClick);
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            this.MainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemLine,
            this.toolStripMenuItemBezier,
            this.toolStripMenuItemEllipse,
            this.toolStripMenuItemTriangle,
            this.toolStripMenuItemRectangle,
            this.toolStripMenuItemPentagon,
            this.toolStripMenuItemHexagon});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemLine
            // 
            this.toolStripMenuItemLine.Name = "toolStripMenuItemLine";
            this.toolStripMenuItemLine.Size = new System.Drawing.Size(50, 26);
            this.toolStripMenuItemLine.Text = "Line";
            this.toolStripMenuItemLine.Click += new System.EventHandler(this.toolStripMenuItemLine_Click);
            // 
            // toolStripMenuItemBezier
            // 
            this.toolStripMenuItemBezier.Name = "toolStripMenuItemBezier";
            this.toolStripMenuItemBezier.Size = new System.Drawing.Size(64, 26);
            this.toolStripMenuItemBezier.Text = "Bezier";
            this.toolStripMenuItemBezier.Click += new System.EventHandler(this.toolStripMenuItemBezier_Click);
            // 
            // toolStripMenuItemEllipse
            // 
            this.toolStripMenuItemEllipse.Name = "toolStripMenuItemEllipse";
            this.toolStripMenuItemEllipse.Size = new System.Drawing.Size(66, 26);
            this.toolStripMenuItemEllipse.Text = "Ellipse";
            this.toolStripMenuItemEllipse.Click += new System.EventHandler(this.toolStripMenuItemEllipse_Click);
            // 
            // toolStripMenuItemTriangle
            // 
            this.toolStripMenuItemTriangle.Name = "toolStripMenuItemTriangle";
            this.toolStripMenuItemTriangle.Size = new System.Drawing.Size(76, 26);
            this.toolStripMenuItemTriangle.Text = "Triangle";
            this.toolStripMenuItemTriangle.Click += new System.EventHandler(this.toolStripMenuItemTriangle_Click);
            // 
            // toolStripMenuItemRectangle
            // 
            this.toolStripMenuItemRectangle.Name = "toolStripMenuItemRectangle";
            this.toolStripMenuItemRectangle.Size = new System.Drawing.Size(85, 26);
            this.toolStripMenuItemRectangle.Text = "Rectange";
            this.toolStripMenuItemRectangle.Click += new System.EventHandler(this.toolStripMenuItemRectangle_Click);
            // 
            // toolStripMenuItemPentagon
            // 
            this.toolStripMenuItemPentagon.Name = "toolStripMenuItemPentagon";
            this.toolStripMenuItemPentagon.Size = new System.Drawing.Size(85, 26);
            this.toolStripMenuItemPentagon.Text = "Pentagon";
            this.toolStripMenuItemPentagon.Click += new System.EventHandler(this.toolStripMenuItemPentagon_Click);
            // 
            // toolStripMenuItemHexagon
            // 
            this.toolStripMenuItemHexagon.Name = "toolStripMenuItemHexagon";
            this.toolStripMenuItemHexagon.Size = new System.Drawing.Size(83, 26);
            this.toolStripMenuItemHexagon.Text = "Hexagon";
            this.toolStripMenuItemHexagon.Click += new System.EventHandler(this.toolStripMenuItemHexagon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 498);
            this.Controls.Add(this.MainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Vecor graphics engine";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLine;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBezier;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEllipse;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTriangle;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRectangle;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPentagon;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHexagon;
    }
}

