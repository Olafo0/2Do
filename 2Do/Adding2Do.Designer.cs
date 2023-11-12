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
            label1 = new Label();
            groupBox1 = new GroupBox();
            TitleTB = new TextBox();
            groupBox2 = new GroupBox();
            DescriptionTB = new RichTextBox();
            AddBTN = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            TitleTB.Location = new Point(43, 41);
            TitleTB.Name = "TitleTB";
            TitleTB.Size = new Size(156, 25);
            TitleTB.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DescriptionTB);
            groupBox2.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 134);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(248, 297);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Description";
            // 
            // DescriptionTB
            // 
            DescriptionTB.Location = new Point(6, 24);
            DescriptionTB.Name = "DescriptionTB";
            DescriptionTB.Size = new Size(236, 267);
            DescriptionTB.TabIndex = 3;
            DescriptionTB.Text = "";
            // 
            // AddBTN
            // 
            AddBTN.Cursor = Cursors.Hand;
            AddBTN.FlatStyle = FlatStyle.Flat;
            AddBTN.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddBTN.Location = new Point(344, 372);
            AddBTN.Name = "AddBTN";
            AddBTN.Size = new Size(123, 53);
            AddBTN.TabIndex = 3;
            AddBTN.Text = "Add";
            AddBTN.UseVisualStyleBackColor = true;
            AddBTN.Click += AddBTN_Click;
            // 
            // Adding2Do
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 443);
            Controls.Add(AddBTN);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Adding2Do";
            Text = "Adding2Do";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
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
    }
}