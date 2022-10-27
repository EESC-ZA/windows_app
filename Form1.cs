namespace windows_app
{
    public partial class USBGUARD : Form
    {

        private const int DEVICECHANGE = 0x0219;
        private const int DBTDEVARRIVAL = 0x8000;
        private const int DBTDEVREMOVED = 0x8004;
        private const int DBTDEVTYPEVOLUME = 0x000000002;

        int TimerCount = 10;
        Form2 LockScreen;

        USBC usbdev;
        
        public USBGUARD()
        {
            InitializeComponent();

            iniForm2();
            usbdev = new USBC();
        }
        public void iniForm2()
        {
            LockScreen = new Form2();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            switch (m.Msg)
            {
                case DEVICECHANGE:
                    switch ((int)m.WParam)
                    {
                        case DBTDEVARRIVAL:
                            RemoveUSB();
                            LockScreen.Show();
                           
                            break;
                        case DBTDEVREMOVED:
                            if (RemoveUSB())
                            {
                                LockScreen.Hide();
                            }


                            //richTextBox1.Text = "USB removed!";
                            break;
                    }

                    break;
            }

        }

        public bool RemoveUSB()
        {
            VolumeDeviceClass vdc = new VolumeDeviceClass();


            foreach (Volume device in vdc.Devices)
            {
                DeviceCapabilities dc = new DeviceCapabilities();
                dc = device.Capabilities;
                if (device.IsUsb)
                {
                    IntPtr usptr = usbdev.USBEject(device.LogicalDrive + "/");

                    if (!usbdev.Eject(usptr))
                    {
                        return false;
                    }
                }


            }
            return true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            notifyIcon1.Text = "Running";
           // notifyIcon1.Icon = SHIELD;
        }

        private void USB_GUARD_Shown(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void USB_GUARD_FormClosing(object sender, FormClosingEventArgs e)
        {

            MessageBox.Show("closes");
        }

        private void USB_GUARD_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("closes");
            Application.Restart();
        }
        private void StartTimer_Tick(object sender, EventArgs e)
        {
            StartLabel.Text = TimerCount.ToString();
            StartPB.Value = TimerCount;
            TimerCount--;
        
            if(TimerCount == -1)
            {

                StartPB.Enabled = false;
                StartTimer.Stop();
                
                this.Hide();
               
            }


            //StartPB.Step = TimerCount;
           
        }

        private void USBGUARD_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void USBGUARD_Load(object sender, EventArgs e)
        {
            LockScreen = new Form2();
            
        }

        private void StartLabel_Click(object sender, EventArgs e)
        {

        }

        private void AppTittle_Click(object sender, EventArgs e)
        {

        }
    }
}