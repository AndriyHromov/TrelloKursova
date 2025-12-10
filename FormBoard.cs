using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TrelloKursova
{
    public partial class FormBoard : Form
    {
        private Project project;
        private List<Project> allProjects;

        public FormBoard(Project project, List<Project> allProjects)
        {
            InitializeComponent();
            this.project = project;
            this.allProjects = allProjects;
            Text = "Дошка — " + (project?.Name ?? "—");
            // підключаємо обробники кнопок (якщо в Designer не зв'язано)
            btnAddToDo.Click += btnAddToDo_Click;
            btnAddInProgress.Click += btnAddInProgress_Click;
            btnAddDone.Click += btnAddDone_Click;

            LoadAllColumns();
        }

        private void LoadAllColumns()
        {
            flpToDo.Controls.Clear();
            flpInProgress.Controls.Clear();
            flpDone.Controls.Clear();

            // render ToDo
            foreach (var t in project.ToDo.ToList())
                flpToDo.Controls.Add(CreateTaskPanel(t, "todo"));

            foreach (var t in project.InProgress.ToList())
                flpInProgress.Controls.Add(CreateTaskPanel(t, "progress"));

            foreach (var t in project.Done.ToList())
                flpDone.Controls.Add(CreateTaskPanel(t, "done"));
        }

        private Panel CreateTaskPanel(TaskItem task, string columnKey)
        {
            var panel = new Panel
            {
                Width = 280,
                Height = 110,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(6)
            };

            var txt = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                BorderStyle = BorderStyle.None,
                BackColor = SystemColors.Control,
                Text = task.Title + Environment.NewLine + task.Description,
                Location = new Point(8, 6),
                Width = 200,
                Height = 56
            };

            var lblDeadline = new Label
            {
                Text = $"Дедлайн: {task.Deadline:yyyy-MM-dd}",
                Location = new Point(8, 66),
                AutoSize = true
            };

            var btnDelete = new Button
            {
                Text = "Видалити",
                Size = new Size(72, 28),
                Location = new Point(200, 66),
                BackColor = Color.LightCoral,
                Tag = new Tuple<TaskItem, string>(task, columnKey)
            };
            btnDelete.Click += BtnDelete_Click;

            // подвійний клік на текст — редагувати (опціонально)
            txt.DoubleClick += (s, e) =>
            {
                EditTask(task, columnKey);
            };

            panel.Controls.Add(txt);
            panel.Controls.Add(lblDeadline);
            panel.Controls.Add(btnDelete);

            return panel;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var tup = (sender as Button).Tag as Tuple<TaskItem, string>;
            var task = tup.Item1;
            var column = tup.Item2;

            var res = MessageBox.Show("Видалити задачу?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes) return;

            RemoveTaskFromProject(task, column);
            DataStorage.SaveProjects(allProjects);
            LoadAllColumns();
        }

        private void RemoveTaskFromProject(TaskItem t, string column)
        {
            switch (column)
            {
                case "todo": project.ToDo.Remove(t); break;
                case "progress": project.InProgress.Remove(t); break;
                case "done": project.Done.Remove(t); break;
            }
        }

        private void EditTask(TaskItem task, string column)
        {
            using (var f = new FormAddTask(project, column, task))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    DataStorage.SaveProjects(allProjects);
                    LoadAllColumns();
                }
            }
        }

        // кнопки додавання
        private void btnAddToDo_Click(object sender, EventArgs e)
        {
            using (var f = new FormAddTask(project, "todo"))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    // вже додано всередині форми
                    DataStorage.SaveProjects(allProjects);
                    LoadAllColumns();
                }
            }
        }

        private void btnAddInProgress_Click(object sender, EventArgs e)
        {
            using (var f = new FormAddTask(project, "progress"))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    DataStorage.SaveProjects(allProjects);
                    LoadAllColumns();
                }
            }
        }

        private void btnAddDone_Click(object sender, EventArgs e)
        {
            using (var f = new FormAddTask(project, "done"))
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    DataStorage.SaveProjects(allProjects);
                    LoadAllColumns();
                }
            }
        }
    }
}
