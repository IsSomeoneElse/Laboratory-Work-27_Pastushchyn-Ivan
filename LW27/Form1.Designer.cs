namespace LW27
{
    partial class Form1
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
            this.driveComboBox = new System.Windows.Forms.ComboBox();
            this.fileListBox = new System.Windows.Forms.ListBox();
            this.directoryListBox = new System.Windows.Forms.ListBox();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.propertiesRichTextBox = new System.Windows.Forms.TextBox();
            this.viewSecurityButton = new System.Windows.Forms.Button();
            this.viewPropertiesButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.viewContentButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // driveComboBox
            // 
            this.driveComboBox.FormattingEnabled = true;
            this.driveComboBox.Location = new System.Drawing.Point(63, 19);
            this.driveComboBox.Name = "driveComboBox";
            this.driveComboBox.Size = new System.Drawing.Size(110, 21);
            this.driveComboBox.TabIndex = 0;
            // 
            // fileListBox
            // 
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.Location = new System.Drawing.Point(6, 52);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.Size = new System.Drawing.Size(258, 238);
            this.fileListBox.TabIndex = 1;
            // 
            // directoryListBox
            // 
            this.directoryListBox.FormattingEnabled = true;
            this.directoryListBox.Location = new System.Drawing.Point(270, 52);
            this.directoryListBox.Name = "directoryListBox";
            this.directoryListBox.Size = new System.Drawing.Size(258, 238);
            this.directoryListBox.TabIndex = 2;
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(53, 32);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(135, 20);
            this.filterTextBox.TabIndex = 3;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(211, 25);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(90, 33);
            this.filterButton.TabIndex = 4;
            this.filterButton.Text = "-->";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Диск:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пошук:";
            // 
            // propertiesRichTextBox
            // 
            this.propertiesRichTextBox.Location = new System.Drawing.Point(41, 19);
            this.propertiesRichTextBox.Multiline = true;
            this.propertiesRichTextBox.Name = "propertiesRichTextBox";
            this.propertiesRichTextBox.ReadOnly = true;
            this.propertiesRichTextBox.Size = new System.Drawing.Size(389, 69);
            this.propertiesRichTextBox.TabIndex = 7;
            // 
            // viewSecurityButton
            // 
            this.viewSecurityButton.Location = new System.Drawing.Point(371, 42);
            this.viewSecurityButton.Name = "viewSecurityButton";
            this.viewSecurityButton.Size = new System.Drawing.Size(157, 23);
            this.viewSecurityButton.TabIndex = 9;
            this.viewSecurityButton.Text = "Атрибути безпеки";
            this.viewSecurityButton.UseVisualStyleBackColor = true;
            this.viewSecurityButton.Click += new System.EventHandler(this.viewSecurityButton_Click);
            // 
            // viewPropertiesButton
            // 
            this.viewPropertiesButton.Location = new System.Drawing.Point(6, 42);
            this.viewPropertiesButton.Name = "viewPropertiesButton";
            this.viewPropertiesButton.Size = new System.Drawing.Size(157, 23);
            this.viewPropertiesButton.TabIndex = 10;
            this.viewPropertiesButton.Text = "Властивості";
            this.viewPropertiesButton.UseVisualStyleBackColor = true;
            this.viewPropertiesButton.Click += new System.EventHandler(this.viewPropertiesButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(245, 94);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(226, 265);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 11;
            this.pictureBox.TabStop = false;
            // 
            // contentTextBox
            // 
            this.contentTextBox.Location = new System.Drawing.Point(6, 94);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(232, 265);
            this.contentTextBox.TabIndex = 12;
            // 
            // viewContentButton
            // 
            this.viewContentButton.Location = new System.Drawing.Point(189, 42);
            this.viewContentButton.Name = "viewContentButton";
            this.viewContentButton.Size = new System.Drawing.Size(157, 23);
            this.viewContentButton.TabIndex = 13;
            this.viewContentButton.Text = "Вміст";
            this.viewContentButton.UseVisualStyleBackColor = true;
            this.viewContentButton.Click += new System.EventHandler(this.viewContentButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.filterTextBox);
            this.groupBox1.Controls.Add(this.filterButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 82);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пошук";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.driveComboBox);
            this.groupBox2.Controls.Add(this.fileListBox);
            this.groupBox2.Controls.Add(this.directoryListBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 296);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Навігація файлової системи";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.viewPropertiesButton);
            this.groupBox3.Controls.Add(this.viewSecurityButton);
            this.groupBox3.Controls.Add(this.viewContentButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 396);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(534, 93);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Робота з програмою";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.propertiesRichTextBox);
            this.groupBox4.Location = new System.Drawing.Point(552, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(477, 105);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Атрибути безпеки";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.pictureBox);
            this.groupBox5.Controls.Add(this.contentTextBox);
            this.groupBox5.Location = new System.Drawing.Point(552, 124);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(477, 365);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Перегляд вмісту";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Графічний файл:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Текстовий файл:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 501);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Програма для роботи з файловою системою";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox driveComboBox;
        private System.Windows.Forms.ListBox fileListBox;
        private System.Windows.Forms.ListBox directoryListBox;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox propertiesRichTextBox;
        private System.Windows.Forms.Button viewSecurityButton;
        private System.Windows.Forms.Button viewPropertiesButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.Button viewContentButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

