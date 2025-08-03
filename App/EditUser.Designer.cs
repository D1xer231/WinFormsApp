namespace App
{
    partial class EditUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordEdit = new System.Windows.Forms.TextBox();
            this.EmailEdit = new System.Windows.Forms.TextBox();
            this.UpdateData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(125, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Панель пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(107, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Редактирование пользователя с логином \"Admin\"";
            // 
            // PasswordEdit
            // 
            this.PasswordEdit.BackColor = System.Drawing.Color.Teal;
            this.PasswordEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordEdit.ForeColor = System.Drawing.Color.PowderBlue;
            this.PasswordEdit.Location = new System.Drawing.Point(183, 207);
            this.PasswordEdit.Name = "PasswordEdit";
            this.PasswordEdit.Size = new System.Drawing.Size(200, 24);
            this.PasswordEdit.TabIndex = 5;
            this.PasswordEdit.Enter += new System.EventHandler(this.TextBox_Enter);
            this.PasswordEdit.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // EmailEdit
            // 
            this.EmailEdit.BackColor = System.Drawing.Color.Teal;
            this.EmailEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailEdit.ForeColor = System.Drawing.Color.PowderBlue;
            this.EmailEdit.Location = new System.Drawing.Point(183, 165);
            this.EmailEdit.Name = "EmailEdit";
            this.EmailEdit.Size = new System.Drawing.Size(200, 24);
            this.EmailEdit.TabIndex = 4;
            this.EmailEdit.Enter += new System.EventHandler(this.TextBox_Enter);
            this.EmailEdit.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // UpdateData
            // 
            this.UpdateData.BackColor = System.Drawing.Color.LightSeaGreen;
            this.UpdateData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpdateData.Location = new System.Drawing.Point(199, 278);
            this.UpdateData.Name = "UpdateData";
            this.UpdateData.Size = new System.Drawing.Size(165, 31);
            this.UpdateData.TabIndex = 6;
            this.UpdateData.Text = "Изменить данные";
            this.UpdateData.UseVisualStyleBackColor = false;
            this.UpdateData.Click += new System.EventHandler(this.UpdateData_Click);
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.UpdateData);
            this.Controls.Add(this.PasswordEdit);
            this.Controls.Add(this.EmailEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditUser";
            this.Enter += new System.EventHandler(this.TextBox_Enter);
            this.Leave += new System.EventHandler(this.TextBox_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordEdit;
        private System.Windows.Forms.TextBox EmailEdit;
        private System.Windows.Forms.Button UpdateData;
    }
}