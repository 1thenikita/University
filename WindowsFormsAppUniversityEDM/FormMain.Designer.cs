namespace WindowsFormsAppUniversityEDM
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonEditMyUserPassword = new System.Windows.Forms.Button();
            this.textBoxMyUserPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMyUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonEditStudent = new System.Windows.Forms.Button();
            this.buttonDeleteStudent = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonEditMyUserPassword);
            this.tabPage1.Controls.Add(this.textBoxMyUserPassword);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.labelMyUserName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "О себе";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonDeleteStudent);
            this.tabPage2.Controls.Add(this.buttonEditStudent);
            this.tabPage2.Controls.Add(this.buttonAddStudent);
            this.tabPage2.Controls.Add(this.dataGridViewStudents);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Работа со студентами";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonEditMyUserPassword
            // 
            this.buttonEditMyUserPassword.Location = new System.Drawing.Point(11, 80);
            this.buttonEditMyUserPassword.Name = "buttonEditMyUserPassword";
            this.buttonEditMyUserPassword.Size = new System.Drawing.Size(120, 35);
            this.buttonEditMyUserPassword.TabIndex = 9;
            this.buttonEditMyUserPassword.Text = "Изменить пароль";
            this.buttonEditMyUserPassword.UseVisualStyleBackColor = true;
            // 
            // textBoxMyUserPassword
            // 
            this.textBoxMyUserPassword.Location = new System.Drawing.Point(11, 54);
            this.textBoxMyUserPassword.Name = "textBoxMyUserPassword";
            this.textBoxMyUserPassword.Size = new System.Drawing.Size(120, 20);
            this.textBoxMyUserPassword.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ваш пароль";
            // 
            // labelMyUserName
            // 
            this.labelMyUserName.AutoSize = true;
            this.labelMyUserName.Location = new System.Drawing.Point(8, 20);
            this.labelMyUserName.Name = "labelMyUserName";
            this.labelMyUserName.Size = new System.Drawing.Size(103, 13);
            this.labelMyUserName.TabIndex = 6;
            this.labelMyUserName.Text = "Имя пользователя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Здравствуйте";
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewStudents.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.Size = new System.Drawing.Size(786, 172);
            this.dataGridViewStudents.TabIndex = 0;
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(7, 182);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(90, 41);
            this.buttonAddStudent.TabIndex = 1;
            this.buttonAddStudent.Text = "Добавить студента";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonEditStudent
            // 
            this.buttonEditStudent.Location = new System.Drawing.Point(327, 182);
            this.buttonEditStudent.Name = "buttonEditStudent";
            this.buttonEditStudent.Size = new System.Drawing.Size(90, 41);
            this.buttonEditStudent.TabIndex = 1;
            this.buttonEditStudent.Text = "Изменить студента";
            this.buttonEditStudent.UseVisualStyleBackColor = true;
            this.buttonEditStudent.Click += new System.EventHandler(this.buttonEditStudent_Click);
            // 
            // buttonDeleteStudent
            // 
            this.buttonDeleteStudent.Location = new System.Drawing.Point(694, 182);
            this.buttonDeleteStudent.Name = "buttonDeleteStudent";
            this.buttonDeleteStudent.Size = new System.Drawing.Size(90, 41);
            this.buttonDeleteStudent.TabIndex = 1;
            this.buttonDeleteStudent.Text = "Удалить студента";
            this.buttonDeleteStudent.UseVisualStyleBackColor = true;
            this.buttonDeleteStudent.Click += new System.EventHandler(this.buttonDeleteStudent_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "Университет";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonEditMyUserPassword;
        private System.Windows.Forms.TextBox textBoxMyUserPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMyUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Button buttonDeleteStudent;
        private System.Windows.Forms.Button buttonEditStudent;
        private System.Windows.Forms.Button buttonAddStudent;
    }
}