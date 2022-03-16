namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        bool hideMenu = true;
        string buttonText = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void logoPanel_Click(object sender, EventArgs e)
        {
            if (hideMenu)
            {
                leftPanel.Width = 50;
                buttonText = button1.Text;
                button1.Text = "";
                logoPanel.Image = ServerManagerPiratia.Properties.Resources.pkodevlogo_min;
                hideMenu = false;
            }
            else
            {
                leftPanel.Width = 270;
                button1.Text = buttonText;
                buttonText = "";
                logoPanel.Image = ServerManagerPiratia.Properties.Resources.pkodevlogo_full;
                hideMenu = true;
            }
        }
    }
}