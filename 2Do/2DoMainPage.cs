namespace _2Do
{
    public partial class MainPage : Form
    {
        bool SidebarExpanded;

        public MainPage()
        {
            InitializeComponent();
        }

        private void SidebarTimer_Tick(object sender, EventArgs e)
        {
            if (SidebarExpanded)
            {
                Sidebar.Height -= 15;
                if (Sidebar.Height == Sidebar.MinimumSize.Height)
                {
                    SidebarExpanded = false;
                    SidebarTimer.Stop();
                }
            }
            else
            {
                Sidebar.Height += 15;
                if (Sidebar.Height == Sidebar.MaximumSize.Height)
                {
                    SidebarExpanded = true;
                    SidebarTimer.Stop();
                }
            }
        }


        public void loadform(object Form)
        {
            if (this.MainDisplay.Controls.Count > 0)
                this.MainDisplay.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainDisplay.Controls.Add(f);
            this.MainDisplay.Tag = f;
            f.Show();
        }

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuBTN_Click(object sender, EventArgs e)
        {
            SidebarTimer.Start();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            loadform(new Displaying2Do());
        }

        private void ViewToDoBTN_Click(object sender, EventArgs e)
        {
            loadform(new Displaying2Do());
        }

        private void AddTaskPageBTN_Click(object sender, EventArgs e)
        {
            loadform(new Adding2Do());
        }

        // Main menu label
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}