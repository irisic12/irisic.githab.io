
namespace StudentGUI
{
    partial class StudentForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.FIOtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CourseTextBox = new System.Windows.Forms.TextBox();
            this.GrouptextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Dogovor_Button = new System.Windows.Forms.RadioButton();
            this.Budjet_Button = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.AcademPerformanceGrid = new System.Windows.Forms.DataGridView();
            this.Save_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AcademPerformanceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // FIOtextBox
            // 
            this.FIOtextBox.Location = new System.Drawing.Point(25, 28);
            this.FIOtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FIOtextBox.Multiline = true;
            this.FIOtextBox.Name = "FIOtextBox";
            this.FIOtextBox.Size = new System.Drawing.Size(201, 24);
            this.FIOtextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Курс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Группа";
            // 
            // CourseTextBox
            // 
            this.CourseTextBox.Location = new System.Drawing.Point(57, 66);
            this.CourseTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CourseTextBox.Name = "CourseTextBox";
            this.CourseTextBox.Size = new System.Drawing.Size(43, 20);
            this.CourseTextBox.TabIndex = 4;
            this.CourseTextBox.TextChanged += new System.EventHandler(this.CourseTextBox_TextChanged);
            // 
            // GrouptextBox
            // 
            this.GrouptextBox.Location = new System.Drawing.Point(57, 90);
            this.GrouptextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GrouptextBox.Name = "GrouptextBox";
            this.GrouptextBox.Size = new System.Drawing.Size(43, 20);
            this.GrouptextBox.TabIndex = 5;
            this.GrouptextBox.TextChanged += new System.EventHandler(this.GrouptextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Форма обучения";
            // 
            // Dogovor_Button
            // 
            this.Dogovor_Button.AutoSize = true;
            this.Dogovor_Button.Location = new System.Drawing.Point(116, 91);
            this.Dogovor_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Dogovor_Button.Name = "Dogovor_Button";
            this.Dogovor_Button.Size = new System.Drawing.Size(69, 17);
            this.Dogovor_Button.TabIndex = 7;
            this.Dogovor_Button.TabStop = true;
            this.Dogovor_Button.Text = "Договор";
            this.Dogovor_Button.UseVisualStyleBackColor = true;
            // 
            // Budjet_Button
            // 
            this.Budjet_Button.AutoSize = true;
            this.Budjet_Button.Location = new System.Drawing.Point(116, 69);
            this.Budjet_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Budjet_Button.Name = "Budjet_Button";
            this.Budjet_Button.Size = new System.Drawing.Size(65, 17);
            this.Budjet_Button.TabIndex = 8;
            this.Budjet_Button.TabStop = true;
            this.Budjet_Button.Text = "Бюджет";
            this.Budjet_Button.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Успеваемость";
            // 
            // AcademPerformanceGrid
            // 
            this.AcademPerformanceGrid.AllowUserToAddRows = false;
            this.AcademPerformanceGrid.AllowUserToDeleteRows = false;
            this.AcademPerformanceGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AcademPerformanceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AcademPerformanceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            this.AcademPerformanceGrid.EnableHeadersVisualStyles = false;
            this.AcademPerformanceGrid.Location = new System.Drawing.Point(25, 159);
            this.AcademPerformanceGrid.Margin = new System.Windows.Forms.Padding(2);
            this.AcademPerformanceGrid.Name = "AcademPerformanceGrid";
            this.AcademPerformanceGrid.RowHeadersVisible = false;
            this.AcademPerformanceGrid.RowHeadersWidth = 51;
            this.AcademPerformanceGrid.RowTemplate.Height = 24;
            this.AcademPerformanceGrid.Size = new System.Drawing.Size(296, 234);
            this.AcademPerformanceGrid.TabIndex = 10;
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(23, 411);
            this.Save_button.Margin = new System.Windows.Forms.Padding(2);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(74, 19);
            this.Save_button.TabIndex = 11;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 411);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 19);
            this.button1.TabIndex = 12;
            this.button1.Text = "Отчислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "№";
            this.Column3.Name = "Column3";
            this.Column3.Width = 43;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Предмет";
            this.Column1.Name = "Column1";
            this.Column1.Width = 77;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Оценка";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 70;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.AcademPerformanceGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Budjet_Button);
            this.Controls.Add(this.Dogovor_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GrouptextBox);
            this.Controls.Add(this.CourseTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FIOtextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentForm";
            this.Text = "Работа со студентом";
            this.Load += new System.EventHandler(this.StudentForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.AcademPerformanceGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FIOtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CourseTextBox;
        private System.Windows.Forms.TextBox GrouptextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton Dogovor_Button;
        private System.Windows.Forms.RadioButton Budjet_Button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView AcademPerformanceGrid;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}