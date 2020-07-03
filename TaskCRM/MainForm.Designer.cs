namespace TaskCRM
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.connectionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // countryTextBox
            // 
            this.countryTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.countryTextBox.Enabled = false;
            this.countryTextBox.Location = new System.Drawing.Point(0, 0);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(477, 22);
            this.countryTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchButton.Enabled = false;
            this.searchButton.Location = new System.Drawing.Point(0, 22);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(477, 65);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // showButton
            // 
            this.showButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.showButton.Enabled = false;
            this.showButton.Location = new System.Drawing.Point(0, 87);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(477, 65);
            this.showButton.TabIndex = 5;
            this.showButton.Text = "Show DB";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.ShowButtonClick);
            // 
            // connectionButton
            // 
            this.connectionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.connectionButton.Location = new System.Drawing.Point(0, 152);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(477, 65);
            this.connectionButton.TabIndex = 6;
            this.connectionButton.Text = "Connection";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.ConnectionButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(477, 221);
            this.Controls.Add(this.connectionButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.countryTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Country info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button connectionButton;
    }
}

