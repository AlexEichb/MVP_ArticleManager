namespace SWE2UE_MVP_ArticleManager
{
    partial class DetailView
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tbx_ArticleNr = new System.Windows.Forms.TextBox();
            this.tbx_Description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_Category = new System.Windows.Forms.TextBox();
            this.tbx_Price = new System.Windows.Forms.TextBox();
            this.tbx_Quantity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(469, 48);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(94, 29);
            this.btn_Submit.TabIndex = 0;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // tbx_Name
            // 
            this.tbx_Name.Location = new System.Drawing.Point(150, 95);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(265, 27);
            this.tbx_Name.TabIndex = 1;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(469, 102);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(94, 29);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // tbx_ArticleNr
            // 
            this.tbx_ArticleNr.Location = new System.Drawing.Point(150, 45);
            this.tbx_ArticleNr.Name = "tbx_ArticleNr";
            this.tbx_ArticleNr.ReadOnly = true;
            this.tbx_ArticleNr.Size = new System.Drawing.Size(265, 27);
            this.tbx_ArticleNr.TabIndex = 3;
            // 
            // tbx_Description
            // 
            this.tbx_Description.Location = new System.Drawing.Point(150, 145);
            this.tbx_Description.Name = "tbx_Description";
            this.tbx_Description.Size = new System.Drawing.Size(265, 27);
            this.tbx_Description.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Article Nr.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantity";
            // 
            // tbx_Category
            // 
            this.tbx_Category.Location = new System.Drawing.Point(150, 195);
            this.tbx_Category.Name = "tbx_Category";
            this.tbx_Category.Size = new System.Drawing.Size(265, 27);
            this.tbx_Category.TabIndex = 11;
            // 
            // tbx_Price
            // 
            this.tbx_Price.Location = new System.Drawing.Point(150, 245);
            this.tbx_Price.Name = "tbx_Price";
            this.tbx_Price.Size = new System.Drawing.Size(265, 27);
            this.tbx_Price.TabIndex = 12;
            // 
            // tbx_Quantity
            // 
            this.tbx_Quantity.Location = new System.Drawing.Point(150, 300);
            this.tbx_Quantity.Name = "tbx_Quantity";
            this.tbx_Quantity.Size = new System.Drawing.Size(265, 27);
            this.tbx_Quantity.TabIndex = 13;
            // 
            // DetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 367);
            this.Controls.Add(this.tbx_Quantity);
            this.Controls.Add(this.tbx_Price);
            this.Controls.Add(this.tbx_Category);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_Description);
            this.Controls.Add(this.tbx_ArticleNr);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.tbx_Name);
            this.Controls.Add(this.btn_Submit);
            this.Name = "DetailView";
            this.Text = "Article View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Submit;
        private TextBox tbx_Name;
        private Button btn_Cancel;
        private TextBox tbx_ArticleNr;
        private TextBox tbx_Description;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbx_Category;
        private TextBox tbx_Price;
        private TextBox tbx_Quantity;
    }
}