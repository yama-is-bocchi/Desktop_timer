using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_desktop_timer.form
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            Init();

        }

        private void Init()
        {
            Timer_.Text = Common.curtime.ToString();
            hour.Value = Common.curtime.Hours;
            minute.Value = Common.curtime.Minutes;
            second.Value = Common.curtime.Seconds;
        }


        private void hour_Scroll(object sender, EventArgs e)
        {
            Common.curtime = new(hour.Value,minute.Value,second.Value);
            Timer_.Text = Common.curtime.ToString();
        }

       

        private void exit_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }
    }
}
