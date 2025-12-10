namespace TrelloKursova
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnAddProject = new System.Windows.Forms.Button();
            this.panelProjects = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(20, 20);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(150, 40);
            this.btnAddProject.TabIndex = 0;
            this.btnAddProject.Text = "Додати проект";
            this.btnAddProject.UseVisualStyleBackColor = true;

            // 🔥 ДОДАНО ВАЖЛИВЕ: тепер кнопка реагує на натискання
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // panelProjects
            // 
            this.panelProjects.AutoScroll = true;
            this.panelProjects.Location = new System.Drawing.Point(20, 80);
            this.panelProjects.Name = "panelProjects";
            this.panelProjects.Size = new System.Drawing.Size(840, 500);
            this.panelProjects.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.panelProjects);
            this.Controls.Add(this.btnAddProject);
            this.Name = "Form1";
            this.Text = "Перелік проектів";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.FlowLayoutPanel panelProjects;
    }
}
