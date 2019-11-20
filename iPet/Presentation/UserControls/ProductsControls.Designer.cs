namespace iPet.Presentation.UserControls
{
    partial class ProductsControls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.lowerPanel = new System.Windows.Forms.Panel();
            this.btnStorage = new System.Windows.Forms.Button();
            this.btnPictures = new System.Windows.Forms.Button();
            this.btnGroups = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.btnGroups);
            this.panel1.Controls.Add(this.btnPictures);
            this.panel1.Controls.Add(this.btnStorage);
            this.panel1.Controls.Add(this.lowerPanel);
            this.panel1.Controls.Add(this.btnGeneral);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnGeneral
            // 
            this.btnGeneral.FlatAppearance.BorderSize = 0;
            this.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneral.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneral.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneral.Location = new System.Drawing.Point(15, 3);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(131, 44);
            this.btnGeneral.TabIndex = 5;
            this.btnGeneral.Text = "Gerais";
            this.btnGeneral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGeneral.UseVisualStyleBackColor = true;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // lowerPanel
            // 
            this.lowerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(214)))), ((int)(((byte)(45)))));
            this.lowerPanel.Location = new System.Drawing.Point(2, 2);
            this.lowerPanel.Name = "lowerPanel";
            this.lowerPanel.Size = new System.Drawing.Size(10, 44);
            this.lowerPanel.TabIndex = 1;
            // 
            // btnStorage
            // 
            this.btnStorage.FlatAppearance.BorderSize = 0;
            this.btnStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStorage.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStorage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStorage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStorage.Location = new System.Drawing.Point(157, 3);
            this.btnStorage.Name = "btnStorage";
            this.btnStorage.Size = new System.Drawing.Size(131, 44);
            this.btnStorage.TabIndex = 6;
            this.btnStorage.Text = "Estoque";
            this.btnStorage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStorage.UseVisualStyleBackColor = true;
            this.btnStorage.Click += new System.EventHandler(this.btnStorage_Click);
            // 
            // btnPictures
            // 
            this.btnPictures.FlatAppearance.BorderSize = 0;
            this.btnPictures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPictures.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPictures.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPictures.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPictures.Location = new System.Drawing.Point(302, 3);
            this.btnPictures.Name = "btnPictures";
            this.btnPictures.Size = new System.Drawing.Size(131, 44);
            this.btnPictures.TabIndex = 7;
            this.btnPictures.Text = "Fotos";
            this.btnPictures.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPictures.UseVisualStyleBackColor = true;
            this.btnPictures.Click += new System.EventHandler(this.btnPictures_Click);
            // 
            // btnGroups
            // 
            this.btnGroups.FlatAppearance.BorderSize = 0;
            this.btnGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroups.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroups.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGroups.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGroups.Location = new System.Drawing.Point(453, 3);
            this.btnGroups.Name = "btnGroups";
            this.btnGroups.Size = new System.Drawing.Size(131, 44);
            this.btnGroups.TabIndex = 8;
            this.btnGroups.Text = "Agrupamentos";
            this.btnGroups.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGroups.UseVisualStyleBackColor = true;
            this.btnGroups.Click += new System.EventHandler(this.btnGroups_Click);
            // 
            // ProductsControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ProductsControls";
            this.Size = new System.Drawing.Size(793, 562);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Panel lowerPanel;
        private System.Windows.Forms.Button btnPictures;
        private System.Windows.Forms.Button btnStorage;
        private System.Windows.Forms.Button btnGroups;
    }
}
