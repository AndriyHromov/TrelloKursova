namespace TrelloKursova
{
    partial class FormBoard
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
            this.flpToDo = new System.Windows.Forms.FlowLayoutPanel();
            this.flpInProgress = new System.Windows.Forms.FlowLayoutPanel();
            this.flpDone = new System.Windows.Forms.FlowLayoutPanel();
            this.lblToDo = new System.Windows.Forms.Label();
            this.lblInProgress = new System.Windows.Forms.Label();
            this.lblDone = new System.Windows.Forms.Label();
            this.btnAddToDo = new System.Windows.Forms.Button();
            this.btnAddInProgress = new System.Windows.Forms.Button();
            this.btnAddDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpToDo
            // 
            this.flpToDo.AutoScroll = true;
            this.flpToDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpToDo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpToDo.Location = new System.Drawing.Point(28, 46);
            this.flpToDo.Name = "flpToDo";
            this.flpToDo.Size = new System.Drawing.Size(300, 500);
            this.flpToDo.TabIndex = 0;
            this.flpToDo.WrapContents = false;
            // 
            // flpInProgress
            // 
            this.flpInProgress.AutoScroll = true;
            this.flpInProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpInProgress.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpInProgress.Location = new System.Drawing.Point(387, 46);
            this.flpInProgress.Name = "flpInProgress";
            this.flpInProgress.Size = new System.Drawing.Size(300, 500);
            this.flpInProgress.TabIndex = 1;
            this.flpInProgress.WrapContents = false;
            // 
            // flpDone
            // 
            this.flpDone.AutoScroll = true;
            this.flpDone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpDone.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDone.Location = new System.Drawing.Point(745, 46);
            this.flpDone.Name = "flpDone";
            this.flpDone.Size = new System.Drawing.Size(300, 500);
            this.flpDone.TabIndex = 2;
            this.flpDone.WrapContents = false;
            // 
            // lblToDo
            // 
            this.lblToDo.AutoSize = true;
            this.lblToDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblToDo.Location = new System.Drawing.Point(132, 9);
            this.lblToDo.Name = "lblToDo";
            this.lblToDo.Size = new System.Drawing.Size(95, 32);
            this.lblToDo.TabIndex = 3;
            this.lblToDo.Text = "To Do";
            // 
            // lblInProgress
            // 
            this.lblInProgress.AutoSize = true;
            this.lblInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblInProgress.Location = new System.Drawing.Point(457, 9);
            this.lblInProgress.Name = "lblInProgress";
            this.lblInProgress.Size = new System.Drawing.Size(168, 32);
            this.lblInProgress.TabIndex = 4;
            this.lblInProgress.Text = "In Progress";
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblDone.Location = new System.Drawing.Point(856, 9);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(86, 32);
            this.lblDone.TabIndex = 5;
            this.lblDone.Text = "Done";
            // 
            // btnAddToDo
            // 
            this.btnAddToDo.Location = new System.Drawing.Point(96, 552);
            this.btnAddToDo.Name = "btnAddToDo";
            this.btnAddToDo.Size = new System.Drawing.Size(170, 30);
            this.btnAddToDo.TabIndex = 6;
            this.btnAddToDo.Text = "Додати завдання";
            this.btnAddToDo.UseVisualStyleBackColor = true;
            this.btnAddToDo.Click += new System.EventHandler(this.btnAddToDo_Click);
            // 
            // btnAddInProgress
            // 
            this.btnAddInProgress.Location = new System.Drawing.Point(455, 552);
            this.btnAddInProgress.Name = "btnAddInProgress";
            this.btnAddInProgress.Size = new System.Drawing.Size(170, 30);
            this.btnAddInProgress.TabIndex = 7;
            this.btnAddInProgress.Text = "Додати завдання";
            this.btnAddInProgress.UseVisualStyleBackColor = true;
            this.btnAddInProgress.Click += new System.EventHandler(this.btnAddInProgress_Click);
            // 
            // btnAddDone
            // 
            this.btnAddDone.Location = new System.Drawing.Point(816, 552);
            this.btnAddDone.Name = "btnAddDone";
            this.btnAddDone.Size = new System.Drawing.Size(170, 30);
            this.btnAddDone.TabIndex = 8;
            this.btnAddDone.Text = "Додати завдання";
            this.btnAddDone.UseVisualStyleBackColor = true;
            this.btnAddDone.Click += new System.EventHandler(this.btnAddDone_Click);
            // 
            // FormBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 644);
            this.Controls.Add(this.btnAddDone);
            this.Controls.Add(this.btnAddInProgress);
            this.Controls.Add(this.btnAddToDo);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.lblInProgress);
            this.Controls.Add(this.lblToDo);
            this.Controls.Add(this.flpDone);
            this.Controls.Add(this.flpInProgress);
            this.Controls.Add(this.flpToDo);
            this.Name = "FormBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Дошка проекту";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpToDo;
        private System.Windows.Forms.FlowLayoutPanel flpInProgress;
        private System.Windows.Forms.FlowLayoutPanel flpDone;
        private System.Windows.Forms.Label lblToDo;
        private System.Windows.Forms.Label lblInProgress;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Button btnAddToDo;
        private System.Windows.Forms.Button btnAddInProgress;
        private System.Windows.Forms.Button btnAddDone;
    }
}
