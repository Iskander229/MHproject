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
            this.picWall = new System.Windows.Forms.PictureBox();
            this.picMonster2 = new System.Windows.Forms.PictureBox();
            this.picMonster1 = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMonster2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMonster1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateMap
            // 
            this.btnCreateMap.Location = new System.Drawing.Point(41, 490);
            this.btnCreateMap.Name = "btnCreateMap";
            this.btnCreateMap.Size = new System.Drawing.Size(168, 74);
            this.btnCreateMap.TabIndex = 0;
            this.btnCreateMap.Text = "Create Map";
            this.btnCreateMap.UseVisualStyleBackColor = true;
            this.btnCreateMap.Click += new System.EventHandler(this.btnCreateMap_Click);
            // 
            // picWall
            // 
            this.picWall.Image = global::MHproject.Properties.Resources.brickWallImage;
            this.picWall.Location = new System.Drawing.Point(588, 501);
            this.picWall.Name = "picWall";
            this.picWall.Size = new System.Drawing.Size(50, 50);
            this.picWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWall.TabIndex = 4;
            this.picWall.TabStop = false;
            this.picWall.Visible = false;
            // 
            // picMonster2
            // 
            this.picMonster2.Image = global::MHproject.Properties.Resources.susPlayerImage;
            this.picMonster2.Location = new System.Drawing.Point(834, 501);
            this.picMonster2.Name = "picMonster2";
            this.picMonster2.Size = new System.Drawing.Size(50, 50);
            this.picMonster2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMonster2.TabIndex = 3;
            this.picMonster2.TabStop = false;
            // 
            // picMonster1
            // 
            this.picMonster1.Image = global::MHproject.Properties.Resources.susPlayerImage;
            this.picMonster1.Location = new System.Drawing.Point(763, 501);
            this.picMonster1.Name = "picMonster1";
            this.picMonster1.Size = new System.Drawing.Size(50, 50);
            this.picMonster1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMonster1.TabIndex = 2;
            this.picMonster1.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.Image = global::MHproject.Properties.Resources.AVA_VRO;
            this.picPlayer.Location = new System.Drawing.Point(678, 501);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(50, 50);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 1;
            this.picPlayer.TabStop = false;
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 615);
            this.Controls.Add(this.picWall);
            this.Controls.Add(this.picMonster2);
            this.Controls.Add(this.picMonster1);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.btnCreateMap);
            this.Name = "FrmGame";
            this.Text = "FrmGame";
            this.Load += new System.EventHandler(this.FrmGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMonster2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMonster1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateMap;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picMonster1;
        private System.Windows.Forms.PictureBox picMonster2;
        private System.Windows.Forms.PictureBox picWall;
    }
}