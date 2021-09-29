
namespace BleWindowTest1
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
            this.lbReceive = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbClient = new System.Windows.Forms.RadioButton();
            this.rbServer = new System.Windows.Forms.RadioButton();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbtitle = new System.Windows.Forms.TextBox();
            this.lbWrite = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbReceive
            // 
            this.lbReceive.FormattingEnabled = true;
            this.lbReceive.ItemHeight = 15;
            this.lbReceive.Location = new System.Drawing.Point(12, 12);
            this.lbReceive.Name = "lbReceive";
            this.lbReceive.Size = new System.Drawing.Size(569, 259);
            this.lbReceive.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbClient);
            this.groupBox1.Controls.Add(this.rbServer);
            this.groupBox1.Location = new System.Drawing.Point(622, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "type";
            // 
            // rbClient
            // 
            this.rbClient.AutoSize = true;
            this.rbClient.Location = new System.Drawing.Point(33, 33);
            this.rbClient.Name = "rbClient";
            this.rbClient.Size = new System.Drawing.Size(62, 19);
            this.rbClient.TabIndex = 2;
            this.rbClient.TabStop = true;
            this.rbClient.Text = "client";
            this.rbClient.UseVisualStyleBackColor = true;
            // 
            // rbServer
            // 
            this.rbServer.AutoSize = true;
            this.rbServer.Location = new System.Drawing.Point(33, 72);
            this.rbServer.Name = "rbServer";
            this.rbServer.Size = new System.Drawing.Size(68, 19);
            this.rbServer.TabIndex = 2;
            this.rbServer.TabStop = true;
            this.rbServer.Text = "server";
            this.rbServer.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(778, 241);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(114, 30);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbtitle
            // 
            this.tbtitle.Location = new System.Drawing.Point(14, 310);
            this.tbtitle.Name = "tbtitle";
            this.tbtitle.Size = new System.Drawing.Size(566, 25);
            this.tbtitle.TabIndex = 2;
            // 
            // lbWrite
            // 
            this.lbWrite.FormattingEnabled = true;
            this.lbWrite.ItemHeight = 15;
            this.lbWrite.Location = new System.Drawing.Point(622, 147);
            this.lbWrite.Name = "lbWrite";
            this.lbWrite.Size = new System.Drawing.Size(315, 64);
            this.lbWrite.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 365);
            this.Controls.Add(this.lbWrite);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbtitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbReceive);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbReceive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.RadioButton rbClient;
        private System.Windows.Forms.RadioButton rbServer;
        private System.Windows.Forms.TextBox tbtitle;
        private System.Windows.Forms.ListBox lbWrite;
    }
}

