using NoteApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppUI
{
    public partial class CreateEditForm : Form
    {
        private Note _note;                                                     // - для хранения заметки, если форма открыта для редактирования
        private bool _isEditing;                                                // - флаг, указывающий, редактируем ли мы заметку

        public event Action<Note> NoteUpdated;

        public CreateEditForm()
        {
            InitializeComponent();
            _isEditing = false;                                                 // - устанавливаем флаг редактирования в false
            InitializeComboBox();
        }

        private void CreateEditForm_Load(object sender, EventArgs e)
        {
            dateTimeCreate.Enabled = false;
            dateTimeUpdate.Enabled = false;

            if (_isEditing) button2.Text = "Обновить";
            else button2.Text = "Создать";
        }

        // [Конструктор для редактирования существующей заметки]
        public CreateEditForm(Note note) : this()
        {
            _note = note;
            _isEditing = true;                                                  // - устанавливаем флаг редактирования в true
            LoadNoteData();                                                     // - загружаем данные заметки в элементы управления
        }

        private void LoadNoteData()
        {
            TitleNoteTextBox.Text = _note.Title;
            CategoryComboBox.SelectedItem = _note.Category;
            TextNoteTextBox.Text = _note.Text;
        }
        private void InitializeComboBox()
        {
            CategoryComboBox.Items.Add("No category");

            foreach (var category in Enum.GetValues(typeof(NoteCategory)))
            {
                CategoryComboBox.Items.Add(category);
            }
            CategoryComboBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string title = TitleNoteTextBox.Text;
            NoteCategory category;

            if (CategoryComboBox.SelectedItem.ToString() == "No category")
            {
                category = NoteCategory.Other;
            }
            else
            {
                category = (NoteCategory)CategoryComboBox.SelectedItem;
            }

            string text = TextNoteTextBox.Text;

            if (_isEditing)
            {
                ProjectManager manager = new ProjectManager();
                Project project = manager.LoadProject();

                // [Находим и удаляем заметку]
                var noteToRemove = project.Notes.FirstOrDefault(note => note.Title == _note.Title);

                if (noteToRemove != null)
                {
                    project.RemoveNote(noteToRemove);
                }

                // [Создаем новую заметку с обновленными данными]
                Note updatedNote = new Note(title, category, text)
                {
                    LastModified = DateTime.Now
                };

                project.AddNote(updatedNote);                                   // - добавляем обновленную заметку

                manager.SaveProject(project);                                   // - сохраняем проект с новой заметкой

                NoteUpdated?.Invoke(_note);                                     // - вызываем событие с обновленной заметкой
            }
            else
            {
                Note newNote = new Note(title, category, text);

                ProjectManager manager = new ProjectManager();
                Project project = manager.LoadProject();
                project.AddNote(newNote);

                manager.SaveProject(project);
            }

            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string title = TitleNoteTextBox.Text;
            NoteCategory category;

            if (CategoryComboBox.SelectedItem.ToString() == "No category")
            {
                category = NoteCategory.Other;
            }
            else
            {
                category = (NoteCategory)CategoryComboBox.SelectedItem;
            }

            string text = TextNoteTextBox.Text;

            if (_isEditing)
            {
                ProjectManager manager = new ProjectManager();
                Project project = manager.LoadProject();

                // [Находим и удаляем заметку]
                var noteToRemove = project.Notes.FirstOrDefault(note => note.Title == _note.Title);

                if (noteToRemove != null)
                {
                    project.RemoveNote(noteToRemove);
                }

                // [Создаем новую заметку с обновленными данными]
                Note updatedNote = new Note(title, category, text)
                {
                    LastModified = DateTime.Now
                };

                project.AddNote(updatedNote);                                   // - добавляем обновленную заметку

                manager.SaveProject(project);                                   // - сохраняем проект с новой заметкой

                NoteUpdated?.Invoke(_note);                                     // - вызываем событие с обновленной заметкой
            }
            else
            {
                Note newNote = new Note(title, category, text);

                ProjectManager manager = new ProjectManager();
                Project project = manager.LoadProject();
                project.AddNote(newNote);

                manager.SaveProject(project);
            }

            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
