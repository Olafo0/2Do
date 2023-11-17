namespace _2Do
{
    partial class Adding2Do
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adding2Do));
            label1 = new Label();
            groupBox1 = new GroupBox();
            TitleTB = new TextBox();
            groupBox2 = new GroupBox();
            WordToLetterLB = new Label();
            DescriptionTB = new RichTextBox();
            AddBTN = new Button();
            groupBox3 = new GroupBox();
            PriorityCB = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(118, 21);
            label1.TabIndex = 0;
            label1.Text = "Creating a 2Do ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TitleTB);
            groupBox1.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 95);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Title";
            // 
            // TitleTB
            // 
            TitleTB.BackColor = SystemColors.ButtonShadow;
            TitleTB.Location = new Point(43, 41);
            TitleTB.Name = "TitleTB";
            TitleTB.Size = new Size(156, 25);
            TitleTB.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(WordToLetterLB);
            groupBox2.Controls.Add(DescriptionTB);
            groupBox2.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 134);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(248, 297);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Description";
            // 
            // WordToLetterLB
            // 
            WordToLetterLB.AutoSize = true;
            WordToLetterLB.Location = new Point(6, 274);
            WordToLetterLB.Name = "WordToLetterLB";
            WordToLetterLB.Size = new Size(14, 17);
            WordToLetterLB.TabIndex = 5;
            WordToLetterLB.Text = "x";
            // 
            // DescriptionTB
            // 
            DescriptionTB.BackColor = SystemColors.ButtonShadow;
            DescriptionTB.Location = new Point(6, 24);
            DescriptionTB.Name = "DescriptionTB";
            DescriptionTB.Size = new Size(236, 267);
            DescriptionTB.TabIndex = 3;
            DescriptionTB.Text = "";
            // 
            // AddBTN
            // 
            AddBTN.BackColor = Color.Green;
            AddBTN.Cursor = Cursors.Hand;
            AddBTN.FlatStyle = FlatStyle.Flat;
            AddBTN.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddBTN.Location = new Point(344, 384);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(123, 53);
            AddBTN.TabIndex = 3;
            AddBTN.Text = "Add";
            AddBTN.UseVisualStyleBackColor = false;
            AddBTN.Click += AddBTN_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(PriorityCB);
            groupBox3.Location = new Point(290, 34);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(202, 94);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Priority";
            // 
            // PriorityCB
            // 
            PriorityCB.BackColor = SystemColors.ButtonShadow;
            PriorityCB.DropDownStyle = ComboBoxStyle.DropDownList;
            PriorityCB.FormattingEnabled = true;
            PriorityCB.Items.AddRange(new object[] { "High", "Medium", "Low" });
            PriorityCB.Location = new Point(54, 40);
            PriorityCB.Name = "PriorityCB";
            PriorityCB.Size = new Size(106, 23);
            PriorityCB.TabIndex = 0;
            // 
            // Adding2Do
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(544, 443);
            Controls.Add(groupBox3);
            Controls.Add(AddBTN);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Adding2Do";
            Text = "Adding2Do";
            Load += Adding2Do_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RichTextBox DescriptionTB;
        private TextBox TitleTB;
        private Button AddBTN;
        private GroupBox groupBox3;
        private ComboBox PriorityCB;
        private Label WordToLetterLB;
    }
}