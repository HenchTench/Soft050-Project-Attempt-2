namespace Soft050_Project_Attempt_2
{
    partial class Form1
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
            testTable = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)testTable).BeginInit();
            SuspendLayout();
            // 
            // testTable
            // 
            testTable.AllowUserToOrderColumns = true;
            testTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            testTable.Location = new Point(70, 26);
            testTable.Name = "testTable";
            testTable.Size = new Size(670, 198);
            testTable.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(154, 274);
            button1.Name = "button1";
            button1.Size = new Size(124, 55);
            button1.TabIndex = 1;
            button1.Text = "CreateDataProperty Test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(487, 274);
            button2.Name = "button2";
            button2.Size = new Size(129, 55);
            button2.TabIndex = 2;
            button2.Text = "ReadDataProperty Test";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 408);
            button3.Name = "button3";
            button3.Size = new Size(153, 30);
            button3.TabIndex = 3;
            button3.Text = "Debug Log";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(182, 409);
            button4.Name = "button4";
            button4.Size = new Size(161, 29);
            button4.TabIndex = 4;
            button4.Text = "Verify Database";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(testTable);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)testTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView testTable;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
