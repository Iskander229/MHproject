namespace MHproject
{
    partial class FrmGame
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
            this.btnCreateMap = new System.Windows.Forms.Button();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.cboMaps = new System.Windows.Forms.ComboBox();
            this.lblErrorMap = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblcurrentHP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateMap
            // 
            this.btnCreateMap.Location = new System.Drawing.Point(98, 168);
            this.btnCreateMap.Name = "btnCreateMap";
            this.btnCreateMap.Size = new System.Drawing.Size(168, 74);
            this.btnCreateMap.TabIndex = 0;
            this.btnCreateMap.Text = "Create Map";
            this.btnCreateMap.UseVisualStyleBackColor = true;
            this.btnCreateMap.Click += new System.EventHandler(this.btnCreateMap_Click);
            // 
            // picPlayer
            // 
            this.picPlayer.Image = global::MHproject.Properties.Resources.AVA_VRO;
            this.picPlayer.Location = new System.Drawing.Point(614, 124);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(50, 50);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 1;
            this.picPlayer.TabStop = false;
            // 
            // cboMaps
            // 
            this.cboMaps.FormattingEnabled = true;
            this.cboMaps.Location = new System.Drawing.Point(81, 75);
            this.cboMaps.Name = "cboMaps";
            this.cboMaps.Size = new System.Drawing.Size(222, 33);
            this.cboMaps.TabIndex = 11;
            // 
            // lblErrorMap
            // 
            this.lblErrorMap.AutoSize = true;
            this.lblErrorMap.BackColor = System.Drawing.SystemColors.Control;
            this.lblErrorMap.ForeColor = System.Drawing.Color.Crimson;
            this.lblErrorMap.Location = new System.Drawing.Point(343, 75);
            this.lblErrorMap.Name = "lblErrorMap";
            this.lblErrorMap.Size = new System.Drawing.Size(152, 25);
            this.lblErrorMap.TabIndex = 12;
            this.lblErrorMap.Text = "Error message";
            this.lblErrorMap.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 880);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "infos:";
            // 
            // lblInfos
            // 
            this.lblInfos.AutoSize = true;
            this.lblInfos.Location = new System.Drawing.Point(163, 880);
            this.lblInfos.Name = "lblInfos";
            this.lblInfos.Size = new System.Drawing.Size(47, 25);
            this.lblInfos.TabIndex = 14;
            this.lblInfos.Text = "info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 910);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "current HP:";
            // 
            // lblcurrentHP
            // 
            this.lblcurrentHP.AutoSize = true;
            this.lblcurrentHP.Location = new System.Drawing.Point(230, 910);
            this.lblcurrentHP.Name = "lblcurrentHP";
            this.lblcurrentHP.Size = new System.Drawing.Size(36, 25);
            this.lblcurrentHP.TabIndex = 16;
            this.lblcurrentHP.Text = "30";
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1822, 944);
            this.Controls.Add(this.lblcurrentHP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInfos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblErrorMap);
            this.Controls.Add(this.cboMaps);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.btnCreateMap);
            this.Name = "FrmGame";
            this.Text = "FrmGame";
            this.Load += new System.EventHandler(this.FrmGame_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmGame_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateMap;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.ComboBox cboMaps;
        private System.Windows.Forms.Label lblErrorMap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInfos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblcurrentHP;
    }
}