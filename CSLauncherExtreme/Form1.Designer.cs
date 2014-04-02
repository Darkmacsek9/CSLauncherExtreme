namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.closeButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.resolutionBox = new System.Windows.Forms.ComboBox();
            this.resLabel = new System.Windows.Forms.Label();
            this.renLabel = new System.Windows.Forms.Label();
            this.renRadio1 = new System.Windows.Forms.RadioButton();
            this.renRadio2 = new System.Windows.Forms.RadioButton();
            this.renPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.hiddenPanel = new System.Windows.Forms.Panel();
            this.hiddenLabel = new System.Windows.Forms.Label();
            this.fullscreenBox = new System.Windows.Forms.CheckBox();
            this.srvBox = new System.Windows.Forms.CheckBox();
            this.renPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closeButton.Location = new System.Drawing.Point(414, 13);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(24, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(309, 206);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(120, 32);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // nameInput
            // 
            this.nameInput.BackColor = System.Drawing.Color.Black;
            this.nameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameInput.ForeColor = System.Drawing.Color.LimeGreen;
            this.nameInput.Location = new System.Drawing.Point(270, 143);
            this.nameInput.Margin = new System.Windows.Forms.Padding(0);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(159, 26);
            this.nameInput.TabIndex = 2;
            this.nameInput.Click += new System.EventHandler(this.nameInput_Click);
            // 
            // resolutionBox
            // 
            this.resolutionBox.BackColor = System.Drawing.Color.Black;
            this.resolutionBox.DisplayMember = "(none)";
            this.resolutionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolutionBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resolutionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resolutionBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.resolutionBox.FormattingEnabled = true;
            this.resolutionBox.Items.AddRange(new object[] {
            "800x600",
            "1024x768",
            "1280x1024"});
            this.resolutionBox.Location = new System.Drawing.Point(39, 116);
            this.resolutionBox.Name = "resolutionBox";
            this.resolutionBox.Size = new System.Drawing.Size(121, 24);
            this.resolutionBox.TabIndex = 3;
            this.resolutionBox.SelectionChangeCommitted += new System.EventHandler(this.resolutionBox_SelectionChangeCommitted);
            // 
            // resLabel
            // 
            this.resLabel.AutoSize = true;
            this.resLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.resLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.resLabel.Location = new System.Drawing.Point(36, 100);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(60, 13);
            this.resLabel.TabIndex = 4;
            this.resLabel.Text = "Resolution:";
            // 
            // renLabel
            // 
            this.renLabel.AutoSize = true;
            this.renLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.renLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.renLabel.Location = new System.Drawing.Point(36, 158);
            this.renLabel.Name = "renLabel";
            this.renLabel.Size = new System.Drawing.Size(54, 13);
            this.renLabel.TabIndex = 6;
            this.renLabel.Text = "Renderer:";
            // 
            // renRadio1
            // 
            this.renRadio1.AutoSize = true;
            this.renRadio1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.renRadio1.Checked = true;
            this.renRadio1.ForeColor = System.Drawing.Color.LimeGreen;
            this.renRadio1.Location = new System.Drawing.Point(3, 3);
            this.renRadio1.Name = "renRadio1";
            this.renRadio1.Size = new System.Drawing.Size(67, 17);
            this.renRadio1.TabIndex = 7;
            this.renRadio1.TabStop = true;
            this.renRadio1.Text = "Software";
            this.renRadio1.UseVisualStyleBackColor = false;
            // 
            // renRadio2
            // 
            this.renRadio2.AutoSize = true;
            this.renRadio2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.renRadio2.ForeColor = System.Drawing.Color.LimeGreen;
            this.renRadio2.Location = new System.Drawing.Point(3, 26);
            this.renRadio2.Name = "renRadio2";
            this.renRadio2.Size = new System.Drawing.Size(47, 17);
            this.renRadio2.TabIndex = 8;
            this.renRadio2.Text = "D3D";
            this.renRadio2.UseVisualStyleBackColor = false;
            // 
            // renPanel
            // 
            this.renPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.renPanel.Controls.Add(this.renRadio2);
            this.renPanel.Controls.Add(this.renRadio1);
            this.renPanel.Location = new System.Drawing.Point(96, 158);
            this.renPanel.Name = "renPanel";
            this.renPanel.Size = new System.Drawing.Size(90, 50);
            this.renPanel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 7);
            this.label1.TabIndex = 11;
            this.label1.Text = "v0.2";
            // 
            // hiddenPanel
            // 
            this.hiddenPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hiddenPanel.Location = new System.Drawing.Point(270, 55);
            this.hiddenPanel.Name = "hiddenPanel";
            this.hiddenPanel.Size = new System.Drawing.Size(37, 30);
            this.hiddenPanel.TabIndex = 13;
            this.hiddenPanel.Click += new System.EventHandler(this.hiddenPanel_Click);
            // 
            // hiddenLabel
            // 
            this.hiddenLabel.AutoSize = true;
            this.hiddenLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.hiddenLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.hiddenLabel.Location = new System.Drawing.Point(329, 72);
            this.hiddenLabel.Name = "hiddenLabel";
            this.hiddenLabel.Size = new System.Drawing.Size(100, 13);
            this.hiddenLabel.TabIndex = 14;
            this.hiddenLabel.Text = "Superhide Enabled!";
            this.hiddenLabel.Visible = false;
            // 
            // fullscreenBox
            // 
            this.fullscreenBox.AutoSize = true;
            this.fullscreenBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fullscreenBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.fullscreenBox.Location = new System.Drawing.Point(39, 209);
            this.fullscreenBox.Name = "fullscreenBox";
            this.fullscreenBox.Size = new System.Drawing.Size(74, 17);
            this.fullscreenBox.TabIndex = 15;
            this.fullscreenBox.Text = "Fullscreen";
            this.fullscreenBox.UseVisualStyleBackColor = false;
            // 
            // srvBox
            // 
            this.srvBox.AutoSize = true;
            this.srvBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.srvBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.srvBox.Location = new System.Drawing.Point(241, 116);
            this.srvBox.Name = "srvBox";
            this.srvBox.Size = new System.Drawing.Size(143, 17);
            this.srvBox.TabIndex = 16;
            this.srvBox.Text = "Connect to Illyés Szerver";
            this.srvBox.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.srvBox);
            this.Controls.Add(this.fullscreenBox);
            this.Controls.Add(this.hiddenLabel);
            this.Controls.Add(this.hiddenPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.renPanel);
            this.Controls.Add(this.renLabel);
            this.Controls.Add(this.resLabel);
            this.Controls.Add(this.resolutionBox);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.renPanel.ResumeLayout(false);
            this.renPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.ComboBox resolutionBox;
        private System.Windows.Forms.Label resLabel;
        private System.Windows.Forms.Label renLabel;
        private System.Windows.Forms.RadioButton renRadio1;
        private System.Windows.Forms.RadioButton renRadio2;
        private System.Windows.Forms.Panel renPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel hiddenPanel;
        private System.Windows.Forms.Label hiddenLabel;
        private System.Windows.Forms.CheckBox fullscreenBox;
        private System.Windows.Forms.CheckBox srvBox;
    }
}

