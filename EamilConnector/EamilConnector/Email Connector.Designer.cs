namespace EamilConnector
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
            this.Connector = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.passwordFiled = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Connector
            // 
            this.Connector.Location = new System.Drawing.Point(378, 46);
            this.Connector.Name = "Connector";
            this.Connector.Size = new System.Drawing.Size(107, 23);
            this.Connector.TabIndex = 0;
            this.Connector.Text = "Test Connection";
            this.Connector.UseVisualStyleBackColor = true;
            this.Connector.Click += new System.EventHandler(this.Connector_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password :";
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(106, 12);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(159, 20);
            this.EmailText.TabIndex = 3;
            // 
            // passwordFiled
            // 
            this.passwordFiled.Location = new System.Drawing.Point(106, 46);
            this.passwordFiled.Name = "passwordFiled";
            this.passwordFiled.Size = new System.Drawing.Size(159, 20);
            this.passwordFiled.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 262);
            this.Controls.Add(this.passwordFiled);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Connector);
            this.Name = "Form1";
            this.Text = "Email Connector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.TextBox passwordFiled;
    }
}

