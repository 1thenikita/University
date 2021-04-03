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
    public partial class FormStudent : Form
    {
        Students st;
        int mode;
        
        /// <summary>
        /// Инициализация формы
        /// </summary>
        /// <param name="_st">Студент (если имеется)</param>
        /// <param name="_mode">Режим формы</param>
        public FormStudent(Students _st, int _mode)
        {
            InitializeComponent();

            numericUpDownYearStudent.Maximum = int.Parse(DateTime.Now.ToString("yyyy"));
            numericUpDownYearStudent.Value = int.Parse(DateTime.Now.ToString("yyyy"));

            if (_mode == 1)
            {
                this.Text = "Форма добавления студента";
                buttonSave.Text = "Добавить";
            }
            else if (_mode == 2)
            {
                this.Text = "Форма изменения студента";
                buttonSave.Text = "Изменить";
                textBoxFirstNameStudent.Text = _st.FirstName.Trim(' ');
                textBoxLastNameStudent.Text = _st.LastName.Trim(' ');
                numericUpDownYearStudent.Value = _st.Year;
            }

            mode = _mode;
            st = _st;
        }

        /// <summary>
        /// Обработчик кнопки действия (в зависимости режима формы)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxFirstNameStudent.Text == String.Empty ||
                textBoxLastNameStudent.Text == String.Empty)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (mode == 1)
            {
                Students _st = new Students
                {
                    FirstName = textBoxLastNameStudent.Text,
                    LastName = textBoxFirstNameStudent.Text,
                    Year = int.Parse(numericUpDownYearStudent.Text)
                };

                Global.DB.Students.Add(_st);
                Global.DB.SaveChanges();

                MessageBox.Show("Студент успешно добавлен!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (mode == 2)
            {
                st.FirstName = textBoxLastNameStudent.Text;
                st.LastName = textBoxFirstNameStudent.Text;
                st.Year = int.Parse(numericUpDownYearStudent.Text);

                Global.DB.SaveChanges();

                MessageBox.Show("Студент успешно изменён!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Обработчик кнопки закрытия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
