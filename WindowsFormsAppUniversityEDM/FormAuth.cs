using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppUniversityEDM
{
    public partial class FormAuth : Form
    {
        /// <summary>
        /// Инициализация формы
        /// </summary>
        public FormAuth()
        {
            InitializeComponent();

            Global.DB = new UniversityDB();
        }

        /// <summary>
        /// Обработчик кнопки авторизации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == String.Empty ||
                textBoxPassword.Text == String.Empty)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Global.MyUser = new Users();
            Global.MyUser.Login = textBoxLogin.Text;

            Global.MyUser = Global.DB.Users.FirstOrDefault(user => user.Login == textBoxLogin.Text);

            if (Global.MyUser != null)
            {
                if (Global.MyUser.Password.Trim(' ') == textBoxPassword.Text)
                {
                    this.Hide();

                    textBoxLogin.Clear();
                    textBoxPassword.Clear();

                    new FormMain().ShowDialog();
                    this.Show();
                }

                else
                {
                    MessageBox.Show("Проверьте ввод!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            else
            { 
                MessageBox.Show("Проверьте ввод!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
