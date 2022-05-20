namespace PT_Lab4
{
    partial class SingletonForm
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
            this.showPerson = new System.Windows.Forms.Button();
            this.arrayLengthBox = new System.Windows.Forms.NumericUpDown();
            this.minValueBox = new System.Windows.Forms.NumericUpDown();
            this.maxValueBox = new System.Windows.Forms.NumericUpDown();
            this.goButton = new System.Windows.Forms.Button();
            this.operationsList = new System.Windows.Forms.CheckedListBox();
            this.generateBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.openMode = new System.Windows.Forms.RadioButton();
            this.generateMode = new System.Windows.Forms.RadioButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.arrayLengthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minValueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxValueBox)).BeginInit();
            this.generateBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // showPerson
            // 
            this.showPerson.Location = new System.Drawing.Point(31, 182);
            this.showPerson.Name = "showPerson";
            this.showPerson.Size = new System.Drawing.Size(275, 23);
            this.showPerson.TabIndex = 0;
            this.showPerson.Text = "Author";
            this.showPerson.UseVisualStyleBackColor = true;
            this.showPerson.Click += new System.EventHandler(this.showPerson_Click);
            // 
            // arrayLengthBox
            // 
            this.arrayLengthBox.Location = new System.Drawing.Point(36, 22);
            this.arrayLengthBox.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.arrayLengthBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.arrayLengthBox.Name = "arrayLengthBox";
            this.arrayLengthBox.Size = new System.Drawing.Size(120, 23);
            this.arrayLengthBox.TabIndex = 1;
            this.arrayLengthBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // minValueBox
            // 
            this.minValueBox.Location = new System.Drawing.Point(36, 51);
            this.minValueBox.Name = "minValueBox";
            this.minValueBox.Size = new System.Drawing.Size(120, 23);
            this.minValueBox.TabIndex = 2;
            // 
            // maxValueBox
            // 
            this.maxValueBox.Location = new System.Drawing.Point(36, 80);
            this.maxValueBox.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.maxValueBox.Name = "maxValueBox";
            this.maxValueBox.Size = new System.Drawing.Size(120, 23);
            this.maxValueBox.TabIndex = 3;
            this.maxValueBox.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(312, 182);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(194, 23);
            this.goButton.TabIndex = 5;
            this.goButton.Text = "Go!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // operationsList
            // 
            this.operationsList.CheckOnClick = true;
            this.operationsList.FormattingEnabled = true;
            this.operationsList.Items.AddRange(new object[] {
            "Average",
            "Sort Downward",
            "Multiply Even numbers by (-t)"});
            this.operationsList.Location = new System.Drawing.Point(312, 49);
            this.operationsList.Name = "operationsList";
            this.operationsList.Size = new System.Drawing.Size(194, 58);
            this.operationsList.TabIndex = 3;
            // 
            // generateBox
            // 
            this.generateBox.Controls.Add(this.label4);
            this.generateBox.Controls.Add(this.label3);
            this.generateBox.Controls.Add(this.label2);
            this.generateBox.Controls.Add(this.arrayLengthBox);
            this.generateBox.Controls.Add(this.minValueBox);
            this.generateBox.Controls.Add(this.maxValueBox);
            this.generateBox.Location = new System.Drawing.Point(110, 3);
            this.generateBox.Name = "generateBox";
            this.generateBox.Size = new System.Drawing.Size(162, 115);
            this.generateBox.TabIndex = 6;
            this.generateBox.TabStop = false;
            this.generateBox.Text = "Generate Array";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.openMode);
            this.panel1.Controls.Add(this.generateMode);
            this.panel1.Controls.Add(this.generateBox);
            this.panel1.Location = new System.Drawing.Point(31, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 146);
            this.panel1.TabIndex = 4;
            // 
            // openMode
            // 
            this.openMode.AutoSize = true;
            this.openMode.Location = new System.Drawing.Point(3, 120);
            this.openMode.Name = "openMode";
            this.openMode.Size = new System.Drawing.Size(102, 19);
            this.openMode.TabIndex = 8;
            this.openMode.TabStop = true;
            this.openMode.Text = "Open from file";
            this.openMode.UseVisualStyleBackColor = true;
            // 
            // generateMode
            // 
            this.generateMode.AutoSize = true;
            this.generateMode.Checked = true;
            this.generateMode.Location = new System.Drawing.Point(3, 3);
            this.generateMode.Name = "generateMode";
            this.generateMode.Size = new System.Drawing.Size(101, 19);
            this.generateMode.TabIndex = 7;
            this.generateMode.TabStop = true;
            this.generateMode.Text = "Generate array";
            this.generateMode.UseVisualStyleBackColor = true;
            this.generateMode.CheckedChanged += new System.EventHandler(this.Mode_CheckedChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "array";
            this.openFileDialog.Filter = "Text files|*txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Operations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "b =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "a =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "n =";
            // 
            // SingletonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 224);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.operationsList);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.showPerson);
            this.Name = "SingletonForm";
            this.Text = "Setup";
            this.Load += new System.EventHandler(this.SingletonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arrayLengthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minValueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxValueBox)).EndInit();
            this.generateBox.ResumeLayout(false);
            this.generateBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button showPerson;
        private NumericUpDown arrayLengthBox;
        private NumericUpDown minValueBox;
        private NumericUpDown maxValueBox;
        private Button goButton;
        private CheckedListBox operationsList;
        private GroupBox generateBox;
        private Panel panel1;
        private RadioButton openMode;
        private RadioButton generateMode;
        private OpenFileDialog openFileDialog;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}