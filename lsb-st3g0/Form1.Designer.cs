namespace lsb_st3g0
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StegoImg = new System.Windows.Forms.PictureBox();
            this.ChannelGroup = new System.Windows.Forms.GroupBox();
            this.CheckRedChannel = new System.Windows.Forms.CheckBox();
            this.CheckGreenChannel = new System.Windows.Forms.CheckBox();
            this.CheckBlueChannel = new System.Windows.Forms.CheckBox();
            this.NumberBitsGroup = new System.Windows.Forms.GroupBox();
            this.ComboRedBits = new System.Windows.Forms.ComboBox();
            this.ComboGreenBits = new System.Windows.Forms.ComboBox();
            this.ComboBlueBits = new System.Windows.Forms.ComboBox();
            this.EncryptionGroup = new System.Windows.Forms.GroupBox();
            this.TextDataGroup = new System.Windows.Forms.GroupBox();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SetTextBtn = new System.Windows.Forms.Button();
            this.SetFileBtn = new System.Windows.Forms.Button();
            this.GetFileBtn = new System.Windows.Forms.Button();
            this.GetTextBtn = new System.Windows.Forms.Button();
            this.CheckEncryption = new System.Windows.Forms.CheckBox();
            this.EncryptionPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboAlgorithm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StegoTextdata = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StegoImg)).BeginInit();
            this.ChannelGroup.SuspendLayout();
            this.NumberBitsGroup.SuspendLayout();
            this.EncryptionGroup.SuspendLayout();
            this.TextDataGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // StegoImg
            // 
            this.StegoImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StegoImg.Location = new System.Drawing.Point(11, 11);
            this.StegoImg.Name = "StegoImg";
            this.StegoImg.Size = new System.Drawing.Size(256, 256);
            this.StegoImg.TabIndex = 0;
            this.StegoImg.TabStop = false;
            // 
            // ChannelGroup
            // 
            this.ChannelGroup.Controls.Add(this.CheckBlueChannel);
            this.ChannelGroup.Controls.Add(this.CheckGreenChannel);
            this.ChannelGroup.Controls.Add(this.CheckRedChannel);
            this.ChannelGroup.Location = new System.Drawing.Point(273, 11);
            this.ChannelGroup.Name = "ChannelGroup";
            this.ChannelGroup.Size = new System.Drawing.Size(83, 107);
            this.ChannelGroup.TabIndex = 2;
            this.ChannelGroup.TabStop = false;
            this.ChannelGroup.Text = "Channel";
            // 
            // CheckRedChannel
            // 
            this.CheckRedChannel.AutoSize = true;
            this.CheckRedChannel.Checked = true;
            this.CheckRedChannel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckRedChannel.Location = new System.Drawing.Point(6, 21);
            this.CheckRedChannel.Name = "CheckRedChannel";
            this.CheckRedChannel.Size = new System.Drawing.Size(56, 21);
            this.CheckRedChannel.TabIndex = 3;
            this.CheckRedChannel.Text = "Red";
            this.CheckRedChannel.UseVisualStyleBackColor = true;
            // 
            // CheckGreenChannel
            // 
            this.CheckGreenChannel.AutoSize = true;
            this.CheckGreenChannel.Checked = true;
            this.CheckGreenChannel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckGreenChannel.Location = new System.Drawing.Point(6, 48);
            this.CheckGreenChannel.Name = "CheckGreenChannel";
            this.CheckGreenChannel.Size = new System.Drawing.Size(70, 21);
            this.CheckGreenChannel.TabIndex = 4;
            this.CheckGreenChannel.Text = "Green";
            this.CheckGreenChannel.UseVisualStyleBackColor = true;
            // 
            // CheckBlueChannel
            // 
            this.CheckBlueChannel.AutoSize = true;
            this.CheckBlueChannel.Checked = true;
            this.CheckBlueChannel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBlueChannel.Location = new System.Drawing.Point(6, 75);
            this.CheckBlueChannel.Name = "CheckBlueChannel";
            this.CheckBlueChannel.Size = new System.Drawing.Size(58, 21);
            this.CheckBlueChannel.TabIndex = 5;
            this.CheckBlueChannel.Text = "Blue";
            this.CheckBlueChannel.UseVisualStyleBackColor = true;
            // 
            // NumberBitsGroup
            // 
            this.NumberBitsGroup.Controls.Add(this.ComboBlueBits);
            this.NumberBitsGroup.Controls.Add(this.ComboGreenBits);
            this.NumberBitsGroup.Controls.Add(this.ComboRedBits);
            this.NumberBitsGroup.Location = new System.Drawing.Point(363, 12);
            this.NumberBitsGroup.Name = "NumberBitsGroup";
            this.NumberBitsGroup.Size = new System.Drawing.Size(203, 107);
            this.NumberBitsGroup.TabIndex = 3;
            this.NumberBitsGroup.TabStop = false;
            this.NumberBitsGroup.Text = "Number of bits to write";
            // 
            // ComboRedBits
            // 
            this.ComboRedBits.FormattingEnabled = true;
            this.ComboRedBits.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.ComboRedBits.Location = new System.Drawing.Point(6, 21);
            this.ComboRedBits.Name = "ComboRedBits";
            this.ComboRedBits.Size = new System.Drawing.Size(191, 24);
            this.ComboRedBits.TabIndex = 0;
            // 
            // ComboGreenBits
            // 
            this.ComboGreenBits.FormattingEnabled = true;
            this.ComboGreenBits.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.ComboGreenBits.Location = new System.Drawing.Point(6, 48);
            this.ComboGreenBits.Name = "ComboGreenBits";
            this.ComboGreenBits.Size = new System.Drawing.Size(191, 24);
            this.ComboGreenBits.TabIndex = 1;
            // 
            // ComboBlueBits
            // 
            this.ComboBlueBits.FormattingEnabled = true;
            this.ComboBlueBits.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.ComboBlueBits.Location = new System.Drawing.Point(6, 75);
            this.ComboBlueBits.Name = "ComboBlueBits";
            this.ComboBlueBits.Size = new System.Drawing.Size(191, 24);
            this.ComboBlueBits.TabIndex = 2;
            // 
            // EncryptionGroup
            // 
            this.EncryptionGroup.Controls.Add(this.label2);
            this.EncryptionGroup.Controls.Add(this.ComboAlgorithm);
            this.EncryptionGroup.Controls.Add(this.label1);
            this.EncryptionGroup.Controls.Add(this.EncryptionPassword);
            this.EncryptionGroup.Controls.Add(this.CheckEncryption);
            this.EncryptionGroup.Location = new System.Drawing.Point(273, 125);
            this.EncryptionGroup.Name = "EncryptionGroup";
            this.EncryptionGroup.Size = new System.Drawing.Size(293, 142);
            this.EncryptionGroup.TabIndex = 4;
            this.EncryptionGroup.TabStop = false;
            this.EncryptionGroup.Text = "Data encryption";
            // 
            // TextDataGroup
            // 
            this.TextDataGroup.Controls.Add(this.StegoTextdata);
            this.TextDataGroup.Location = new System.Drawing.Point(273, 273);
            this.TextDataGroup.Name = "TextDataGroup";
            this.TextDataGroup.Size = new System.Drawing.Size(293, 234);
            this.TextDataGroup.TabIndex = 5;
            this.TextDataGroup.TabStop = false;
            this.TextDataGroup.Text = "Text data";
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(11, 273);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(256, 34);
            this.OpenBtn.TabIndex = 0;
            this.OpenBtn.Text = "Open image";
            this.OpenBtn.UseVisualStyleBackColor = true;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(11, 473);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(256, 34);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Save image";
            this.SaveBtn.UseVisualStyleBackColor = true;
            // 
            // SetTextBtn
            // 
            this.SetTextBtn.Location = new System.Drawing.Point(11, 313);
            this.SetTextBtn.Name = "SetTextBtn";
            this.SetTextBtn.Size = new System.Drawing.Size(256, 34);
            this.SetTextBtn.TabIndex = 8;
            this.SetTextBtn.Text = "Set text into image";
            this.SetTextBtn.UseVisualStyleBackColor = true;
            // 
            // SetFileBtn
            // 
            this.SetFileBtn.Location = new System.Drawing.Point(11, 353);
            this.SetFileBtn.Name = "SetFileBtn";
            this.SetFileBtn.Size = new System.Drawing.Size(256, 34);
            this.SetFileBtn.TabIndex = 9;
            this.SetFileBtn.Text = "Set file into image";
            this.SetFileBtn.UseVisualStyleBackColor = true;
            // 
            // GetFileBtn
            // 
            this.GetFileBtn.Location = new System.Drawing.Point(11, 433);
            this.GetFileBtn.Name = "GetFileBtn";
            this.GetFileBtn.Size = new System.Drawing.Size(256, 34);
            this.GetFileBtn.TabIndex = 11;
            this.GetFileBtn.Text = "Get file from image";
            this.GetFileBtn.UseVisualStyleBackColor = true;
            // 
            // GetTextBtn
            // 
            this.GetTextBtn.Location = new System.Drawing.Point(11, 393);
            this.GetTextBtn.Name = "GetTextBtn";
            this.GetTextBtn.Size = new System.Drawing.Size(256, 34);
            this.GetTextBtn.TabIndex = 10;
            this.GetTextBtn.Text = "Get text from image";
            this.GetTextBtn.UseVisualStyleBackColor = true;
            // 
            // CheckEncryption
            // 
            this.CheckEncryption.AutoSize = true;
            this.CheckEncryption.Location = new System.Drawing.Point(6, 21);
            this.CheckEncryption.Name = "CheckEncryption";
            this.CheckEncryption.Size = new System.Drawing.Size(147, 21);
            this.CheckEncryption.TabIndex = 0;
            this.CheckEncryption.Text = "Is data encrypted?";
            this.CheckEncryption.UseVisualStyleBackColor = true;
            // 
            // EncryptionPassword
            // 
            this.EncryptionPassword.Location = new System.Drawing.Point(6, 65);
            this.EncryptionPassword.Name = "EncryptionPassword";
            this.EncryptionPassword.Size = new System.Drawing.Size(281, 22);
            this.EncryptionPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // ComboAlgorithm
            // 
            this.ComboAlgorithm.FormattingEnabled = true;
            this.ComboAlgorithm.Items.AddRange(new object[] {
            "AES"});
            this.ComboAlgorithm.Location = new System.Drawing.Point(6, 110);
            this.ComboAlgorithm.Name = "ComboAlgorithm";
            this.ComboAlgorithm.Size = new System.Drawing.Size(281, 24);
            this.ComboAlgorithm.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Algorithm";
            // 
            // StegoTextdata
            // 
            this.StegoTextdata.Location = new System.Drawing.Point(6, 21);
            this.StegoTextdata.Multiline = true;
            this.StegoTextdata.Name = "StegoTextdata";
            this.StegoTextdata.Size = new System.Drawing.Size(281, 207);
            this.StegoTextdata.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 520);
            this.Controls.Add(this.GetFileBtn);
            this.Controls.Add(this.GetTextBtn);
            this.Controls.Add(this.SetFileBtn);
            this.Controls.Add(this.SetTextBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.OpenBtn);
            this.Controls.Add(this.TextDataGroup);
            this.Controls.Add(this.EncryptionGroup);
            this.Controls.Add(this.NumberBitsGroup);
            this.Controls.Add(this.ChannelGroup);
            this.Controls.Add(this.StegoImg);
            this.Name = "Form1";
            this.Text = "LSB stego";
            ((System.ComponentModel.ISupportInitialize)(this.StegoImg)).EndInit();
            this.ChannelGroup.ResumeLayout(false);
            this.ChannelGroup.PerformLayout();
            this.NumberBitsGroup.ResumeLayout(false);
            this.EncryptionGroup.ResumeLayout(false);
            this.EncryptionGroup.PerformLayout();
            this.TextDataGroup.ResumeLayout(false);
            this.TextDataGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox StegoImg;
        private System.Windows.Forms.GroupBox ChannelGroup;
        private System.Windows.Forms.CheckBox CheckBlueChannel;
        private System.Windows.Forms.CheckBox CheckGreenChannel;
        private System.Windows.Forms.CheckBox CheckRedChannel;
        private System.Windows.Forms.GroupBox NumberBitsGroup;
        private System.Windows.Forms.ComboBox ComboBlueBits;
        private System.Windows.Forms.ComboBox ComboGreenBits;
        private System.Windows.Forms.ComboBox ComboRedBits;
        private System.Windows.Forms.GroupBox EncryptionGroup;
        private System.Windows.Forms.CheckBox CheckEncryption;
        private System.Windows.Forms.GroupBox TextDataGroup;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button SetTextBtn;
        private System.Windows.Forms.Button SetFileBtn;
        private System.Windows.Forms.Button GetFileBtn;
        private System.Windows.Forms.Button GetTextBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EncryptionPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboAlgorithm;
        private System.Windows.Forms.TextBox StegoTextdata;
    }
}

