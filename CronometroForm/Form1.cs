using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CronometroForm
{
    public partial class Form1 : Form
    {

        private readonly Cronometro _cronometro;

        public Form1()
        {
            InitializeComponent();
            _cronometro = new Cronometro();
        }

        private void bt_OnOff_Click(object sender, EventArgs e)
        {
            if (_cronometro.ClockState())
            {
                _cronometro.StopClock();
                bt_OnOff.Text = "Ligar";
                timer1.Enabled = false;
                //lbl_Contador.Text = _cronometro.GetTimeSpan().ToString();
                
            }
            else
            {
                _cronometro.StartClock();
                bt_OnOff.Text = "Desligar";
                timer1.Enabled = true;
            }
        }

        private void UpdateLable()
        {
            var tempo = DateTime.Now - _cronometro.StartTime();
            lbl_Contador.Text = string.Format("{0:D2}:{1:D2}:{2:D2}:{3}", tempo.Hours, tempo.Minutes, tempo.Seconds, tempo.Milliseconds);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateLable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
