namespace Digitron
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
            pictureBox1 = new PictureBox();
            currentValue = new Label();
            inputBox = new TextBox();
            key1 = new Button();
            key2 = new Button();
            key3 = new Button();
            key4 = new Button();
            key5 = new Button();
            key6 = new Button();
            key7 = new Button();
            key8 = new Button();
            key9 = new Button();
            clearKey = new Button();
            key0 = new Button();
            periodKey = new Button();
            plusKey = new Button();
            minusKey = new Button();
            multiplyKey = new Button();
            divideKey = new Button();
            historyBox = new ListBox();
            logo = new PictureBox();
            undoButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._70d8fbf605d278a212a4c6044a118e35;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // currentValue
            // 
            currentValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            currentValue.Font = new Font("NSimSun", 36F, FontStyle.Bold, GraphicsUnit.Point);
            currentValue.ForeColor = Color.DodgerBlue;
            currentValue.Location = new Point(180, 12);
            currentValue.Name = "currentValue";
            currentValue.Size = new Size(212, 150);
            currentValue.TabIndex = 1;
            currentValue.Text = "0";
            currentValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // inputBox
            // 
            inputBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            inputBox.Location = new Point(12, 168);
            inputBox.Name = "inputBox";
            inputBox.PlaceholderText = "Input...";
            inputBox.Size = new Size(203, 35);
            inputBox.TabIndex = 2;
            // 
            // key1
            // 
            key1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            key1.Location = new Point(12, 209);
            key1.Name = "key1";
            key1.Size = new Size(50, 50);
            key1.TabIndex = 3;
            key1.Text = "1";
            key1.UseVisualStyleBackColor = true;
            // 
            // key2
            // 
            key2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            key2.Location = new Point(68, 209);
            key2.Name = "key2";
            key2.Size = new Size(50, 50);
            key2.TabIndex = 4;
            key2.Text = "2";
            key2.UseVisualStyleBackColor = true;
            // 
            // key3
            // 
            key3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            key3.Location = new Point(124, 209);
            key3.Name = "key3";
            key3.Size = new Size(50, 50);
            key3.TabIndex = 5;
            key3.Text = "3";
            key3.UseVisualStyleBackColor = true;
            // 
            // key4
            // 
            key4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            key4.Location = new Point(12, 265);
            key4.Name = "key4";
            key4.Size = new Size(50, 50);
            key4.TabIndex = 6;
            key4.Text = "4";
            key4.UseVisualStyleBackColor = true;
            // 
            // key5
            // 
            key5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            key5.Location = new Point(68, 265);
            key5.Name = "key5";
            key5.Size = new Size(50, 50);
            key5.TabIndex = 7;
            key5.Text = "5";
            key5.UseVisualStyleBackColor = true;
            // 
            // key6
            // 
            key6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            key6.Location = new Point(124, 265);
            key6.Name = "key6";
            key6.Size = new Size(50, 50);
            key6.TabIndex = 8;
            key6.Text = "6";
            key6.UseVisualStyleBackColor = true;
            // 
            // key7
            // 
            key7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            key7.Location = new Point(12, 321);
            key7.Name = "key7";
            key7.Size = new Size(50, 50);
            key7.TabIndex = 9;
            key7.Text = "7";
            key7.UseVisualStyleBackColor = true;
            // 
            // key8
            // 
            key8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            key8.Location = new Point(68, 321);
            key8.Name = "key8";
            key8.Size = new Size(50, 50);
            key8.TabIndex = 10;
            key8.Text = "8";
            key8.UseVisualStyleBackColor = true;
            // 
            // key9
            // 
            key9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            key9.Location = new Point(124, 321);
            key9.Name = "key9";
            key9.Size = new Size(50, 50);
            key9.TabIndex = 11;
            key9.Text = "9";
            key9.UseVisualStyleBackColor = true;
            // 
            // clearKey
            // 
            clearKey.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            clearKey.Location = new Point(12, 377);
            clearKey.Name = "clearKey";
            clearKey.Size = new Size(50, 41);
            clearKey.TabIndex = 12;
            clearKey.Text = "C";
            clearKey.UseVisualStyleBackColor = true;
            // 
            // key0
            // 
            key0.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            key0.Location = new Point(68, 377);
            key0.Name = "key0";
            key0.Size = new Size(50, 41);
            key0.TabIndex = 13;
            key0.Text = "0";
            key0.UseVisualStyleBackColor = true;
            // 
            // periodKey
            // 
            periodKey.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            periodKey.Location = new Point(124, 378);
            periodKey.Name = "periodKey";
            periodKey.Size = new Size(50, 41);
            periodKey.TabIndex = 14;
            periodKey.Text = ".";
            periodKey.UseVisualStyleBackColor = true;
            // 
            // plusKey
            // 
            plusKey.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            plusKey.Location = new Point(180, 210);
            plusKey.Name = "plusKey";
            plusKey.Size = new Size(35, 50);
            plusKey.TabIndex = 15;
            plusKey.Text = "+";
            plusKey.UseVisualStyleBackColor = true;
            // 
            // minusKey
            // 
            minusKey.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            minusKey.Location = new Point(180, 266);
            minusKey.Name = "minusKey";
            minusKey.Size = new Size(35, 50);
            minusKey.TabIndex = 16;
            minusKey.Text = "-";
            minusKey.UseVisualStyleBackColor = true;
            // 
            // multiplyKey
            // 
            multiplyKey.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            multiplyKey.Location = new Point(180, 322);
            multiplyKey.Name = "multiplyKey";
            multiplyKey.Size = new Size(35, 50);
            multiplyKey.TabIndex = 17;
            multiplyKey.Text = "*";
            multiplyKey.UseVisualStyleBackColor = true;
            // 
            // divideKey
            // 
            divideKey.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            divideKey.Location = new Point(180, 378);
            divideKey.Name = "divideKey";
            divideKey.Size = new Size(35, 41);
            divideKey.TabIndex = 18;
            divideKey.Text = "/";
            divideKey.UseVisualStyleBackColor = true;
            // 
            // historyBox
            // 
            historyBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            historyBox.BackColor = Color.Black;
            historyBox.BorderStyle = BorderStyle.None;
            historyBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            historyBox.ForeColor = SystemColors.ControlLightLight;
            historyBox.FormattingEnabled = true;
            historyBox.IntegralHeight = false;
            historyBox.ItemHeight = 21;
            historyBox.Location = new Point(221, 168);
            historyBox.Name = "historyBox";
            historyBox.RightToLeft = RightToLeft.Yes;
            historyBox.Size = new Size(171, 194);
            historyBox.TabIndex = 19;
            // 
            // logo
            // 
            logo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            logo.Image = Properties.Resources.MB_Transparent;
            logo.Location = new Point(221, 377);
            logo.Name = "logo";
            logo.Size = new Size(43, 42);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 20;
            logo.TabStop = false;
            // 
            // undoButton
            // 
            undoButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            undoButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            undoButton.Location = new Point(313, 378);
            undoButton.Name = "undoButton";
            undoButton.Size = new Size(79, 40);
            undoButton.TabIndex = 21;
            undoButton.Text = "UNDO";
            undoButton.UseVisualStyleBackColor = true;
            undoButton.Click += undoButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(404, 431);
            Controls.Add(undoButton);
            Controls.Add(logo);
            Controls.Add(historyBox);
            Controls.Add(divideKey);
            Controls.Add(multiplyKey);
            Controls.Add(minusKey);
            Controls.Add(plusKey);
            Controls.Add(periodKey);
            Controls.Add(key0);
            Controls.Add(clearKey);
            Controls.Add(key9);
            Controls.Add(key8);
            Controls.Add(key7);
            Controls.Add(key6);
            Controls.Add(key5);
            Controls.Add(key4);
            Controls.Add(key3);
            Controls.Add(key2);
            Controls.Add(key1);
            Controls.Add(inputBox);
            Controls.Add(currentValue);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MinimumSize = new Size(400, 470);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BORKANOV ULTRA DIGITRON 300000";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label currentValue;
        private TextBox inputBox;
        private Button key1;
        private Button key2;
        private Button key3;
        private Button key4;
        private Button key5;
        private Button key6;
        private Button key7;
        private Button key8;
        private Button key9;
        private Button clearKey;
        private Button key0;
        private Button periodKey;
        private Button plusKey;
        private Button minusKey;
        private Button multiplyKey;
        private Button divideKey;
        private ListBox historyBox;
        private PictureBox logo;
        private Button undoButton;
    }
}