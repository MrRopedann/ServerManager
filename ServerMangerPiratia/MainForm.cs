using ServerManagerPiratia;
using ServerManagerPiratia.Cunstruct;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        bool hideMenu = true;
        string buttonText = "";
        public MainForm()
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

        private void button1_Click(object sender, EventArgs e)
        {
            ChildForm.OpenChildForm(new EditTextFileForm(), mainPanel);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChildForm.OpenChildForm(new NpcManagerForm(), mainPanel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChildForm.OpenChildForm(new NPCLuaCodeGenirator(), mainPanel);
        }
    }
}