namespace PT_Lab4
{
    partial class GetT_Form
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
            this.tValueBox = new System.Windows.Forms.NumericUpDown();
            this.proceedButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tValueBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tValueBox
            // 
            this.tValueBox.Location = new System.Drawing.Point(42, 7);
            this.tValueBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tValueBox.Name = "tValueBox";
            this.tValueBox.Size = new System.Drawing.Size(179, 23);
            this.tValueBox.TabIndex = 0;
            this.tValueBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // proceedButton
            // 
            this.proceedButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.proceedButton.Location = new System.Drawing.Point(42, 36);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(179, 23);
            this.proceedButton.TabIndex = 1;
            this.proceedButton.Text = "Proceed";
            this.proceedButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "T =";
            // 
            // GetT_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 72);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.proceedButton);
            this.Controls.Add(this.tValueBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GetT_Form";
            this.Text = "Insert T";
            this.Load += new System.EventHandler(this.GetT_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tValueBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button proceedButton;
        private NumericUpDown tValueBox;
        private Label label1;
    }
}