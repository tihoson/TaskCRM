namespace TaskCRM
{
    partial class CountryViewForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.capitalTextBox = new System.Windows.Forms.TextBox();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.regionTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(0, 0);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(477, 22);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Text = "Name:";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.codeTextBox.Enabled = false;
            this.codeTextBox.Location = new System.Drawing.Point(0, 22);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(477, 22);
            this.codeTextBox.TabIndex = 1;
            this.codeTextBox.Text = "Code:";
            // 
            // capitalTextBox
            // 
            this.capitalTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.capitalTextBox.Enabled = false;
            this.capitalTextBox.Location = new System.Drawing.Point(0, 44);
            this.capitalTextBox.Name = "capitalTextBox";
            this.capitalTextBox.Size = new System.Drawing.Size(477, 22);
            this.capitalTextBox.TabIndex = 2;
            this.capitalTextBox.Text = "Capital:";
            // 
            // areaTextBox
            // 
            this.areaTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.areaTextBox.Enabled = false;
            this.areaTextBox.Location = new System.Drawing.Point(0, 66);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(477, 22);
            this.areaTextBox.TabIndex = 3;
            this.areaTextBox.Text = "Area:";
            // 
            // populationTextBox
            // 
            this.populationTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.populationTextBox.Enabled = false;
            this.populationTextBox.Location = new System.Drawing.Point(0, 88);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.Size = new System.Drawing.Size(477, 22);
            this.populationTextBox.TabIndex = 4;
            this.populationTextBox.Text = "Population";
            // 
            // regionTextBox
            // 
            this.regionTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.regionTextBox.Enabled = false;
            this.regionTextBox.Location = new System.Drawing.Point(0, 110);
            this.regionTextBox.Name = "regionTextBox";
            this.regionTextBox.Size = new System.Drawing.Size(477, 22);
            this.regionTextBox.TabIndex = 5;
            this.regionTextBox.Text = "Region:";
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveButton.Location = new System.Drawing.Point(0, 132);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(477, 65);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.closeButton.Location = new System.Drawing.Point(0, 197);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(477, 65);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // CountryViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(477, 267);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.regionTextBox);
            this.Controls.Add(this.populationTextBox);
            this.Controls.Add(this.areaTextBox);
            this.Controls.Add(this.capitalTextBox);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.nameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CountryViewForm";
            this.Text = "CountryViewForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox capitalTextBox;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.TextBox populationTextBox;
        private System.Windows.Forms.TextBox regionTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button closeButton;
    }
}