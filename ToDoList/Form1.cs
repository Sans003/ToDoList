using System;
using MetroFramework;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using MetroFramework.Forms;
using Microsoft.VisualBasic;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        private TextBox textBox1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        public static string CustomTextDialog(string title, string prompt, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = prompt;
            textBox.Text = value;

            buttonOk.Text = "Add";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBox.Location = new Point(20, 20);
            label.Location = new Point(20, 5);
            buttonOk.Location = new Point(100, 50);
            buttonCancel.Location = new Point(50, 50);

            form.ClientSize = new Size(200, 100);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult result = form.ShowDialog();
            value = textBox.Text;
            return Convert.ToString(value);
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string value = "very important thing";
            var textValue = CustomTextDialog("Add Item", "Input To-Do Text", ref value);
            checkedListBox1.Items.Add(textValue);
        }

        private void rem_btn_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);
        }
    }
}
