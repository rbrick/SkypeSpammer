namespace SkypeSpammer
{
    partial class SkypeSpammer
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
            this.skypeSpamGroup = new System.Windows.Forms.GroupBox();
            this.spamBtn = new System.Windows.Forms.Button();
            this.iterBox = new System.Windows.Forms.TextBox();
            this.iterlbl = new System.Windows.Forms.Label();
            this.msgBox = new System.Windows.Forms.TextBox();
            this.messageLbl = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.TextBox();
            this.msgGroupCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.skypeSpamGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // skypeSpamGroup
            // 
            this.skypeSpamGroup.Controls.Add(this.label1);
            this.skypeSpamGroup.Controls.Add(this.msgGroupCheck);
            this.skypeSpamGroup.Controls.Add(this.spamBtn);
            this.skypeSpamGroup.Controls.Add(this.iterBox);
            this.skypeSpamGroup.Controls.Add(this.iterlbl);
            this.skypeSpamGroup.Controls.Add(this.msgBox);
            this.skypeSpamGroup.Controls.Add(this.messageLbl);
            this.skypeSpamGroup.Controls.Add(this.userName);
            this.skypeSpamGroup.Controls.Add(this.userBox);
            this.skypeSpamGroup.Location = new System.Drawing.Point(13, 13);
            this.skypeSpamGroup.Name = "skypeSpamGroup";
            this.skypeSpamGroup.Size = new System.Drawing.Size(416, 277);
            this.skypeSpamGroup.TabIndex = 0;
            this.skypeSpamGroup.TabStop = false;
            this.skypeSpamGroup.Text = "Skype Spammer";
            // 
            // spamBtn
            // 
            this.spamBtn.Location = new System.Drawing.Point(286, 31);
            this.spamBtn.Name = "spamBtn";
            this.spamBtn.Size = new System.Drawing.Size(113, 192);
            this.spamBtn.TabIndex = 6;
            this.spamBtn.Text = "Spam";
            this.spamBtn.UseVisualStyleBackColor = true;
            this.spamBtn.Click += new System.EventHandler(this.spamBtn_Click);
            // 
            // iterBox
            // 
            this.iterBox.Location = new System.Drawing.Point(63, 87);
            this.iterBox.Name = "iterBox";
            this.iterBox.Size = new System.Drawing.Size(190, 20);
            this.iterBox.TabIndex = 5;
            // 
            // iterlbl
            // 
            this.iterlbl.AutoSize = true;
            this.iterlbl.Location = new System.Drawing.Point(6, 87);
            this.iterlbl.Name = "iterlbl";
            this.iterlbl.Size = new System.Drawing.Size(50, 13);
            this.iterlbl.TabIndex = 4;
            this.iterlbl.Text = "Iterations";
            // 
            // msgBox
            // 
            this.msgBox.Location = new System.Drawing.Point(6, 147);
            this.msgBox.Multiline = true;
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(247, 57);
            this.msgBox.TabIndex = 3;
            // 
            // messageLbl
            // 
            this.messageLbl.AutoSize = true;
            this.messageLbl.Location = new System.Drawing.Point(7, 131);
            this.messageLbl.Name = "messageLbl";
            this.messageLbl.Size = new System.Drawing.Size(50, 13);
            this.messageLbl.TabIndex = 2;
            this.messageLbl.Text = "Message";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(7, 31);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(58, 13);
            this.userName.TabIndex = 1;
            this.userName.Text = "Username:";
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(6, 50);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(247, 20);
            this.userBox.TabIndex = 0;
            // 
            // msgGroupCheck
            // 
            this.msgGroupCheck.AutoSize = true;
            this.msgGroupCheck.Location = new System.Drawing.Point(300, 254);
            this.msgGroupCheck.Name = "msgGroupCheck";
            this.msgGroupCheck.Size = new System.Drawing.Size(107, 17);
            this.msgGroupCheck.TabIndex = 7;
            this.msgGroupCheck.Text = "Message Group?";
            this.msgGroupCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // SkypeSpammer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 302);
            this.Controls.Add(this.skypeSpamGroup);
            this.Name = "SkypeSpammer";
            this.Text = "Skype Spammer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.skypeSpamGroup.ResumeLayout(false);
            this.skypeSpamGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox skypeSpamGroup;
        private System.Windows.Forms.TextBox msgBox;
        private System.Windows.Forms.Label messageLbl;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox iterBox;
        private System.Windows.Forms.Label iterlbl;
        private System.Windows.Forms.Button spamBtn;
        private System.Windows.Forms.CheckBox msgGroupCheck;
        private System.Windows.Forms.Label label1;
    }
}

