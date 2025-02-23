using WinformTodo;

namespace WinFormsAppJJ
{
    public partial class Form1 : Form
    {
        private List<Todo> TaskList {  get; set; }
        public Form1()
        {
            InitializeComponent();
            TaskList = new List<Todo>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

//        private void lbTaskList_SelectedIndexChanged(object sender, EventArgs e)
//        {
////int selectedIndex = lbTaskList.SelectedIndex;
//            //string selectedItem = (string)lbTaskList.SelectedItem;

//            if (selectedIndex == -1)
//            {
//                return;
//            }

//            if (selectedItem == null)
//            {
//                MessageBox.Show("No item selected at the index.");
//                return;
//            }

//            int id = Int32.Parse(selectedItem.Split(" - ")[0]);
//            var todo = TaskList.Find(t=>t.Id == id);
//            if (todo != null)
//            {
//                todo.IsDone = !todo.IsDone;
//                UpdateListBox();
//            }
//        }

        private void gbTaskList_Enter(object sender, EventArgs e)
        {

        }

        private void submitForm(object sender, EventArgs e)
        {
            if (Validators.IsEmptyText(txtTaskDescription))
            {
                MessageBox.Show("Description is empty, please provide a description");
                return;
            }
            
            if (Validators.IsTextNull(txtTaskDescription))
            {
                MessageBox.Show("Description needs to be created");
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

            Todo myTodo = new Todo(txtTaskDescription.Text, DateTime.Parse(txtDueDate.Text));

            TaskList.Add(myTodo);
            FpTasks.Controls.Add(new TaskControl(myTodo));
            UpdateListBox();
            ClearForm();
        }

        public void UpdateListBox()
        {
            //lbTaskList.Items.Clear();
            var list = TaskList
            .OrderBy(t =>t.DueDate)
            .ToList();

            for (int i = 0; i < list.Count; i++)
            {
                //lbTaskList.Items.Add(list[i].ToString());
            }
        }
        private void txtDueDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTaskDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
