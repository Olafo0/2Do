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
            SuspendLayout();
            // 
            // TaskOutputter
            // 
            TaskOutputter.Location = new Point(134, 12);
            TaskOutputter.Name = "TaskOutputter";
            TaskOutputter.ReadOnly = true;
            TaskOutputter.Size = new Size(414, 327);
            TaskOutputter.TabIndex = 0;
            TaskOutputter.Text = "";
            // 
            // ClearBTN
            // 
            ClearBTN.Location = new Point(28, 301);
            ClearBTN.Name = "ClearBTN";
            ClearBTN.Size = new Size(75, 23);
            ClearBTN.TabIndex = 2;
            ClearBTN.Text = "Clear";
            ClearBTN.UseVisualStyleBackColor = true;
            ClearBTN.Click += ClearBTN_Click;
            // 
            // FindByIDBTN
            // 
            FindByIDBTN.Location = new Point(28, 24);
            FindByIDBTN.Name = "FindByIDBTN";
            FindByIDBTN.Size = new Size(75, 23);
            FindByIDBTN.TabIndex = 3;
            FindByIDBTN.Text = "Find by ID";
            FindByIDBTN.UseVisualStyleBackColor = true;
            FindByIDBTN.Click += FindByIDBTN_Click;
            // 
            // Displaying2Do
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 482);
            Controls.Add(FindByIDBTN);
            Controls.Add(ClearBTN);
            Controls.Add(TaskOutputter);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Displaying2Do";
            Load += Displaying2Do_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox TaskOutputter;
        private Button ClearBTN;
        private Button FindByIDBTN;
    }
}