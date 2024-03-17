namespace ImageDownShrinker
{
    partial class ImageGoesSmol
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            NewSizeTxt = new TextBox();
            label4 = new Label();
            ZapaziBtn = new Button();
            IzberiSnimkaBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 160);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 9);
            label3.Name = "label3";
            label3.Size = new Size(148, 20);
            label3.TabIndex = 3;
            label3.Text = "Избери нов размер";
            // 
            // NewSizeTxt
            // 
            NewSizeTxt.Location = new Point(336, 36);
            NewSizeTxt.Name = "NewSizeTxt";
            NewSizeTxt.Size = new Size(58, 27);
            NewSizeTxt.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(400, 39);
            label4.Name = "label4";
            label4.Size = new Size(21, 20);
            label4.TabIndex = 5;
            label4.Text = "%";
            // 
            // ZapaziBtn
            // 
            ZapaziBtn.Location = new Point(496, 36);
            ZapaziBtn.Name = "ZapaziBtn";
            ZapaziBtn.Size = new Size(94, 29);
            ZapaziBtn.TabIndex = 6;
            ZapaziBtn.Text = "Запази";
            ZapaziBtn.UseVisualStyleBackColor = true;
            ZapaziBtn.Click += ZapaziBtn_Click;
            // 
            // IzberiSnimkaBtn
            // 
            IzberiSnimkaBtn.Location = new Point(88, 35);
            IzberiSnimkaBtn.Name = "IzberiSnimkaBtn";
            IzberiSnimkaBtn.Size = new Size(94, 29);
            IzberiSnimkaBtn.TabIndex = 7;
            IzberiSnimkaBtn.Text = "Избери снимка";
            IzberiSnimkaBtn.UseVisualStyleBackColor = true;
            IzberiSnimkaBtn.Click += ChooseImage_Click;
            // 
            // ImageGoesSmol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IzberiSnimkaBtn);
            Controls.Add(ZapaziBtn);
            Controls.Add(label4);
            Controls.Add(NewSizeTxt);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "ImageGoesSmol";
            Text = "ImageGoesSmol";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox NewSizeTxt;
        private Label label4;
        private Button ZapaziBtn;
        private Button IzberiSnimkaBtn;
    }
}
