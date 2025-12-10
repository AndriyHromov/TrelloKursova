using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TrelloKursova
{
    public partial class Form1 : Form
    {
        private List<Project> projects;

        public Form1()
        {
            InitializeComponent();
            LoadData();
            RenderProjects();
        }

        private void LoadData()
        {
            projects = DataStorage.LoadProjects();
        }

        private void SaveData() => DataStorage.SaveProjects(projects);

        private void RenderProjects()
        {
            panelProjects.Controls.Clear();
            panelProjects.AutoScroll = true;

            foreach (var p in projects)
            {
                var card = CreateProjectCard(p);
                panelProjects.Controls.Add(card);
            }
        }

        private Panel CreateProjectCard(Project p)
        {
            var panel = new Panel
            {
                Width = panelProjects.ClientSize.Width - 25,
                Height = 80,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(8)
            };

            var lblTitle = new Label
            {
                Text = p.Name,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(10, 8),
                AutoSize = false,
                Width = panel.Width - 220,
                Height = 24
            };

            var lblDeadline = new Label
            {
                Text = $"Дедлайн: {p.Deadline:yyyy-MM-dd}",
                Location = new Point(10, 36),
                AutoSize = false,
                Width = 300,
                Height = 20
            };

            var btnOpen = new Button
            {
                Text = "Відкрити",
                Size = new Size(90, 30),
                Location = new Point(panel.Width - 190, 20),
                Tag = p
            };
            btnOpen.Click += (s, e) =>
            {
                var proj = (s as Button).Tag as Project;
                var board = new FormBoard(proj, projects);
                board.ShowDialog();
                // Після закриття дошки - зберегти та оновити
                SaveData();
                RenderProjects();
            };

            var btnDelete = new Button
            {
                Text = "Видалити",
                Size = new Size(90, 30),
                Location = new Point(panel.Width - 95, 20),
                BackColor = Color.LightCoral,
                Tag = p
            };
            btnDelete.Click += (s, e) =>
            {
                var proj = (s as Button).Tag as Project;
                if (MessageBox.Show($"Видалити проект \"{proj.Name}\"?", "Підтвердження", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    projects.Remove(proj);
                    SaveData();
                    RenderProjects();
                }
            };

            panel.Controls.Add(lblTitle);
            panel.Controls.Add(lblDeadline);
            panel.Controls.Add(btnOpen);
            panel.Controls.Add(btnDelete);

            // щоб весь панель кликався для відкриття (альтернатива)
            panel.Click += (s, e) =>
            {
                var board = new FormBoard(p, projects);
                board.ShowDialog();
                SaveData();
                RenderProjects();
            };

            return panel;
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            using (var f = new FormAddProject())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    var proj = new Project
                    {
                        Name = f.ProjectName,
                        Deadline = f.ProjectDeadline
                    };
                    projects.Add(proj);
                    SaveData();
                    RenderProjects();
                }
            }
        }
    }
}
