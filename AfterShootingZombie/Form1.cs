namespace AfterShootingZombie
{
    public partial class Form1 : Form
    {
        IEnumerable<string> backupItems;

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            personListBox.Items.Add("Ali");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                Random random = new();
                long code = random.Next(10000, 99999);

                personListBox.Items.Add($"{i}. {code}");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var items = personListBox.Items.Cast<string>();
            backupItems = items;
            personListBox.Items.Clear();
            var data = items;//.Where(c => c == textBox1.Text);

            foreach (var item in data)
                personListBox.Items.Add(item);

        }
    }
}
