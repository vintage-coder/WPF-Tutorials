
namespace CRUDWinForm.Views.UserControls
{
    partial class EmployeeListViewUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.EmployeeGridView = new System.Windows.Forms.DataGridView();
            this.OptionContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).BeginInit();
            this.OptionContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeGridView
            // 
            this.EmployeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeGridView.Location = new System.Drawing.Point(3, 3);
            this.EmployeeGridView.Name = "EmployeeGridView";
            this.EmployeeGridView.RowHeadersWidth = 51;
            this.EmployeeGridView.RowTemplate.Height = 24;
            this.EmployeeGridView.Size = new System.Drawing.Size(795, 387);
            this.EmployeeGridView.TabIndex = 0;
            this.EmployeeGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeGridView_CellClick);
            this.EmployeeGridView.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeGridView_CellMouseLeave);
            this.EmployeeGridView.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EmployeeGridView_CellMouseMove);
            // 
            // OptionContextMenuStrip
            // 
            this.OptionContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.OptionContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.OptionContextMenuStrip.Name = "OptionContextMenuStrip";
            this.OptionContextMenuStrip.Size = new System.Drawing.Size(123, 76);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // EmployeeListViewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EmployeeGridView);
            this.Name = "EmployeeListViewUC";
            this.Size = new System.Drawing.Size(801, 378);
            this.Load += new System.EventHandler(this.EmployeeListViewUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).EndInit();
            this.OptionContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeGridView;
        private System.Windows.Forms.ContextMenuStrip OptionContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
