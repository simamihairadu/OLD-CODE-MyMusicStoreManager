namespace MyMusicGUI
{
    partial class AddProductPanel
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
            this.productNameBox = new System.Windows.Forms.TextBox();
            this.productBrandBox = new System.Windows.Forms.TextBox();
            this.productPriceBox = new System.Windows.Forms.TextBox();
            this.productCountBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productNameBox
            // 
            this.productNameBox.Location = new System.Drawing.Point(135, 49);
            this.productNameBox.Name = "productNameBox";
            this.productNameBox.Size = new System.Drawing.Size(195, 20);
            this.productNameBox.TabIndex = 0;
            // 
            // productBrandBox
            // 
            this.productBrandBox.Location = new System.Drawing.Point(135, 96);
            this.productBrandBox.Name = "productBrandBox";
            this.productBrandBox.Size = new System.Drawing.Size(194, 20);
            this.productBrandBox.TabIndex = 1;
            // 
            // productPriceBox
            // 
            this.productPriceBox.Location = new System.Drawing.Point(135, 145);
            this.productPriceBox.Name = "productPriceBox";
            this.productPriceBox.Size = new System.Drawing.Size(195, 20);
            this.productPriceBox.TabIndex = 2;
            // 
            // productCountBox
            // 
            this.productCountBox.Location = new System.Drawing.Point(135, 200);
            this.productCountBox.Name = "productCountBox";
            this.productCountBox.Size = new System.Drawing.Size(195, 20);
            this.productCountBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(70, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(70, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(70, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(70, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Count";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddButton.Location = new System.Drawing.Point(145, 259);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(173, 43);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddProductPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(452, 346);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productCountBox);
            this.Controls.Add(this.productPriceBox);
            this.Controls.Add(this.productBrandBox);
            this.Controls.Add(this.productNameBox);
            this.Name = "AddProductPanel";
            this.Text = "AddProductPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productNameBox;
        private System.Windows.Forms.TextBox productBrandBox;
        private System.Windows.Forms.TextBox productPriceBox;
        private System.Windows.Forms.TextBox productCountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddButton;
    }
}