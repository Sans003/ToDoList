using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ToDoList;

public partial class Form1 : Form
{
    private TextBox textBox1;
    public List<string> itemNameList = new List<string>();
    public List<int> itemPrioList = new List<int>();
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        populateCheckedListBox();
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
            itemNameList.Add(textValue);
            itemPrioList.Add(int.Parse(Priority));
            checkedListBox1.Items.Add($"{textValue} - {Priority}");
            var item = new ToDoItem { Name = textValue, Importance = int.Parse(Priority) };
            db.ToDoItems.Add(item);
            db.SaveChanges();
            populateCheckedListBox();
        }
    }

    private void rem_btn_Click(object sender, EventArgs e)
    {
        using (var db = new ToDoDB())
        {
            var todoItem = db.ToDoItems.FirstOrDefault(x => x.Id == (checkedListBox1.SelectedIndex));
            checkedListBox1.Items.Remove(todoItem);
            var item = new ToDoItem { Name = todoItem.ToString() };
            db.ToDoItems.Remove(todoItem);
            db.SaveChanges();
            populateCheckedListBox();
        }
    }

    public void populateCheckedListBox()
    {
        checkedListBox1.Items.Clear();

        using (var db = new ToDoDB())
        {
            db.Database.EnsureCreated();
            try
            {
                var items = from b in db.ToDoItems
                            orderby b.Importance
                            select b;
                if (items != null)
                {
                    foreach (var item in items)
                    {
                        itemNameList.Add(item.Name);
                        itemPrioList.Add(item.Importance);
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

    private void edit_btn_Click(object sender, EventArgs e)
    {
        using (var db = new ToDoDB())
        {
            string ref_val = itemNameList[checkedListBox1.SelectedIndex];
            var value = CustomTextDialog($"Edit {itemNameList[checkedListBox1.SelectedIndex]}", "Enter New Title", ref ref_val);
            itemNameList[checkedListBox1.SelectedIndex] = value;
            var todoItem = db.ToDoItems.FirstOrDefault(x => x.Id == (checkedListBox1.SelectedIndex));
            todoItem.Name = value;
            checkedListBox1.SelectedItem = $"{itemNameList[checkedListBox1.SelectedIndex]} - {itemPrioList[checkedListBox1.SelectedIndex]}";
            checkedListBox1.Refresh();
        }
        populateCheckedListBox();
    }
}

public class ToDoItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Importance { get; set; }
}

public class ToDoDB : DbContext
{
    public DbSet<ToDoItem> ToDoItems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=stupid;Trusted_Connection=True;MultipleActiveResultSets=True;Trust Server Certificate=True;App=ToDo");
    }
}
