using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using SharpDX.XAudio2;
using SharpDX.Multimedia;

namespace Astronomical_Study_Guide
{
    public partial class frmRomanSplashScreen : Form
    {
        public frmRomanSplashScreen()
        {
            InitializeComponent();
        }

        private void frmRomanSplashScreen_Load(object sender, EventArgs e)
        {
            this.Show();

            XAudio2 xaudio;
            Assembly assembly;

            AudioBuffer logo_buffer;
            SoundStream logo_soundstream;
            SourceVoice logo_voice;
            WaveFormat logo_waveFormat;
            assembly = Assembly.GetExecutingAssembly();
            xaudio = new XAudio2();
            var masteringsound = new MasteringVoice(xaudio);

            logo_soundstream = new SoundStream(assembly.GetManifestResourceStream("Astronomical_Study_Guide.Audio.logosong.wav"));

            logo_waveFormat = logo_soundstream.Format;

            logo_buffer = new AudioBuffer
            {
                Stream = logo_soundstream.ToDataStream(),
                AudioBytes = (int)logo_soundstream.Length,
                Flags = BufferFlags.EndOfStream
            };

            logo_voice = new SourceVoice(xaudio, logo_waveFormat, true);
            logo_voice.SubmitSourceBuffer(logo_buffer, logo_soundstream.DecodedPacketsInfo);
            logo_voice.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var newForm = new frmSplashScreen();
            Visible = false;
            newForm.Show();
            timer1.Enabled = false;
        }
    }
}
