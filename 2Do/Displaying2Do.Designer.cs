namespace _2Do
{
    partial class Displaying2Do
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
            TaskOutputter = new RichTextBox();
            ClearBTN = new Button();
            FindByIDBTN = new Button();
            FindByTitleBTN = new Button();
            groupBox1 = new GroupBox();
            StatusTB = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            FindByPriorityBTN = new Button();
            groupBox3 = new GroupBox();
            RemoveBTN = new Button();
            MarkCompleteBTN = new Button();
            ChnPriorityBTN = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // TaskOutputter
            // 
            TaskOutputter.BackColor = SystemColors.ActiveCaption;
            TaskOutputter.Location = new Point(134, 12);
            TaskOutputter.Name = "TaskOutputter";
            TaskOutputter.ReadOnly = true;
            TaskOutputter.Size = new Size(414, 356);
            TaskOutputter.TabIndex = 0;
            TaskOutputter.Text = "";
            // 
            // ClearBTN
            // 
            ClearBTN.BackColor = Color.IndianRed;
            ClearBTN.Cursor = Cursors.Hand;
            ClearBTN.FlatStyle = FlatStyle.Flat;
            ClearBTN.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ClearBTN.Location = new Point(12, 345);
            ClearBTN.Name = "ClearBTN";
            ClearBTN.Size = new Size(112, 23);
            ClearBTN.TabIndex = 2;
            ClearBTN.Text = "Clear";
            ClearBTN.UseVisualStyleBackColor = false;
            ClearBTN.Click += ClearBTN_Click;
            // 
            // FindByIDBTN
            // 
            FindByIDBTN.Cursor = Cursors.Hand;
            FindByIDBTN.FlatStyle = FlatStyle.Flat;
            FindByIDBTN.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FindByIDBTN.Location = new Point(6, 22);
            FindByIDBTN.Name = "FindByIDBTN";
            FindByIDBTN.Size = new Size(100, 23);
            FindByIDBTN.TabIndex = 3;
            FindByIDBTN.Text = "Find by ID";
            FindByIDBTN.UseVisualStyleBackColor = true;
            FindByIDBTN.Click += FindByIDBTN_Click;
            // 
            // FindByTitleBTN
            // 
            FindByTitleBTN.Cursor = Cursors.Hand;
            FindByTitleBTN.FlatStyle = FlatStyle.Flat;
            FindByTitleBTN.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FindByTitleBTN.Location = new Point(6, 62);
            FindByTitleBTN.Name = "FindByTitleBTN";
            FindByTitleBTN.Size = new Size(100, 23);
            FindByTitleBTN.TabIndex = 4;
            FindByTitleBTN.Text = "Find by Title";
            FindByTitleBTN.UseVisualStyleBackColor = true;
            FindByTitleBTN.Click += FindByTitleBTN_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(StatusTB);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 374);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(204, 91);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Stats";
            // 
            // StatusTB
            // 
            StatusTB.Cursor = Cursors.No;
            StatusTB.Location = new Point(78, 20);
            StatusTB.Name = "StatusTB";
            StatusTB.ReadOnly = true;
            StatusTB.Size = new Size(40, 27);
            StatusTB.TabIndex = 6;
            StatusTB.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 6;
            label1.Text = "2Do's ->";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(FindByPriorityBTN);
            groupBox2.Controls.Add(FindByIDBTN);
            groupBox2.Controls.Add(FindByTitleBTN);
            groupBox2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(112, 146);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filters";
            // 
            // FindByPriorityBTN
            // 
            FindByPriorityBTN.Cursor = Cursors.Hand;
            FindByPriorityBTN.FlatStyle = FlatStyle.Flat;
            FindByPriorityBTN.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FindByPriorityBTN.Location = new Point(6, 102);
            FindByPriorityBTN.Name = "FindByPriorityBTN";
            FindByPriorityBTN.Size = new Size(100, 23);
            FindByPriorityBTN.TabIndex = 5;
            FindByPriorityBTN.Text = "Find by Priority";
            FindByPriorityBTN.UseVisualStyleBackColor = true;
            FindByPriorityBTN.Click += FindByPriorityBTN_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(ChnPriorityBTN);
            groupBox3.Controls.Add(RemoveBTN);
            groupBox3.Controls.Add(MarkCompleteBTN);
            groupBox3.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(12, 164);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(112, 175);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Edit";
            // 
            // RemoveBTN
            // 
            RemoveBTN.Cursor = Cursors.Hand;
            RemoveBTN.FlatStyle = FlatStyle.Flat;
            RemoveBTN.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveBTN.Location = new Point(6, 22);
            RemoveBTN.Name = "RemoveBTN";
            RemoveBTN.Size = new Size(100, 23);
            RemoveBTN.TabIndex = 3;
            RemoveBTN.Text = "Remove";
            RemoveBTN.UseVisualStyleBackColor = true;
            RemoveBTN.Click += RemoveBTN_Click;
            // 
            // MarkCompleteBTN
            // 
            MarkCompleteBTN.Cursor = Cursors.Hand;
            MarkCompleteBTN.FlatStyle = FlatStyle.Flat;
            MarkCompleteBTN.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MarkCompleteBTN.Location = new Point(6, 62);
            MarkCompleteBTN.Name = "MarkCompleteBTN";
            MarkCompleteBTN.Size = new Size(100, 23);
            MarkCompleteBTN.TabIndex = 4;
            MarkCompleteBTN.Text = "Mark complete";
            MarkCompleteBTN.UseVisualStyleBackColor = true;
            MarkCompleteBTN.Click += MarkCompleteBTN_Click;
            // 
            // ChnPriorityBTN
            // 
            ChnPriorityBTN.Cursor = Cursors.Hand;
            ChnPriorityBTN.FlatStyle = FlatStyle.Flat;
            ChnPriorityBTN.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ChnPriorityBTN.Location = new Point(6, 102);
            ChnPriorityBTN.Name = "ChnPriorityBTN";
            ChnPriorityBTN.Size = new Size(100, 44);
            ChnPriorityBTN.TabIndex = 5;
            ChnPriorityBTN.Text = "Change task Priority";
            ChnPriorityBTN.UseVisualStyleBackColor = true;
            ChnPriorityBTN.Click += ChnPriorityBTN_Click;
            // 
            // Displaying2Do
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 482);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(ClearBTN);
            Controls.Add(TaskOutputter);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Displaying2Do";
            Load += Displaying2Do_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox TaskOutputter;
        private Button ClearBTN;
        private Button FindByIDBTN;
        private Button FindByTitleBTN;
        private GroupBox groupBox1;
        private TextBox StatusTB;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button RemoveBTN;
        private Button MarkCompleteBTN;
        private Button FindByPriorityBTN;
        private Button ChnPriorityBTN;
    }
}