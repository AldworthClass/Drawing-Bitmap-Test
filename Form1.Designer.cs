namespace Drawing_Bitmap_Test
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
            this.imgPlate = new System.Windows.Forms.PictureBox();
            this.btnAddCorn = new System.Windows.Forms.Button();
            this.btnAddCabbage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlate)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPlate
            // 
            this.imgPlate.Image = global::Drawing_Bitmap_Test.Properties.Resources.essential_dinner_plate;
            this.imgPlate.Location = new System.Drawing.Point(182, 45);
            this.imgPlate.Name = "imgPlate";
            this.imgPlate.Size = new System.Drawing.Size(383, 355);
            this.imgPlate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlate.TabIndex = 0;
            this.imgPlate.TabStop = false;
            this.imgPlate.Paint += new System.Windows.Forms.PaintEventHandler(this.imgPlate_Paint);
            // 
            // btnAddCorn
            // 
            this.btnAddCorn.Location = new System.Drawing.Point(12, 12);
            this.btnAddCorn.Name = "btnAddCorn";
            this.btnAddCorn.Size = new System.Drawing.Size(75, 23);
            this.btnAddCorn.TabIndex = 1;
            this.btnAddCorn.Text = "Corn";
            this.btnAddCorn.UseVisualStyleBackColor = true;
            this.btnAddCorn.Click += new System.EventHandler(this.btnAddCorn_Click);
            // 
            // btnAddCabbage
            // 
            this.btnAddCabbage.Location = new System.Drawing.Point(12, 45);
            this.btnAddCabbage.Name = "btnAddCabbage";
            this.btnAddCabbage.Size = new System.Drawing.Size(75, 23);
            this.btnAddCabbage.TabIndex = 2;
            this.btnAddCabbage.Text = "Cabbage";
            this.btnAddCabbage.UseVisualStyleBackColor = true;
            this.btnAddCabbage.Click += new System.EventHandler(this.btnAddCabbage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddCabbage);
            this.Controls.Add(this.btnAddCorn);
            this.Controls.Add(this.imgPlate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgPlate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPlate;
        private System.Windows.Forms.Button btnAddCorn;
        private System.Windows.Forms.Button btnAddCabbage;
    }
}

