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
using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;

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
            using (var db = new ToDoDB())
            {
                try
                {
                    var items = from b in db.ToDoItems
                                orderby b.Importance
                                select b;
                    if (items != null)
                    {
                        foreach (var item in items)
                        {
                            checkedListBox1.Items.Add($"{item.Name} - {item.Importance}");
                        }
                        db.SaveChanges();
                    }
                }
                catch 
                {
                    Debug.Write("No Items in DB");
                }
            }
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
            return value.ToString();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            using (var db = new ToDoDB())
            {
                string value = "very important thing";
                var textValue = CustomTextDialog("Add Item", "Text Input To-Do Text", ref value);
                value = "";
                var Priority = CustomTextDialog("Add Priority", "Priority Input To-Do Text", ref value);
                checkedListBox1.Items.Add($"{textValue} - {Priority}");
                var item = new ToDoItem { Name = textValue , Importance = int.Parse(Priority)};
                db.ToDoItems.Add(item);
                db.SaveChanges();
            }
        }

        private void rem_btn_Click(object sender, EventArgs e)
        {
            using (var db = new ToDoDB())
            {
                var selItem = checkedListBox1.SelectedItem;
                checkedListBox1.Items.Remove(selItem);
                var item = new ToDoItem { Name = selItem.ToString() };
                var dbItem = db.ToDoItems.Find(selItem.ToString());
                if (dbItem != null)
                {
                    db.ToDoItems.Remove(dbItem);
                }
                db.SaveChanges();
            }
        }
        public void populateCheckedListBox()
        {
            checkedListBox1.Items.Clear();

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            string ref_val = $"{checkedListBox1.SelectedItem}";
            var value = CustomTextDialog($"Edit {checkedListBox1.SelectedItem}", "Enter New Title", ref ref_val);
            checkedListBox1.SelectedItem = value;
        }

    }
    public class ToDoItem
    {
        [Key]
        public string Name { get; set; }
        public int Importance { get; set; }
    }
    public class ToDoDB : DbContext
    {
        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}
