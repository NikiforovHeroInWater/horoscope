namespace Гороскоп
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
            monthCalendar1 = new MonthCalendar();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(13, 9);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(189, 9);
            label1.Name = "label1";
            label1.Size = new Size(257, 40);
            label1.TabIndex = 1;
            label1.Text = "Ваш знак зодиака";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(189, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(380, 243);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(13, 353);
            label2.Name = "label2";
            label2.Size = new Size(0, 18);
            label2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 448);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(monthCalendar1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Честный гороскоп";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}
