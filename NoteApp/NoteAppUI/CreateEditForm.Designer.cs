namespace NoteAppUI
{
    partial class CreateEditForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TitleNoteTextBox = new System.Windows.Forms.TextBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimeCreate = new System.Windows.Forms.DateTimePicker();
            this.dateTimeUpdate = new System.Windows.Forms.DateTimePicker();
            this.TextNoteTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заголовок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Категория";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Создано";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Обновлено";
            // 
            // TitleNoteTextBox
            // 
            this.TitleNoteTextBox.Location = new System.Drawing.Point(92, 19);
            this.TitleNoteTextBox.Name = "TitleNoteTextBox";
            this.TitleNoteTextBox.Size = new System.Drawing.Size(315, 20);
            this.TitleNoteTextBox.TabIndex = 4;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(92, 49);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(171, 21);
            this.CategoryComboBox.TabIndex = 5;
            // 
            // dateTimeCreate
            // 
            this.dateTimeCreate.Location = new System.Drawing.Point(69, 90);
            this.dateTimeCreate.Name = "dateTimeCreate";
            this.dateTimeCreate.Size = new System.Drawing.Size(126, 20);
            this.dateTimeCreate.TabIndex = 6;
            // 
            // dateTimeUpdate
            // 
            this.dateTimeUpdate.Location = new System.Drawing.Point(290, 90);
            this.dateTimeUpdate.Name = "dateTimeUpdate";
            this.dateTimeUpdate.Size = new System.Drawing.Size(126, 20);
            this.dateTimeUpdate.TabIndex = 7;
            // 
            // TextNoteTextBox
            // 
            this.TextNoteTextBox.Location = new System.Drawing.Point(16, 116);
            this.TextNoteTextBox.Multiline = true;
            this.TextNoteTextBox.Name = "TextNoteTextBox";
            this.TextNoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextNoteTextBox.Size = new System.Drawing.Size(718, 410);
            this.TextNoteTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(659, 547);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // CreateEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 582);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TextNoteTextBox);
            this.Controls.Add(this.dateTimeUpdate);
            this.Controls.Add(this.dateTimeCreate);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.TitleNoteTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateEditForm";
            this.Text = "CreateEditForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateEditForm_FormClosed);
            this.Load += new System.EventHandler(this.CreateEditForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TitleNoteTextBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.DateTimePicker dateTimeCreate;
        private System.Windows.Forms.DateTimePicker dateTimeUpdate;
        private System.Windows.Forms.TextBox TextNoteTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}