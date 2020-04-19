namespace _72_Creating_Cutsom_WindowsEventLogger
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblevntsource = new System.Windows.Forms.Label();
            this.LblEvntlog = new System.Windows.Forms.Label();
            this.textBoxEventSource = new System.Windows.Forms.TextBox();
            this.textBoxEventLogName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Create Event Log in Windows event viewer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblevntsource
            // 
            this.lblevntsource.AutoSize = true;
            this.lblevntsource.Location = new System.Drawing.Point(153, 134);
            this.lblevntsource.Name = "lblevntsource";
            this.lblevntsource.Size = new System.Drawing.Size(121, 17);
            this.lblevntsource.TabIndex = 8;
            this.lblevntsource.Text = "Event Log Source";
            // 
            // LblEvntlog
            // 
            this.LblEvntlog.AutoSize = true;
            this.LblEvntlog.Location = new System.Drawing.Point(150, 82);
            this.LblEvntlog.Name = "LblEvntlog";
            this.LblEvntlog.Size = new System.Drawing.Size(109, 17);
            this.LblEvntlog.TabIndex = 7;
            this.LblEvntlog.Text = "EventLog Name";
            // 
            // textBoxEventSource
            // 
            this.textBoxEventSource.Location = new System.Drawing.Point(284, 131);
            this.textBoxEventSource.Name = "textBoxEventSource";
            this.textBoxEventSource.Size = new System.Drawing.Size(174, 22);
            this.textBoxEventSource.TabIndex = 6;
            // 
            // textBoxEventLogName
            // 
            this.textBoxEventLogName.Location = new System.Drawing.Point(284, 82);
            this.textBoxEventLogName.Name = "textBoxEventLogName";
            this.textBoxEventLogName.Size = new System.Drawing.Size(174, 22);
            this.textBoxEventLogName.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblevntsource);
            this.Controls.Add(this.LblEvntlog);
            this.Controls.Add(this.textBoxEventSource);
            this.Controls.Add(this.textBoxEventLogName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblevntsource;
        private System.Windows.Forms.Label LblEvntlog;
        private System.Windows.Forms.TextBox textBoxEventSource;
        private System.Windows.Forms.TextBox textBoxEventLogName;
    }
}

