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
            CategoryComboBox.Items.Add("All");

            // Добавление категорий в выпадающий список
            foreach (var category in Enum.GetValues(typeof(NoteCategory)))
            {
                CategoryComboBox.Items.Add(category);
            }

            CategoryComboBox.SelectedIndex = 0;                                 // - по умолчанию выбрано: показать все категории
        }
        public void LoadAndDisplayNotes()
        {
            ProjectManager manager = new ProjectManager();
            Project project = manager.LoadProject();

            TextAreaNoteViewData.Visible = false;
            string selectedCategory = "";

            if (CategoryComboBox.SelectedItem != null)
            {
                selectedCategory = CategoryComboBox.SelectedItem.ToString();
            }
            else selectedCategory = "All";

            NoteListLB.Items.Clear();
            if (project.Notes.Count > 0)
            {
                foreach (Note note in project.Notes)
                {
                    if (selectedCategory.ToString() == "All" || note.Category.ToString() == selectedCategory)
                    {
                        ListViewItem item = new ListViewItem(note.Title);
                        NoteListLB.Items.Add(item.Text);
                    }
                }
            }
        }
        private void EditForm_NoteUpdated(Note updatedNote)
        {
            TitleNoteViewData.Text = updatedNote.Title;                         // - обновляем заголовок
            TextAreaNoteViewData.Text = updatedNote.Text;                       // - обновляем текст заметки
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CreateEditForm createEditForm = new CreateEditForm();
            createEditForm.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (NoteListLB.SelectedItem != null)
            {
                ProjectManager manager = new ProjectManager();
                Project project = manager.LoadProject();

                string selectedNoteTitle = NoteListLB.SelectedItem.ToString();

                Note noteToEdit = project.Notes.FirstOrDefault(note => note.Title == selectedNoteTitle);

                CreateEditForm editEditForm = new CreateEditForm(noteToEdit);
                editEditForm.NoteUpdated += EditForm_NoteUpdated;               // - подписываемся на событие обновления заметки
                editEditForm.ShowDialog();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            // Проверяем, выбрана ли заметка
            if (NoteListLB.SelectedItem != null)
            {
                // Получаем заголовок выбранной заметки
                string selectedNoteTitle = NoteListLB.SelectedItem.ToString();

                // Загружаем проект и получаем все заметки
                ProjectManager manager = new ProjectManager();
                Project project = manager.LoadProject();

                // Находим заметку по заголовку
                Note noteToRemove = project.Notes.FirstOrDefault(note => note.Title == selectedNoteTitle);

                if (noteToRemove != null)
                {
                    project.RemoveNote(noteToRemove);                           // - удаляем заметку из проекта
                    manager.SaveProject(project);                               // - сохраняем изменения в проекте
                    LoadAndDisplayNotes();                                      // - обновляем список заметок в ListBox
                }
            }
        }
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAndDisplayNotes();
        }
        private void NoteListLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Проверяем, выбран ли элемент
            if (NoteListLB.SelectedItem != null)
            {
                TextAreaNoteViewData.Visible = true;                                    // - отображаем панель с информацией о заметке

                string selectedNoteTitle = NoteListLB.SelectedItem.ToString();    // - получаем заголовок выбранной заметки

                // Находим заметку по заголовку
                ProjectManager manager = new ProjectManager();
                Project project = manager.LoadProject();
                //Note selectedNote = project.Notes.FirstOrDefault(note => note.Title == selectedNoteTitle);

                // Находим все заметки с одинаковым заголовком
                var matchingNotes = project.Notes.Where(note => note.Title == selectedNoteTitle).ToList();

                if (matchingNotes.Count > 0)
                {
                    Note selectedNote = matchingNotes[0];

                    // Отображаем данные выбранной заметки
                    TitleNoteViewData.Text = selectedNote.Title;
                    CategoryTextNoteViewData.Text = selectedNote.Category.ToString();
                    CreateDataTimeNoteViewData.Value = selectedNote.CreationTime;
                    EditDataTimeNoteViewData.Value = selectedNote.LastModified;
                    TextAreaNoteViewData.Text = selectedNote.Text;
                }
            }
        }
        private void UpdateNoteBtn_Click(object sender, EventArgs e)
        {
            LoadAndDisplayNotes();
        }
    }
}
