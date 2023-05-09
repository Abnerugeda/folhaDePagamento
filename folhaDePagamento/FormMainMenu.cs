
using folhaDePagamento.Forms;
using folhaDePagamento.services;
using FontAwesome.Sharp;
namespace folhaDePagamento
{
    public partial class FormMainMenu : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public FormMainMenu()
        {

            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

        }
        private struct RGBcolors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void AtivarBotao(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DesativarBotao();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                currentBtn.Font = new Font(currentBtn.Font.FontFamily, 12f, currentBtn.Font.Style);
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                iconHome.IconChar = currentBtn.IconChar;
                iconHome.IconColor = color;

            }
        }
        private void DesativarBotao()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                iconHome.IconChar = IconChar.Home;
                iconHome.IconColor = Color.MediumPurple;
                currentBtn.Font = new Font(currentBtn.Font.FontFamily, 9f, currentBtn.Font.Style);

            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            AtivarBotao(sender, RGBcolors.color1);
            abrirChildForm(new DashFuncionario());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            AtivarBotao(sender, RGBcolors.color2);
            abrirChildForm(new FormFolha());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            AtivarBotao(sender, RGBcolors.color3);
            abrirChildForm(new FormFuncionarios());
        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            AtivarBotao(sender, RGBcolors.color4);
            abrirChildForm(new FormConfiguracoes());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            AtivarBotao(sender, RGBcolors.color5);
            abrirChildForm(new FormSuporte());
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void reset()
        {
            DesativarBotao();
            leftBorderBtn.Visible = false;
            currentChildForm.Close();
            lblHome.Text = "Home";
        }

        private void abrirChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblHome.Text = childForm.Text.Replace("Form", "");
        }
        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timerNow_Tick(object sender, EventArgs e)
        {
            lblHorario.Text = DateTime.Now.ToString("HH:mm:ss");
            lblData.Text = DateTime.Now.ToLongDateString();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {

        }
    }
}