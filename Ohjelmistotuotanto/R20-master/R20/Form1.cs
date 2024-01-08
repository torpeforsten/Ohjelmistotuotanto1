using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R20
{
    public partial class Form1 : Form
    {
        Color baseColor = SystemColors.HotTrack;
        Color selectedColor = ControlPaint.Dark(SystemColors.HotTrack, 0.1f);

        StringFormat stringFormat = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };

        bool pressed1 = false;
        bool pressed2 = false;
        bool pressed3 = false;
        bool pressed4 = false;
        bool pressed5 = false;
        bool pressed6 = false;
        bool pressed7 = false;

        public Form1()
        {
            InitializeComponent();           
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        //MENU 1 CONTROLS
        #region MENU 1 CONTROLS
        private void menu1_MouseEnter(object sender, EventArgs e)
        {
            menu1.BackColor = selectedColor;
        }

        private void menu1_MouseLeave(object sender, EventArgs e)
        {
            if (!pressed1)
            {
                menu1.BackColor = baseColor;
            }
        }

        private void menu1_Click(object sender, EventArgs e)
        {
            menu1.BackColor = selectedColor;
            menu2.BackColor = baseColor;
            menu3.BackColor = baseColor;
            menu4.BackColor = baseColor;
            menu5.BackColor = baseColor;
            menu6.BackColor = baseColor;
            pressed1 = true;
            pressed2 = false;
            pressed3 = false;
            pressed4 = false;
            pressed5 = false;
            pressed6 = false;
            pressed7 = false;

            Asiakashallinta asiakashallinta = new Asiakashallinta();
            addUserControl(asiakashallinta);
        }

        private void menu1lbl_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(menu1lbl.BackColor);
            if (!menu1lbl.Enabled)
            {
                using (Brush brush = new SolidBrush(SystemColors.HighlightText))
                {
                    e.Graphics.DrawString(menu1lbl.Text, menu1lbl.Font, brush, menu1lbl.ClientRectangle, stringFormat);
                }
            }
        }
        #endregion

        //MENU 2 CONTROLS
        #region MENU 2 CONTROLS
        private void menu2_MouseEnter(object sender, EventArgs e)
        {
            menu2.BackColor = selectedColor;
        }

        private void menu2_MouseLeave(object sender, EventArgs e)
        {
            if (!pressed2)
            {
                menu2.BackColor = baseColor;
            }
        }

        private void menu2_Click(object sender, EventArgs e)
        {
            menu1.BackColor = baseColor;
            menu2.BackColor = selectedColor;
            menu3.BackColor = baseColor;
            menu4.BackColor = baseColor;
            menu5.BackColor = baseColor;
            menu6.BackColor = baseColor;

            pressed1 = false;
            pressed2 = true;
            pressed3 = false;
            pressed4 = false;
            pressed5 = false;
            pressed6 = false;
            pressed7 = false;

            Mokit mokit = new Mokit();
            addUserControl(mokit);
        }

        private void menu2lbl_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(menu2lbl.BackColor);
            if (!menu2lbl.Enabled)
            {
                using (Brush brush = new SolidBrush(SystemColors.HighlightText))
                {
                    e.Graphics.DrawString(menu2lbl.Text, menu2lbl.Font, brush, menu2lbl.ClientRectangle, stringFormat);
                }
            }
        }
        #endregion

        //MENU 3 CONTROLS
        #region MENU 3 CONTROLS
        private void menu3_MouseEnter(object sender, EventArgs e)
        {
            menu3.BackColor = selectedColor;
        }

        private void menu3_MouseLeave(object sender, EventArgs e)
        {
            if (!pressed3)
            {
                menu3.BackColor = baseColor;
            }
        }

        private void menu3_Click(object sender, EventArgs e)
        {
            menu1.BackColor = baseColor;
            menu2.BackColor = baseColor;
            menu3.BackColor = selectedColor;
            menu4.BackColor = baseColor;
            menu5.BackColor = baseColor;
            menu6.BackColor = baseColor;

            pressed1 = false;
            pressed2 = false;
            pressed3 = true;
            pressed4 = false;
            pressed5 = false;
            pressed6 = false;
            pressed7 = false;

            Alueet alueet = new Alueet();
            addUserControl(alueet);
        }

        private void menu3lbl_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(menu3lbl.BackColor);
            if (!menu3lbl.Enabled)
            {
                using (Brush brush = new SolidBrush(SystemColors.HighlightText))
                {
                    e.Graphics.DrawString(menu3lbl.Text, menu3lbl.Font, brush, menu3lbl.ClientRectangle, stringFormat);
                }
            }
        }
        #endregion

        //MENU 4 CONTROLS
        #region MENU 4 CONTROLS
        private void menu4_MouseEnter(object sender, EventArgs e)
        {
            menu4.BackColor = selectedColor;
        }

        private void menu4_MouseLeave(object sender, EventArgs e)
        {
            if (!pressed4)
            {
                menu4.BackColor = baseColor;
            }
        }

        private void menu4_Click(object sender, EventArgs e)
        {
            menu1.BackColor = baseColor;
            menu2.BackColor = baseColor;
            menu3.BackColor = baseColor;
            menu4.BackColor = selectedColor;
            menu5.BackColor = baseColor;
            menu6.BackColor = baseColor;

            pressed1 = false;
            pressed2 = false;
            pressed3 = false;
            pressed4 = true;
            pressed5 = false;
            pressed6 = false;
            pressed7 = false;

            Palvelut palvelut = new Palvelut();
            addUserControl(palvelut);
        }

        private void menu4lbl_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(menu4lbl.BackColor);
            if (!menu4lbl.Enabled)
            {
                using (Brush brush = new SolidBrush(SystemColors.HighlightText))
                {
                    e.Graphics.DrawString(menu4lbl.Text, menu4lbl.Font, brush, menu4lbl.ClientRectangle, stringFormat);
                }
            }
        }
        #endregion

        //MENU 5 CONTROLS
        #region MENU 5 CONTROLS
        private void menu5_MouseEnter(object sender, EventArgs e)
        {
            menu5.BackColor = selectedColor;
        }

        private void menu5_MouseLeave(object sender, EventArgs e)
        {
            if (!pressed5)
            {
                menu5.BackColor = baseColor;
            }
        }

        private void menu5_Click(object sender, EventArgs e)
        {
            menu1.BackColor = baseColor;
            menu2.BackColor = baseColor;
            menu3.BackColor = baseColor;
            menu4.BackColor = baseColor;
            menu5.BackColor = selectedColor;
            menu6.BackColor = baseColor;

            pressed1 = false;
            pressed2 = false;
            pressed3 = false;
            pressed4 = false;
            pressed5 = true;
            pressed6 = false;

            Laskut laskut = new Laskut();
            addUserControl(laskut);
        }

        private void menu5lbl_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(menu5lbl.BackColor);
            if (!menu5lbl.Enabled)
            {
                using (Brush brush = new SolidBrush(SystemColors.HighlightText))
                {
                    e.Graphics.DrawString(menu5lbl.Text, menu5lbl.Font, brush, menu5lbl.ClientRectangle, stringFormat);
                }
            }
        }
        #endregion

        //MENU 6 CONTROLS
        #region MENU 6 CONTROLS
        private void menu6_MouseEnter(object sender, EventArgs e)
        {
            menu6.BackColor = selectedColor;
        }

        private void menu6_MouseLeave(object sender, EventArgs e)
        {
            if (!pressed6)
            {
                menu6.BackColor = baseColor;
            }
        }

        private void menu6_Click(object sender, EventArgs e)
        {
            menu1.BackColor = baseColor;
            menu2.BackColor = baseColor;
            menu3.BackColor = baseColor;
            menu4.BackColor = baseColor;
            menu5.BackColor = baseColor;
            menu6.BackColor = selectedColor;

            pressed1 = false;
            pressed2 = false;
            pressed3 = false;
            pressed4 = false;
            pressed5 = false;
            pressed6 = true;
            pressed7 = false;

            Varaukset raportit = new Varaukset();
            addUserControl(raportit);
        }

        private void menu6lbl_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(menu6lbl.BackColor);
            if (!menu6lbl.Enabled)
            {
                using (Brush brush = new SolidBrush(SystemColors.HighlightText))
                {
                    e.Graphics.DrawString(menu6lbl.Text, menu6lbl.Font, brush, menu6lbl.ClientRectangle, stringFormat);
                }
            }
        }
        #endregion

    }
}