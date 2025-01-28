namespace WinformTodo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            lbTaskList.Items.Add(myTodo.ToString());

            ClearForm();
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
    }
}
