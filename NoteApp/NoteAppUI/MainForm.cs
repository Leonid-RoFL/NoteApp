using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComboBox(); 
            LoadAndDisplayNotes(); 
        }

        private void InitializeComboBox()
        {
            CategoryComboBox.Items.Add("All");                                      // - добавление категории "Все" в выпадающий список

            foreach (var category in Enum.GetValues(typeof(NoteCategory)))
            {
                CategoryComboBox.Items.Add(category); 
            }

            CategoryComboBox.SelectedIndex = 0;                                     // - по умолчанию выбрана категория "Все"
        }

        // Загрузка заметок и их отображение в пользовательском интерфейсе
        public void LoadAndDisplayNotes()
        {
            ProjectManager manager = new ProjectManager(); 
            Project project = manager.LoadProject(); 
            AreaDataNote.Visible = false;

            string selectedCategory = ""; 
            if (CategoryComboBox.SelectedItem != null)
            {
                selectedCategory = CategoryComboBox.SelectedItem.ToString();        // - получение выбранной категории
            }
            else
                selectedCategory = "All";

            NoteListLB.Items.Clear();

            if (project.Notes.Count > 0)                                            // - проверка наличия заметок в проекте
            {
                foreach (Note note in project.Notes) 
                {
                    if (selectedCategory == "All" || note.Category.ToString() == selectedCategory)
                    {
                        NoteListLB.Items.Add(note);
                    }
                }
            }
        }

        // Открытие формы для создания и редактирования заметки
        private void OpenCreateEditForm(Note note = null)
        {
            CreateEditForm createEditForm = note == null ? new CreateEditForm(this) : new CreateEditForm(this, note);
            createEditForm.NoteUpdated += OnNoteUpdated;                                                                    
            createEditForm.ShowDialog();                                                                                    
        }

        // Обновление списка заметок
        private void OnNoteUpdated(Note updatedNote)
        {
            LoadAndDisplayNotes(); // Обновляем список заметок при обновлении
        }

        // Кнопка "Добавить"
        private void button2_Click(object sender, EventArgs e)
        {
            OpenCreateEditForm();
        }

        // Кнопка "Изменить"
        private void button3_Click(object sender, EventArgs e)
        {
            if (NoteListLB.SelectedItem != null)
            {
                var selectedNote = (Note)NoteListLB.SelectedItem;
                OpenCreateEditForm(selectedNote);
            }
        }

        // Кнопка "Удалить"
        private void button4_Click(object sender, EventArgs e)
        {
            if (NoteListLB.SelectedItem != null)
            {
                var selectedNote = (Note)NoteListLB.SelectedItem;

                ProjectManager manager = new ProjectManager();
                Project project = manager.LoadProject();

                project.RemoveNote(selectedNote.Id);

                manager.SaveProject(project);
                LoadAndDisplayNotes();
            }
        }
        
        // Категория заметок
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAndDisplayNotes();
        }

        // Список заметок
        private void NoteListLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NoteListLB.SelectedItem != null)
            {
                AreaDataNote.Visible = true;

                string selectedNoteTitle = NoteListLB.SelectedItem.ToString();

                ProjectManager manager = new ProjectManager();
                Project project = manager.LoadProject();

                var matchingNotes = project.Notes.Where(note => note.Title == selectedNoteTitle).ToList(); // - находим все заметки с одинаковым заголовком

                if (matchingNotes.Count > 0)
                {
                    Note selectedNote = matchingNotes[0]; 

                    TitleNoteViewData.Text = selectedNote.Title;
                    CategoryTextNoteViewData.Text = selectedNote.Category.ToString();
                    CreateDataTimeNoteViewData.Value = selectedNote.CreationTime;
                    EditDataTimeNoteViewData.Value = selectedNote.LastModified;
                    TextAreaNoteViewData.Text = selectedNote.Text;
                }
            }
        }

        // Кнопка "Создать" в меню "Изменить"
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCreateEditForm();
        }

        // Кнопка "Редактировать" в меню "Изменить"
        private void изменитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (NoteListLB.SelectedItem != null)
            {
                var selectedNote = (Note)NoteListLB.SelectedItem;
                OpenCreateEditForm(selectedNote);
            }
        }

        // Кнопка "Удалить" в меню "Изменить"
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NoteListLB.SelectedItem != null)
            {
                var selectedNote = (Note)NoteListLB.SelectedItem;

                ProjectManager manager = new ProjectManager();
                Project project = manager.LoadProject();

                project.RemoveNote(selectedNote.Id);

                manager.SaveProject(project);
                LoadAndDisplayNotes();
            }
        }

        // Кнопка "Выйти" в меню "Файл"
        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();                                                                                   // закрываем форму при выборе выхода из приложения  
        }

        // Кнопка "О нас" в меню "Помощь"
        private void оНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUsForm aboutForm = new AboutUsForm();                                                      // создаем форму "О нас"   
            aboutForm.ShowDialog();                                                                         // отображаем форму как диалоговое окно   
        }
    }
}