using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPomodoroClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int alarmCounter = 1;
        int saniye = 60;
        int dakika = 0;
        private int calismaSuresi = 0;
        private int dinlenmeSuresi = 0;
      
        private void baslatButton_Click(object sender, EventArgs e)
        {
            myTimer.Interval = calismaSuresi;
            
            dakika = calismaSuresi / 60000;
            
            labelTimer.Start();
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Start();
            baslatButton.Enabled = false;
            baslatButton.Text = "Başlatıldı...";
            molaComboBox.Enabled = false;
            calismaSuresiComboBox.Enabled = false;
        }

        private void TimerEventProcessor(Object myObject,
            EventArgs myEventArgs)
        {

            myTimer.Stop();
            //     SystemSounds.Exclamation.Play();
            SoundPlayer simpleSound = new SoundPlayer(@"Bike Horn.wav");
            simpleSound.Play();

            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Şimdi "+ molaComboBox.Items[molaComboBox.SelectedIndex].ToString() + " mola...";
            notifyIcon1.BalloonTipTitle = "Pomodoro Tekniği";
            
            notifyIcon1.ShowBalloonTip(20000);
            dakika = dinlenmeSuresi / 60000;
            saniye = 60;
            lblDk.Text = dakika.ToString();
            lblSn.Text = saniye.ToString();
            labelText.Text = "Molanın bitmesine kalan süre";
            labelTimer.Start();
            molaTimer.Interval = dinlenmeSuresi;
            molaTimer.Tick += new EventHandler(TimerEventProcessorMola);
            molaTimer.Enabled = true;
        }


        private void TimerEventProcessorMola(Object myObject,
            EventArgs myEventArgs)
        {
            molaTimer.Stop();
            SoundPlayer simpleSound = new SoundPlayer(@"Red Alert.wav");
            simpleSound.Play();
          //  SystemSounds.Hand.Play();
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Tekrar çalışmaya başla";
            notifyIcon1.BalloonTipTitle = "Pomodoro Tekniği";

            notifyIcon1.ShowBalloonTip(20000);
            dakika = calismaSuresi / 60000;
            saniye = 60;
            lblDk.Text = dakika.ToString();
            lblSn.Text = saniye.ToString();
            labelTimer.Start();
            labelText.Text = "Çalışmanın bitmesine kalan süre";
            myTimer.Interval = calismaSuresi;
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calismaSuresiComboBox.SelectedIndex = 0;
            molaComboBox.SelectedIndex = 0;
            string calismaSuresiTxt = calismaSuresiComboBox.Items[calismaSuresiComboBox.SelectedIndex].ToString();
            string[] calismaSuresiTxtArray = calismaSuresiTxt.Split('-');
            string dinlenmeSuresiTxt = molaComboBox.Items[molaComboBox.SelectedIndex].ToString();
            string[] dinlenmeSuresiTxtArray = dinlenmeSuresiTxt.Split('-');
            calismaSuresi = Int32.Parse(calismaSuresiTxtArray[0]) * 60000;
            dinlenmeSuresi = Int32.Parse(dinlenmeSuresiTxtArray[0]) * 60000;
            tekrarlaCheckBox.Checked = true;
            labelText.Text = "Çalışmanın bitmesine kalan süre:";
            lblSn.Text="00";
            lblDk.Text = "00";
        }

        private void labelTimer_Tick(object sender, EventArgs e)
        {
            labelTimer.Interval = 1000;
            saniye = saniye - 1;
            lblSn.Text = Convert.ToString(saniye);
            lblDk.Text = Convert.ToString(dakika - 1);
            if (saniye == 0)
            {

                dakika = dakika - 1;
                lblDk.Text = Convert.ToString(dakika);
                saniye = 60;
            }
            if (lblDk.Text == "-1")
            {
                labelTimer.Stop();
                labelText.Text = "Molanın bitmesine kalan süre";
            }
        }

        private void calismaSuresiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string calismaSuresiTxt = calismaSuresiComboBox.Items[calismaSuresiComboBox.SelectedIndex].ToString();
            string[] calismaSuresiTxtArray = calismaSuresiTxt.Split('-');
            calismaSuresi = Int32.Parse(calismaSuresiTxtArray[0]) * 60000;
        }

        private void molaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dinlenmeSuresiTxt = molaComboBox.Items[molaComboBox.SelectedIndex].ToString();
            string []dinlenmeSuresiTxtArray = dinlenmeSuresiTxt.Split('-');
            dinlenmeSuresi = Int32.Parse(dinlenmeSuresiTxtArray[0]) * 60000;
        }
    }
}