namespace StudentEncryptedToDB
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtStream = new System.Windows.Forms.TextBox();
            this.txtEncName = new System.Windows.Forms.TextBox();
            this.txtEncAddres = new System.Windows.Forms.TextBox();
            this.txtEncStream = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtkeyName = new System.Windows.Forms.TextBox();
            this.txtKeyAddress = new System.Windows.Forms.TextBox();
            this.txtkeyStream = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(47, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(147, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(75, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(47, 88);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(47, 126);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 4;
            this.lblClass.Text = "Class";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(147, 88);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(75, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // txtStream
            // 
            this.txtStream.Location = new System.Drawing.Point(147, 126);
            this.txtStream.Name = "txtStream";
            this.txtStream.Size = new System.Drawing.Size(75, 20);
            this.txtStream.TabIndex = 6;
            // 
            // txtEncName
            // 
            this.txtEncName.Location = new System.Drawing.Point(328, 53);
            this.txtEncName.Multiline = true;
            this.txtEncName.Name = "txtEncName";
            this.txtEncName.Size = new System.Drawing.Size(100, 20);
            this.txtEncName.TabIndex = 7;
            // 
            // txtEncAddres
            // 
            this.txtEncAddres.Location = new System.Drawing.Point(328, 88);
            this.txtEncAddres.Multiline = true;
            this.txtEncAddres.Name = "txtEncAddres";
            this.txtEncAddres.Size = new System.Drawing.Size(100, 20);
            this.txtEncAddres.TabIndex = 8;
            // 
            // txtEncStream
            // 
            this.txtEncStream.Location = new System.Drawing.Point(328, 126);
            this.txtEncStream.Multiline = true;
            this.txtEncStream.Name = "txtEncStream";
            this.txtEncStream.Size = new System.Drawing.Size(100, 20);
            this.txtEncStream.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Encrypt&Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtkeyName
            // 
            this.txtkeyName.Location = new System.Drawing.Point(228, 53);
            this.txtkeyName.Name = "txtkeyName";
            this.txtkeyName.Size = new System.Drawing.Size(75, 20);
            this.txtkeyName.TabIndex = 11;
            // 
            // txtKeyAddress
            // 
            this.txtKeyAddress.Location = new System.Drawing.Point(228, 88);
            this.txtKeyAddress.Name = "txtKeyAddress";
            this.txtKeyAddress.Size = new System.Drawing.Size(75, 20);
            this.txtKeyAddress.TabIndex = 12;
            // 
            // txtkeyStream
            // 
            this.txtkeyStream.Location = new System.Drawing.Point(228, 126);
            this.txtkeyStream.Name = "txtkeyStream";
            this.txtkeyStream.Size = new System.Drawing.Size(75, 20);
            this.txtkeyStream.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 237);
            this.Controls.Add(this.txtkeyStream);
            this.Controls.Add(this.txtKeyAddress);
            this.Controls.Add(this.txtkeyName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEncStream);
            this.Controls.Add(this.txtEncAddres);
            this.Controls.Add(this.txtEncName);
            this.Controls.Add(this.txtStream);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtStream;
        private System.Windows.Forms.TextBox txtEncName;
        private System.Windows.Forms.TextBox txtEncAddres;
        private System.Windows.Forms.TextBox txtEncStream;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtkeyName;
        private System.Windows.Forms.TextBox txtKeyAddress;
        private System.Windows.Forms.TextBox txtkeyStream;
    }
}

