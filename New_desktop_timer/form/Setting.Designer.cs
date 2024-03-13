namespace New_desktop_timer.form
{
    partial class Setting
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
            hour = new TrackBar();
            minute = new TrackBar();
            second = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Timer_ = new Label();
            exit = new Button();
            ((System.ComponentModel.ISupportInitialize)hour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)second).BeginInit();
            SuspendLayout();
            // 
            // hour
            // 
            hour.Cursor = Cursors.Hand;
            hour.LargeChange = 0;
            hour.Location = new Point(34, 258);
            hour.Maximum = 23;
            hour.Name = "hour";
            hour.Size = new Size(754, 45);
            hour.TabIndex = 0;
            hour.Scroll += hour_Scroll;
            // 
            // minute
            // 
            minute.Cursor = Cursors.Hand;
            minute.LargeChange = 0;
            minute.Location = new Point(34, 326);
            minute.Maximum = 59;
            minute.Name = "minute";
            minute.Size = new Size(754, 45);
            minute.TabIndex = 1;
            minute.Scroll += hour_Scroll;
            // 
            // second
            // 
            second.Cursor = Cursors.Hand;
            second.LargeChange = 0;
            second.Location = new Point(34, 393);
            second.Maximum = 59;
            second.Name = "second";
            second.Size = new Size(754, 45);
            second.TabIndex = 2;
            second.Scroll += hour_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(0, 258);
            label1.Name = "label1";
            label1.Size = new Size(38, 40);
            label1.TabIndex = 4;
            label1.Text = "H";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.ForeColor = Color.LimeGreen;
            label2.Location = new Point(0, 326);
            label2.Name = "label2";
            label2.Size = new Size(43, 40);
            label2.TabIndex = 5;
            label2.Text = "M";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.ForeColor = Color.LimeGreen;
            label3.Location = new Point(0, 393);
            label3.Name = "label3";
            label3.Size = new Size(32, 40);
            label3.TabIndex = 6;
            label3.Text = "S";
            // 
            // Timer_
            // 
            Timer_.AutoSize = true;
            Timer_.Cursor = Cursors.Hand;
            Timer_.Font = new Font("Yu Gothic UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Timer_.ForeColor = Color.LimeGreen;
            Timer_.Location = new Point(259, 68);
            Timer_.Name = "Timer_";
            Timer_.Size = new Size(205, 86);
            Timer_.TabIndex = 7;
            Timer_.Text = "00:00:";
            // 
            // exit
            // 
            exit.Cursor = Cursors.Hand;
            exit.FlatStyle = FlatStyle.Flat;
            exit.ForeColor = Color.LimeGreen;
            exit.Location = new Point(12, 12);
            exit.Name = "exit";
            exit.Size = new Size(50, 35);
            exit.TabIndex = 8;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.MouseClick += exit_MouseClick;
            // 
            // Setting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(exit);
            Controls.Add(Timer_);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(second);
            Controls.Add(minute);
            Controls.Add(hour);
            Name = "Setting";
            Text = "Setting";
            ((System.ComponentModel.ISupportInitialize)hour).EndInit();
            ((System.ComponentModel.ISupportInitialize)minute).EndInit();
            ((System.ComponentModel.ISupportInitialize)second).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar hour;
        private TrackBar minute;
        private TrackBar second;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label Timer_;
        private Button exit;
    }
}