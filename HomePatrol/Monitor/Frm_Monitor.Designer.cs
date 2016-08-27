namespace Monitor
{
    partial class Frm_Monitor
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
            this.lbl_SystemName = new System.Windows.Forms.Label();
            this.lbl_DepartmentName = new System.Windows.Forms.Label();
            this.lbl_ConvFreq = new System.Windows.Forms.Label();
            this.lbl_viewDescrip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_SystemName
            // 
            this.lbl_SystemName.AutoEllipsis = true;
            this.lbl_SystemName.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SystemName.ForeColor = System.Drawing.Color.White;
            this.lbl_SystemName.Location = new System.Drawing.Point(2, 4);
            this.lbl_SystemName.Name = "lbl_SystemName";
            this.lbl_SystemName.Size = new System.Drawing.Size(259, 18);
            this.lbl_SystemName.TabIndex = 0;
            this.lbl_SystemName.Text = "label1";
            // 
            // lbl_DepartmentName
            // 
            this.lbl_DepartmentName.AutoEllipsis = true;
            this.lbl_DepartmentName.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DepartmentName.ForeColor = System.Drawing.Color.White;
            this.lbl_DepartmentName.Location = new System.Drawing.Point(2, 31);
            this.lbl_DepartmentName.Name = "lbl_DepartmentName";
            this.lbl_DepartmentName.Size = new System.Drawing.Size(259, 19);
            this.lbl_DepartmentName.TabIndex = 1;
            this.lbl_DepartmentName.Text = "label2";
            // 
            // lbl_ConvFreq
            // 
            this.lbl_ConvFreq.AutoEllipsis = true;
            this.lbl_ConvFreq.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConvFreq.ForeColor = System.Drawing.Color.White;
            this.lbl_ConvFreq.Location = new System.Drawing.Point(2, 60);
            this.lbl_ConvFreq.Name = "lbl_ConvFreq";
            this.lbl_ConvFreq.Size = new System.Drawing.Size(259, 16);
            this.lbl_ConvFreq.TabIndex = 2;
            this.lbl_ConvFreq.Text = "label3";
            // 
            // lbl_viewDescrip
            // 
            this.lbl_viewDescrip.AutoEllipsis = true;
            this.lbl_viewDescrip.Font = new System.Drawing.Font("Noto Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_viewDescrip.ForeColor = System.Drawing.Color.White;
            this.lbl_viewDescrip.Location = new System.Drawing.Point(2, 86);
            this.lbl_viewDescrip.Name = "lbl_viewDescrip";
            this.lbl_viewDescrip.Size = new System.Drawing.Size(259, 14);
            this.lbl_viewDescrip.TabIndex = 3;
            this.lbl_viewDescrip.Text = "label4";
            // 
            // Frm_Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(265, 108);
            this.Controls.Add(this.lbl_viewDescrip);
            this.Controls.Add(this.lbl_ConvFreq);
            this.Controls.Add(this.lbl_DepartmentName);
            this.Controls.Add(this.lbl_SystemName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_Monitor";
            this.Text = "Monitor";
            this.Load += new System.EventHandler(this.Frm_Monitor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_SystemName;
        private System.Windows.Forms.Label lbl_DepartmentName;
        private System.Windows.Forms.Label lbl_ConvFreq;
        private System.Windows.Forms.Label lbl_viewDescrip;
    }
}

