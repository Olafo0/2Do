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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            panel2 = new Panel();
            ViewToDoBTN = new Button();
            panel3 = new Panel();
            AddTaskPageBTN = new Button();
            MainDisplay = new Panel();
            panel4 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(ViewToDoBTN);
            panel2.Location = new Point(0, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(139, 37);
            panel2.TabIndex = 2;
            // 
            // ViewToDoBTN
            // 
            ViewToDoBTN.BackColor = SystemColors.ControlDarkDark;
            ViewToDoBTN.Cursor = Cursors.Hand;
            ViewToDoBTN.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ViewToDoBTN.Image = (Image)resources.GetObject("ViewToDoBTN.Image");
            ViewToDoBTN.ImageAlign = ContentAlignment.MiddleLeft;
            ViewToDoBTN.Location = new Point(-17, -14);
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
            panel3.Location = new Point(0, 127);
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
            AddTaskPageBTN.Location = new Point(-14, -14);
            AddTaskPageBTN.Name = "AddTaskPageBTN";
            AddTaskPageBTN.Padding = new Padding(20, 0, 0, 0);
            AddTaskPageBTN.Size = new Size(175, 67);
            AddTaskPageBTN.TabIndex = 4;
            AddTaskPageBTN.Text = "          Add a 2Do";
            AddTaskPageBTN.TextAlign = ContentAlignment.MiddleLeft;
            AddTaskPageBTN.UseVisualStyleBackColor = false;
            AddTaskPageBTN.Click += AddTaskPageBTN_Click;
            // 
            // MainDisplay
            // 
            MainDisplay.Location = new Point(145, 0);
            MainDisplay.Name = "MainDisplay";
            MainDisplay.Size = new Size(556, 482);
            MainDisplay.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlDarkDark;
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel3);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(139, 483);
            panel4.TabIndex = 0;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(702, 483);
            Controls.Add(panel4);
            Controls.Add(MainDisplay);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "2Do";
            Load += MainPage_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button ViewToDoBTN;
        private Panel panel3;
        private Button AddTaskPageBTN;
        private Panel MainDisplay;
        private Panel panel4;
    }
}