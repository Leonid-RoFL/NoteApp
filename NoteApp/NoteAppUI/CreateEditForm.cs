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
        private Timer autoSaveTimer;                                                // Таймер для автосохранения
        private bool _hasChanges;                                                   // Флаг для отслеживания изменений

        public event Action<Note> NoteUpdated;                                      // Событие, вызываемое при обновлении заметки

        public CreateEditForm()
        {
            InitializeComponent();                                                  // Инициализация компонентов формы
            _isEditing = false;
            InitializeComboBox();                                                   // Инициализация выпадающего списка категорий
            InitializeAutoSave();                                                   // Инициализация автосохранения
            _hasChanges = false;                                                    // Изначально изменений нет
        }

        private void InitializeAutoSave()
        {
            autoSaveTimer = new Timer();
            autoSaveTimer.Interval = 10000;                                         // Установка интервала на 10 секунд (10000 мс)
            autoSaveTimer.Tick += AutoSaveTimer_Tick;                               // Связываем событие
            autoSaveTimer.Start();                                                  // Запускаем таймер
        }

        private void AutoSaveTimer_Tick(object sender, EventArgs e)
        {
            if (_hasChanges == true)                                                // Проверяем, были ли изменения
            {
                SaveNotes();                                                        // Вызываем метод сохранения заметок
            }
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
                return;
            }

            if (_isEditing && _note != null)                                        // Проверяем, что мы в режиме редактирования и _note не null
            {
                var existingNote = project.Notes.FirstOrDefault(note => note.Id == _note.Id);

                if (existingNote != null)                                           // Если заметка найдена, обновляем её
                {
                    existingNote.Title = title;                                     // Обновляем заголовок
                    existingNote.Category = category;                               // Обновляем категорию
                    existingNote.Text = text;                                       // Обновляем текст
                    existingNote.LastModified = DateTime.Now;                       // Обновляем время последнего изменения

                    manager.SaveProject(project);                                   // Сохраняем изменения в проекте
                    _hasChanges = false;                                            // Сбрасываем флаг изменений после успешного сохранения
                }
            }
            else if (!_isEditing)                                                   // Если создается новая заметка
            {
                Note newNote = new Note(title, category, text)
                {
                    Id = Guid.NewGuid(),                                            // Генерация уникального идентификатора
                    CreationTime = DateTime.Now,
                    LastModified = DateTime.Now
                };

                project.AddNote(newNote);                                           // Добавляем новую заметку в проект
                manager.SaveProject(project);                                       // Сохраняем изменения в проекте
                _hasChanges = false;                                                // Сбрасываем флаг изменений после успешного сохранения
            }
        }

        private void CreateEditForm_Load_1(object sender, EventArgs e)
        {
            dateTimeCreate.Enabled = false;                                   
            dateTimeUpdate.Enabled = false;
            _hasChanges = true;

            button1.Text = _isEditing ? "Обновить" : "Создать";                     // - устанавливаем текст кнопки в зависимости от режима (редактирование или создание)
        }

        // Конструктор редактирования заметки
        public CreateEditForm(Note note) : this()
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
            string title = TitleNoteTextBox.Text;                                  
            NoteCategory category = (NoteCategory)CategoryComboBox.SelectedItem;   // - присваиваем категорию заметки

            string text = TextNoteTextBox.Text;                             

            if (_isEditing)                                                        // - проверяем, находимся ли мы в режиме редактирования
            {
                ProjectManager manager = new ProjectManager();             
                Project project = manager.LoadProject();                  

                // Поиск и удаление заметки
                var noteToRemove = project.Notes.FirstOrDefault(note => note.CreationTime == _note.CreationTime);

                if (noteToRemove != null)                                          
                {
                    project.RemoveNote(noteToRemove);                              
                }

                // Создание заметки с обновлёнными данными
                Note updatedNote = new Note(title, category, text)          
                {
                    LastModified = DateTime.Now                             
                };

                project.AddNote(updatedNote);                               
                manager.SaveProject(project);                               
                NoteUpdated?.Invoke(_note);                                 
            }
            else                                                            
            {
                Note newNote = new Note(title, category, text);           

                ProjectManager manager = new ProjectManager();             
                Project project = manager.LoadProject();                   

                project.AddNote(newNote);                                   
                manager.SaveProject(project);                               
            }

            this.Close();                                                            // - закрываем форму после завершения редактирования заметки
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();                                                            // - закрываем форму при нажатии на кнопку назад
        }
    }
}