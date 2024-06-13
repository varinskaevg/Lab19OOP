namespace Lab19OOP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl2 = new Label();
            lbl3 = new Label();
            lbl4 = new Label();
            lbl5 = new Label();
            lbl6 = new Label();
            lbl7 = new Label();
            lbl8 = new Label();
            lbl9 = new Label();
            lbl10 = new Label();
            lbl12 = new Label();
            btnGetInfo = new Button();
            txtProcessor = new TextBox();
            label1 = new Label();
            txtManufacturer = new TextBox();
            txtDescription = new TextBox();
            txtVideoCard = new TextBox();
            txtVideoProcessor = new TextBox();
            txtDriverVersion = new TextBox();
            txtAdapterRAM = new TextBox();
            txtDVDName = new TextBox();
            txtDVDDrive = new TextBox();
            txtDiskDrive = new TextBox();
            txtDiskSize = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMotherboard = new TextBox();
            txtNetworkAdapter = new TextBox();
            txtBIOS = new TextBox();
            SuspendLayout();
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(19, 49);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(82, 20);
            lbl2.TabIndex = 1;
            lbl2.Text = "Виробник:";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(19, 80);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(48, 20);
            lbl3.TabIndex = 2;
            lbl3.Text = "Опис:";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(14, 118);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(88, 20);
            lbl4.TabIndex = 3;
            lbl4.Text = "Відеокарта:";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Location = new Point(15, 151);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(119, 20);
            lbl5.TabIndex = 4;
            lbl5.Text = "Відеопроцесор:";
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Location = new Point(14, 182);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(131, 20);
            lbl6.TabIndex = 5;
            lbl6.Text = "Версія драйверу: ";
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.Location = new Point(14, 218);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(184, 20);
            lbl7.TabIndex = 6;
            lbl7.Text = "Об’єм пам’яти (в байтах):";
            // 
            // lbl8
            // 
            lbl8.AutoSize = true;
            lbl8.Location = new Point(16, 255);
            lbl8.Name = "lbl8";
            lbl8.Size = new Size(89, 20);
            lbl8.TabIndex = 7;
            lbl8.Text = "Назва DVD:";
            // 
            // lbl9
            // 
            lbl9.AutoSize = true;
            lbl9.Location = new Point(15, 285);
            lbl9.Name = "lbl9";
            lbl9.Size = new Size(86, 20);
            lbl9.TabIndex = 8;
            lbl9.Text = "Буква DVD:";
            // 
            // lbl10
            // 
            lbl10.AutoSize = true;
            lbl10.Location = new Point(15, 316);
            lbl10.Name = "lbl10";
            lbl10.Size = new Size(116, 20);
            lbl10.TabIndex = 9;
            lbl10.Text = "Жорсткий диск:";
            // 
            // lbl12
            // 
            lbl12.AutoSize = true;
            lbl12.Location = new Point(14, 354);
            lbl12.Name = "lbl12";
            lbl12.Size = new Size(126, 20);
            lbl12.TabIndex = 10;
            lbl12.Text = "Об’єм (в байтах):";
            // 
            // btnGetInfo
            // 
            btnGetInfo.Location = new Point(16, 582);
            btnGetInfo.Name = "btnGetInfo";
            btnGetInfo.Size = new Size(601, 50);
            btnGetInfo.TabIndex = 11;
            btnGetInfo.Text = "Отримати інформацію";
            btnGetInfo.UseVisualStyleBackColor = true;
            btnGetInfo.Click += btnGetInfo_Click;
            // 
            // txtProcessor
            // 
            txtProcessor.Location = new Point(212, 18);
            txtProcessor.Name = "txtProcessor";
            txtProcessor.Size = new Size(408, 27);
            txtProcessor.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 18);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 13;
            label1.Text = "Процесор:";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(212, 49);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(408, 27);
            txtManufacturer.TabIndex = 14;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(212, 82);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(408, 27);
            txtDescription.TabIndex = 15;
            // 
            // txtVideoCard
            // 
            txtVideoCard.Location = new Point(213, 115);
            txtVideoCard.Name = "txtVideoCard";
            txtVideoCard.Size = new Size(408, 27);
            txtVideoCard.TabIndex = 16;
            // 
            // txtVideoProcessor
            // 
            txtVideoProcessor.Location = new Point(213, 148);
            txtVideoProcessor.Name = "txtVideoProcessor";
            txtVideoProcessor.Size = new Size(408, 27);
            txtVideoProcessor.TabIndex = 17;
            // 
            // txtDriverVersion
            // 
            txtDriverVersion.Location = new Point(213, 182);
            txtDriverVersion.Name = "txtDriverVersion";
            txtDriverVersion.Size = new Size(408, 27);
            txtDriverVersion.TabIndex = 18;
            // 
            // txtAdapterRAM
            // 
            txtAdapterRAM.Location = new Point(213, 215);
            txtAdapterRAM.Name = "txtAdapterRAM";
            txtAdapterRAM.Size = new Size(408, 27);
            txtAdapterRAM.TabIndex = 19;
            // 
            // txtDVDName
            // 
            txtDVDName.Location = new Point(212, 252);
            txtDVDName.Name = "txtDVDName";
            txtDVDName.Size = new Size(408, 27);
            txtDVDName.TabIndex = 20;
            // 
            // txtDVDDrive
            // 
            txtDVDDrive.Location = new Point(213, 285);
            txtDVDDrive.Name = "txtDVDDrive";
            txtDVDDrive.Size = new Size(408, 27);
            txtDVDDrive.TabIndex = 21;
            // 
            // txtDiskDrive
            // 
            txtDiskDrive.Location = new Point(212, 318);
            txtDiskDrive.Name = "txtDiskDrive";
            txtDiskDrive.Size = new Size(408, 27);
            txtDiskDrive.TabIndex = 22;
            // 
            // txtDiskSize
            // 
            txtDiskSize.Location = new Point(213, 351);
            txtDiskSize.Name = "txtDiskSize";
            txtDiskSize.Size = new Size(408, 27);
            txtDiskSize.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 384);
            label2.Name = "label2";
            label2.Size = new Size(147, 20);
            label2.TabIndex = 24;
            label2.Text = "Материнська плата:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 418);
            label3.Name = "label3";
            label3.Size = new Size(174, 20);
            label3.TabIndex = 25;
            label3.Text = "Мережеве обладнання:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 454);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 26;
            label4.Text = "BIOS:";
            // 
            // txtMotherboard
            // 
            txtMotherboard.Location = new Point(213, 384);
            txtMotherboard.Name = "txtMotherboard";
            txtMotherboard.Size = new Size(408, 27);
            txtMotherboard.TabIndex = 27;
            // 
            // txtNetworkAdapter
            // 
            txtNetworkAdapter.Location = new Point(212, 418);
            txtNetworkAdapter.Name = "txtNetworkAdapter";
            txtNetworkAdapter.Size = new Size(408, 27);
            txtNetworkAdapter.TabIndex = 28;
            // 
            // txtBIOS
            // 
            txtBIOS.Location = new Point(64, 451);
            txtBIOS.Multiline = true;
            txtBIOS.Name = "txtBIOS";
            txtBIOS.Size = new Size(556, 125);
            txtBIOS.TabIndex = 29;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 638);
            Controls.Add(txtBIOS);
            Controls.Add(txtNetworkAdapter);
            Controls.Add(txtMotherboard);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDiskSize);
            Controls.Add(txtDiskDrive);
            Controls.Add(txtDVDDrive);
            Controls.Add(txtDVDName);
            Controls.Add(txtAdapterRAM);
            Controls.Add(txtDriverVersion);
            Controls.Add(txtVideoProcessor);
            Controls.Add(txtVideoCard);
            Controls.Add(txtDescription);
            Controls.Add(txtManufacturer);
            Controls.Add(label1);
            Controls.Add(txtProcessor);
            Controls.Add(btnGetInfo);
            Controls.Add(lbl12);
            Controls.Add(lbl10);
            Controls.Add(lbl9);
            Controls.Add(lbl8);
            Controls.Add(lbl7);
            Controls.Add(lbl6);
            Controls.Add(lbl5);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
        private Label lbl5;
        private Label lbl6;
        private Label lbl7;
        private Label lbl8;
        private Label lbl9;
        private Label lbl10;
        private Label lbl12;
        private Button btnGetInfo;
        private TextBox txtProcessor;
        private Label label1;
        private TextBox txtManufacturer;
        private TextBox txtDescription;
        private TextBox txtVideoCard;
        private TextBox txtVideoProcessor;
        private TextBox txtDriverVersion;
        private TextBox txtAdapterRAM;
        private TextBox txtDVDName;
        private TextBox txtDVDDrive;
        private TextBox txtDiskDrive;
        private TextBox txtDiskSize;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMotherboard;
        private TextBox txtNetworkAdapter;
        private TextBox txtBIOS;
    }
}
