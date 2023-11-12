namespace _2Do
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            Sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            MenuBTN = new PictureBox();
            panel2 = new Panel();
            ViewToDoBTN = new Button();
            panel3 = new Panel();
            AddTaskPageBTN = new Button();
            SidebarTimer = new System.Windows.Forms.Timer(components);
            MainDisplay = new Panel();
            Sidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuBTN).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // Sidebar
            // 
            Sidebar.BackColor = SystemColors.ControlDarkDark;
            Sidebar.Controls.Add(panel1);
            Sidebar.Controls.Add(panel2);
            Sidebar.Controls.Add(panel3);
            Sidebar.Location = new Point(0, 0);
            Sidebar.MaximumSize = new Size(139, 483);
            Sidebar.MinimumSize = new Size(139, 44);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(139, 44);
            Sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(MenuBTN);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(132, 41);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(56, 10);
            label1.Name = "label1";
            label1.Size = new Size(41, 17);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            label1.Click += label1_Click;
            // 
            // MenuBTN
            // 
            MenuBTN.Cursor = Cursors.Hand;
            MenuBTN.Image = (Image)resources.GetObject("MenuBTN.Image");
            MenuBTN.Location = new Point(3, 3);
            MenuBTN.Name = "MenuBTN";
            MenuBTN.Size = new Size(34, 34);
            MenuBTN.TabIndex = 1;
            MenuBTN.TabStop = false;
            MenuBTN.Click += MenuBTN_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(ViewToDoBTN);
            panel2.Location = new Point(3, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(144, 37);
            panel2.TabIndex = 2;
            // 
            // ViewToDoBTN
            // 
            ViewToDoBTN.BackColor = SystemColors.ControlDarkDark;
            ViewToDoBTN.Cursor = Cursors.Hand;
            ViewToDoBTN.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ViewToDoBTN.Image = (Image)resources.GetObject("ViewToDoBTN.Image");
            ViewToDoBTN.ImageAlign = ContentAlignment.MiddleLeft;
            ViewToDoBTN.Location = new Point(-22, -15);
            ViewToDoBTN.Name = "ViewToDoBTN";
            ViewToDoBTN.Padding = new Padding(20, 0, 0, 0);
            ViewToDoBTN.Size = new Size(172, 71);
            ViewToDoBTN.TabIndex = 3;
            ViewToDoBTN.Text = "          View 2Do";
            ViewToDoBTN.TextAlign = ContentAlignment.MiddleLeft;
            ViewToDoBTN.UseVisualStyleBackColor = false;
            ViewToDoBTN.Click += ViewToDoBTN_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(AddTaskPageBTN);
            panel3.Location = new Point(3, 93);
            panel3.Name = "panel3";
            panel3.Size = new Size(144, 37);
            panel3.TabIndex = 5;
            // 
            // AddTaskPageBTN
            // 
            AddTaskPageBTN.BackColor = SystemColors.ControlDarkDark;
            AddTaskPageBTN.Cursor = Cursors.Hand;
            AddTaskPageBTN.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddTaskPageBTN.Image = (Image)resources.GetObject("AddTaskPageBTN.Image");
            AddTaskPageBTN.ImageAlign = ContentAlignment.MiddleLeft;
            AddTaskPageBTN.Location = new Point(-20, -14);
            AddTaskPageBTN.Name = "AddTaskPageBTN";
            AddTaskPageBTN.Padding = new Padding(20, 0, 0, 0);
            AddTaskPageBTN.Size = new Size(172, 71);
            AddTaskPageBTN.TabIndex = 4;
            AddTaskPageBTN.Text = "          Add a 2Do";
            AddTaskPageBTN.TextAlign = ContentAlignment.MiddleLeft;
            AddTaskPageBTN.UseVisualStyleBackColor = false;
            AddTaskPageBTN.Click += AddTaskPageBTN_Click;
            // 
            // SidebarTimer
            // 
            SidebarTimer.Interval = 7;
            SidebarTimer.Tick += SidebarTimer_Tick;
            // 
            // MainDisplay
            // 
            MainDisplay.Location = new Point(141, 0);
            MainDisplay.Name = "MainDisplay";
            MainDisplay.Size = new Size(560, 482);
            MainDisplay.TabIndex = 1;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 483);
            Controls.Add(MainDisplay);
            Controls.Add(Sidebar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "2Do";
            Load += MainPage_Load;
            Sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MenuBTN).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel Sidebar;
        private Panel panel1;
        private Panel panel2;
        private Button ViewToDoBTN;
        private Panel panel3;
        private Button AddTaskPageBTN;
        private Label label1;
        private PictureBox MenuBTN;
        private System.Windows.Forms.Timer SidebarTimer;
        private Panel MainDisplay;
    }
}