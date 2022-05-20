namespace PT_Lab4
{
    partial class ProcessingForm
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
            this.arrayGrid = new System.Windows.Forms.DataGridView();
            this.avgBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.operationBox = new System.Windows.Forms.RichTextBox();
            this.serializeArr = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.AverageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.arrayGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // arrayGrid
            // 
            this.arrayGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.arrayGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.arrayGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.arrayGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.arrayGrid.ColumnHeadersVisible = false;
            this.arrayGrid.Location = new System.Drawing.Point(233, 27);
            this.arrayGrid.Name = "arrayGrid";
            this.arrayGrid.ReadOnly = true;
            this.arrayGrid.RowHeadersVisible = false;
            this.arrayGrid.RowTemplate.Height = 25;
            this.arrayGrid.Size = new System.Drawing.Size(350, 191);
            this.arrayGrid.TabIndex = 0;
            // 
            // avgBox
            // 
            this.avgBox.Location = new System.Drawing.Point(483, 224);
            this.avgBox.Name = "avgBox";
            this.avgBox.Size = new System.Drawing.Size(100, 23);
            this.avgBox.TabIndex = 1;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(12, 166);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(215, 23);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next Condition";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // operationBox
            // 
            this.operationBox.Location = new System.Drawing.Point(12, 27);
            this.operationBox.Name = "operationBox";
            this.operationBox.Size = new System.Drawing.Size(215, 133);
            this.operationBox.TabIndex = 3;
            this.operationBox.Text = "";
            // 
            // serializeArr
            // 
            this.serializeArr.Location = new System.Drawing.Point(12, 195);
            this.serializeArr.Name = "serializeArr";
            this.serializeArr.Size = new System.Drawing.Size(215, 23);
            this.serializeArr.TabIndex = 4;
            this.serializeArr.Text = "Save Array";
            this.serializeArr.UseVisualStyleBackColor = true;
            this.serializeArr.Click += new System.EventHandler(this.serializeArr_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "array";
            this.saveFileDialog.Filter = "Text files| *.txt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Processed operations";
            // 
            // AverageLabel
            // 
            this.AverageLabel.AutoSize = true;
            this.AverageLabel.Location = new System.Drawing.Point(427, 227);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(50, 15);
            this.AverageLabel.TabIndex = 6;
            this.AverageLabel.Text = "Average";
            this.AverageLabel.Visible = false;
            // 
            // ProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 261);
            this.Controls.Add(this.AverageLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serializeArr);
            this.Controls.Add(this.operationBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.avgBox);
            this.Controls.Add(this.arrayGrid);
            this.Name = "ProcessingForm";
            this.Text = "Processing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProcessingForm_FormClosed);
            this.Load += new System.EventHandler(this.ProcessingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.arrayGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView arrayGrid;
        private TextBox avgBox;
        private Button nextButton;
        private RichTextBox operationBox;
        private Button serializeArr;
        private SaveFileDialog saveFileDialog;
        private Label label1;
        private Label AverageLabel;
    }
}