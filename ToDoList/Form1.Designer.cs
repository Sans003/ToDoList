using System.Drawing;

namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.add_btn = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.rem_btn = new System.Windows.Forms.Button();
            this.urgency_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(219)))), ((int)(((byte)(251)))));
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(190)))), ((int)(((byte)(248)))));
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.add_btn.Location = new System.Drawing.Point(492, 37);
            this.add_btn.Margin = new System.Windows.Forms.Padding(0);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(128, 61);
            this.add_btn.TabIndex = 0;
            this.add_btn.Text = "Add Entry";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(219)))), ((int)(((byte)(251)))));
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(18, 17);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(420, 760);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.ThreeDCheckBoxes = true;
            // 
            // rem_btn
            // 
            this.rem_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(219)))), ((int)(((byte)(251)))));
            this.rem_btn.FlatAppearance.BorderSize = 0;
            this.rem_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(190)))), ((int)(((byte)(248)))));
            this.rem_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rem_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rem_btn.Location = new System.Drawing.Point(492, 120);
            this.rem_btn.Margin = new System.Windows.Forms.Padding(0);
            this.rem_btn.Name = "rem_btn";
            this.rem_btn.Size = new System.Drawing.Size(128, 61);
            this.rem_btn.TabIndex = 2;
            this.rem_btn.Text = "Remove Entry";
            this.rem_btn.UseVisualStyleBackColor = false;
            this.rem_btn.Click += new System.EventHandler(this.rem_btn_Click);
            // 
            // urgency_btn
            // 
            this.urgency_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(219)))), ((int)(((byte)(251)))));
            this.urgency_btn.FlatAppearance.BorderSize = 0;
            this.urgency_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(190)))), ((int)(((byte)(248)))));
            this.urgency_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urgency_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.urgency_btn.Location = new System.Drawing.Point(492, 286);
            this.urgency_btn.Margin = new System.Windows.Forms.Padding(0);
            this.urgency_btn.Name = "urgency_btn";
            this.urgency_btn.Size = new System.Drawing.Size(128, 61);
            this.urgency_btn.TabIndex = 3;
            this.urgency_btn.Text = "Change Importance";
            this.urgency_btn.UseVisualStyleBackColor = false;
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(219)))), ((int)(((byte)(251)))));
            this.edit_btn.FlatAppearance.BorderSize = 0;
            this.edit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(190)))), ((int)(((byte)(248)))));
            this.edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.edit_btn.Location = new System.Drawing.Point(492, 203);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(0);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(128, 61);
            this.edit_btn.TabIndex = 4;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(160)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(650, 800);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.urgency_btn);
            this.Controls.Add(this.rem_btn);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.add_btn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1050, 1385);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(30, 83, 30, 28);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.MenuText;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button rem_btn;
        private System.Windows.Forms.Button urgency_btn;
        private System.Windows.Forms.Button edit_btn;
    }
}

