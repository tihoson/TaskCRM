namespace TaskCRM
{
    partial class ConnectionForm
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
            this.serverNameLabel = new System.Windows.Forms.Label();
            this.serverNameTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.passLabel = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.trustedConLabel = new System.Windows.Forms.Label();
            this.databaseTextBox = new System.Windows.Forms.TextBox();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverNameLabel
            // 
            this.serverNameLabel.AutoSize = true;
            this.serverNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.serverNameLabel.Location = new System.Drawing.Point(0, 0);
            this.serverNameLabel.Name = "serverNameLabel";
            this.serverNameLabel.Size = new System.Drawing.Size(89, 17);
            this.serverNameLabel.TabIndex = 0;
            this.serverNameLabel.Text = "Server name";
            // 
            // serverNameTextBox
            // 
            this.serverNameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.serverNameTextBox.Location = new System.Drawing.Point(0, 17);
            this.serverNameTextBox.Name = "serverNameTextBox";
            this.serverNameTextBox.Size = new System.Drawing.Size(329, 22);
            this.serverNameTextBox.TabIndex = 1;
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.closeButton.Location = new System.Drawing.Point(0, 284);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(329, 65);
            this.closeButton.TabIndex = 43;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // passTextBox
            // 
            this.passTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.passTextBox.Location = new System.Drawing.Point(0, 172);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(329, 22);
            this.passTextBox.TabIndex = 41;
            this.passTextBox.UseSystemPasswordChar = true;
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.passLabel.Location = new System.Drawing.Point(0, 155);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(69, 17);
            this.passLabel.TabIndex = 40;
            this.passLabel.Text = "Password";
            // 
            // userTextBox
            // 
            this.userTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.userTextBox.Location = new System.Drawing.Point(0, 133);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(329, 22);
            this.userTextBox.TabIndex = 39;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userLabel.Location = new System.Drawing.Point(0, 116);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(38, 17);
            this.userLabel.TabIndex = 38;
            this.userLabel.Text = "User";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox.Location = new System.Drawing.Point(0, 95);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(329, 21);
            this.checkBox.TabIndex = 37;
            this.checkBox.Text = "Yes";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.CheckBoxCheckedChanged);
            // 
            // trustedConLabel
            // 
            this.trustedConLabel.AutoSize = true;
            this.trustedConLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.trustedConLabel.Location = new System.Drawing.Point(0, 78);
            this.trustedConLabel.Name = "trustedConLabel";
            this.trustedConLabel.Size = new System.Drawing.Size(130, 17);
            this.trustedConLabel.TabIndex = 36;
            this.trustedConLabel.Text = "Trusted connection";
            // 
            // databaseTextBox
            // 
            this.databaseTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.databaseTextBox.Location = new System.Drawing.Point(0, 56);
            this.databaseTextBox.Name = "databaseTextBox";
            this.databaseTextBox.Size = new System.Drawing.Size(329, 22);
            this.databaseTextBox.TabIndex = 35;
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.databaseLabel.Location = new System.Drawing.Point(0, 39);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(69, 17);
            this.databaseLabel.TabIndex = 34;
            this.databaseLabel.Text = "Database";
            // 
            // connectButton
            // 
            this.connectButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.connectButton.Location = new System.Drawing.Point(0, 219);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(329, 65);
            this.connectButton.TabIndex = 44;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButtonClick);
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(329, 349);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.trustedConLabel);
            this.Controls.Add(this.databaseTextBox);
            this.Controls.Add(this.databaseLabel);
            this.Controls.Add(this.serverNameTextBox);
            this.Controls.Add(this.serverNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConnectionForm";
            this.Text = "ConnectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serverNameLabel;
        private System.Windows.Forms.TextBox serverNameTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label trustedConLabel;
        private System.Windows.Forms.TextBox databaseTextBox;
        private System.Windows.Forms.Label databaseLabel;
        private System.Windows.Forms.Button connectButton;
    }
}