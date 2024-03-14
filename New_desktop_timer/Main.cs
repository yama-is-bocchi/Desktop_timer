using Microsoft.Toolkit.Uwp.Notifications;
using System.Text;

namespace New_desktop_timer
{
    

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Read_parent_data();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        private TimeSpan Parent_cur_timespan;
        private TimeSpan Counting_cur_timespan;

        private void Read_parent_data()
        {
            StreamReader sr = new StreamReader(@"res\Parent_data.csv");//フィールドデータ読み取り
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine() + "";
                    string[] values = line.Split("\n");
                    List<string> lists = new List<string>();
                    lists.AddRange(values);
                    foreach (string liner in lists)
                    {
                        string[] work = liner.Split(",");
                        if (liner.Contains("TRUE"))
                        {
                            //タイマーラベル変換処理
                            Parent_cur_timespan = TimeSpan.Parse(work[1]);
                            Common.curtime = Parent_cur_timespan;
                            //ファイルを捜して読み取る
                            Timer_label.Text = Ret_cur_file();

                        }
                    }

                }
                sr.Close();
            }
        }

        private void Write_cur_counting()
        {
            using (StreamWriter sw = new StreamWriter(@"res\origin.csv", false,
                    Encoding.GetEncoding("utf-8")))
            {
                sw.WriteLine(Counting_cur_timespan.ToString());

                sw.Close();
            }
        }


        private string Ret_cur_file()
        {
            string temp = "";
            StreamReader sr = new StreamReader(@"res\origin.csv");//フィールドデータ読み取り
            {

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine() + "";
                    string[] values = line.Split("\n");
                    List<string> lists = new List<string>();
                    lists.AddRange(values);
                    foreach (string liner in lists)
                    {
                        Counting_cur_timespan = TimeSpan.Parse(liner);
                        temp = Counting_cur_timespan.ToString();
                    }

                }
                sr.Close();
            }
            return temp;
        }

        private void st_btn_MouseClick(object sender, MouseEventArgs e)
        {
            if (Counting_cur_timespan == new TimeSpan(0, 0, 0)) return;


            if (((Button)sender).Text == "ST")
            {
                ((Button)sender).Text = "Stop";

                count_cur_timer.Start();

            }
            else
            {
                ((Button)sender).Text = "ST";

                count_cur_timer.Stop();
            }
        }

        private void reset_btn_MouseClick(object sender, MouseEventArgs e)
        {
            count_cur_timer.Stop();
            Counting_cur_timespan = Parent_cur_timespan;
            Write_cur_counting();
            Timer_label.Text = Parent_cur_timespan.ToString();
            st_btn.Text = "ST";
        }

        private void count_cur_timer_Tick(object sender, EventArgs e)
        {
            count_cur_timer.Stop();

            TimeSpan work = new TimeSpan(0, 0, 1);

            Counting_cur_timespan -= work;

            Timer_label.Text = Counting_cur_timespan.ToString();

            Write_cur_counting();

            if (Counting_cur_timespan.TotalSeconds > 0)
            {
                count_cur_timer.Start();
            }
            else
            {
                new ToastContentBuilder()
               .AddText("タイマー満了通知です")
               .Show();
            }
        }

        private void Timer_label_MouseClick(object sender, MouseEventArgs e)
        {
            //設定フォームを開く
            count_cur_timer.Stop();
            st_btn.Text = "ST";
            Form form = new form.Setting();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            main_panel.Controls.Add(form);
            this.MaximumSize = new Size(816, 489);
            this.MinimumSize = new Size(816, 489);
            this.Size = new Size(816, 489);
            form.FormClosed += Closed_form;
            form.BringToFront();
            form.Show();
        }

        private void Closed_form(object? sender,EventArgs e)
        {
            this.MaximumSize = new Size(150, 140);
            this.MinimumSize = new Size(150, 140);
            this.Size = new Size(150, 140);
            if (Common.curtime==Parent_cur_timespan)return;
            else
            Parent_cur_timespan=Common.curtime;
            Counting_cur_timespan = Common.curtime;
            Write_cur_counting() ;

            string[] work=new string[0];

            StreamReader sr = new StreamReader(@"res\Parent_data.csv");//フィールドデータ読み取り
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine() + "";
                    string[] values = line.Split("\n");
                    List<string> lists = new List<string>();
                    lists.AddRange(values);
                    foreach (string liner in lists)
                    {
                         work= liner.Split(",");
                    
                    }

                }
                sr.Close();
            }


            using (StreamWriter sw = new StreamWriter(@"res\Parent_data.csv", false,
         Encoding.GetEncoding("utf-8")))
            {
                sw.WriteLine(work[0] + "," + Common.curtime.ToString() + "," + work[2]);

                sw.Close();
            }

            Timer_label.Text = Parent_cur_timespan.ToString();
        }
    }
}
