
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbClient = new System.Windows.Forms.RadioButton();
            this.rbServer = new System.Windows.Forms.RadioButton();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbClient);
            this.groupBox1.Controls.Add(this.rbServer);
            this.groupBox1.Location = new System.Drawing.Point(420, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(400, 86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "type";
            // 
            // rbClient
            // 
            this.rbClient.AutoSize = true;
            this.rbClient.Checked = true;
            this.rbClient.Location = new System.Drawing.Point(29, 26);
            this.rbClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbClient.Name = "rbClient";
            this.rbClient.Size = new System.Drawing.Size(61, 17);
            this.rbClient.TabIndex = 2;
            this.rbClient.TabStop = true;
            this.rbClient.Text = "client";
            this.rbClient.UseVisualStyleBackColor = true;
            // 
            // rbServer
            // 
            this.rbServer.AutoSize = true;
            this.rbServer.Location = new System.Drawing.Point(29, 58);
            this.rbServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbServer.Name = "rbServer";
            this.rbServer.Size = new System.Drawing.Size(68, 17);
            this.rbServer.TabIndex = 2;
            this.rbServer.Text = "server";
            this.rbServer.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(720, 245);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 24);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "장치조회";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(12, 248);
            this.tbText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(388, 21);
            this.tbText.TabIndex = 2;
            this.tbText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbText_KeyPress);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(420, 106);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(400, 124);
            this.listBox1.TabIndex = 4;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(12, 10);
            this.tbOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(388, 218);
            this.tbOutput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 292);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.RadioButton rbClient;
        private System.Windows.Forms.RadioButton rbServer;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbOutput;
    }
}

