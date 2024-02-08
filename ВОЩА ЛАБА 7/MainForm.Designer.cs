
namespace StudentGUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.FiletoolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.CreateButton = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenButton = new System.Windows.Forms.ToolStripMenuItem();
            this.XMLOpenButton = new System.Windows.Forms.ToolStripMenuItem();
            this.BinOpenButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TextOpenButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.XMLSaveAsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.BinSaveAsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TextSaveAsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AddButton = new System.Windows.Forms.ToolStripButton();
            this.TaskButton = new System.Windows.Forms.ToolStripButton();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TasktextBox = new System.Windows.Forms.TextBox();
            this.openTextFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openBinFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openXMLFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FiletoolStripButton,
            this.AddButton,
            this.TaskButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(910, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // FiletoolStripButton
            // 
            this.FiletoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FiletoolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateButton,
            this.OpenButton,
            this.SaveButton,
            this.сохранитьКакToolStripMenuItem});
            this.FiletoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FiletoolStripButton.Image")));
            this.FiletoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FiletoolStripButton.Name = "FiletoolStripButton";
            this.FiletoolStripButton.Size = new System.Drawing.Size(59, 24);
            this.FiletoolStripButton.Text = "Файл";
            this.FiletoolStripButton.Click += new System.EventHandler(this.FiletoolStripButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(224, 26);
            this.CreateButton.Text = "Создать";
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click_1);
            // 
            // OpenButton
            // 
            this.OpenButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XMLOpenButton,
            this.BinOpenButton,
            this.TextOpenButton});
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(224, 26);
            this.OpenButton.Text = "Открыть";
            // 
            // XMLOpenButton
            // 
            this.XMLOpenButton.Name = "XMLOpenButton";
            this.XMLOpenButton.Size = new System.Drawing.Size(121, 26);
            this.XMLOpenButton.Text = "XML";
            this.XMLOpenButton.Click += new System.EventHandler(this.XMLOpenButton_Click);
            // 
            // BinOpenButton
            // 
            this.BinOpenButton.Name = "BinOpenButton";
            this.BinOpenButton.Size = new System.Drawing.Size(121, 26);
            this.BinOpenButton.Text = "BIN";
            this.BinOpenButton.Click += new System.EventHandler(this.BinOpenButton_Click);
            // 
            // TextOpenButton
            // 
            this.TextOpenButton.Name = "TextOpenButton";
            this.TextOpenButton.Size = new System.Drawing.Size(121, 26);
            this.TextOpenButton.Text = "TXT";
            this.TextOpenButton.Click += new System.EventHandler(this.TextOpenButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(224, 26);
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click_1);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.XMLSaveAsButton,
            this.BinSaveAsButton,
            this.TextSaveAsButton});
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            // 
            // XMLSaveAsButton
            // 
            this.XMLSaveAsButton.Name = "XMLSaveAsButton";
            this.XMLSaveAsButton.Size = new System.Drawing.Size(121, 26);
            this.XMLSaveAsButton.Text = "XML";
            this.XMLSaveAsButton.Click += new System.EventHandler(this.XMLSaveAsButton_Click);
            // 
            // BinSaveAsButton
            // 
            this.BinSaveAsButton.Name = "BinSaveAsButton";
            this.BinSaveAsButton.Size = new System.Drawing.Size(121, 26);
            this.BinSaveAsButton.Text = "BIN";
            this.BinSaveAsButton.Click += new System.EventHandler(this.BinSaveAsButton_Click);
            // 
            // TextSaveAsButton
            // 
            this.TextSaveAsButton.Name = "TextSaveAsButton";
            this.TextSaveAsButton.Size = new System.Drawing.Size(121, 26);
            this.TextSaveAsButton.Text = "TXT";
            this.TextSaveAsButton.Click += new System.EventHandler(this.TextSaveAsButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(132, 24);
            this.AddButton.Text = "Добавить запись";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TaskButton
            // 
            this.TaskButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TaskButton.Image = ((System.Drawing.Image)(resources.GetObject("TaskButton.Image")));
            this.TaskButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TaskButton.Name = "TaskButton";
            this.TaskButton.Size = new System.Drawing.Size(61, 24);
            this.TaskButton.Text = "Задача";
            this.TaskButton.Click += new System.EventHandler(this.TaskButton_Click);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.HorizontalScrollbar = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(12, 30);
            this.listBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox.Name = "listBox";
            this.listBox.ScrollAlwaysVisible = true;
            this.listBox.Size = new System.Drawing.Size(886, 284);
            this.listBox.TabIndex = 1;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(873, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество студентов бюджетной и договорной форм обучения без задолжностей на каж" +
    "дом курсе:";
            // 
            // TasktextBox
            // 
            this.TasktextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TasktextBox.Location = new System.Drawing.Point(12, 364);
            this.TasktextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TasktextBox.Multiline = true;
            this.TasktextBox.Name = "TasktextBox";
            this.TasktextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TasktextBox.Size = new System.Drawing.Size(886, 278);
            this.TasktextBox.TabIndex = 3;
            // 
            // openTextFileDialog
            // 
            this.openTextFileDialog.FileName = "openFileDialog1";
            // 
            // openBinFileDialog
            // 
            this.openBinFileDialog.FileName = "openFileDialog2";
            // 
            // openXMLFileDialog
            // 
            this.openXMLFileDialog.FileName = "openFileDialog3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 653);
            this.Controls.Add(this.TasktextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Работа со студентами";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton FiletoolStripButton;
        private System.Windows.Forms.ToolStripButton AddButton;
        private System.Windows.Forms.ToolStripButton TaskButton;
        private System.Windows.Forms.ToolStripMenuItem CreateButton;
        private System.Windows.Forms.ToolStripMenuItem OpenButton;
        private System.Windows.Forms.ToolStripMenuItem XMLOpenButton;
        private System.Windows.Forms.ToolStripMenuItem BinOpenButton;
        private System.Windows.Forms.ToolStripMenuItem TextOpenButton;
        private System.Windows.Forms.ToolStripMenuItem SaveButton;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem XMLSaveAsButton;
        private System.Windows.Forms.ToolStripMenuItem BinSaveAsButton;
        private System.Windows.Forms.ToolStripMenuItem TextSaveAsButton;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TasktextBox;
        private System.Windows.Forms.OpenFileDialog openTextFileDialog;
        private System.Windows.Forms.OpenFileDialog openBinFileDialog;
        private System.Windows.Forms.OpenFileDialog openXMLFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}