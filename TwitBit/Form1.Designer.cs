namespace TwitBit {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing&&(components!=null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.ChannelLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.IPLabel = new System.Windows.Forms.Label();
            this.TESTButton = new System.Windows.Forms.Button();
            this.DEBUGLabel = new System.Windows.Forms.Label();
            this.textBoxChannel = new System.Windows.Forms.TextBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.buttonColor = new System.Windows.Forms.Button();
            this.timerBlink = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ChannelLabel
            // 
            this.ChannelLabel.AutoSize = true;
            this.ChannelLabel.Location = new System.Drawing.Point(12, 28);
            this.ChannelLabel.Name = "ChannelLabel";
            this.ChannelLabel.Size = new System.Drawing.Size(52, 13);
            this.ChannelLabel.TabIndex = 0;
            this.ChannelLabel.Text = "Channel: ";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(12, 86);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(32, 13);
            this.PortLabel.TabIndex = 1;
            this.PortLabel.Text = "Port: ";
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Location = new System.Drawing.Point(12, 56);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(23, 13);
            this.IPLabel.TabIndex = 2;
            this.IPLabel.Text = "IP: ";
            // 
            // TESTButton
            // 
            this.TESTButton.Location = new System.Drawing.Point(70, 132);
            this.TESTButton.Name = "TESTButton";
            this.TESTButton.Size = new System.Drawing.Size(75, 23);
            this.TESTButton.TabIndex = 3;
            this.TESTButton.Text = "TEST";
            this.TESTButton.UseVisualStyleBackColor = true;
            this.TESTButton.Click += new System.EventHandler(this.TESTButton_Click);
            // 
            // DEBUGLabel
            // 
            this.DEBUGLabel.AutoSize = true;
            this.DEBUGLabel.Location = new System.Drawing.Point(12, 284);
            this.DEBUGLabel.Name = "DEBUGLabel";
            this.DEBUGLabel.Size = new System.Drawing.Size(51, 13);
            this.DEBUGLabel.TabIndex = 4;
            this.DEBUGLabel.Text = "DEBUG: ";
            // 
            // textBoxChannel
            // 
            this.textBoxChannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxChannel.Location = new System.Drawing.Point(70, 25);
            this.textBoxChannel.Name = "textBoxChannel";
            this.textBoxChannel.Size = new System.Drawing.Size(100, 20);
            this.textBoxChannel.TabIndex = 6;
            // 
            // textBoxIP
            // 
            this.textBoxIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxIP.Location = new System.Drawing.Point(70, 54);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxIP.TabIndex = 7;
            this.textBoxIP.Text = "irc.twitch.tv";
            // 
            // textBoxPort
            // 
            this.textBoxPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPort.Location = new System.Drawing.Point(70, 84);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxPort.TabIndex = 8;
            this.textBoxPort.Text = "6667";
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(199, 132);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(75, 23);
            this.buttonColor.TabIndex = 9;
            this.buttonColor.Text = "Toggle Color";
            this.buttonColor.UseVisualStyleBackColor = true;
            // 
            // timerBlink
            // 
            this.timerBlink.Tick += new System.EventHandler(this.timerBlink_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 340);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.textBoxChannel);
            this.Controls.Add(this.DEBUGLabel);
            this.Controls.Add(this.TESTButton);
            this.Controls.Add(this.IPLabel);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.ChannelLabel);
            this.Name = "Form1";
            this.Text = "TwitBit 0.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChannelLabel;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.Button TESTButton;
        private System.Windows.Forms.Label DEBUGLabel;
        private System.Windows.Forms.TextBox textBoxChannel;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Timer timerBlink;
    }
}

