using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;
using MainForm;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {

        private GameTimer gameTimer = new GameTimer(24,7,4);
        private ImageComposer composer = new ImageComposer();
        private Thread refreshingThread;
        private bool setEnd = false;

        public MainForm()
        {
            InitializeComponent();
        }


        private void RefreshScreen() 
        {
            while (!setEnd)
            {
                string labelText = string.Format("Hora decimal : {0} del dia {1} del mes {2} año {3}:: Mes del año real {4}",
                                            gameTimer.DecimalHour, gameTimer.Days, gameTimer.Months, gameTimer.Years, gameTimer.GetRealMonth()); ;
                bool millIsOn,thiefIsOn;
                millIsOn = thiefIsOn = false;
                foreach(ISchedulableObject schedulable in gameTimer.Schedulables) 
                {
                    if (schedulable.GetName() == "Mill") millIsOn = schedulable.IsOn;
                    if (schedulable.GetName() == "Thief") thiefIsOn = schedulable.IsOn;
                }

                this.Invoke(new Action(() => 
                                { 
                                    this.lblDateSplash.Text = labelText;
                                    this.lblGameLongDate.Text = gameTimer.GameLongDateString();
                                    this.lblTimeLapsed.Text = gameTimer.TotalSeconds + " seconds lapsed.";
                                    this.pictureBox1.Image = CalculateImage();
                                    this.pictureBox1.Invalidate();
                                    this.pictureBox1.Update();
                                    if (millIsOn) 
                                    {
                                        lblLumberMill.ForeColor = Color.Green;
                                    }
                                    else 
                                    {
                                        lblLumberMill.ForeColor = Color.Red;
                                    }
                                    if (thiefIsOn) 
                                    {
                                        lblThief.ForeColor = Color.Green;
                                    }
                                    else 
                                    {
                                        lblThief.ForeColor = Color.Red;
                                    }
                                }));
                Thread.Sleep(1000);
            }
        }


        private Image CalculateImage() 
        {
            double transparency;
            int hour = gameTimer.GameDateArray()[0];
            if (hour <= 21 && hour >= 6) 
            {
                transparency = 0;
                if(hour > 14) 
                {
                    transparency += (((double)hour -14)/10);
                }else if(hour < 14) 
                {
                    transparency += ((14 - (double)hour) / 10);
                }
            }
            else { transparency = 0.7; }
            if (transparency > 0.7) transparency = 0.7;
            return composer.GetFusionAt(transparency);
        }


        private void btnStartStop_Click(object sender, EventArgs e)
        {

            if (gameTimer.Running)
            {
                gameTimer.StopTimer();
                setEnd = true;
            }
            else 
            {
                setEnd = false;
                int dayLapse, monthLapse, yearLapse;
                int.TryParse(this.txtBoxDayLapse.Text, out dayLapse);
                int.TryParse(this.txtBoxMonthLapse.Text, out monthLapse);
                int.TryParse(this.txtBoxYearLapse.Text, out yearLapse);
                gameTimer = new GameTimer(dayLapse,monthLapse,yearLapse);
                
                // Scheduled objects control
                if (true) 
                {
                    PopulateScheduledObjects();

                }
                gameTimer.StartTimer();
                refreshingThread = new Thread(new ThreadStart(RefreshScreen));
                refreshingThread.Start();
            }
        }

        private void PopulateScheduledObjects()
        {
            gameTimer.AddSchedulable(new BussinesClass1("Mill", 8, 19));
            gameTimer.AddSchedulable(new BussinesClass2("Thiefs", 19, 8));
        }
    }
}
