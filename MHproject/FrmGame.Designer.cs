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
            this.picMonster2 = new System.Windows.Forms.PictureBox();
            this.picMonster1 = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.cboMaps = new System.Windows.Forms.ComboBox();
            this.lblErrorMap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picMonster2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMonster1)).BeginInit();
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
            // picMonster2
            // 
            this.picMonster2.Image = global::MHproject.Properties.Resources.susPlayerImage;
            this.picMonster2.Location = new System.Drawing.Point(827, 124);
            this.picMonster2.Name = "picMonster2";
            this.picMonster2.Size = new System.Drawing.Size(50, 50);
            this.picMonster2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMonster2.TabIndex = 3;
            this.picMonster2.TabStop = false;
            // 
            // picMonster1
            // 
            this.picMonster1.Image = global::MHproject.Properties.Resources.susPlayerImage;
            this.picMonster1.Location = new System.Drawing.Point(713, 124);
            this.picMonster1.Name = "picMonster1";
            this.picMonster1.Size = new System.Drawing.Size(50, 50);
            this.picMonster1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMonster1.TabIndex = 2;
            this.picMonster1.TabStop = false;
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
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 404);
            this.Controls.Add(this.lblErrorMap);
            this.Controls.Add(this.cboMaps);
            this.Controls.Add(this.picMonster2);
            this.Controls.Add(this.picMonster1);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.btnCreateMap);
            this.Name = "FrmGame";
            this.Text = "FrmGame";
            this.Load += new System.EventHandler(this.FrmGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMonster2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMonster1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateMap;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picMonster1;
        private System.Windows.Forms.PictureBox picMonster2;
        private System.Windows.Forms.ComboBox cboMaps;
        private System.Windows.Forms.Label lblErrorMap;
    }
}