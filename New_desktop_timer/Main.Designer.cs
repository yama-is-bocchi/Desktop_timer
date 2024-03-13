namespace New_desktop_timer
{
    partial class Main
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
            components = new System.ComponentModel.Container();
            reset_btn = new Button();
            st_btn = new Button();
            Timer_label = new Label();
            count_cur_timer = new System.Windows.Forms.Timer(components);
            main_panel = new Panel();
            main_panel.SuspendLayout();
            SuspendLayout();
            // 
            // reset_btn
            // 
            reset_btn.Cursor = Cursors.Hand;
            reset_btn.FlatStyle = FlatStyle.Flat;
            reset_btn.ForeColor = Color.LimeGreen;
            reset_btn.Location = new Point(75, 56);
            reset_btn.Name = "reset_btn";
            reset_btn.Size = new Size(50, 35);
            reset_btn.TabIndex = 5;
            reset_btn.Text = "Reset";
            reset_btn.UseVisualStyleBackColor = true;
            reset_btn.MouseClick += reset_btn_MouseClick;
            // 
            // st_btn
            // 
            st_btn.Cursor = Cursors.Hand;
            st_btn.FlatStyle = FlatStyle.Flat;
            st_btn.ForeColor = Color.LimeGreen;
            st_btn.Location = new Point(12, 56);
            st_btn.Name = "st_btn";
            st_btn.Size = new Size(50, 35);
            st_btn.TabIndex = 4;
            st_btn.Text = "ST";
            st_btn.UseVisualStyleBackColor = true;
            st_btn.MouseClick += st_btn_MouseClick;
            // 
            // Timer_label
            // 
            Timer_label.AutoSize = true;
            Timer_label.Cursor = Cursors.Hand;
            Timer_label.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Timer_label.ForeColor = Color.LimeGreen;
            Timer_label.Location = new Point(9, 9);
            Timer_label.Name = "Timer_label";
            Timer_label.Size = new Size(125, 40);
            Timer_label.TabIndex = 3;
            Timer_label.Text = "00:00:00";
            Timer_label.MouseClick += Timer_label_MouseClick;
            // 
            // count_cur_timer
            // 
            count_cur_timer.Interval = 1000;
            count_cur_timer.Tick += count_cur_timer_Tick;
            // 
            // main_panel
            // 
            main_panel.Controls.Add(reset_btn);
            main_panel.Controls.Add(Timer_label);
            main_panel.Controls.Add(st_btn);
            main_panel.Dock = DockStyle.Fill;
            main_panel.Location = new Point(0, 0);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(134, 101);
            main_panel.TabIndex = 6;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(134, 101);
            Controls.Add(main_panel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            TopMost = true;
            main_panel.ResumeLayout(false);
            main_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button reset_btn;
        private Button st_btn;
        private Label Timer_label;
        private System.Windows.Forms.Timer count_cur_timer;
        private Panel main_panel;
    }
}
