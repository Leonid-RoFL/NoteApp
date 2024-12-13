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
            TitleNoteViewData.Text = updatedNote.Title; 
            TextAreaNoteViewData.Text = updatedNote.Text; 
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
                editEditForm.NoteUpdated += EditForm_NoteUpdated;
                editEditForm.ShowDialog(); 
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (NoteListLB.SelectedItem != null) 
            {
                string selectedNoteTitle = NoteListLB.SelectedItem.ToString();

                ProjectManager manager = new ProjectManager(); 
                Project project = manager.LoadProject();

                Note noteToRemove = project.Notes.FirstOrDefault(note => note.Title == selectedNoteTitle); // - поиск заметки для удаления

                if (noteToRemove != null)
                {
                    project.RemoveNote(noteToRemove);
                    manager.SaveProject(project);
                    LoadAndDisplayNotes();
                }
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAndDisplayNotes();
        }

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

        private void UpdateNoteBtn_Click(object sender, EventArgs e)
        {
            LoadAndDisplayNotes();   
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateEditForm createEditForm = new CreateEditForm();  
            createEditForm.ShowDialog();  
        }

        private void изменитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (NoteListLB.SelectedItem != null)
            {
                ProjectManager manager = new ProjectManager();
                Project project = manager.LoadProject(); 

                string selectedNoteTitle = NoteListLB.SelectedItem.ToString(); 
                Note noteToEdit = project.Notes.FirstOrDefault(note => note.Title == selectedNoteTitle); 

                CreateEditForm editEditForm = new CreateEditForm(noteToEdit);  
                editEditForm.NoteUpdated += EditForm_NoteUpdated;  
                editEditForm.ShowDialog(); 
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (NoteListLB.SelectedItem != null) 
            {
                string selectedNoteTitle = NoteListLB.SelectedItem.ToString();  

                ProjectManager manager = new ProjectManager(); 
                Project project = manager.LoadProject();

                Note noteToRemove = project.Notes.FirstOrDefault(note => note.Title == selectedNoteTitle);  // ищем заметку для удаления  

                if (noteToRemove != null) 
                {
                    project.RemoveNote(noteToRemove); 
                    manager.SaveProject(project);  
                    LoadAndDisplayNotes(); 
                }
            }
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();                                                                                   // закрываем форму при выборе выхода из приложения  
        }

        private void оНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUsForm aboutForm = new AboutUsForm();                                                      // создаем форму "О нас"   
            aboutForm.ShowDialog();                                                                         // отображаем форму как диалоговое окно   
        }
    }
}
