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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            add_btn = new System.Windows.Forms.Button();
            checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            rem_btn = new System.Windows.Forms.Button();
            urgency_btn = new System.Windows.Forms.Button();
            edit_btn = new System.Windows.Forms.Button();
            stupidDataSetBindingSource = new System.Windows.Forms.BindingSource(components);
            stupidDataSet = new stupidDataSet();
            ((System.ComponentModel.ISupportInitialize)stupidDataSetBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stupidDataSet).BeginInit();
            SuspendLayout();
            // 
            // add_btn
            // 
            add_btn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            add_btn.AutoSize = true;
            add_btn.BackColor = Color.FromArgb(236, 219, 251);
            add_btn.FlatAppearance.BorderSize = 0;
            add_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 190, 248);
            add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            add_btn.ForeColor = Color.FromArgb(50, 50, 50);
            add_btn.Location = new Point(615, 94);
            add_btn.Margin = new System.Windows.Forms.Padding(0);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(128, 61);
            add_btn.TabIndex = 0;
            add_btn.Text = "Add Entry";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.FromArgb(236, 219, 251);
            checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            checkedListBox1.Dock = System.Windows.Forms.DockStyle.Left;
            checkedListBox1.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBox1.ForeColor = Color.FromArgb(50, 50, 50);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.HorizontalScrollbar = true;
            checkedListBox1.Location = new Point(30, 83);
            checkedListBox1.Margin = new System.Windows.Forms.Padding(0);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(569, 689);
            checkedListBox1.TabIndex = 1;
            checkedListBox1.ThreeDCheckBoxes = true;
            // 
            // rem_btn
            // 
            rem_btn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            rem_btn.AutoSize = true;
            rem_btn.BackColor = Color.FromArgb(236, 219, 251);
            rem_btn.FlatAppearance.BorderSize = 0;
            rem_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 190, 248);
            rem_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rem_btn.ForeColor = Color.FromArgb(50, 50, 50);
            rem_btn.Location = new Point(615, 177);
            rem_btn.Margin = new System.Windows.Forms.Padding(0);
            rem_btn.Name = "rem_btn";
            rem_btn.Size = new Size(128, 61);
            rem_btn.TabIndex = 2;
            rem_btn.Text = "Remove Entry";
            rem_btn.UseVisualStyleBackColor = false;
            rem_btn.Click += rem_btn_Click;
            // 
            // urgency_btn
            // 
            urgency_btn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            urgency_btn.BackColor = Color.FromArgb(236, 219, 251);
            urgency_btn.FlatAppearance.BorderSize = 0;
            urgency_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 190, 248);
            urgency_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            urgency_btn.ForeColor = Color.FromArgb(50, 50, 50);
            urgency_btn.Location = new Point(615, 343);
            urgency_btn.Margin = new System.Windows.Forms.Padding(0);
            urgency_btn.Name = "urgency_btn";
            urgency_btn.Size = new Size(128, 61);
            urgency_btn.TabIndex = 3;
            urgency_btn.Text = "Change Importance";
            urgency_btn.UseVisualStyleBackColor = false;
            // 
            // edit_btn
            // 
            edit_btn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            edit_btn.AutoSize = true;
            edit_btn.BackColor = Color.FromArgb(236, 219, 251);
            edit_btn.FlatAppearance.BorderSize = 0;
            edit_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(220, 190, 248);
            edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            edit_btn.ForeColor = Color.FromArgb(50, 50, 50);
            edit_btn.Location = new Point(615, 260);
            edit_btn.Margin = new System.Windows.Forms.Padding(0);
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(128, 61);
            edit_btn.TabIndex = 4;
            edit_btn.Text = "Edit";
            edit_btn.UseVisualStyleBackColor = false;
            edit_btn.Click += edit_btn_Click;
            // 
            // stupidDataSetBindingSource
            // 
            stupidDataSetBindingSource.DataSource = stupidDataSet;
            stupidDataSetBindingSource.Position = 0;
            // 
            // stupidDataSet
            // 
            stupidDataSet.DataSetName = "stupidDataSet";
            stupidDataSet.Namespace = "http://tempuri.org/stupidDataSet.xsd";
            stupidDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(203, 160, 243);
            ClientSize = new Size(756, 800);
            Controls.Add(edit_btn);
            Controls.Add(urgency_btn);
            Controls.Add(rem_btn);
            Controls.Add(checkedListBox1);
            Controls.Add(add_btn);
            Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4);
            MaximumSize = new Size(1050, 1385);
            Name = "Form1";
            Padding = new System.Windows.Forms.Padding(30, 83, 30, 28);
            StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            Text = "Form1";
            TransparencyKey = SystemColors.MenuText;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)stupidDataSetBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)stupidDataSet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button rem_btn;
        private System.Windows.Forms.Button urgency_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.BindingSource stupidDataSetBindingSource;
        private stupidDataSet stupidDataSet;
    }
}

