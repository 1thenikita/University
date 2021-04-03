namespace WindowsFormsAppUniversityEDM
{
    partial class FormStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFirstNameStudent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLastNameStudent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownYearStudent = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя студента";
            // 
            // textBoxFirstNameStudent
            // 
            this.textBoxFirstNameStudent.Location = new System.Drawing.Point(42, 30);
            this.textBoxFirstNameStudent.Name = "textBoxFirstNameStudent";
            this.textBoxFirstNameStudent.Size = new System.Drawing.Size(120, 20);
            this.textBoxFirstNameStudent.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия студента";
            // 
            // textBoxLastNameStudent
            // 
            this.textBoxLastNameStudent.Location = new System.Drawing.Point(41, 69);
            this.textBoxLastNameStudent.Name = "textBoxLastNameStudent";
            this.textBoxLastNameStudent.Size = new System.Drawing.Size(120, 20);
            this.textBoxLastNameStudent.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Год рождения";
            // 
            // numericUpDownYearStudent
            // 
            this.numericUpDownYearStudent.Location = new System.Drawing.Point(41, 108);
            this.numericUpDownYearStudent.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.numericUpDownYearStudent.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownYearStudent.Name = "numericUpDownYearStudent";
            this.numericUpDownYearStudent.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownYearStudent.TabIndex = 5;
            this.numericUpDownYearStudent.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(212, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(84, 37);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Действие";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(212, 68);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(84, 37);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Отмена";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 180);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownYearStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLastNameStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFirstNameStudent);
            this.Controls.Add(this.label1);
            this.Name = "FormStudent";
            this.Text = "FormStudent";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFirstNameStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLastNameStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownYearStudent;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExit;
    }
}