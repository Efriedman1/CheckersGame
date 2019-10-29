namespace CheckersGame
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblInstruct = new System.Windows.Forms.Label();
            this.txtPlayer1Name = new System.Windows.Forms.TextBox();
            this.txtPlayer2Name = new System.Windows.Forms.TextBox();
            this.btnOK1 = new System.Windows.Forms.Button();
            this.btnEdit1 = new System.Windows.Forms.Button();
            this.btnEdit2 = new System.Windows.Forms.Button();
            this.btnOK2 = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbLogo.Location = new System.Drawing.Point(145, 58);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(634, 180);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // lblInstruct
            // 
            this.lblInstruct.AutoSize = true;
            this.lblInstruct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruct.Location = new System.Drawing.Point(187, 271);
            this.lblInstruct.Name = "lblInstruct";
            this.lblInstruct.Size = new System.Drawing.Size(564, 37);
            this.lblInstruct.TabIndex = 3;
            this.lblInstruct.Text = "Please enter each players name below";
            // 
            // txtPlayer1Name
            // 
            this.txtPlayer1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer1Name.Location = new System.Drawing.Point(145, 340);
            this.txtPlayer1Name.Name = "txtPlayer1Name";
            this.txtPlayer1Name.Size = new System.Drawing.Size(406, 38);
            this.txtPlayer1Name.TabIndex = 4;
            this.txtPlayer1Name.TextChanged += new System.EventHandler(this.txtPlayer1Name_TextChanged);
            // 
            // txtPlayer2Name
            // 
            this.txtPlayer2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayer2Name.Location = new System.Drawing.Point(145, 420);
            this.txtPlayer2Name.Name = "txtPlayer2Name";
            this.txtPlayer2Name.Size = new System.Drawing.Size(406, 38);
            this.txtPlayer2Name.TabIndex = 5;
            // 
            // btnOK1
            // 
            this.btnOK1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnOK1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK1.Location = new System.Drawing.Point(585, 333);
            this.btnOK1.Name = "btnOK1";
            this.btnOK1.Size = new System.Drawing.Size(83, 50);
            this.btnOK1.TabIndex = 6;
            this.btnOK1.Text = "OK";
            this.btnOK1.UseVisualStyleBackColor = false;
            // 
            // btnEdit1
            // 
            this.btnEdit1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit1.Location = new System.Drawing.Point(696, 333);
            this.btnEdit1.Name = "btnEdit1";
            this.btnEdit1.Size = new System.Drawing.Size(83, 50);
            this.btnEdit1.TabIndex = 7;
            this.btnEdit1.Text = "Edit";
            this.btnEdit1.UseVisualStyleBackColor = true;
            // 
            // btnEdit2
            // 
            this.btnEdit2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit2.Location = new System.Drawing.Point(696, 413);
            this.btnEdit2.Name = "btnEdit2";
            this.btnEdit2.Size = new System.Drawing.Size(83, 50);
            this.btnEdit2.TabIndex = 9;
            this.btnEdit2.Text = "Edit";
            this.btnEdit2.UseVisualStyleBackColor = true;
            // 
            // btnOK2
            // 
            this.btnOK2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnOK2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK2.Location = new System.Drawing.Point(585, 413);
            this.btnOK2.Name = "btnOK2";
            this.btnOK2.Size = new System.Drawing.Size(83, 50);
            this.btnOK2.TabIndex = 8;
            this.btnOK2.Text = "OK";
            this.btnOK2.UseVisualStyleBackColor = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(362, 520);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(206, 70);
            this.btnPlay.TabIndex = 10;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            // 
            // btnRules
            // 
            this.btnRules.BackColor = System.Drawing.Color.Salmon;
            this.btnRules.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRules.Location = new System.Drawing.Point(362, 635);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(206, 70);
            this.btnRules.TabIndex = 11;
            this.btnRules.Text = "RULES";
            this.btnRules.UseVisualStyleBackColor = false;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 774);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnEdit2);
            this.Controls.Add(this.btnOK2);
            this.Controls.Add(this.btnEdit1);
            this.Controls.Add(this.btnOK1);
            this.Controls.Add(this.txtPlayer2Name);
            this.Controls.Add(this.txtPlayer1Name);
            this.Controls.Add(this.lblInstruct);
            this.Controls.Add(this.pbLogo);
            this.Name = "frmMenu";
            this.Text = "Checkers Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblInstruct;
        private System.Windows.Forms.TextBox txtPlayer1Name;
        private System.Windows.Forms.TextBox txtPlayer2Name;
        private System.Windows.Forms.Button btnOK1;
        private System.Windows.Forms.Button btnEdit1;
        private System.Windows.Forms.Button btnEdit2;
        private System.Windows.Forms.Button btnOK2;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnRules;
    }
}