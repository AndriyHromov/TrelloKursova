using System;
using System.Windows.Forms;

namespace TrelloKursova
{
    public partial class FormAddProject : Form
    {
        public string ProjectName => txtName.Text.Trim();
        public DateTime ProjectDeadline => dateDeadline.Value.Date;

        public FormAddProject()
        {
            InitializeComponent();
            // ініціальна дата дедлайну (опціонально)
            dateDeadline.Value = DateTime.Now.Date.AddDays(7);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введіть назву проекту.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
