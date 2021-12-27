
namespace CRUDWinForm.Views.UserControls
{
    partial class EmployeeDetailViewUC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.empidtext = new System.Windows.Forms.TextBox();
            this.firstnametext = new System.Windows.Forms.TextBox();
            this.lastnametext = new System.Windows.Forms.TextBox();
            this.emailidtext = new System.Windows.Forms.TextBox();
            this.RolecomboBox = new System.Windows.Forms.ComboBox();
            this.membercheckBox = new System.Windows.Forms.CheckBox();
            this.StatuscheckBox = new System.Windows.Forms.CheckBox();
            this.dobdateTimePick = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dobdateTimePick);
            this.panel1.Controls.Add(this.StatuscheckBox);
            this.panel1.Controls.Add(this.membercheckBox);
            this.panel1.Controls.Add(this.RolecomboBox);
            this.panel1.Controls.Add(this.emailidtext);
            this.panel1.Controls.Add(this.lastnametext);
            this.panel1.Controls.Add(this.firstnametext);
            this.panel1.Controls.Add(this.empidtext);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CancelBtn);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 452);
            this.panel1.TabIndex = 0;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(397, 342);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(103, 39);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(397, 399);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(103, 37);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Emp id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Is member";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Role";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Date of Birth";
            // 
            // empidtext
            // 
            this.empidtext.Location = new System.Drawing.Point(218, 24);
            this.empidtext.Name = "empidtext";
            this.empidtext.Size = new System.Drawing.Size(122, 22);
            this.empidtext.TabIndex = 10;
            // 
            // firstnametext
            // 
            this.firstnametext.Location = new System.Drawing.Point(218, 67);
            this.firstnametext.Name = "firstnametext";
            this.firstnametext.Size = new System.Drawing.Size(122, 22);
            this.firstnametext.TabIndex = 11;
            // 
            // lastnametext
            // 
            this.lastnametext.Location = new System.Drawing.Point(218, 125);
            this.lastnametext.Name = "lastnametext";
            this.lastnametext.Size = new System.Drawing.Size(122, 22);
            this.lastnametext.TabIndex = 12;
            // 
            // emailidtext
            // 
            this.emailidtext.Location = new System.Drawing.Point(218, 168);
            this.emailidtext.Name = "emailidtext";
            this.emailidtext.Size = new System.Drawing.Size(122, 22);
            this.emailidtext.TabIndex = 13;
            // 
            // RolecomboBox
            // 
            this.RolecomboBox.FormattingEnabled = true;
            this.RolecomboBox.Location = new System.Drawing.Point(220, 361);
            this.RolecomboBox.Name = "RolecomboBox";
            this.RolecomboBox.Size = new System.Drawing.Size(130, 24);
            this.RolecomboBox.TabIndex = 14;
            // 
            // membercheckBox
            // 
            this.membercheckBox.AutoSize = true;
            this.membercheckBox.Location = new System.Drawing.Point(220, 214);
            this.membercheckBox.Name = "membercheckBox";
            this.membercheckBox.Size = new System.Drawing.Size(95, 21);
            this.membercheckBox.TabIndex = 15;
            this.membercheckBox.Text = "Is Member";
            this.membercheckBox.UseVisualStyleBackColor = true;
            // 
            // StatuscheckBox
            // 
            this.StatuscheckBox.AutoSize = true;
            this.StatuscheckBox.Location = new System.Drawing.Point(220, 260);
            this.StatuscheckBox.Name = "StatuscheckBox";
            this.StatuscheckBox.Size = new System.Drawing.Size(70, 21);
            this.StatuscheckBox.TabIndex = 16;
            this.StatuscheckBox.Text = "Status";
            this.StatuscheckBox.UseVisualStyleBackColor = true;
            // 
            // dobdateTimePick
            // 
            this.dobdateTimePick.Location = new System.Drawing.Point(220, 312);
            this.dobdateTimePick.Name = "dobdateTimePick";
            this.dobdateTimePick.Size = new System.Drawing.Size(130, 22);
            this.dobdateTimePick.TabIndex = 17;
            // 
            // EmployeeDetailViewUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeDetailViewUC";
            this.Size = new System.Drawing.Size(519, 458);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox StatuscheckBox;
        private System.Windows.Forms.CheckBox membercheckBox;
        private System.Windows.Forms.ComboBox RolecomboBox;
        private System.Windows.Forms.TextBox emailidtext;
        private System.Windows.Forms.TextBox lastnametext;
        private System.Windows.Forms.TextBox firstnametext;
        private System.Windows.Forms.TextBox empidtext;
        private System.Windows.Forms.DateTimePicker dobdateTimePick;
    }
}
