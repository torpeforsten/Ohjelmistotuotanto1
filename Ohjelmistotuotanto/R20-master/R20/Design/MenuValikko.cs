using R20.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R20.Design
{
    public partial class MenuValikko : Form
    {

        // Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        // Constructor
        public MenuValikko()
        {
            InitializeComponent();
            random = new Random();
        }

        // Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index) {
              index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender !=null)
            {
                if(currentButton!= (Button)btnSender)
                {
                    DisableButton((Button)btnSender);
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton(object btnSender)
        {
            foreach(Control previousBtn in panel1.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        // Click

        private void btnAsiakashallinta_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAsiakashallinta(), sender);
        }

        private void btnMokit_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMokit(), sender);
        }

        private void btnPalvelut_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormPalvelut(), sender);
        }

        private void btnVaraukset_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormVaraukset(), sender);
        }

        private void btnAlueet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAlueet(), sender);
        }

        private void btnLaskut_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormLaskut(), sender);
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
