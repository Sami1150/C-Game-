using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatformGameMain
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void btn_continue_MouseHover(object sender, EventArgs e)
        {
            btn_continue.Image = Properties.Resources.continue_hover;

        }

        private void btn_continue_MouseLeave(object sender, EventArgs e)
        {
            btn_continue.Image = Properties.Resources.continue_normal;
        }

        private void btn_new_MouseHover(object sender, EventArgs e)
        {
            btn_new.Image = Properties.Resources.new_hover;
        }

        private void btn_new_MouseLeave(object sender, EventArgs e)
        {
            btn_new.Image = Properties.Resources.new_normal;
        }

        private void btn_help_MouseHover(object sender, EventArgs e)
        {
            btn_help.Image = Properties.Resources.help_hover;
        }

        private void btn_help_MouseLeave(object sender, EventArgs e)
        {
            btn_help.Image = Properties.Resources.help_normal;
        }

        private void btn_exit_MouseHover(object sender, EventArgs e)
        {
            btn_exit.Image = Properties.Resources.exit_hover;
        }

        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.Image = Properties.Resources.exit_normal;
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t \t **********WELCOME USER**********\r\n\r\nMovement: Use the arrow keys (Left and Right) to move the player character left and right. Press the Spacebar to make the player character jump.\r\n\r\nWin: Collect all 26 coins and reach the final platform to WIN the game. \r\n\r\nPlatforms: The player can stand & navigate through the platforms to reach the final platform.\r\n\r\nEnemies: If the player  touches an enemy, the game is over. \r\n\r\nScore: The score is displayed at the top of the game screen. It represents the number of coins collected.\r\n\r\nRestart: If the game is over, you can press the ESCAPE key to restart the game.", "Help", MessageBoxButtons.OK);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            Application.Exit();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            this.Close();
            HideAllForms();
            Form1 form1 = new Form1();
            form1.Show(); // Show Form1

        }
        static void HideAllForms()
        {
            Form[] openForms = Application.OpenForms.Cast<Form>().ToArray();

            foreach (Form form in openForms)
            {
                form.Hide();
            }
            
        }
        static void CloseAllForms()
        {
            Form[] openForms = Application.OpenForms.Cast<Form>().ToArray();

            foreach (Form form in openForms)
            {
                form.Close();
            }

        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
