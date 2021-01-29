namespace WinFormAddin
{
    partial class NewForm
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
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.Distance = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdoHorizontal = new System.Windows.Forms.RadioButton();
            this.RdoVertical = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(238, 287);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 0;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOk
            // 
            this.ButtonOk.Location = new System.Drawing.Point(66, 287);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(75, 23);
            this.ButtonOk.TabIndex = 1;
            this.ButtonOk.Text = "Ok";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(77, 12);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(191, 20);
            this.txtDistance.TabIndex = 2;
            this.txtDistance.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Distance
            // 
            this.Distance.AutoSize = true;
            this.Distance.Location = new System.Drawing.Point(22, 15);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(49, 13);
            this.Distance.TabIndex = 3;
            this.Distance.Text = "Distance";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdoHorizontal);
            this.groupBox1.Controls.Add(this.RdoVertical);
            this.groupBox1.Location = new System.Drawing.Point(43, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // RdoHorizontal
            // 
            this.RdoHorizontal.AutoSize = true;
            this.RdoHorizontal.Location = new System.Drawing.Point(7, 44);
            this.RdoHorizontal.Name = "RdoHorizontal";
            this.RdoHorizontal.Size = new System.Drawing.Size(72, 17);
            this.RdoHorizontal.TabIndex = 1;
            this.RdoHorizontal.Text = "Horizontal";
            this.RdoHorizontal.UseVisualStyleBackColor = true;
            // 
            // RdoVertical
            // 
            this.RdoVertical.AutoSize = true;
            this.RdoVertical.Checked = true;
            this.RdoVertical.Location = new System.Drawing.Point(7, 20);
            this.RdoVertical.Name = "RdoVertical";
            this.RdoVertical.Size = new System.Drawing.Size(60, 17);
            this.RdoVertical.TabIndex = 0;
            this.RdoVertical.TabStop = true;
            this.RdoVertical.Text = "Vertical";
            this.RdoVertical.UseVisualStyleBackColor = true;
            // 
            // NewForm
            // 
            this.AcceptButton = this.ButtonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(348, 340);
            this.Controls.Add(this.ButtonOk);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Distance);
            this.Controls.Add(this.txtDistance);
            this.Name = "NewForm";
            this.Text = "NewForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonOk;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label Distance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdoHorizontal;
        private System.Windows.Forms.RadioButton RdoVertical;
    }
}