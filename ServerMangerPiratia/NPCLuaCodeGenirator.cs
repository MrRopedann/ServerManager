using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerManagerPiratia
{
     
    public partial class NPCLuaCodeGenirator : Form
    {
        public NPCLuaCodeGenirator()
        {
            InitializeComponent();
        }

        public string Function(string nameNpc)
        {
            return string.Format("function {0} ()", nameNpc);
        }

        public string Talk(int page, string text)
        {
            return string.Format("Talk({0}, \"{1}\")", page, text);
                //Talk(1, \"Кузнец - Голди:_Я могу помочь тебе в этом длинном _путешествии от новичка до Укротителя Морей! \")
        }

        public string TextLua(int page, string text, string functionName)
        {
            return string.Format("Text( {0}, \"{1} \", {2} ) \n", page, text, functionName);
                //Text( 1,  "Торг ", BuyPage )
        }

        public string InitTrade(string TypeTrade, int idItem)
        {
            return string.Format(
                                "\n" + "InitTrade()" +
                                "\n" + "{0}({1})", TypeTrade, idItem 
                                );
        }

        public string End()
        {
            return "\nend";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zeroitCodeTextBox1.Text = Function("npc_kuznec");
            zeroitCodeTextBox1.Text += "\n" + Talk(1, "Кузнец - Голди:_Я могу помочь тебе в этом длинном _путешествии от новичка до Укротителя Морей!");
            zeroitCodeTextBox1.Text += "\n" + TextLua(1, "Торг", "BuyPage");
            zeroitCodeTextBox1.Text += InitTrade("Weapon", 0453);
            zeroitCodeTextBox1.Text += End();
        }
    }
}
