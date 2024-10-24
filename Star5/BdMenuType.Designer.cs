namespace Star5
{
    partial class BdMenuType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BdMenuType));
            this.gunaGradientTileButton2 = new Guna.UI.WinForms.GunaGradientTileButton();
            this.gunaGradientTileButton1 = new Guna.UI.WinForms.GunaGradientTileButton();
            this.SuspendLayout();
            // 
            // gunaGradientTileButton2
            // 
            this.gunaGradientTileButton2.AnimationHoverSpeed = 0.07F;
            this.gunaGradientTileButton2.AnimationSpeed = 0.03F;
            this.gunaGradientTileButton2.BaseColor1 = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton2.BaseColor2 = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientTileButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientTileButton2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientTileButton2.ForeColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientTileButton2.Image")));
            this.gunaGradientTileButton2.ImageSize = new System.Drawing.Size(32, 32);
            this.gunaGradientTileButton2.Location = new System.Drawing.Point(39, 257);
            this.gunaGradientTileButton2.Name = "gunaGradientTileButton2";
            this.gunaGradientTileButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientTileButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientTileButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientTileButton2.OnHoverImage = null;
            this.gunaGradientTileButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton2.Size = new System.Drawing.Size(82, 65);
            this.gunaGradientTileButton2.TabIndex = 15;
            this.gunaGradientTileButton2.Text = "Drinks";
            this.gunaGradientTileButton2.Click += new System.EventHandler(this.gunaGradientTileButton2_Click);
            // 
            // gunaGradientTileButton1
            // 
            this.gunaGradientTileButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientTileButton1.AnimationSpeed = 0.03F;
            this.gunaGradientTileButton1.BaseColor1 = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton1.BaseColor2 = System.Drawing.Color.Transparent;
            this.gunaGradientTileButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientTileButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientTileButton1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientTileButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientTileButton1.Image")));
            this.gunaGradientTileButton1.ImageSize = new System.Drawing.Size(32, 32);
            this.gunaGradientTileButton1.Location = new System.Drawing.Point(39, 122);
            this.gunaGradientTileButton1.Name = "gunaGradientTileButton1";
            this.gunaGradientTileButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientTileButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientTileButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientTileButton1.OnHoverImage = null;
            this.gunaGradientTileButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientTileButton1.Size = new System.Drawing.Size(82, 65);
            this.gunaGradientTileButton1.TabIndex = 14;
            this.gunaGradientTileButton1.Text = "Foods";
            this.gunaGradientTileButton1.Click += new System.EventHandler(this.gunaGradientTileButton1_Click);
            // 
            // BdMenuType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.gunaGradientTileButton2);
            this.Controls.Add(this.gunaGradientTileButton1);
            this.Name = "BdMenuType";
            this.Size = new System.Drawing.Size(160, 475);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaGradientTileButton gunaGradientTileButton2;
        private Guna.UI.WinForms.GunaGradientTileButton gunaGradientTileButton1;
    }
}
