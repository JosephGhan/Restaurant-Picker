
namespace Resturant_Picker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStts = new System.Windows.Forms.Label();
            this.txtNm = new System.Windows.Forms.TextBox();
            this.lblTrn = new System.Windows.Forms.Label();
            this.lblRstrnt = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lstMchd = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(32, 371);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblStts
            // 
            this.lblStts.AutoSize = true;
            this.lblStts.Location = new System.Drawing.Point(32, 408);
            this.lblStts.Name = "lblStts";
            this.lblStts.Size = new System.Drawing.Size(39, 15);
            this.lblStts.TabIndex = 3;
            this.lblStts.Text = "Status";
            // 
            // txtNm
            // 
            this.txtNm.Location = new System.Drawing.Point(119, 371);
            this.txtNm.Name = "txtNm";
            this.txtNm.Size = new System.Drawing.Size(180, 23);
            this.txtNm.TabIndex = 4;
            // 
            // lblTrn
            // 
            this.lblTrn.AutoSize = true;
            this.lblTrn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTrn.Location = new System.Drawing.Point(183, 9);
            this.lblTrn.Name = "lblTrn";
            this.lblTrn.Size = new System.Drawing.Size(86, 32);
            this.lblTrn.TabIndex = 5;
            this.lblTrn.Text = "User 1";
            this.lblTrn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRstrnt
            // 
            this.lblRstrnt.AutoSize = true;
            this.lblRstrnt.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRstrnt.Location = new System.Drawing.Point(174, 62);
            this.lblRstrnt.Name = "lblRstrnt";
            this.lblRstrnt.Size = new System.Drawing.Size(104, 25);
            this.lblRstrnt.TabIndex = 6;
            this.lblRstrnt.Text = "Restaurant";
            this.lblRstrnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(30, 115);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(192, 178);
            this.btnYes.TabIndex = 7;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(228, 115);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(192, 178);
            this.btnNo.TabIndex = 8;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lstMchd
            // 
            this.lstMchd.FormattingEnabled = true;
            this.lstMchd.ItemHeight = 15;
            this.lstMchd.Location = new System.Drawing.Point(482, 62);
            this.lstMchd.Name = "lstMchd";
            this.lstMchd.Size = new System.Drawing.Size(245, 334);
            this.lstMchd.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Matches";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMchd);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblRstrnt);
            this.Controls.Add(this.lblTrn);
            this.Controls.Add(this.txtNm);
            this.Controls.Add(this.lblStts);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Matches";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblStts;
        private System.Windows.Forms.TextBox txtNm;
        private System.Windows.Forms.Label lblTrn;
        private System.Windows.Forms.Label lblRstrnt;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.ListBox lstMchd;
        private System.Windows.Forms.Label label1;
    }
}

