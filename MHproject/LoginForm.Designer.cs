namespace MHproject
{
    partial class LoginForm
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
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblMapChoice = new System.Windows.Forms.Label();
            this.cboMaps = new System.Windows.Forms.ComboBox();
            this.lblErrorName = new System.Windows.Forms.Label();
            this.lblErrorMap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(198, 51);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(356, 31);
            this.txtPlayerName.TabIndex = 0;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(36, 51);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(141, 25);
            this.lblPlayerName.TabIndex = 1;
            this.lblPlayerName.Text = "Player Name:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(41, 201);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(230, 78);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(422, 201);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(230, 78);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit Game";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // lblMapChoice
            // 
            this.lblMapChoice.AutoSize = true;
            this.lblMapChoice.Location = new System.Drawing.Point(87, 131);
            this.lblMapChoice.Name = "lblMapChoice";
            this.lblMapChoice.Size = new System.Drawing.Size(60, 25);
            this.lblMapChoice.TabIndex = 4;
            this.lblMapChoice.Text = "Map:";
            // 
            // cboMaps
            // 
            this.cboMaps.FormattingEnabled = true;
            this.cboMaps.Location = new System.Drawing.Point(198, 131);
            this.cboMaps.Name = "cboMaps";
            this.cboMaps.Size = new System.Drawing.Size(229, 33);
            this.cboMaps.TabIndex = 5;
            // 
            // lblErrorName
            // 
            this.lblErrorName.AutoSize = true;
            this.lblErrorName.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorName.Location = new System.Drawing.Point(609, 51);
            this.lblErrorName.Name = "lblErrorName";
            this.lblErrorName.Size = new System.Drawing.Size(118, 25);
            this.lblErrorName.TabIndex = 6;
            this.lblErrorName.Text = "Error name";
            this.lblErrorName.Visible = false;
            // 
            // lblErrorMap
            // 
            this.lblErrorMap.AutoSize = true;
            this.lblErrorMap.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorMap.Location = new System.Drawing.Point(480, 134);
            this.lblErrorMap.Name = "lblErrorMap";
            this.lblErrorMap.Size = new System.Drawing.Size(106, 25);
            this.lblErrorMap.TabIndex = 7;
            this.lblErrorMap.Text = "Error map";
            this.lblErrorMap.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 408);
            this.Controls.Add(this.lblErrorMap);
            this.Controls.Add(this.lblErrorName);
            this.Controls.Add(this.cboMaps);
            this.Controls.Add(this.lblMapChoice);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.txtPlayerName);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblMapChoice;
        public System.Windows.Forms.ComboBox cboMaps;
        private System.Windows.Forms.Label lblErrorName;
        private System.Windows.Forms.Label lblErrorMap;
    }
}

