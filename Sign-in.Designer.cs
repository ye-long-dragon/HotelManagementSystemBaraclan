namespace HotelManagementSystemBaraclan
{
    partial class Main
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
            this.lblSignin = new System.Windows.Forms.Label();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblSignin
            // 
            this.lblSignin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSignin.AutoSize = true;
            this.lblSignin.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignin.Location = new System.Drawing.Point(198, 110);
            this.lblSignin.Name = "lblSignin";
            this.lblSignin.Size = new System.Drawing.Size(389, 75);
            this.lblSignin.TabIndex = 0;
            this.lblSignin.Text = "Welcome User";
            // 
            // btnRoom
            // 
            this.btnRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRoom.Location = new System.Drawing.Point(139, 257);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(184, 95);
            this.btnRoom.TabIndex = 1;
            this.btnRoom.Text = "User";
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnUserClicked);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmployee.Location = new System.Drawing.Point(438, 257);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(184, 95);
            this.btnEmployee.TabIndex = 2;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployeeClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 40);
            this.panel1.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(785, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnRoom);
            this.Controls.Add(this.lblSignin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AcuHotel System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSignin;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Panel panel1;
    }
}

