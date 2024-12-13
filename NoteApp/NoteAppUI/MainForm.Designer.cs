namespace NoteAppUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NoteListLB = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оНасToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.AreaDataNote = new System.Windows.Forms.Panel();
            this.CategoryTextNoteViewData = new System.Windows.Forms.Label();
            this.TitleNoteViewData = new System.Windows.Forms.Label();
            this.EditDataTimeNoteViewData = new System.Windows.Forms.DateTimePicker();
            this.CreateDataTimeNoteViewData = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateNoteBtn = new System.Windows.Forms.Button();
            this.TextAreaNoteViewData = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.AreaDataNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // NoteListLB
            // 
            this.NoteListLB.FormattingEnabled = true;
            this.NoteListLB.Location = new System.Drawing.Point(12, 53);
            this.NoteListLB.Name = "NoteListLB";
            this.NoteListLB.Size = new System.Drawing.Size(236, 342);
            this.NoteListLB.TabIndex = 0;
            this.NoteListLB.SelectedIndexChanged += new System.EventHandler(this.NoteListLB_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.изменитьToolStripMenuItem1,
            this.удалитьToolStripMenuItem});
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem1
            // 
            this.изменитьToolStripMenuItem1.Name = "изменитьToolStripMenuItem1";
            this.изменитьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.изменитьToolStripMenuItem1.Text = "Редактировать";
            this.изменитьToolStripMenuItem1.Click += new System.EventHandler(this.изменитьToolStripMenuItem1_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оНасToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оНасToolStripMenuItem
            // 
            this.оНасToolStripMenuItem.Name = "оНасToolStripMenuItem";
            this.оНасToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оНасToolStripMenuItem.Text = "О нас";
            this.оНасToolStripMenuItem.Click += new System.EventHandler(this.оНасToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Категория:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(12, 402);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 36);
            this.panel1.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(166, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 29);
            this.button4.TabIndex = 2;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(85, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 29);
            this.button3.TabIndex = 1;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 29);
            this.button2.TabIndex = 0;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(81, 27);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(167, 21);
            this.CategoryComboBox.TabIndex = 9;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // AreaDataNote
            // 
            this.AreaDataNote.Controls.Add(this.TextAreaNoteViewData);
            this.AreaDataNote.Controls.Add(this.CategoryTextNoteViewData);
            this.AreaDataNote.Controls.Add(this.TitleNoteViewData);
            this.AreaDataNote.Controls.Add(this.EditDataTimeNoteViewData);
            this.AreaDataNote.Controls.Add(this.CreateDataTimeNoteViewData);
            this.AreaDataNote.Controls.Add(this.label5);
            this.AreaDataNote.Controls.Add(this.label4);
            this.AreaDataNote.Controls.Add(this.label3);
            this.AreaDataNote.Location = new System.Drawing.Point(254, 27);
            this.AreaDataNote.Name = "AreaDataNote";
            this.AreaDataNote.Size = new System.Drawing.Size(534, 368);
            this.AreaDataNote.TabIndex = 10;
            this.AreaDataNote.Visible = false;
            // 
            // CategoryTextNoteViewData
            // 
            this.CategoryTextNoteViewData.AutoSize = true;
            this.CategoryTextNoteViewData.Location = new System.Drawing.Point(78, 42);
            this.CategoryTextNoteViewData.Name = "CategoryTextNoteViewData";
            this.CategoryTextNoteViewData.Size = new System.Drawing.Size(10, 13);
            this.CategoryTextNoteViewData.TabIndex = 8;
            this.CategoryTextNoteViewData.Text = "-";
            // 
            // TitleNoteViewData
            // 
            this.TitleNoteViewData.AutoSize = true;
            this.TitleNoteViewData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleNoteViewData.Location = new System.Drawing.Point(6, 3);
            this.TitleNoteViewData.Name = "TitleNoteViewData";
            this.TitleNoteViewData.Size = new System.Drawing.Size(19, 25);
            this.TitleNoteViewData.TabIndex = 7;
            this.TitleNoteViewData.Text = "-";
            // 
            // EditDataTimeNoteViewData
            // 
            this.EditDataTimeNoteViewData.Enabled = false;
            this.EditDataTimeNoteViewData.Location = new System.Drawing.Point(261, 59);
            this.EditDataTimeNoteViewData.Name = "EditDataTimeNoteViewData";
            this.EditDataTimeNoteViewData.Size = new System.Drawing.Size(121, 20);
            this.EditDataTimeNoteViewData.TabIndex = 6;
            // 
            // CreateDataTimeNoteViewData
            // 
            this.CreateDataTimeNoteViewData.Enabled = false;
            this.CreateDataTimeNoteViewData.Location = new System.Drawing.Point(67, 59);
            this.CreateDataTimeNoteViewData.Name = "CreateDataTimeNoteViewData";
            this.CreateDataTimeNoteViewData.Size = new System.Drawing.Size(115, 20);
            this.CreateDataTimeNoteViewData.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Обновлено:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Создано:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Категория:";
            // 
            // UpdateNoteBtn
            // 
            this.UpdateNoteBtn.Location = new System.Drawing.Point(700, 406);
            this.UpdateNoteBtn.Name = "UpdateNoteBtn";
            this.UpdateNoteBtn.Size = new System.Drawing.Size(88, 29);
            this.UpdateNoteBtn.TabIndex = 3;
            this.UpdateNoteBtn.Text = "Обновить";
            this.UpdateNoteBtn.UseVisualStyleBackColor = true;
            this.UpdateNoteBtn.Click += new System.EventHandler(this.UpdateNoteBtn_Click);
            // 
            // TextAreaNoteViewData
            // 
            this.TextAreaNoteViewData.Location = new System.Drawing.Point(11, 85);
            this.TextAreaNoteViewData.Multiline = true;
            this.TextAreaNoteViewData.Name = "TextAreaNoteViewData";
            this.TextAreaNoteViewData.Size = new System.Drawing.Size(520, 280);
            this.TextAreaNoteViewData.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateNoteBtn);
            this.Controls.Add(this.AreaDataNote);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NoteListLB);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.AreaDataNote.ResumeLayout(false);
            this.AreaDataNote.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox NoteListLB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оНасToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Panel AreaDataNote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker EditDataTimeNoteViewData;
        private System.Windows.Forms.DateTimePicker CreateDataTimeNoteViewData;
        private System.Windows.Forms.Label CategoryTextNoteViewData;
        private System.Windows.Forms.Label TitleNoteViewData;
        private System.Windows.Forms.Button UpdateNoteBtn;
        private System.Windows.Forms.TextBox TextAreaNoteViewData;
    }
}

