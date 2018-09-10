namespace A3AT
{
    partial class WindowMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbServers = new System.Windows.Forms.GroupBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arma 3 Administrator Tools";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbServers
            // 
            this.gbServers.Location = new System.Drawing.Point(12, 78);
            this.gbServers.Name = "gbServers";
            this.gbServers.Size = new System.Drawing.Size(326, 331);
            this.gbServers.TabIndex = 1;
            this.gbServers.TabStop = false;
            this.gbServers.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(12, 415);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 23);
            this.cmdExit.TabIndex = 2;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdConfirm
            // 
            this.cmdConfirm.Location = new System.Drawing.Point(263, 415);
            this.cmdConfirm.Name = "cmdConfirm";
            this.cmdConfirm.Size = new System.Drawing.Size(75, 23);
            this.cmdConfirm.TabIndex = 3;
            this.cmdConfirm.Text = "Add Server";
            this.cmdConfirm.UseVisualStyleBackColor = true;
            // 
            // WindowMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.ControlBox = false;
            this.Controls.Add(this.cmdConfirm);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.gbServers);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WindowMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.WindowMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbServers;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdConfirm;
    }
}

