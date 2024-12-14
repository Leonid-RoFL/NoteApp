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
        private Note _note;                                                         // Переменная для хранения заметки, если форма открыта для редактирования
        private bool _isEditing;                                                    // Флаг, указывающий, находимся ли мы в режиме редактирования заметки
        private bool _hasChanges;                                                   // Флаг для отслеживания изменений
        private MainForm _mainForm;

        public event Action<Note> NoteUpdated;                                      // Событие, вызываемое при обновлении заметки

        public CreateEditForm(MainForm mainForm)
        {
            InitializeComponent();                                 // Инициализация компонентов формы
            _mainForm = mainForm;
            _isEditing = false;
            InitializeComboBox();                                                   // Инициализация выпадающего списка категорий
            _hasChanges = false;                                                    // Изначально изменений нет
        }

        private void SaveNotes()
        {
            string title = TitleNoteTextBox.Text;
            NoteCategory category = (NoteCategory)CategoryComboBox.SelectedItem;
            string text = TextNoteTextBox.Text;

            ProjectManager manager = new ProjectManager();
            Project project = manager.LoadProject();

            if (project == null)
            {
                return;                                                             // Если проект не загружен, выходим
            }

            if (_isEditing && _note != null)                                        // Режим редактирования
            {
                var existingNote = project.Notes.FirstOrDefault(note => note.Id == _note.Id);
                if (existingNote != null)                                           // Если заметка найдена, обновляем её
                {
                    existingNote.Title = title;                                     // Обновляем заголовок
                    existingNote.Category = category;                               // Обновляем категорию
                    existingNote.Text = text;                                       // Обновляем текст
                    existingNote.LastModified = DateTime.Now;                       // Обновляем время последнего изменения

                    manager.SaveProject(project);                                   // Сохраняем изменения в проекте
                }
            }
            else                                                                    // Если создается новая заметка
            {
                if (project.Notes.Any(note => note.Title.Equals(title, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Заметка с таким заголовком уже существует.");
                    return;                                                         // Прерываем выполнение метода, если дубликат найден
                }

                Note newNote = new Note(title, category, text)
                {
                    Id = Guid.NewGuid(),                                            // Генерация уникального идентификатора
                    CreationTime = DateTime.Now,
                    LastModified = DateTime.Now
                };

                project.AddNote(newNote);                                           // Добавляем новую заметку в проект
                manager.SaveProject(project);                                       // Сохраняем изменения в проекте
            }
        }

        private void CreateEditForm_Load_1(object sender, EventArgs e)
        {
            dateTimeCreate.Enabled = false;                                   
            dateTimeUpdate.Enabled = false;
            _hasChanges = true;

            button1.Text = _isEditing ? "Обновить" : "Создать";                     // - устанавливаем текст кнопки в зависимости от режима (редактирование или создание)
        }

        public CreateEditForm(MainForm mainForm, Note note) : this(mainForm)
        {
            _note = note;                                                           // - сохраняем переданную заметку
            _isEditing = true;                                               
            LoadNoteData();                                                         // - загружаем данные заметки в элементы управления формы
        }

        private void LoadNoteData()
        {
            TitleNoteTextBox.Text = _note.Title;                              
            CategoryComboBox.SelectedItem = _note.Category;                   
            TextNoteTextBox.Text = _note.Text;                                
        }

        private void InitializeComboBox()
        {
            foreach (var category in Enum.GetValues(typeof(NoteCategory)))   // - добавляем все категории из перечисления NoteCategory
            {
                CategoryComboBox.Items.Add(category);
            }

            CategoryComboBox.SelectedIndex = 6;                                    // - устанавливаем выбранный индекс на категорию (other)
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveNotes();                                                           // Вызываем метод сохранения перед закрытием формы
            NoteUpdated?.Invoke(_note);
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();                                                          // - закрываем форму при нажатии на кнопку назад
        }

        private void CreateEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}