using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppUniversityEDM
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Инициализация формы
        /// </summary>
        public FormMain()
        {
            InitializeComponent();

            Global.DB.Students.Load();
            dataGridViewStudents.DataSource = Global.DB.Students.Local.ToBindingList();

            textBoxMyUserPassword.Text = Global.MyUser.Password.Trim(' ');
        }

        /// <summary>
        /// Обработчик кнопки изменения пароля сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditMyUserPassword_Click(object sender, EventArgs e)
        {
            if (textBoxMyUserPassword.Text == String.Empty)
            {
                MessageBox.Show("Пароль не может быть пустым!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxMyUserPassword.Text == Global.MyUser.Password)
            {
                return;
            }
            
            Global.MyUser.Password = textBoxMyUserPassword.Text;

            Global.DB.SaveChanges();

            MessageBox.Show("Пароль изменён", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Обработчик кнопки добавления студента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            new FormStudent(null, 1).ShowDialog();
            dataGridViewStudents.Refresh();
        }

        /// <summary>
        /// Обработчик кнопки изменения студента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditStudent_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                int id = int.Parse(dataGridViewStudents.SelectedRows[0].Cells[0].Value.ToString());
                Students st = Global.DB.Students.Find(id);
                new FormStudent(st, 2).ShowDialog();
                dataGridViewStudents.Refresh();
            }
        }

        /// <summary>
        /// Обработчик кнопки удаления студента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                int id = int.Parse(dataGridViewStudents.SelectedRows[0].Cells[0].Value.ToString());
                Students st = Global.DB.Students.Find(id);
                Global.DB.Students.Remove(st);
                Global.DB.SaveChanges();
                dataGridViewStudents.Refresh();
            }
        }
    }
}
