namespace musicPlayer
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player;
        OpenFileDialog ofd;
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
           
        }
        bool playing = false;
        private void songButton_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV";
            ofd.ShowDialog();
            player = new System.Media.SoundPlayer(@ofd.FileName);
            player.Play();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (!playing)
            {
                player.Stop();
                playing = true;
            }
            else
            {
                player.Play();
                playing = false;
            }
        }
        private void restartButton_Click(object sender, EventArgs e)
        {
            player.Stop();
            player = new System.Media.SoundPlayer(@ofd.FileName);
            player.Play();
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV";
            ofd.ShowDialog();
            player = new System.Media.SoundPlayer(@ofd.FileName);
            player.Play();
        }
    }
}