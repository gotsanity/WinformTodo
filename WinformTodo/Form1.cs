namespace WinformTodo
{
    public partial class Form1 : Form
    {
        private List<Todo> TaskList { get; set; }

        public Form1()
        {
            InitializeComponent();
            TaskList = new List<Todo>();
        }

        private void submitForm(object sender, EventArgs e)
        {
            // check if the todo is valid
            // if it is not, display an error
            // exit
            if (Validators.IsEmptyText(txtTaskDescription)) // description must exist, due date must be formatted as a valid date
            {
                MessageBox.Show("Description is empty, please provide a description.");
                return;
            }

            if (Validators.IsTextNull(txtTaskDescription))
            {
                MessageBox.Show("Description needs to be created.");
                return;
            }

            if (Validators.IsEmptyText(txtDueDate))
            {
                MessageBox.Show("Missing a due date.");
                return;
            }

            if (!Validators.IsValidDate(txtDueDate))
            {
                MessageBox.Show("Date is incorrectly formatted, please resubmit.");
                return;
            }



            // where we handle the add event
            Todo myTodo = new Todo(txtTaskDescription.Text, DateTime.Parse(txtDueDate.Text));

            // take todo and insert into my list
            TaskList.Add(myTodo);

            UpdateListBox();

            ClearForm();
        }

        public void UpdateListBox()
        {
            // clear the contents of the list box
            lbTaskList.Items.Clear();

            // transform the list
            var list = TaskList
                //.Where(t => t.IsDone == false)
                .OrderBy(t => t.DueDate)
                .ToList();


            // read in the new contents
            for (int i = 0; i < list.Count; i++)
            {
                lbTaskList.Items.Add(list[i].ToString());
            }

            // cleanup if required
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
            MessageBox.Show("Form Cleared");
        }

        private void ClearForm()
        {
            txtTaskDescription.Clear();
            txtDueDate.Clear();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                submitForm(sender, e);
            }
        }

        private void lbTaskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show($"Selected Index is: {lbTaskList.SelectedIndex}");

            int selectedIndex = lbTaskList.SelectedIndex;
            string selectedItem = (string)lbTaskList.SelectedItem;

            if (selectedIndex == -1)
            {
                return;
            }

            if (selectedItem == null)
            {
                MessageBox.Show("No item selected at the index.");
                return;
            }

            // STRING FORMAT: # - 01-01-2025 - description - status: complete

            int id = Int32.Parse(selectedItem.Split(" - ")[0]);

            // find the item in the list with the matching id, toggle its complete status
            var todo = TaskList.Find(t => t.Id == id);

            if (todo != null)
            {
                todo.IsDone = !todo.IsDone;

                UpdateListBox();
            }
        }
    }
}
