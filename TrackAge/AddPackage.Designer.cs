
namespace TrackAge
{
    partial class AddPackage
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
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Courier = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_AddPackage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(110, 12);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(298, 23);
            this.txt_Name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Package Name:";
            // 
            // txt_Number
            // 
            this.txt_Number.Location = new System.Drawing.Point(124, 42);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(284, 23);
            this.txt_Number.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tracking Number:";
            // 
            // lb_Courier
            // 
            this.lb_Courier.FormattingEnabled = true;
            this.lb_Courier.ItemHeight = 15;
            this.lb_Courier.Items.AddRange(new object[] {
            "USPS",
            "Intelcom",
            "UPS",
            "Canada Post",
            "Purolator"});
            this.lb_Courier.Location = new System.Drawing.Point(70, 75);
            this.lb_Courier.Name = "lb_Courier";
            this.lb_Courier.Size = new System.Drawing.Size(338, 19);
            this.lb_Courier.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Courier:";
            // 
            // btn_AddPackage
            // 
            this.btn_AddPackage.Location = new System.Drawing.Point(13, 101);
            this.btn_AddPackage.Name = "btn_AddPackage";
            this.btn_AddPackage.Size = new System.Drawing.Size(394, 23);
            this.btn_AddPackage.TabIndex = 6;
            this.btn_AddPackage.Text = "Add Package";
            this.btn_AddPackage.UseVisualStyleBackColor = true;
            this.btn_AddPackage.Click += new System.EventHandler(this.btn_AddPackage_Click);
            // 
            // AddPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 141);
            this.Controls.Add(this.btn_AddPackage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_Courier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Name);
            this.Name = "AddPackage";
            this.Text = "TrackAge - Add Package";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_Courier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_AddPackage;
    }
}