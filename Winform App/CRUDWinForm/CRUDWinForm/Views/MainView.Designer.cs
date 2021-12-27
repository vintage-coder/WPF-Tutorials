
namespace CRUDWinForm
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.EmployeeBtn = new System.Windows.Forms.Button();
            this.userControlPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // EmployeeBtn
            // 
            this.EmployeeBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.EmployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeBtn.ForeColor = System.Drawing.Color.White;
            this.EmployeeBtn.Location = new System.Drawing.Point(53, 34);
            this.EmployeeBtn.Name = "EmployeeBtn";
            this.EmployeeBtn.Size = new System.Drawing.Size(155, 41);
            this.EmployeeBtn.TabIndex = 0;
            this.EmployeeBtn.Text = "Employee";
            this.EmployeeBtn.UseVisualStyleBackColor = false;
            this.EmployeeBtn.Click += new System.EventHandler(this.EmployeeBtn_Click);
            // 
            // userControlPanel
            // 
            this.userControlPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControlPanel.Location = new System.Drawing.Point(2, 98);
            this.userControlPanel.Name = "userControlPanel";
            this.userControlPanel.Size = new System.Drawing.Size(796, 424);
            this.userControlPanel.TabIndex = 1;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.userControlPanel);
            this.Controls.Add(this.EmployeeBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee DataGrid Project";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EmployeeBtn;
        private System.Windows.Forms.Panel userControlPanel;
    }
}

