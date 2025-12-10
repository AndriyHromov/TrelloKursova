using System;
using System.Windows.Forms;

namespace TrelloKursova
{
    public partial class FormAddTask : Form
    {
        private Project _project;
        private string _targetColumn;
        private TaskItem _editingTask;

        public FormAddTask(Project project, string targetColumn, TaskItem editingTask = null)
        {
            InitializeComponent();
            _project = project;
            _targetColumn = targetColumn;
            _editingTask = editingTask;

            // якщо редагування — підкладати значення
            if (_editingTask != null)
            {
                // текст - можна зберігати Title + Description в одному TextBox (назва в першому рядку)
                txtTaskText.Text = _editingTask.Title + Environment.NewLine + _editingTask.Description;
                dtDeadline.Value = _editingTask.Deadline;
            }
            else
            {
                dtDeadline.Value = DateTime.Now.Date.AddDays(1);
            }

            btnCreate.Click += BtnCreate_Click;
            btnCancel.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaskText.Text))
            {
                MessageBox.Show("Введіть текст задачі.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Розділення першого рядка як заголовок, решта - опис
            var lines = txtTaskText.Text.Trim().Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            var title = lines.Length > 0 ? lines[0] : txtTaskText.Text.Trim();
            var desc = lines.Length > 1 ? string.Join(Environment.NewLine, lines, 1, lines.Length - 1) : "";

            if (_editingTask == null)
            {
                var t = new TaskItem
                {
                    Title = title,
                    Description = desc,
                    Deadline = dtDeadline.Value.Date
                };

                switch (_targetColumn)
                {
                    case "todo": _project.ToDo.Add(t); break;
                    case "progress": _project.InProgress.Add(t); break;
                    case "done": _project.Done.Add(t); break;
                }
            }
            else
            {
                // оновлення
                _editingTask.Title = title;
                _editingTask.Description = desc;
                _editingTask.Deadline = dtDeadline.Value.Date;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
