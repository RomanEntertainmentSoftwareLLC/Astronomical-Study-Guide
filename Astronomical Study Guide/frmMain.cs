using Astronomical_Study_Guide.Properties;
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
    public partial class frmMain : Form
    {
        private bool locklabels = false;
        private bool correct = false;
        private bool soundEnabled = true;
        private bool insideExitButton = false;
        private bool insideMinimizeButton = false;
        private bool insideSoundButton = false;
        private bool insideResultsButton = false;

        private bool insidech1 = false;
        private bool insidech2 = false;
        private bool insidech3 = false;
        private bool insidech6 = false;
        private bool insidech7 = false;
        private bool insidech8 = false;
        private bool insidech9 = false;
        private bool insidemidterm = false;

        private bool insideA = false;
        private bool insideB = false;
        private bool insideC = false;
        private bool insideD = false;

        private bool chapter1game = false;
        private bool chapter2game = false;
        private bool chapter3game = false;
        private bool chapter6game = false;
        private bool chapter7game = false;
        private bool chapter8game = false;
        private bool chapter9game = false;
        private bool midtermgame = false;

        private XAudio2 xaudio;
        private Assembly assembly;

        private AudioBuffer beep2_buffer;
        private SoundStream beep2_soundstream;
        private SourceVoice beep2_voice;
        private WaveFormat beep2_waveFormat;

        private AudioBuffer nanoblade_buffer;
        private SoundStream nanoblade_soundstream;
        private SourceVoice nanoblade_voice;
        private WaveFormat nanoblade_waveFormat;

        private AudioBuffer applause_buffer;
        private SoundStream applause_soundstream;
        private SourceVoice applause_voice;
        private WaveFormat applause_waveFormat;

        private AudioBuffer wrong_buffer;
        private SoundStream wrong_soundstream;
        private SourceVoice wrong_voice;
        private WaveFormat wrong_waveFormat;

        private Chapter1 chapter1;
        private Chapter2 chapter2;
        private Chapter3 chapter3;
        private Chapter6 chapter6;
        private Chapter7 chapter7;
        private Chapter8 chapter8;
        private Chapter9 chapter9;
        private Midterm midterm;

        private void Chapter1_Game(Label answerLetter)
        {
            if (chapter1.questionNumber <= chapter1.questionsInGame)
            {
                if (chapter1game == true)
                {
                    if (answerLetter.Text == chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 0])
                    {
                        if (soundEnabled == true)
                        {
                            applause_voice = new SourceVoice(xaudio, applause_waveFormat, true);
                            applause_voice.SubmitSourceBuffer(applause_buffer, applause_soundstream.DecodedPacketsInfo);
                            applause_voice.Start();
                        }

                        correct = true;
                        lblCorrectMessage.Visible = true;
                        chapter1.score++;
                        answerLetter.ForeColor = Color.FromArgb(0, 164, 164);
                        locklabels = true;
                        timer1.Enabled = true;
                    }
                    else
                    {
                        if (soundEnabled == true)
                        {
                            wrong_voice = new SourceVoice(xaudio, wrong_waveFormat, true);
                            wrong_voice.SubmitSourceBuffer(wrong_buffer, wrong_soundstream.DecodedPacketsInfo);
                            wrong_voice.Start();
                        }

                        correct = false;
                        lblWrong.Visible = true;
                        chapter1.antiScore++;
                        answerLetter.ForeColor = Color.FromArgb(255, 0, 0);
                        locklabels = true;
                        if (lblA.Text == chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 0])
                            lblA.ForeColor = Color.FromArgb(0, 164, 164);
                        else if (lblB.Text == chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 0])
                            lblB.ForeColor = Color.FromArgb(0, 164, 164);
                        else if (lblC.Text == chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 0])
                            lblC.ForeColor = Color.FromArgb(0, 164, 164);
                        else if (lblD.Text == chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 0])
                            lblD.ForeColor = Color.FromArgb(0, 164, 164);
                        timer1.Enabled = true;

                    }
                }
            }
        }

        private void Chapter2_Game(Label answerLetter)
        {
            if (chapter2.questionNumber <= chapter2.questionsInGame)
            {
                if (chapter2game == true)
                {
                    if (answerLetter.Text == chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 0])
                    {
                        if (soundEnabled == true)
                        {
                            applause_voice = new SourceVoice(xaudio, applause_waveFormat, true);
                            applause_voice.SubmitSourceBuffer(applause_buffer, applause_soundstream.DecodedPacketsInfo);
                            applause_voice.Start();
                        }

                        correct = true;
                        lblCorrectMessage.Visible = true;
                        chapter2.score++;
                        answerLetter.ForeColor = Color.FromArgb(0, 164, 164);
                        locklabels = true;
                        timer1.Enabled = true;
                    }
                    else
                    {
                        if (soundEnabled == true)
                        {
                            wrong_voice = new SourceVoice(xaudio, wrong_waveFormat, true);
                            wrong_voice.SubmitSourceBuffer(wrong_buffer, wrong_soundstream.DecodedPacketsInfo);
                            wrong_voice.Start();
                        }

                        correct = false;
                        lblWrong.Visible = true;
                        chapter2.antiScore++;
                        answerLetter.ForeColor = Color.FromArgb(255, 0, 0);
                        locklabels = true;
                        if (lblA.Text == chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 0])
                            lblA.ForeColor = Color.FromArgb(0, 164, 164);
                        else if (lblB.Text == chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 0])
                            lblB.ForeColor = Color.FromArgb(0, 164, 164);
                        else if (lblC.Text == chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 0])
                            lblC.ForeColor = Color.FromArgb(0, 164, 164);
                        else if (lblD.Text == chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 0])
                            lblD.ForeColor = Color.FromArgb(0, 164, 164);
                        timer1.Enabled = true;

                    }
                }
            }
        }

        private void Chapter3_Game(Label answerLetter)
        {
            if (chapter3.questionNumber <= chapter3.questionsInGame)
            {
                if (chapter3game == true)
                {
                    if (answerLetter.Text == chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 0])
                    {
                        if (soundEnabled == true)
                        {
                            applause_voice = new SourceVoice(xaudio, applause_waveFormat, true);
                            applause_voice.SubmitSourceBuffer(applause_buffer, applause_soundstream.DecodedPacketsInfo);
                            applause_voice.Start();
                        }

                        correct = true;
                        lblCorrectMessage.Visible = true;
                        chapter3.score++;
                        answerLetter.ForeColor = Color.FromArgb(0, 164, 164);
                        locklabels = true;
                        timer1.Enabled = true;
                    }
                    else
                    {
                        if (soundEnabled == true)
                        {
                            wrong_voice = new SourceVoice(xaudio, wrong_waveFormat, true);
                            wrong_voice.SubmitSourceBuffer(wrong_buffer, wrong_soundstream.DecodedPacketsInfo);
                            wrong_voice.Start();
                        }

                        correct = false;
                        lblWrong.Visible = true;
                        chapter3.antiScore++;
                        answerLetter.ForeColor = Color.FromArgb(255, 0, 0);
                        locklabels = true;
                        if (lblA.Text == chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 0])
                            lblA.ForeColor = Color.FromArgb(0, 164, 164);
                        else if (lblB.Text == chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 0])
                            lblB.ForeColor = Color.FromArgb(0, 164, 164);
                        else if (lblC.Text == chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 0])
                            lblC.ForeColor = Color.FromArgb(0, 164, 164);
                        else if (lblD.Text == chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 0])
                            lblD.ForeColor = Color.FromArgb(0, 164, 164);
                        timer1.Enabled = true;

                    }
                }
            }
        }

        private void Chapter6_Game(Label answerLetter)
        {
            if (chapter6.questionNumber <= chapter6.questionsInGame)
            {
                if (chapter6game == true)
                {
                    if (answerLetter.Text == chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 0])
                    {
                        if (soundEnabled == true)
                        {
                            applause_voice = new SourceVoice(xaudio, applause_waveFormat, true);
                            applause_voice.SubmitSourceBuffer(applause_buffer, applause_soundstream.DecodedPacketsInfo);
                            applause_voice.Start();
                        }

                        correct = true;
                        lblCorrectMessage.Visible = true;
                        chapter6.score++;
                        answerLetter.ForeColor = Color.FromArgb(0, 164, 164);
                        locklabels = true;
                        timer1.Enabled = true;
                    }
                    else
                    {
                        if (soundEnabled == true)
                        {
                            wrong_voice = new SourceVoice(xaudio, wrong_waveFormat, true);
                            wrong_voice.SubmitSourceBuffer(wrong_buffer, wrong_soundstream.DecodedPacketsInfo);
                            wrong_voice.Start();
                        }

                        correct = false;
                        lblWrong.Visible = true;
                        chapter6.antiScore++;
                        answerLetter.ForeColor = Color.FromArgb(255, 0, 0);
                        locklabels = true;
                        if (lblA.Text == chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 0])
                            lblA.ForeColor = Color.FromArgb(0, 164, 164);
                        else if (lblB.Text == chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 0])
                            lblB.ForeColor = Color.FromArgb(0, 164, 164);
                        else if (lblC.Text == chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 0])
                            lblC.ForeColor = Color.FromArgb(0, 164, 164);
                        else if (lblD.Text == chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 0])
                            lblD.ForeColor = Color.FromArgb(0, 164, 164);
                        timer1.Enabled = true;

                    }
                }
            }
        }

        private void Chapter7_Game(Label answerLetter)
        {
            if (chapter7.questionNumber <= chapter7.questionsInGame)
            {
                if (chapter7game == true)
                {
                    if (answerLetter.Text == chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 0])
                    {
                        if (soundEnabled == true)
                        {
                            applause_voice = new SourceVoice(xaudio, applause_waveFormat, true);
                            applause_voice.SubmitSourceBuffer(applause_buffer, applause_soundstream.DecodedPacketsInfo);
                            applause_voice.Start();
                        }

                        correct = true;
                        lblCorrectMessage.Visible = true;
                        chapter7.score++;
                        answerLetter.ForeColor = Color.FromArgb(0, 164, 164);
                        locklabels = true;
                        timer1.Enabled = true;
                    }
                    else
                    {
                        if (soundEnabled == true)
                        {
                            wrong_voice = new SourceVoice(xaudio, wrong_waveFormat, true);
                            wrong_voice.SubmitSourceBuffer(wrong_buffer, wrong_soundstream.DecodedPacketsInfo);
                            wrong_voice.Start();
                        }

                        correct = false;
                        lblWrong.Visible = true;
                        chapter7.antiScore++;
                        answerLetter.ForeColor = Color.FromArgb(255, 0, 0);
                        locklabels = true;
                        if (lblA.Text == chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 0])
                            lblA.ForeColor = Color.FromArgb(0, 164, 164);
                        else if (lblB.Text == chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 0])
                            lblB.ForeColor = Color.FromArgb(0, 164, 164);
                        else if (lblC.Text == chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 0])
                            lblC.ForeColor = Color.FromArgb(0, 164, 164);
                        else if (lblD.Text == chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 0])
                            lblD.ForeColor = Color.FromArgb(0, 164, 164);
                        timer1.Enabled = true;

                    }
                }
            }
        }

        private void Chapter8_Game(Label answerLetter)
        {
            if (chapter8.questionNumber <= chapter8.questionsInGame)
            {
                if (chapter8game == true)
                {
                    if (answerLetter.Text == chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 0])
                    {
                        if (soundEnabled == true)
                        {
                            applause_voice = new SourceVoice(xaudio, applause_waveFormat, true);
                            applause_voice.SubmitSourceBuffer(applause_buffer, applause_soundstream.DecodedPacketsInfo);
                            applause_voice.Start();
                        }

                        correct = true;
                        lblCorrectMessage.Visible = true;
                        chapter8.score++;
                        answerLetter.ForeColor = Color.FromArgb(0, 164, 164);
                        locklabels = true;
                        timer1.Enabled = true;
                    }
                    else
                    {
                        if (soundEnabled == true)
                        {
                            wrong_voice = new SourceVoice(xaudio, wrong_waveFormat, true);
                            wrong_voice.SubmitSourceBuffer(wrong_buffer, wrong_soundstream.DecodedPacketsInfo);
                            wrong_voice.Start();
                        }

                        correct = false;
                        lblWrong.Visible = true;
                        chapter8.antiScore++;
                        answerLetter.ForeColor = Color.FromArgb(255, 0, 0);
                        locklabels = true;
                        if (lblA.Text == chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 0])
                            lblA.ForeColor = Color.FromArgb(0, 164, 164);
                        else if (lblB.Text == chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 0])
                            lblB.ForeColor = Color.FromArgb(0, 164, 164);
                        else if (lblC.Text == chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 0])
                            lblC.ForeColor = Color.FromArgb(0, 164, 164);
                        else if (lblD.Text == chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 0])
                            lblD.ForeColor = Color.FromArgb(0, 164, 164);
                        timer1.Enabled = true;

                    }
                }
            }
        }

        private void Chapter9_Game(Label answerLetter)
        {
            if (chapter9.questionNumber <= chapter9.questionsInGame)
            {
                if (chapter9game == true)
                {
                    if (answerLetter.Text == chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 0])
                    {
                        if (soundEnabled == true)
                        {
                            applause_voice = new SourceVoice(xaudio, applause_waveFormat, true);
                            applause_voice.SubmitSourceBuffer(applause_buffer, applause_soundstream.DecodedPacketsInfo);
                            applause_voice.Start();
                        }

                        correct = true;
                        lblCorrectMessage.Visible = true;
                        chapter9.score++;
                        answerLetter.ForeColor = Color.FromArgb(0, 164, 164);
                        locklabels = true;
                        timer1.Enabled = true;
                    }
                    else
                    {
                        if (soundEnabled == true)
                        {
                            wrong_voice = new SourceVoice(xaudio, wrong_waveFormat, true);
                            wrong_voice.SubmitSourceBuffer(wrong_buffer, wrong_soundstream.DecodedPacketsInfo);
                            wrong_voice.Start();
                        }

                        correct = false;
                        lblWrong.Visible = true;
                        chapter9.antiScore++;
                        answerLetter.ForeColor = Color.FromArgb(255, 0, 0);
                        locklabels = true;
                        if (lblA.Text == chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 0])
                            lblA.ForeColor = Color.FromArgb(0, 164, 164);
                        else if (lblB.Text == chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 0])
                            lblB.ForeColor = Color.FromArgb(0, 164, 164);
                        else if (lblC.Text == chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 0])
                            lblC.ForeColor = Color.FromArgb(0, 164, 164);
                        else if (lblD.Text == chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 0])
                            lblD.ForeColor = Color.FromArgb(0, 164, 164);
                        timer1.Enabled = true;

                    }
                }
            }
        }

        private void Midterm_Game(Label answerLetter)
        {
            if (midterm.questionNumber <= midterm.questionsInGame)
            {
                if (midtermgame == true)
                {
                    if (answerLetter.Text == midterm.answer[midterm.randomOrder[midterm.questionNumber], 0])
                    {
                        if (soundEnabled == true)
                        {
                            applause_voice = new SourceVoice(xaudio, applause_waveFormat, true);
                            applause_voice.SubmitSourceBuffer(applause_buffer, applause_soundstream.DecodedPacketsInfo);
                            applause_voice.Start();
                        }

                        correct = true;
                        lblCorrectMessage.Visible = true;
                        midterm.score++;
                        answerLetter.ForeColor = Color.FromArgb(0, 164, 164);
                        locklabels = true;
                        timer1.Enabled = true;
                    }
                    else
                    {
                        if (soundEnabled == true)
                        {
                            wrong_voice = new SourceVoice(xaudio, wrong_waveFormat, true);
                            wrong_voice.SubmitSourceBuffer(wrong_buffer, wrong_soundstream.DecodedPacketsInfo);
                            wrong_voice.Start();
                        }

                        correct = false;
                        lblWrong.Visible = true;
                        midterm.antiScore++;
                        answerLetter.ForeColor = Color.FromArgb(255, 0, 0);
                        locklabels = true;
                        if (lblA.Text == midterm.answer[midterm.randomOrder[midterm.questionNumber], 0])
                            lblA.ForeColor = Color.FromArgb(0, 164, 164);
                        else if (lblB.Text == midterm.answer[midterm.randomOrder[midterm.questionNumber], 0])
                            lblB.ForeColor = Color.FromArgb(0, 164, 164);
                        else if (lblC.Text == midterm.answer[midterm.randomOrder[midterm.questionNumber], 0])
                            lblC.ForeColor = Color.FromArgb(0, 164, 164);
                        else if (lblD.Text == midterm.answer[midterm.randomOrder[midterm.questionNumber], 0])
                            lblD.ForeColor = Color.FromArgb(0, 164, 164);
                        timer1.Enabled = true;

                    }
                }
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void picExit_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Image imgExitButton3 = Resources.Exit_Button_3;
                picExit.BackgroundImage = imgExitButton3;
            }
        }

        private void picExit_MouseMove(object sender, MouseEventArgs e)
        {
            if (insideExitButton == false)
            {
                insideExitButton = true;
                Image imgExitButton2 = Resources.Exit_Button_2;
                picExit.BackgroundImage = imgExitButton2;

                if (soundEnabled == true)
                {
                    beep2_voice = new SourceVoice(xaudio, beep2_waveFormat, true);
                    beep2_voice.SubmitSourceBuffer(beep2_buffer, beep2_soundstream.DecodedPacketsInfo);
                    beep2_voice.Start();
                }
            }
        }

        private void picExit_MouseLeave(object sender, EventArgs e)
        {
            insideExitButton = false;
            Image imgExitButton = Resources.Exit_Button;
            picExit.BackgroundImage = imgExitButton;
        }

        private void picExit_MouseUp(object sender, MouseEventArgs e)
        {
            if (insideExitButton == true)
            {
                Image imgExitButton2 = Resources.Exit_Button_2;
                picExit.BackgroundImage = imgExitButton2;
                if (e.Button == MouseButtons.Left)
                {
                    if (soundEnabled == true)
                    {
                        nanoblade_voice = new SourceVoice(xaudio, nanoblade_waveFormat, true);
                        nanoblade_voice.SubmitSourceBuffer(nanoblade_buffer, nanoblade_soundstream.DecodedPacketsInfo);
                        nanoblade_voice.Start();
                    }

                    //WriteToBinaryFile("score.dat");

                    Application.Exit();
                }
            }
            else
            {
                Image imgExitButton = Resources.Exit_Button;
                picExit.BackgroundImage = imgExitButton;
            }
        }

        private void picMinimize_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Image imgMinimizeButton3 = Resources.Minimize_Button_3;
                picMinimize.BackgroundImage = imgMinimizeButton3;
            }
        }

        private void picMinimize_MouseMove(object sender, MouseEventArgs e)
        {
            if (insideMinimizeButton == false)
            {
                insideMinimizeButton = true;
                Image imgMinimizeButton2 = Resources.Minimize_Button_2;
                picMinimize.BackgroundImage = imgMinimizeButton2;

                if (soundEnabled == true)
                {
                    beep2_voice = new SourceVoice(xaudio, beep2_waveFormat, true);
                    beep2_voice.SubmitSourceBuffer(beep2_buffer, beep2_soundstream.DecodedPacketsInfo);
                    beep2_voice.Start();
                }
            }
        }

        private void picMinimize_MouseLeave(object sender, EventArgs e)
        {
            insideMinimizeButton = false;
            Image imgMinimizeButton = Resources.Minimize_Button;
            picMinimize.BackgroundImage = imgMinimizeButton;
        }

        private void picMinimize_MouseUp(object sender, MouseEventArgs e)
        {
            if (insideMinimizeButton == true)
            {
                Image imgMinimizeButton2 = Resources.Minimize_Button_2;
                picMinimize.BackgroundImage = imgMinimizeButton2;
                if (e.Button == MouseButtons.Left)
                {
                    if (soundEnabled == true)
                    {
                        nanoblade_voice = new SourceVoice(xaudio, nanoblade_waveFormat, true);
                        nanoblade_voice.SubmitSourceBuffer(nanoblade_buffer, nanoblade_soundstream.DecodedPacketsInfo);
                        nanoblade_voice.Start();
                    }

                    WindowState = FormWindowState.Minimized;
                }
            }
            else
            {
                Image imgMinimizeButton = Resources.Minimize_Button;
                picMinimize.BackgroundImage = imgMinimizeButton;
            }
        }

        private void picSound_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (soundEnabled == true)
                {
                    Image imgSoundButton3 = Resources.Sound_Button_3;
                    picSound.BackgroundImage = imgSoundButton3;
                }
                else
                {
                    Image imgSoundButton3 = Resources.Sound_Button_3;
                    picSound.BackgroundImage = imgSoundButton3;
                }
            }
        }

        private void picSound_MouseMove(object sender, MouseEventArgs e)
        {
            if (insideSoundButton == false)
            {
                insideSoundButton = true;

                if (soundEnabled == true)
                {
                    Image imgSoundButton2 = Resources.Sound_Button_2;
                    picSound.BackgroundImage = imgSoundButton2;
                    beep2_voice = new SourceVoice(xaudio, beep2_waveFormat, true);
                    beep2_voice.SubmitSourceBuffer(beep2_buffer, beep2_soundstream.DecodedPacketsInfo);
                    beep2_voice.Start();

                }
                else
                {
                    Image imgSoundButton2 = Resources.Sound_Disabled_Button_2;
                    picSound.BackgroundImage = imgSoundButton2;
                }
            }
        }

        private void picSound_MouseLeave(object sender, EventArgs e)
        {
            if (insideSoundButton == true)
            {
                insideSoundButton = false;

                if (soundEnabled == true)
                {
                    Image imgSoundButton = Resources.Sound_Button;
                    picSound.BackgroundImage = imgSoundButton;
                }
                else
                {
                    Image imgSoundButton = Resources.Sound_Disabled_Button;
                    picSound.BackgroundImage = imgSoundButton;
                }
            }
        }

        private void picSound_MouseUp(object sender, MouseEventArgs e)
        {
            if (insideSoundButton == true)
            {
                if (soundEnabled == true)
                {
                    Image imgSoundButton2 = Resources.Sound_Button_2;
                    picSound.BackgroundImage = imgSoundButton2;
                }
                else
                {
                    Image imgSoundButton2 = Resources.Sound_Disabled_Button_2;
                    picSound.BackgroundImage = imgSoundButton2;
                }

                if (e.Button == MouseButtons.Left)
                {
                    if (soundEnabled == true)
                    {
                        Image imgSoundButton2 = Resources.Sound_Disabled_Button_2;
                        picSound.BackgroundImage = imgSoundButton2;

                        soundEnabled = false;
                    }
                    else
                    {
                        nanoblade_voice = new SourceVoice(xaudio, nanoblade_waveFormat, true);
                        nanoblade_voice.SubmitSourceBuffer(nanoblade_buffer, nanoblade_soundstream.DecodedPacketsInfo);
                        nanoblade_voice.Start();

                        Image imgSoundButton2 = Resources.Sound_Button_2;
                        picSound.BackgroundImage = imgSoundButton2;

                        soundEnabled = true;
                    }
                }
            }
            else
            {
                if (soundEnabled == true)
                {
                    Image imgSoundButton = Resources.Sound_Button;
                    picSound.BackgroundImage = imgSoundButton;
                }
                else
                {
                    Image imgSoundButton = Resources.Sound_Disabled_Button;
                    picSound.BackgroundImage = imgSoundButton;
                }
            }
        }

        private void picResults_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Image imgResultsButton3 = Resources.Results_Button_3;
                picResults.BackgroundImage = imgResultsButton3;
            }
        }

        private void picResults_MouseMove(object sender, MouseEventArgs e)
        {
            if (insideResultsButton == false)
            {
                insideResultsButton = true;
                Image imgResultsButton2 = Resources.Results_Button_2;
                picResults.BackgroundImage = imgResultsButton2;

                if (soundEnabled == true)
                {
                    beep2_voice = new SourceVoice(xaudio, beep2_waveFormat, true);
                    beep2_voice.SubmitSourceBuffer(beep2_buffer, beep2_soundstream.DecodedPacketsInfo);
                    beep2_voice.Start();
                }
            }
        }

        private void picResults_MouseLeave(object sender, EventArgs e)
        {
            insideResultsButton = false;
            Image imgResultsButton = Resources.Results_Button;
            picResults.BackgroundImage = imgResultsButton;
        }

        private void picResults_MouseUp(object sender, MouseEventArgs e)
        {
            if (insideResultsButton == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    //DO ACTION HERE

                    Image imgResultsButton2 = Resources.Results_Button_2;
                    picResults.BackgroundImage = imgResultsButton2;

                    if (soundEnabled == true)
                    {
                        nanoblade_voice = new SourceVoice(xaudio, nanoblade_waveFormat, true);
                        nanoblade_voice.SubmitSourceBuffer(nanoblade_buffer, nanoblade_soundstream.DecodedPacketsInfo);
                        nanoblade_voice.Start();
                    }
                }
            }
            else
            {
                Image imgResultsButton = Resources.Results_Button;
                picResults.BackgroundImage = imgResultsButton;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            chapter1 = new Chapter1();
            chapter2 = new Chapter2();
            chapter3 = new Chapter3();
            chapter6 = new Chapter6();
            chapter7 = new Chapter7();
            chapter8 = new Chapter8();
            chapter9 = new Chapter9();
            midterm = new Midterm();

            assembly = Assembly.GetExecutingAssembly();
            xaudio = new XAudio2();
            var masteringsound = new MasteringVoice(xaudio);

            beep2_soundstream = new SoundStream(assembly.GetManifestResourceStream("Astronomical_Study_Guide.Audio.beep2.wav"));
            nanoblade_soundstream = new SoundStream(assembly.GetManifestResourceStream("Astronomical_Study_Guide.Audio.nanoblade.wav"));
            applause_soundstream = new SoundStream(assembly.GetManifestResourceStream("Astronomical_Study_Guide.Audio.applause.wav"));
            wrong_soundstream = new SoundStream(assembly.GetManifestResourceStream("Astronomical_Study_Guide.Audio.wrong.wav"));

            beep2_waveFormat = beep2_soundstream.Format;
            nanoblade_waveFormat = nanoblade_soundstream.Format;
            applause_waveFormat = applause_soundstream.Format;
            wrong_waveFormat = wrong_soundstream.Format;

            beep2_buffer = new AudioBuffer
            {
                Stream = beep2_soundstream.ToDataStream(),
                AudioBytes = (int)beep2_soundstream.Length,
                Flags = BufferFlags.EndOfStream
            };

            nanoblade_buffer = new AudioBuffer
            {
                Stream = nanoblade_soundstream.ToDataStream(),
                AudioBytes = (int)nanoblade_soundstream.Length,
                Flags = BufferFlags.EndOfStream
            };

            applause_buffer = new AudioBuffer
            {
                Stream = applause_soundstream.ToDataStream(),
                AudioBytes = (int)applause_soundstream.Length,
                Flags = BufferFlags.EndOfStream
            };

            wrong_buffer = new AudioBuffer
            {
                Stream = wrong_soundstream.ToDataStream(),
                AudioBytes = (int)wrong_soundstream.Length,
                Flags = BufferFlags.EndOfStream
            };
        }

        private void lblch1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblch1.ForeColor = Color.FromArgb(0, 69, 87);
            }
        }

        private void lblch1_MouseMove(object sender, MouseEventArgs e)
        {
            lblch1.Font = new Font("Microsoft Sans Serif", 28, FontStyle.Regular);

            if (e.Button != MouseButtons.Left)
            {
                lblch1.ForeColor = Color.FromArgb(0, 164, 164);
            }

            if (insidech1 == false)
            {
                insidech1 = true;

                if (soundEnabled == true)
                {
                    beep2_voice = new SourceVoice(xaudio, beep2_waveFormat, true);
                    beep2_voice.SubmitSourceBuffer(beep2_buffer, beep2_soundstream.DecodedPacketsInfo);
                    beep2_voice.Start();
                }
            }
        }

        private void lblch1_MouseLeave(object sender, EventArgs e)
        {
            lblch1.ForeColor = Color.FromArgb(255, 255, 255);
            lblch1.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular);
            insidech1 = false;

        }

        private void lblch1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblch1.ForeColor = Color.FromArgb(0, 164, 164);
                panelchapters.Visible = false;
                pnlgame.Visible = true;

                if (soundEnabled == true)
                {
                    nanoblade_voice = new SourceVoice(xaudio, nanoblade_waveFormat, true);
                    nanoblade_voice.SubmitSourceBuffer(nanoblade_buffer, nanoblade_soundstream.DecodedPacketsInfo);
                    nanoblade_voice.Start();
                }

                chapter1game = true;
                chapter1.questionsInGame = 65;

                if (chapter1.questionsInGame > 0)
                {
                    chapter1.Randomize_Questions();
                    chapter1.minutes = chapter1.questionsInGame / 2;
                    chapter1.seconds = 0;
                    chapter1.score = 0;
                    chapter1.antiScore = 0;
                    chapter1.questionNumber = 0;
                    chapter1.text = string.Empty;
                    chapter1.yourAnswer = string.Empty;
                    lbltime.Text = "Time: " + chapter1.minutes.ToString().PadLeft(2, '0') + ":" + chapter1.seconds.ToString().PadLeft(2, '0');
                    timer2.Enabled = true;
                    lblquestion.Text = "#" + Convert.ToString(chapter1.questionNumber + 1) + " of " + Convert.ToString(chapter1.questionsInGame) + ": " + chapter1.Get_Question(chapter1.randomOrder[chapter1.questionNumber]);
                    Random random = new Random();
                    int result;

                    if (chapter1.questiontype[chapter1.randomOrder[chapter1.questionNumber]] == Chapter1.QuestionType.MultipleChoice)
                    {
                        result = random.Next(0, 4);

                        if (result == 0)
                        {
                            lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                    lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                    lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                    lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                    lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                    lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                    lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 1)
                        {
                            lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                    lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                    lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                    lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                    lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                    lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                    lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 2)
                        {
                            lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                    lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                    lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                    lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                    lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                    lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                    lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 3)
                        {
                            lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                    lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                    lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                    lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                    lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                    lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                    lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                }
                            }
                        }
                    }
                    else if (chapter1.questiontype[chapter1.randomOrder[chapter1.questionNumber]] == Chapter1.QuestionType.TrueOrFalse)
                    {
                        result = random.Next(0, 2);

                        if (result == 0)
                        {
                            lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 0];
                            lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                        else if (result == 1)
                        {
                            lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];
                            lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 0];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                    }
                }
            }
        }

        private void lblch2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblch2.ForeColor = Color.FromArgb(0, 69, 87);
            }
        }

        private void lblch2_MouseMove(object sender, MouseEventArgs e)
        {
            lblch2.Font = new Font("Microsoft Sans Serif", 28, FontStyle.Regular);

            if (e.Button != MouseButtons.Left)
            {
                lblch2.ForeColor = Color.FromArgb(0, 164, 164);
            }

            if (insidech2 == false)
            {
                insidech2 = true;

                if (soundEnabled == true)
                {
                    beep2_voice = new SourceVoice(xaudio, beep2_waveFormat, true);
                    beep2_voice.SubmitSourceBuffer(beep2_buffer, beep2_soundstream.DecodedPacketsInfo);
                    beep2_voice.Start();
                }
            }
        }

        private void lblch2_MouseLeave(object sender, EventArgs e)
        {
            lblch2.ForeColor = Color.FromArgb(255, 255, 255);
            lblch2.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular);
            insidech2 = false;
        }

        private void lblch2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblch2.ForeColor = Color.FromArgb(0, 164, 164);
                panelchapters.Visible = false;
                pnlgame.Visible = true;

                if (soundEnabled == true)
                {
                    nanoblade_voice = new SourceVoice(xaudio, nanoblade_waveFormat, true);
                    nanoblade_voice.SubmitSourceBuffer(nanoblade_buffer, nanoblade_soundstream.DecodedPacketsInfo);
                    nanoblade_voice.Start();
                }

                chapter2game = true;
                chapter2.questionsInGame = 53;

                if (chapter2.questionsInGame > 0)
                {
                    chapter2.Randomize_Questions();
                    chapter2.minutes = chapter2.questionsInGame / 2;
                    chapter2.seconds = 0;
                    chapter2.score = 0;
                    chapter2.antiScore = 0;
                    chapter2.questionNumber = 0;
                    chapter2.text = string.Empty;
                    chapter2.yourAnswer = string.Empty;
                    lbltime.Text = "Time: " + chapter2.minutes.ToString().PadLeft(2, '0') + ":" + chapter2.seconds.ToString().PadLeft(2, '0');
                    timer2.Enabled = true;
                    lblquestion.Text = "#" + Convert.ToString(chapter2.questionNumber + 1) + " of " + Convert.ToString(chapter2.questionsInGame) + ": " + chapter2.Get_Question(chapter2.randomOrder[chapter2.questionNumber]);
                    Random random = new Random();
                    int result;

                    if (chapter2.questiontype[chapter2.randomOrder[chapter2.questionNumber]] == Chapter2.QuestionType.MultipleChoice)
                    {
                        result = random.Next(0, 4);

                        if (result == 0)
                        {
                            lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                    lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                    lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                    lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                    lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                    lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                    lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 1)
                        {
                            lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                    lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                    lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                    lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                    lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                    lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                    lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 2)
                        {
                            lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                    lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                    lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                    lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                    lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                    lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                    lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 3)
                        {
                            lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                    lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                    lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                    lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                    lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                    lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                    lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                }
                            }
                        }
                    }
                    else if (chapter2.questiontype[chapter2.randomOrder[chapter2.questionNumber]] == Chapter2.QuestionType.TrueOrFalse)
                    {
                        result = random.Next(0, 2);

                        if (result == 0)
                        {
                            lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 0];
                            lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                        else if (result == 1)
                        {
                            lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];
                            lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 0];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                    }
                }

            }
        }

        private void lblch3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblch3.ForeColor = Color.FromArgb(0, 69, 87);
            }
        }

        private void lblch3_MouseMove(object sender, MouseEventArgs e)
        {
            lblch3.Font = new Font("Microsoft Sans Serif", 28, FontStyle.Regular);

            if (e.Button != MouseButtons.Left)
            {
                lblch3.ForeColor = Color.FromArgb(0, 164, 164);
            }

            if (insidech3 == false)
            {
                insidech3 = true;

                if (soundEnabled == true)
                {
                    beep2_voice = new SourceVoice(xaudio, beep2_waveFormat, true);
                    beep2_voice.SubmitSourceBuffer(beep2_buffer, beep2_soundstream.DecodedPacketsInfo);
                    beep2_voice.Start();
                }
            }
        }

        private void lblch3_MouseLeave(object sender, EventArgs e)
        {
            lblch3.ForeColor = Color.FromArgb(255, 255, 255);
            lblch3.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular);
            insidech3 = false;
        }

        private void lblch3_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblch3.ForeColor = Color.FromArgb(0, 164, 164);
                panelchapters.Visible = false;
                pnlgame.Visible = true;

                if (soundEnabled == true)
                {
                    nanoblade_voice = new SourceVoice(xaudio, nanoblade_waveFormat, true);
                    nanoblade_voice.SubmitSourceBuffer(nanoblade_buffer, nanoblade_soundstream.DecodedPacketsInfo);
                    nanoblade_voice.Start();
                }

                chapter3game = true;
                chapter3.questionsInGame = 49;

                if (chapter3.questionsInGame > 0)
                {
                    chapter3.Randomize_Questions();
                    chapter3.minutes = chapter3.questionsInGame / 2;
                    chapter3.seconds = 0;
                    chapter3.score = 0;
                    chapter3.antiScore = 0;
                    chapter3.questionNumber = 0;
                    chapter3.text = string.Empty;
                    chapter3.yourAnswer = string.Empty;
                    lbltime.Text = "Time: " + chapter3.minutes.ToString().PadLeft(2, '0') + ":" + chapter3.seconds.ToString().PadLeft(2, '0');
                    timer2.Enabled = true;
                    lblquestion.Text = "#" + Convert.ToString(chapter3.questionNumber + 1) + " of " + Convert.ToString(chapter3.questionsInGame) + ": " + chapter3.Get_Question(chapter3.randomOrder[chapter3.questionNumber]);
                    Random random = new Random();
                    int result;

                    if (chapter3.questiontype[chapter3.randomOrder[chapter3.questionNumber]] == Chapter3.QuestionType.MultipleChoice)
                    {
                        result = random.Next(0, 4);

                        if (result == 0)
                        {
                            lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                    lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                    lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                    lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                    lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                    lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                    lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 1)
                        {
                            lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                    lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                    lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                    lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                    lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                    lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                    lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 2)
                        {
                            lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                    lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                    lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                    lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                    lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                    lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                    lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 3)
                        {
                            lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                    lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                    lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                    lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                    lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                    lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                    lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                }
                            }
                        }
                    }
                    else if (chapter3.questiontype[chapter3.randomOrder[chapter3.questionNumber]] == Chapter3.QuestionType.TrueOrFalse)
                    {
                        result = random.Next(0, 2);

                        if (result == 0)
                        {
                            lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 0];
                            lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                        else if (result == 1)
                        {
                            lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];
                            lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 0];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                    }
                }
            }
        }

        private void lblch6_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblch6.ForeColor = Color.FromArgb(0, 69, 87);
            }
        }

        private void lblch6_MouseMove(object sender, MouseEventArgs e)
        {
            lblch6.Font = new Font("Microsoft Sans Serif", 28, FontStyle.Regular);

            if (e.Button != MouseButtons.Left)
            {
                lblch6.ForeColor = Color.FromArgb(0, 164, 164);
            }

            if (insidech6 == false)
            {
                insidech6 = true;

                if (soundEnabled == true)
                {
                    beep2_voice = new SourceVoice(xaudio, beep2_waveFormat, true);
                    beep2_voice.SubmitSourceBuffer(beep2_buffer, beep2_soundstream.DecodedPacketsInfo);
                    beep2_voice.Start();
                }
            }
        }

        private void lblch6_MouseLeave(object sender, EventArgs e)
        {
            lblch6.ForeColor = Color.FromArgb(255, 255, 255);
            lblch6.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular);
            insidech6 = false;
        }

        private void lblch6_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblch6.ForeColor = Color.FromArgb(0, 164, 164);
                panelchapters.Visible = false;
                pnlgame.Visible = true;

                if (soundEnabled == true)
                {
                    nanoblade_voice = new SourceVoice(xaudio, nanoblade_waveFormat, true);
                    nanoblade_voice.SubmitSourceBuffer(nanoblade_buffer, nanoblade_soundstream.DecodedPacketsInfo);
                    nanoblade_voice.Start();
                }

                chapter6game = true;
                chapter6.questionsInGame = 52;

                if (chapter6.questionsInGame > 0)
                {
                    chapter6.Randomize_Questions();
                    chapter6.minutes = chapter6.questionsInGame / 2;
                    chapter6.seconds = 0;
                    chapter6.score = 0;
                    chapter6.antiScore = 0;
                    chapter6.questionNumber = 0;
                    chapter6.text = string.Empty;
                    chapter6.yourAnswer = string.Empty;
                    lbltime.Text = "Time: " + chapter6.minutes.ToString().PadLeft(2, '0') + ":" + chapter6.seconds.ToString().PadLeft(2, '0');
                    timer2.Enabled = true;
                    lblquestion.Text = "#" + Convert.ToString(chapter6.questionNumber + 1) + " of " + Convert.ToString(chapter6.questionsInGame) + ": " + chapter6.Get_Question(chapter6.randomOrder[chapter6.questionNumber]);
                    Random random = new Random();
                    int result;

                    if (chapter6.questiontype[chapter6.randomOrder[chapter6.questionNumber]] == Chapter6.QuestionType.MultipleChoice)
                    {
                        result = random.Next(0, 4);

                        if (result == 0)
                        {
                            lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                    lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                    lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                    lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                    lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                    lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                    lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 1)
                        {
                            lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                    lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                    lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                    lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                    lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                    lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                    lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 2)
                        {
                            lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                    lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                    lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                    lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                    lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                    lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                    lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 3)
                        {
                            lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                    lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                    lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                    lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                    lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                    lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                    lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                }
                            }
                        }
                    }
                    else if (chapter6.questiontype[chapter6.randomOrder[chapter6.questionNumber]] == Chapter6.QuestionType.TrueOrFalse)
                    {
                        result = random.Next(0, 2);

                        if (result == 0)
                        {
                            lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 0];
                            lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                        else if (result == 1)
                        {
                            lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];
                            lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 0];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                    }
                }
            }
        }

        private void lblch7_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblch7.ForeColor = Color.FromArgb(0, 69, 87);
            }
        }

        private void lblch7_MouseMove(object sender, MouseEventArgs e)
        {
            lblch7.Font = new Font("Microsoft Sans Serif", 28, FontStyle.Regular);

            if (e.Button != MouseButtons.Left)
            {
                lblch7.ForeColor = Color.FromArgb(0, 164, 164);
            }

            if (insidech7 == false)
            {
                insidech7 = true;

                if (soundEnabled == true)
                {
                    beep2_voice = new SourceVoice(xaudio, beep2_waveFormat, true);
                    beep2_voice.SubmitSourceBuffer(beep2_buffer, beep2_soundstream.DecodedPacketsInfo);
                    beep2_voice.Start();
                }
            }
        }

        private void lblch7_MouseLeave(object sender, EventArgs e)
        {
            lblch7.ForeColor = Color.FromArgb(255, 255, 255);
            lblch7.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular);
            insidech7 = false;
        }

        private void lblch7_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblch7.ForeColor = Color.FromArgb(0, 164, 164);
                panelchapters.Visible = false;
                pnlgame.Visible = true;

                if (soundEnabled == true)
                {
                    nanoblade_voice = new SourceVoice(xaudio, nanoblade_waveFormat, true);
                    nanoblade_voice.SubmitSourceBuffer(nanoblade_buffer, nanoblade_soundstream.DecodedPacketsInfo);
                    nanoblade_voice.Start();
                }

                chapter7game = true;
                chapter7.questionsInGame = 83;

                if (chapter7.questionsInGame > 0)
                {
                    chapter7.Randomize_Questions();
                    chapter7.minutes = chapter7.questionsInGame / 2;
                    chapter7.seconds = 0;
                    chapter7.score = 0;
                    chapter7.antiScore = 0;
                    chapter7.questionNumber = 0;
                    chapter7.text = string.Empty;
                    chapter7.yourAnswer = string.Empty;
                    lbltime.Text = "Time: " + chapter7.minutes.ToString().PadLeft(2, '0') + ":" + chapter7.seconds.ToString().PadLeft(2, '0');
                    timer2.Enabled = true;
                    lblquestion.Text = "#" + Convert.ToString(chapter7.questionNumber + 1) + " of " + Convert.ToString(chapter7.questionsInGame) + ": " + chapter7.Get_Question(chapter7.randomOrder[chapter7.questionNumber]);
                    Random random = new Random();
                    int result;

                    if (chapter7.questiontype[chapter7.randomOrder[chapter7.questionNumber]] == Chapter7.QuestionType.MultipleChoice)
                    {
                        result = random.Next(0, 4);

                        if (result == 0)
                        {
                            lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                    lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                    lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                    lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                    lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                    lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                    lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 1)
                        {
                            lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                    lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                    lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                    lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                    lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                    lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                    lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 2)
                        {
                            lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                    lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                    lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                    lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                    lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                    lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                    lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 3)
                        {
                            lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                    lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                    lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                    lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                    lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                    lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                    lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                }
                            }
                        }
                    }
                    else if (chapter7.questiontype[chapter7.randomOrder[chapter7.questionNumber]] == Chapter7.QuestionType.TrueOrFalse)
                    {
                        result = random.Next(0, 2);

                        if (result == 0)
                        {
                            lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 0];
                            lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                        else if (result == 1)
                        {
                            lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];
                            lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 0];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                    }
                }
            }
        }

        private void lblch8_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblch8.ForeColor = Color.FromArgb(0, 69, 87);
            }
        }

        private void lblch8_MouseMove(object sender, MouseEventArgs e)
        {
            lblch8.Font = new Font("Microsoft Sans Serif", 28, FontStyle.Regular);

            if (e.Button != MouseButtons.Left)
            {
                lblch8.ForeColor = Color.FromArgb(0, 164, 164);
            }

            if (insidech8 == false)
            {
                insidech8 = true;

                if (soundEnabled == true)
                {
                    beep2_voice = new SourceVoice(xaudio, beep2_waveFormat, true);
                    beep2_voice.SubmitSourceBuffer(beep2_buffer, beep2_soundstream.DecodedPacketsInfo);
                    beep2_voice.Start();
                }
            }
        }

        private void lblch8_MouseLeave(object sender, EventArgs e)
        {
            lblch8.ForeColor = Color.FromArgb(255, 255, 255);
            lblch8.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular);
            insidech8 = false;
        }

        private void lblch8_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblch8.ForeColor = Color.FromArgb(0, 164, 164);
                panelchapters.Visible = false;
                pnlgame.Visible = true;

                if (soundEnabled == true)
                {
                    nanoblade_voice = new SourceVoice(xaudio, nanoblade_waveFormat, true);
                    nanoblade_voice.SubmitSourceBuffer(nanoblade_buffer, nanoblade_soundstream.DecodedPacketsInfo);
                    nanoblade_voice.Start();
                }

                chapter8game = true;
                chapter8.questionsInGame = 23;

                if (chapter8.questionsInGame > 0)
                {
                    chapter8.Randomize_Questions();
                    chapter8.minutes = chapter8.questionsInGame / 2;
                    chapter8.seconds = 0;
                    chapter8.score = 0;
                    chapter8.antiScore = 0;
                    chapter8.questionNumber = 0;
                    chapter8.text = string.Empty;
                    chapter8.yourAnswer = string.Empty;
                    lbltime.Text = "Time: " + chapter8.minutes.ToString().PadLeft(2, '0') + ":" + chapter8.seconds.ToString().PadLeft(2, '0');
                    timer2.Enabled = true;
                    lblquestion.Text = "#" + Convert.ToString(chapter8.questionNumber + 1) + " of " + Convert.ToString(chapter8.questionsInGame) + ": " + chapter8.Get_Question(chapter8.randomOrder[chapter8.questionNumber]);
                    Random random = new Random();
                    int result;

                    if (chapter8.questiontype[chapter8.randomOrder[chapter8.questionNumber]] == Chapter8.QuestionType.MultipleChoice)
                    {
                        result = random.Next(0, 4);

                        if (result == 0)
                        {
                            lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                    lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                    lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                    lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                    lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                    lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                    lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 1)
                        {
                            lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                    lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                    lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                    lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                    lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                    lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                    lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 2)
                        {
                            lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                    lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                    lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                    lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                    lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                    lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                    lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 3)
                        {
                            lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                    lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                    lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                    lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                    lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                    lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                    lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                }
                            }
                        }
                    }
                    else if (chapter8.questiontype[chapter8.randomOrder[chapter8.questionNumber]] == Chapter8.QuestionType.TrueOrFalse)
                    {
                        result = random.Next(0, 2);

                        if (result == 0)
                        {
                            lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 0];
                            lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                        else if (result == 1)
                        {
                            lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];
                            lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 0];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                    }
                }
            }
        }

        private void lblch9_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblch9.ForeColor = Color.FromArgb(0, 69, 87);
            }
        }

        private void lblch9_MouseMove(object sender, MouseEventArgs e)
        {
            lblch9.Font = new Font("Microsoft Sans Serif", 28, FontStyle.Regular);

            if (e.Button != MouseButtons.Left)
            {
                lblch9.ForeColor = Color.FromArgb(0, 164, 164);
            }

            if (insidech9 == false)
            {
                insidech9 = true;

                if (soundEnabled == true)
                {
                    beep2_voice = new SourceVoice(xaudio, beep2_waveFormat, true);
                    beep2_voice.SubmitSourceBuffer(beep2_buffer, beep2_soundstream.DecodedPacketsInfo);
                    beep2_voice.Start();
                }
            }
        }

        private void lblch9_MouseLeave(object sender, EventArgs e)
        {
            lblch9.ForeColor = Color.FromArgb(255, 255, 255);
            lblch9.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular);
            insidech9 = false;
        }

        private void lblch9_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblch9.ForeColor = Color.FromArgb(0, 164, 164);
                panelchapters.Visible = false;
                pnlgame.Visible = true;

                if (soundEnabled == true)
                {
                    nanoblade_voice = new SourceVoice(xaudio, nanoblade_waveFormat, true);
                    nanoblade_voice.SubmitSourceBuffer(nanoblade_buffer, nanoblade_soundstream.DecodedPacketsInfo);
                    nanoblade_voice.Start();
                }

                chapter9game = true;
                chapter9.questionsInGame = 37;

                if (chapter9.questionsInGame > 0)
                {
                    chapter9.Randomize_Questions();
                    chapter9.minutes = chapter9.questionsInGame / 2;
                    chapter9.seconds = 0;
                    chapter9.score = 0;
                    chapter9.antiScore = 0;
                    chapter9.questionNumber = 0;
                    chapter9.text = string.Empty;
                    chapter9.yourAnswer = string.Empty;
                    lbltime.Text = "Time: " + chapter9.minutes.ToString().PadLeft(2, '0') + ":" + chapter9.seconds.ToString().PadLeft(2, '0');
                    timer2.Enabled = true;
                    lblquestion.Text = "#" + Convert.ToString(chapter9.questionNumber + 1) + " of " + Convert.ToString(chapter9.questionsInGame) + ": " + chapter9.Get_Question(chapter9.randomOrder[chapter9.questionNumber]);
                    Random random = new Random();
                    int result;

                    if (chapter9.questiontype[chapter9.randomOrder[chapter9.questionNumber]] == Chapter9.QuestionType.MultipleChoice)
                    {
                        result = random.Next(0, 4);

                        if (result == 0)
                        {
                            lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                    lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                    lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                    lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                    lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                    lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                    lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 1)
                        {
                            lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                    lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                    lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                    lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                    lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                    lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                    lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 2)
                        {
                            lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                    lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                    lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                    lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                    lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                    lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                    lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 3)
                        {
                            lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                    lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                    lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                    lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                    lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                    lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                    lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                }
                            }
                        }
                    }
                    else if (chapter9.questiontype[chapter9.randomOrder[chapter9.questionNumber]] == Chapter9.QuestionType.TrueOrFalse)
                    {
                        result = random.Next(0, 2);

                        if (result == 0)
                        {
                            lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 0];
                            lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                        else if (result == 1)
                        {
                            lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];
                            lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 0];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                    }
                }
            }
        }

        private void lblmidterm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblmidterm.ForeColor = Color.FromArgb(0, 69, 87);
            }
        }

        private void lblmidterm_MouseMove(object sender, MouseEventArgs e)
        {
            lblmidterm.Font = new Font("Microsoft Sans Serif", 28, FontStyle.Regular);

            if (e.Button != MouseButtons.Left)
            {
                lblmidterm.ForeColor = Color.FromArgb(0, 164, 164);
            }

            if (insidemidterm == false)
            {
                insidemidterm = true;

                if (soundEnabled == true)
                {
                    beep2_voice = new SourceVoice(xaudio, beep2_waveFormat, true);
                    beep2_voice.SubmitSourceBuffer(beep2_buffer, beep2_soundstream.DecodedPacketsInfo);
                    beep2_voice.Start();
                }
            }
        }

        private void lblmidterm_MouseLeave(object sender, EventArgs e)
        {
            lblmidterm.ForeColor = Color.FromArgb(255, 255, 255);
            lblmidterm.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular);
            insidemidterm = false;
        }

        private void lblmidterm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lblmidterm.ForeColor = Color.FromArgb(0, 164, 164);
                panelchapters.Visible = false;
                pnlgame.Visible = true;

                if (soundEnabled == true)
                {
                    nanoblade_voice = new SourceVoice(xaudio, nanoblade_waveFormat, true);
                    nanoblade_voice.SubmitSourceBuffer(nanoblade_buffer, nanoblade_soundstream.DecodedPacketsInfo);
                    nanoblade_voice.Start();
                }

                midtermgame = true;
                midterm.questionsInGame = 31;

                if (midterm.questionsInGame > 0)
                {
                    midterm.Randomize_Questions();
                    midterm.minutes = midterm.questionsInGame / 2;
                    midterm.seconds = 0;
                    midterm.score = 0;
                    midterm.antiScore = 0;
                    midterm.questionNumber = 0;
                    midterm.text = string.Empty;
                    midterm.yourAnswer = string.Empty;
                    lbltime.Text = "Time: " + midterm.minutes.ToString().PadLeft(2, '0') + ":" + midterm.seconds.ToString().PadLeft(2, '0');
                    timer2.Enabled = true;
                    lblquestion.Text = "#" + Convert.ToString(midterm.questionNumber + 1) + " of " + Convert.ToString(midterm.questionsInGame) + ": " + midterm.Get_Question(midterm.randomOrder[midterm.questionNumber]);
                    Random random = new Random();
                    int result;

                    if (midterm.questiontype[midterm.randomOrder[midterm.questionNumber]] == Midterm.QuestionType.MultipleChoice)
                    {
                        result = random.Next(0, 4);

                        if (result == 0)
                        {
                            lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                    lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                    lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                    lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                    lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                    lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                    lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 1)
                        {
                            lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                    lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                    lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                    lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                    lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                    lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                    lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 2)
                        {
                            lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                    lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                    lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                    lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                    lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                    lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                    lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 3)
                        {
                            lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                    lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                    lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                    lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                    lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                    lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                    lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                }
                            }
                        }
                    }
                    else if (midterm.questiontype[midterm.randomOrder[midterm.questionNumber]] == Midterm.QuestionType.TrueOrFalse)
                    {
                        result = random.Next(0, 2);

                        if (result == 0)
                        {
                            lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 0];
                            lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                        else if (result == 1)
                        {
                            lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];
                            lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 0];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                    }
                }
            }
        }

        private void lblA_MouseDown(object sender, MouseEventArgs e)
        {
            if (locklabels == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    lblA.ForeColor = Color.FromArgb(0, 69, 87);
                }
            }  
        }

        private void lblA_MouseMove(object sender, MouseEventArgs e)
        {
            if (locklabels == false)
            {
                lblA.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular);

                if (e.Button != MouseButtons.Left)
                {
                    lblA.ForeColor = Color.FromArgb(0, 164, 164);
                }

                if (insideA == false)
                {
                    insideA = true;

                    if (soundEnabled == true)
                    {
                        beep2_voice = new SourceVoice(xaudio, beep2_waveFormat, true);
                        beep2_voice.SubmitSourceBuffer(beep2_buffer, beep2_soundstream.DecodedPacketsInfo);
                        beep2_voice.Start();
                    }
                }
            }
        }

        private void lblA_MouseLeave(object sender, EventArgs e)
        {
            if (locklabels == false)
            {
                lblA.ForeColor = Color.FromArgb(255, 255, 255);
                lblA.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                insideA = false;
            }
        }

        private void lblA_MouseUp(object sender, MouseEventArgs e)
        {
            if (locklabels == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    lblA.ForeColor = Color.FromArgb(0, 164, 164);

                    if (soundEnabled == true)
                    {
                        nanoblade_voice = new SourceVoice(xaudio, nanoblade_waveFormat, true);
                        nanoblade_voice.SubmitSourceBuffer(nanoblade_buffer, nanoblade_soundstream.DecodedPacketsInfo);
                        nanoblade_voice.Start();
                    }

                    Chapter1_Game(lblA);
                    Chapter2_Game(lblA);
                    Chapter3_Game(lblA);
                    Chapter6_Game(lblA);
                    Chapter7_Game(lblA);
                    Chapter8_Game(lblA);
                    Chapter9_Game(lblA);
                    Midterm_Game(lblA);
                }
            }
        }

        private void lblB_MouseDown(object sender, MouseEventArgs e)
        {
            if (locklabels == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    lblB.ForeColor = Color.FromArgb(0, 69, 87);
                }
            }
        }

        private void lblB_MouseMove(object sender, MouseEventArgs e)
        {
            if (locklabels == false)
            {
                lblB.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular);

                if (e.Button != MouseButtons.Left)
                {
                    lblB.ForeColor = Color.FromArgb(0, 164, 164);
                }

                if (insideB == false)
                {
                    insideB = true;

                    if (soundEnabled == true)
                    {
                        beep2_voice = new SourceVoice(xaudio, beep2_waveFormat, true);
                        beep2_voice.SubmitSourceBuffer(beep2_buffer, beep2_soundstream.DecodedPacketsInfo);
                        beep2_voice.Start();
                    }
                }
            }
        }

        private void lblB_MouseLeave(object sender, EventArgs e)
        {
            if (locklabels == false)
            {
                lblB.ForeColor = Color.FromArgb(255, 255, 255);
                lblB.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                insideB = false;
            }
        }

        private void lblB_MouseUp(object sender, MouseEventArgs e)
        {
            if (locklabels == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    lblB.ForeColor = Color.FromArgb(0, 164, 164);

                    if (soundEnabled == true)
                    {
                        nanoblade_voice = new SourceVoice(xaudio, nanoblade_waveFormat, true);
                        nanoblade_voice.SubmitSourceBuffer(nanoblade_buffer, nanoblade_soundstream.DecodedPacketsInfo);
                        nanoblade_voice.Start();
                    }

                    Chapter1_Game(lblB);
                    Chapter2_Game(lblB);
                    Chapter3_Game(lblB);
                    Chapter6_Game(lblB);
                    Chapter7_Game(lblB);
                    Chapter8_Game(lblB);
                    Chapter9_Game(lblB);
                    Midterm_Game(lblB);
                }
            }
        }

        private void lblC_MouseDown(object sender, MouseEventArgs e)
        {
            if (locklabels == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    lblC.ForeColor = Color.FromArgb(0, 69, 87);
                }
            }
        }

        private void lblC_MouseMove(object sender, MouseEventArgs e)
        {
            if (locklabels == false)
            {
                lblC.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular);

                if (e.Button != MouseButtons.Left)
                {
                    lblC.ForeColor = Color.FromArgb(0, 164, 164);
                }

                if (insideC == false)
                {
                    insideC = true;

                    if (soundEnabled == true)
                    {
                        beep2_voice = new SourceVoice(xaudio, beep2_waveFormat, true);
                        beep2_voice.SubmitSourceBuffer(beep2_buffer, beep2_soundstream.DecodedPacketsInfo);
                        beep2_voice.Start();
                    }
                }
            }
        }

        private void lblC_MouseLeave(object sender, EventArgs e)
        {
            if (locklabels == false)
            {
                lblC.ForeColor = Color.FromArgb(255, 255, 255);
                lblC.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                insideC = false;
            }
        }

        private void lblC_MouseUp(object sender, MouseEventArgs e)
        {
            if (locklabels == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    lblC.ForeColor = Color.FromArgb(0, 164, 164);

                    if (soundEnabled == true)
                    {
                        nanoblade_voice = new SourceVoice(xaudio, nanoblade_waveFormat, true);
                        nanoblade_voice.SubmitSourceBuffer(nanoblade_buffer, nanoblade_soundstream.DecodedPacketsInfo);
                        nanoblade_voice.Start();
                    }

                    Chapter1_Game(lblC);
                    Chapter2_Game(lblC);
                    Chapter3_Game(lblC);
                    Chapter6_Game(lblC);
                    Chapter7_Game(lblC);
                    Chapter8_Game(lblC);
                    Chapter9_Game(lblC);
                    Midterm_Game(lblC);
                }
            }
        }

        private void lblD_MouseDown(object sender, MouseEventArgs e)
        {
            if (locklabels == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    lblD.ForeColor = Color.FromArgb(0, 69, 87);
                }
            }
        }

        private void lblD_MouseMove(object sender, MouseEventArgs e)
        {
            if (locklabels == false)
            {
                lblD.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular);

                if (e.Button != MouseButtons.Left)
                {
                    lblD.ForeColor = Color.FromArgb(0, 164, 164);
                }

                if (insideD == false)
                {
                    insideD = true;

                    if (soundEnabled == true)
                    {
                        beep2_voice = new SourceVoice(xaudio, beep2_waveFormat, true);
                        beep2_voice.SubmitSourceBuffer(beep2_buffer, beep2_soundstream.DecodedPacketsInfo);
                        beep2_voice.Start();
                    }
                }
            }
        }

        private void lblD_MouseLeave(object sender, EventArgs e)
        {
            if (locklabels == false)
            {
                lblD.ForeColor = Color.FromArgb(255, 255, 255);
                lblD.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                insideD = false;
            }
        }

        private void lblD_MouseUp(object sender, MouseEventArgs e)
        {
            if (locklabels == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    lblD.ForeColor = Color.FromArgb(0, 164, 164);

                    if (soundEnabled == true)
                    {
                        nanoblade_voice = new SourceVoice(xaudio, nanoblade_waveFormat, true);
                        nanoblade_voice.SubmitSourceBuffer(nanoblade_buffer, nanoblade_soundstream.DecodedPacketsInfo);
                        nanoblade_voice.Start();
                    }

                    Chapter1_Game(lblD);
                    Chapter2_Game(lblD);
                    Chapter3_Game(lblD);
                    Chapter6_Game(lblD);
                    Chapter7_Game(lblD);
                    Chapter8_Game(lblD);
                    Chapter9_Game(lblD);
                    Midterm_Game(lblD);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chapter1game == true)
            {
                chapter1.questionNumber++;
                locklabels = false;
                timer1.Enabled = false;
                correct = false;
                lblCorrectMessage.Visible = false;
                lblWrong.Visible = false;
                lblA.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblB.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblC.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblD.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblA.ForeColor = Color.FromArgb(255, 255, 255);
                lblB.ForeColor = Color.FromArgb(255, 255, 255);
                lblC.ForeColor = Color.FromArgb(255, 255, 255);
                lblD.ForeColor = Color.FromArgb(255, 255, 255);

                if (chapter1.questionNumber == chapter1.questionsInGame)
                {
                    chapter1.minutes = 0;
                    chapter1.seconds = 0;
                    locklabels = true;
                    pnlGrade.Visible = true;
                    timer2.Enabled = false;
                    timer3.Enabled = true;
                    lblCorrect.Text = Convert.ToString(chapter1.score);
                    lblIncorrect.Text = Convert.ToString(chapter1.antiScore);

                    float grade = Convert.ToSingle(Decimal.Divide(chapter1.score, chapter1.questionsInGame)) * 100.0f;

                    switch (grade)
                    {
                        case float n when (n >= 90.0f):
                            {
                                lblGrade.Text = "A";
                                break;
                            }
                        case float n when (n >= 80.0f && n < 90.0f):
                            {
                                lblGrade.Text = "B";
                                break;
                            }
                        case float n when (n >= 70.0f && n < 80.0f):
                            {
                                lblGrade.Text = "C";
                                break;
                            }
                        case float n when (n >= 60.0f && n < 70.0f):
                            {
                                lblGrade.Text = "D";
                                break;
                            }
                        case float n when (n < 60.0f):
                            {
                                lblGrade.Text = "F";
                                break;
                            }
                    }
                }
                else
                {
                    lblquestion.Text = "#" + Convert.ToString(chapter1.questionNumber + 1) + " of " + Convert.ToString(chapter1.questionsInGame) + ": " + chapter1.Get_Question(chapter1.randomOrder[chapter1.questionNumber]);
                    Random random = new Random();
                    int result;

                    if (chapter1.questiontype[chapter1.randomOrder[chapter1.questionNumber]] == Chapter1.QuestionType.MultipleChoice)
                    {
                        result = random.Next(0, 4);

                        if (result == 0)
                        {
                            lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                    lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                    lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                    lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                    lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                    lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                    lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 1)
                        {
                            lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                    lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                    lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                    lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                    lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                    lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                    lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 2)
                        {
                            lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                    lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                    lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                    lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                    lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                    lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                    lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 3)
                        {
                            lblD.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                    lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                    lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                    lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                    lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                    lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 3];
                                    lblC.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 2];
                                }
                            }
                        }
                    }
                    else if (chapter1.questiontype[chapter1.randomOrder[chapter1.questionNumber]] == Chapter1.QuestionType.TrueOrFalse)
                    {
                        result = random.Next(0, 2);

                        if (result == 0)
                        {
                            lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 0];
                            lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                        else if (result == 1)
                        {
                            lblA.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 1];
                            lblB.Text = chapter1.answer[chapter1.randomOrder[chapter1.questionNumber], 0];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                    }
                }
            }
            else if (chapter2game == true)
            {
                chapter2.questionNumber++;
                locklabels = false;
                timer1.Enabled = false;
                correct = false;
                lblCorrectMessage.Visible = false;
                lblWrong.Visible = false;
                lblA.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblB.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblC.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblD.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblA.ForeColor = Color.FromArgb(255, 255, 255);
                lblB.ForeColor = Color.FromArgb(255, 255, 255);
                lblC.ForeColor = Color.FromArgb(255, 255, 255);
                lblD.ForeColor = Color.FromArgb(255, 255, 255);

                if (chapter2.questionNumber == chapter2.questionsInGame)
                {
                    chapter2.minutes = 0;
                    chapter2.seconds = 0;
                    locklabels = true;
                    pnlGrade.Visible = true;
                    timer2.Enabled = false;
                    timer3.Enabled = true;
                    lblCorrect.Text = Convert.ToString(chapter2.score);
                    lblIncorrect.Text = Convert.ToString(chapter2.antiScore);

                    float grade = Convert.ToSingle(Decimal.Divide(chapter2.score, chapter2.questionsInGame)) * 100.0f;

                    switch (grade)
                    {
                        case float n when (n >= 90.0f):
                            {
                                lblGrade.Text = "A";
                                break;
                            }
                        case float n when (n >= 80.0f && n < 90.0f):
                            {
                                lblGrade.Text = "B";
                                break;
                            }
                        case float n when (n >= 70.0f && n < 80.0f):
                            {
                                lblGrade.Text = "C";
                                break;
                            }
                        case float n when (n >= 60.0f && n < 70.0f):
                            {
                                lblGrade.Text = "D";
                                break;
                            }
                        case float n when (n < 60.0f):
                            {
                                lblGrade.Text = "F";
                                break;
                            }
                    }
                }
                else
                {
                    lblquestion.Text = "#" + Convert.ToString(chapter2.questionNumber + 1) + " of " + Convert.ToString(chapter2.questionsInGame) + ": " + chapter2.Get_Question(chapter2.randomOrder[chapter2.questionNumber]);
                    Random random = new Random();
                    int result;

                    if (chapter2.questiontype[chapter2.randomOrder[chapter2.questionNumber]] == Chapter2.QuestionType.MultipleChoice)
                    {
                        result = random.Next(0, 4);

                        if (result == 0)
                        {
                            lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                    lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                    lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                    lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                    lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                    lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                    lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 1)
                        {
                            lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                    lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                    lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                    lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                    lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                    lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                    lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 2)
                        {
                            lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                    lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                    lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                    lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                    lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                    lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                    lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 3)
                        {
                            lblD.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                    lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                    lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                    lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                    lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                    lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 3];
                                    lblC.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 2];
                                }
                            }
                        }
                    }
                    else if (chapter2.questiontype[chapter2.randomOrder[chapter2.questionNumber]] == Chapter2.QuestionType.TrueOrFalse)
                    {
                        result = random.Next(0, 2);

                        if (result == 0)
                        {
                            lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 0];
                            lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                        else if (result == 1)
                        {
                            lblA.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 1];
                            lblB.Text = chapter2.answer[chapter2.randomOrder[chapter2.questionNumber], 0];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                    }
                }
            }
            else if (chapter3game == true)
            {
                chapter3.questionNumber++;
                locklabels = false;
                timer1.Enabled = false;
                correct = false;
                lblCorrectMessage.Visible = false;
                lblWrong.Visible = false;
                lblA.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblB.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblC.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblD.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblA.ForeColor = Color.FromArgb(255, 255, 255);
                lblB.ForeColor = Color.FromArgb(255, 255, 255);
                lblC.ForeColor = Color.FromArgb(255, 255, 255);
                lblD.ForeColor = Color.FromArgb(255, 255, 255);

                if (chapter3.questionNumber == chapter3.questionsInGame)
                {
                    chapter3.minutes = 0;
                    chapter3.seconds = 0;
                    locklabels = true;
                    pnlGrade.Visible = true;
                    timer2.Enabled = false;
                    timer3.Enabled = true;
                    lblCorrect.Text = Convert.ToString(chapter3.score);
                    lblIncorrect.Text = Convert.ToString(chapter3.antiScore);

                    float grade = Convert.ToSingle(Decimal.Divide(chapter3.score, chapter3.questionsInGame)) * 100.0f;

                    switch (grade)
                    {
                        case float n when (n >= 90.0f):
                            {
                                lblGrade.Text = "A";
                                break;
                            }
                        case float n when (n >= 80.0f && n < 90.0f):
                            {
                                lblGrade.Text = "B";
                                break;
                            }
                        case float n when (n >= 70.0f && n < 80.0f):
                            {
                                lblGrade.Text = "C";
                                break;
                            }
                        case float n when (n >= 60.0f && n < 70.0f):
                            {
                                lblGrade.Text = "D";
                                break;
                            }
                        case float n when (n < 60.0f):
                            {
                                lblGrade.Text = "F";
                                break;
                            }
                    }
                }
                else
                {
                    lblquestion.Text = "#" + Convert.ToString(chapter3.questionNumber + 1) + " of " + Convert.ToString(chapter3.questionsInGame) + ": " + chapter3.Get_Question(chapter3.randomOrder[chapter3.questionNumber]);
                    Random random = new Random();
                    int result;

                    if (chapter3.questiontype[chapter3.randomOrder[chapter3.questionNumber]] == Chapter3.QuestionType.MultipleChoice)
                    {
                        result = random.Next(0, 4);

                        if (result == 0)
                        {
                            lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                    lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                    lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                    lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                    lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                    lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                    lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 1)
                        {
                            lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                    lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                    lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                    lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                    lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                    lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                    lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 2)
                        {
                            lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                    lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                    lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                    lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                    lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                    lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                    lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 3)
                        {
                            lblD.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                    lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                    lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                    lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                    lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                    lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 3];
                                    lblC.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 2];
                                }
                            }
                        }
                    }
                    else if (chapter3.questiontype[chapter3.randomOrder[chapter3.questionNumber]] == Chapter3.QuestionType.TrueOrFalse)
                    {
                        result = random.Next(0, 2);

                        if (result == 0)
                        {
                            lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 0];
                            lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                        else if (result == 1)
                        {
                            lblA.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 1];
                            lblB.Text = chapter3.answer[chapter3.randomOrder[chapter3.questionNumber], 0];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                    }
                }
            }
            else if (chapter6game == true)
            {
                chapter6.questionNumber++;
                locklabels = false;
                timer1.Enabled = false;
                correct = false;
                lblCorrectMessage.Visible = false;
                lblWrong.Visible = false;
                lblA.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblB.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblC.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblD.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblA.ForeColor = Color.FromArgb(255, 255, 255);
                lblB.ForeColor = Color.FromArgb(255, 255, 255);
                lblC.ForeColor = Color.FromArgb(255, 255, 255);
                lblD.ForeColor = Color.FromArgb(255, 255, 255);

                if (chapter6.questionNumber == chapter6.questionsInGame)
                {
                    chapter6.minutes = 0;
                    chapter6.seconds = 0;
                    locklabels = true;
                    pnlGrade.Visible = true;
                    timer2.Enabled = false;
                    timer3.Enabled = true;
                    lblCorrect.Text = Convert.ToString(chapter6.score);
                    lblIncorrect.Text = Convert.ToString(chapter6.antiScore);

                    float grade = Convert.ToSingle(Decimal.Divide(chapter6.score, chapter6.questionsInGame)) * 100.0f;

                    switch (grade)
                    {
                        case float n when (n >= 90.0f):
                            {
                                lblGrade.Text = "A";
                                break;
                            }
                        case float n when (n >= 80.0f && n < 90.0f):
                            {
                                lblGrade.Text = "B";
                                break;
                            }
                        case float n when (n >= 70.0f && n < 80.0f):
                            {
                                lblGrade.Text = "C";
                                break;
                            }
                        case float n when (n >= 60.0f && n < 70.0f):
                            {
                                lblGrade.Text = "D";
                                break;
                            }
                        case float n when (n < 60.0f):
                            {
                                lblGrade.Text = "F";
                                break;
                            }
                    }
                }
                else
                {
                    lblquestion.Text = "#" + Convert.ToString(chapter6.questionNumber + 1) + " of " + Convert.ToString(chapter6.questionsInGame) + ": " + chapter6.Get_Question(chapter6.randomOrder[chapter6.questionNumber]);
                    Random random = new Random();
                    int result;

                    if (chapter6.questiontype[chapter6.randomOrder[chapter6.questionNumber]] == Chapter6.QuestionType.MultipleChoice)
                    {
                        result = random.Next(0, 4);

                        if (result == 0)
                        {
                            lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                    lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                    lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                    lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                    lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                    lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                    lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 1)
                        {
                            lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                    lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                    lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                    lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                    lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                    lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                    lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 2)
                        {
                            lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                    lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                    lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                    lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                    lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                    lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                    lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 3)
                        {
                            lblD.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                    lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                    lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                    lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                    lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                    lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 3];
                                    lblC.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 2];
                                }
                            }
                        }
                    }
                    else if (chapter6.questiontype[chapter6.randomOrder[chapter6.questionNumber]] == Chapter6.QuestionType.TrueOrFalse)
                    {
                        result = random.Next(0, 2);

                        if (result == 0)
                        {
                            lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 0];
                            lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                        else if (result == 1)
                        {
                            lblA.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 1];
                            lblB.Text = chapter6.answer[chapter6.randomOrder[chapter6.questionNumber], 0];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                    }
                }
            }
            else if (chapter7game == true)
            {
                chapter7.questionNumber++;
                locklabels = false;
                timer1.Enabled = false;
                correct = false;
                lblCorrectMessage.Visible = false;
                lblWrong.Visible = false;
                lblA.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblB.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblC.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblD.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblA.ForeColor = Color.FromArgb(255, 255, 255);
                lblB.ForeColor = Color.FromArgb(255, 255, 255);
                lblC.ForeColor = Color.FromArgb(255, 255, 255);
                lblD.ForeColor = Color.FromArgb(255, 255, 255);

                if (chapter7.questionNumber == chapter7.questionsInGame)
                {
                    chapter7.minutes = 0;
                    chapter7.seconds = 0;
                    locklabels = true;
                    pnlGrade.Visible = true;
                    timer2.Enabled = false;
                    timer3.Enabled = true;
                    lblCorrect.Text = Convert.ToString(chapter7.score);
                    lblIncorrect.Text = Convert.ToString(chapter7.antiScore);

                    float grade = Convert.ToSingle(Decimal.Divide(chapter7.score, chapter7.questionsInGame)) * 100.0f;

                    switch (grade)
                    {
                        case float n when (n >= 90.0f):
                            {
                                lblGrade.Text = "A";
                                break;
                            }
                        case float n when (n >= 80.0f && n < 90.0f):
                            {
                                lblGrade.Text = "B";
                                break;
                            }
                        case float n when (n >= 70.0f && n < 80.0f):
                            {
                                lblGrade.Text = "C";
                                break;
                            }
                        case float n when (n >= 60.0f && n < 70.0f):
                            {
                                lblGrade.Text = "D";
                                break;
                            }
                        case float n when (n < 60.0f):
                            {
                                lblGrade.Text = "F";
                                break;
                            }
                    }
                }
                else
                {
                    lblquestion.Text = "#" + Convert.ToString(chapter7.questionNumber + 1) + " of " + Convert.ToString(chapter7.questionsInGame) + ": " + chapter7.Get_Question(chapter7.randomOrder[chapter7.questionNumber]);
                    Random random = new Random();
                    int result;

                    if (chapter7.questiontype[chapter7.randomOrder[chapter7.questionNumber]] == Chapter7.QuestionType.MultipleChoice)
                    {
                        result = random.Next(0, 4);

                        if (result == 0)
                        {
                            lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                    lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                    lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                    lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                    lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                    lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                    lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 1)
                        {
                            lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                    lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                    lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                    lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                    lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                    lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                    lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 2)
                        {
                            lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                    lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                    lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                    lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                    lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                    lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                    lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 3)
                        {
                            lblD.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                    lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                    lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                    lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                    lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                    lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 3];
                                    lblC.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 2];
                                }
                            }
                        }
                    }
                    else if (chapter7.questiontype[chapter7.randomOrder[chapter7.questionNumber]] == Chapter7.QuestionType.TrueOrFalse)
                    {
                        result = random.Next(0, 2);

                        if (result == 0)
                        {
                            lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 0];
                            lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                        else if (result == 1)
                        {
                            lblA.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 1];
                            lblB.Text = chapter7.answer[chapter7.randomOrder[chapter7.questionNumber], 0];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                    }
                }
            }
            else if (chapter8game == true)
            {
                chapter8.questionNumber++;
                locklabels = false;
                timer1.Enabled = false;
                correct = false;
                lblCorrectMessage.Visible = false;
                lblWrong.Visible = false;
                lblA.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblB.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblC.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblD.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblA.ForeColor = Color.FromArgb(255, 255, 255);
                lblB.ForeColor = Color.FromArgb(255, 255, 255);
                lblC.ForeColor = Color.FromArgb(255, 255, 255);
                lblD.ForeColor = Color.FromArgb(255, 255, 255);

                if (chapter8.questionNumber == chapter8.questionsInGame)
                {
                    chapter8.minutes = 0;
                    chapter8.seconds = 0;
                    locklabels = true;
                    pnlGrade.Visible = true;
                    timer2.Enabled = false;
                    timer3.Enabled = true;
                    lblCorrect.Text = Convert.ToString(chapter8.score);
                    lblIncorrect.Text = Convert.ToString(chapter8.antiScore);

                    float grade = Convert.ToSingle(Decimal.Divide(chapter8.score, chapter8.questionsInGame)) * 100.0f;

                    switch (grade)
                    {
                        case float n when (n >= 90.0f):
                            {
                                lblGrade.Text = "A";
                                break;
                            }
                        case float n when (n >= 80.0f && n < 90.0f):
                            {
                                lblGrade.Text = "B";
                                break;
                            }
                        case float n when (n >= 70.0f && n < 80.0f):
                            {
                                lblGrade.Text = "C";
                                break;
                            }
                        case float n when (n >= 60.0f && n < 70.0f):
                            {
                                lblGrade.Text = "D";
                                break;
                            }
                        case float n when (n < 60.0f):
                            {
                                lblGrade.Text = "F";
                                break;
                            }
                    }
                }
                else
                {
                    lblquestion.Text = "#" + Convert.ToString(chapter8.questionNumber + 1) + " of " + Convert.ToString(chapter8.questionsInGame) + ": " + chapter8.Get_Question(chapter8.randomOrder[chapter8.questionNumber]);
                    Random random = new Random();
                    int result;

                    if (chapter8.questiontype[chapter8.randomOrder[chapter8.questionNumber]] == Chapter8.QuestionType.MultipleChoice)
                    {
                        result = random.Next(0, 4);

                        if (result == 0)
                        {
                            lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                    lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                    lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                    lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                    lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                    lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                    lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 1)
                        {
                            lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                    lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                    lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                    lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                    lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                    lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                    lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 2)
                        {
                            lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                    lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                    lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                    lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                    lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                    lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                    lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 3)
                        {
                            lblD.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                    lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                    lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                    lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                    lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                    lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 3];
                                    lblC.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 2];
                                }
                            }
                        }
                    }
                    else if (chapter8.questiontype[chapter8.randomOrder[chapter8.questionNumber]] == Chapter8.QuestionType.TrueOrFalse)
                    {
                        result = random.Next(0, 2);

                        if (result == 0)
                        {
                            lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 0];
                            lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                        else if (result == 1)
                        {
                            lblA.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 1];
                            lblB.Text = chapter8.answer[chapter8.randomOrder[chapter8.questionNumber], 0];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                    }
                }
            }
            else if (chapter9game == true)
            {
                chapter9.questionNumber++;
                locklabels = false;
                timer1.Enabled = false;
                correct = false;
                lblCorrectMessage.Visible = false;
                lblWrong.Visible = false;
                lblA.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblB.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblC.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblD.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblA.ForeColor = Color.FromArgb(255, 255, 255);
                lblB.ForeColor = Color.FromArgb(255, 255, 255);
                lblC.ForeColor = Color.FromArgb(255, 255, 255);
                lblD.ForeColor = Color.FromArgb(255, 255, 255);

                if (chapter9.questionNumber == chapter9.questionsInGame)
                {
                    chapter9.minutes = 0;
                    chapter9.seconds = 0;
                    locklabels = true;
                    pnlGrade.Visible = true;
                    timer2.Enabled = false;
                    timer3.Enabled = true;
                    lblCorrect.Text = Convert.ToString(chapter9.score);
                    lblIncorrect.Text = Convert.ToString(chapter9.antiScore);

                    float grade = Convert.ToSingle(Decimal.Divide(chapter9.score, chapter9.questionsInGame)) * 100.0f;

                    switch (grade)
                    {
                        case float n when (n >= 90.0f):
                            {
                                lblGrade.Text = "A";
                                break;
                            }
                        case float n when (n >= 80.0f && n < 90.0f):
                            {
                                lblGrade.Text = "B";
                                break;
                            }
                        case float n when (n >= 70.0f && n < 80.0f):
                            {
                                lblGrade.Text = "C";
                                break;
                            }
                        case float n when (n >= 60.0f && n < 70.0f):
                            {
                                lblGrade.Text = "D";
                                break;
                            }
                        case float n when (n < 60.0f):
                            {
                                lblGrade.Text = "F";
                                break;
                            }
                    }
                }
                else
                {
                    lblquestion.Text = "#" + Convert.ToString(chapter9.questionNumber + 1) + " of " + Convert.ToString(chapter9.questionsInGame) + ": " + chapter9.Get_Question(chapter9.randomOrder[chapter9.questionNumber]);
                    Random random = new Random();
                    int result;

                    if (chapter9.questiontype[chapter9.randomOrder[chapter9.questionNumber]] == Chapter9.QuestionType.MultipleChoice)
                    {
                        result = random.Next(0, 4);

                        if (result == 0)
                        {
                            lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                    lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                    lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                    lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                    lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                    lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                    lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 1)
                        {
                            lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                    lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                    lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                    lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                    lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                    lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                    lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 2)
                        {
                            lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                    lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                    lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                    lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                    lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                    lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                    lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 3)
                        {
                            lblD.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                    lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                    lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                    lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                    lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                    lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 3];
                                    lblC.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 2];
                                }
                            }
                        }
                    }
                    else if (chapter9.questiontype[chapter9.randomOrder[chapter9.questionNumber]] == Chapter9.QuestionType.TrueOrFalse)
                    {
                        result = random.Next(0, 2);

                        if (result == 0)
                        {
                            lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 0];
                            lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                        else if (result == 1)
                        {
                            lblA.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 1];
                            lblB.Text = chapter9.answer[chapter9.randomOrder[chapter9.questionNumber], 0];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                    }
                }
            }
            else if (midtermgame == true)
            {
                midterm.questionNumber++;
                locklabels = false;
                timer1.Enabled = false;
                correct = false;
                lblCorrectMessage.Visible = false;
                lblWrong.Visible = false;
                lblA.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblB.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblC.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblD.Font = new Font("Microsoft Sans Serif", 14, FontStyle.Regular);
                lblA.ForeColor = Color.FromArgb(255, 255, 255);
                lblB.ForeColor = Color.FromArgb(255, 255, 255);
                lblC.ForeColor = Color.FromArgb(255, 255, 255);
                lblD.ForeColor = Color.FromArgb(255, 255, 255);

                if (midterm.questionNumber == midterm.questionsInGame)
                {
                    midterm.minutes = 0;
                    midterm.seconds = 0;
                    locklabels = true;
                    pnlGrade.Visible = true;
                    timer2.Enabled = false;
                    timer3.Enabled = true;
                    lblCorrect.Text = Convert.ToString(midterm.score);
                    lblIncorrect.Text = Convert.ToString(midterm.antiScore);

                    float grade = Convert.ToSingle(Decimal.Divide(midterm.score, midterm.questionsInGame)) * 100.0f;

                    switch (grade)
                    {
                        case float n when (n >= 90.0f):
                            {
                                lblGrade.Text = "A";
                                break;
                            }
                        case float n when (n >= 80.0f && n < 90.0f):
                            {
                                lblGrade.Text = "B";
                                break;
                            }
                        case float n when (n >= 70.0f && n < 80.0f):
                            {
                                lblGrade.Text = "C";
                                break;
                            }
                        case float n when (n >= 60.0f && n < 70.0f):
                            {
                                lblGrade.Text = "D";
                                break;
                            }
                        case float n when (n < 60.0f):
                            {
                                lblGrade.Text = "F";
                                break;
                            }
                    }
                }
                else
                {
                    lblquestion.Text = "#" + Convert.ToString(midterm.questionNumber + 1) + " of " + Convert.ToString(midterm.questionsInGame) + ": " + midterm.Get_Question(midterm.randomOrder[midterm.questionNumber]);
                    Random random = new Random();
                    int result;

                    if (midterm.questiontype[midterm.randomOrder[midterm.questionNumber]] == Midterm.QuestionType.MultipleChoice)
                    {
                        result = random.Next(0, 4);

                        if (result == 0)
                        {
                            lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                    lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                    lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                    lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                    lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                    lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                    lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 1)
                        {
                            lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                    lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                    lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                    lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                    lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                    lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                    lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 2)
                        {
                            lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                    lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                    lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                    lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                    lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                    lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                    lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                }
                            }
                        }
                        /////////////////////////////////////////////////////////////////////////////////
                        else if (result == 3)
                        {
                            lblD.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 0];

                            result = random.Next(0, 2);

                            if (result == 0)
                            {
                                lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                    lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                    lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                }
                            }
                            else if (result == 1)
                            {
                                lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                    lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                    lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                }
                            }
                            else if (result == 2)
                            {
                                lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];

                                result = random.Next(0, 1);

                                if (result == 0)
                                {
                                    lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                    lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                }
                                else if (result == 1)
                                {
                                    lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 3];
                                    lblC.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 2];
                                }
                            }
                        }
                    }
                    else if (midterm.questiontype[midterm.randomOrder[midterm.questionNumber]] == Midterm.QuestionType.TrueOrFalse)
                    {
                        result = random.Next(0, 2);

                        if (result == 0)
                        {
                            lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 0];
                            lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                        else if (result == 1)
                        {
                            lblA.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 1];
                            lblB.Text = midterm.answer[midterm.randomOrder[midterm.questionNumber], 0];
                            lblC.Text = string.Empty;
                            lblD.Text = string.Empty;
                        }
                    }
                }
            }
        }
            private void timer2_Tick(object sender, EventArgs e)
        {
            if (chapter1game == true)
            {
                chapter1.seconds -= 1;

                if (chapter1.seconds < 0)
                {
                    if (chapter1.minutes > 0)
                    {
                        chapter1.minutes -= 1;
                        chapter1.seconds = 59;
                    }
                    else
                    {
                        if (soundEnabled == true)
                        {
                            wrong_voice = new SourceVoice(xaudio, wrong_waveFormat, true);
                            wrong_voice.SubmitSourceBuffer(wrong_buffer, wrong_soundstream.DecodedPacketsInfo);
                            wrong_voice.Start();
                        }

                        chapter1.minutes = 0;
                        chapter1.seconds = 0;
                        lblTimeOut.Visible = true;
                        locklabels = true;
                        pnlGrade.Visible = true;
                        timer2.Enabled = false;
                        timer3.Enabled = true;
                        lblCorrect.Text = Convert.ToString(chapter1.score);
                        lblIncorrect.Text = Convert.ToString(chapter1.antiScore);
                        
                        float grade = Convert.ToSingle(Decimal.Divide(chapter1.score, chapter1.questionsInGame)) * 100.0f;

                        switch (grade)
                        {
                            case float n when (n >= 90.0f):
                                {
                                    lblGrade.Text = "A";
                                    break;
                                }
                            case float n when (n >= 80.0f && n < 90.0f):
                                {
                                    lblGrade.Text = "B";
                                    break;
                                }
                            case float n when (n >= 70.0f && n < 80.0f):
                                {
                                    lblGrade.Text = "C";
                                    break;
                                }
                            case float n when (n >= 60.0f && n < 70.0f):
                                {
                                    lblGrade.Text = "D";
                                    break;
                                }
                            case float n when (n < 60.0f):
                                {
                                    lblGrade.Text = "F";
                                    break;
                                }
                        }
                    }
                }
                lbltime.Text = "Time: " + chapter1.minutes.ToString().PadLeft(2, '0') + ":" + chapter1.seconds.ToString().PadLeft(2, '0');
            }
            else if (chapter2game == true)
            {
                chapter2.seconds -= 1;

                if (chapter2.seconds < 0)
                {
                    if (chapter2.minutes > 0)
                    {
                        chapter2.minutes -= 1;
                        chapter2.seconds = 59;
                    }
                    else
                    {
                        if (soundEnabled == true)
                        {
                            wrong_voice = new SourceVoice(xaudio, wrong_waveFormat, true);
                            wrong_voice.SubmitSourceBuffer(wrong_buffer, wrong_soundstream.DecodedPacketsInfo);
                            wrong_voice.Start();
                        }

                        chapter2.minutes = 0;
                        chapter2.seconds = 0;
                        lblTimeOut.Visible = true;
                        locklabels = true;
                        pnlGrade.Visible = true;
                        timer2.Enabled = false;
                        timer3.Enabled = true;
                        lblCorrect.Text = Convert.ToString(chapter2.score);
                        lblIncorrect.Text = Convert.ToString(chapter2.antiScore);

                        float grade = Convert.ToSingle(Decimal.Divide(chapter2.score, chapter2.questionsInGame)) * 100.0f;

                        switch (grade)
                        {
                            case float n when (n >= 90.0f):
                                {
                                    lblGrade.Text = "A";
                                    break;
                                }
                            case float n when (n >= 80.0f && n < 90.0f):
                                {
                                    lblGrade.Text = "B";
                                    break;
                                }
                            case float n when (n >= 70.0f && n < 80.0f):
                                {
                                    lblGrade.Text = "C";
                                    break;
                                }
                            case float n when (n >= 60.0f && n < 70.0f):
                                {
                                    lblGrade.Text = "D";
                                    break;
                                }
                            case float n when (n < 60.0f):
                                {
                                    lblGrade.Text = "F";
                                    break;
                                }
                        }
                    }
                }
                lbltime.Text = "Time: " + chapter2.minutes.ToString().PadLeft(2, '0') + ":" + chapter2.seconds.ToString().PadLeft(2, '0');
            }
            else if (chapter3game == true)
            {
                chapter3.seconds -= 1;

                if (chapter3.seconds < 0)
                {
                    if (chapter3.minutes > 0)
                    {
                        chapter3.minutes -= 1;
                        chapter3.seconds = 59;
                    }
                    else
                    {
                        if (soundEnabled == true)
                        {
                            wrong_voice = new SourceVoice(xaudio, wrong_waveFormat, true);
                            wrong_voice.SubmitSourceBuffer(wrong_buffer, wrong_soundstream.DecodedPacketsInfo);
                            wrong_voice.Start();
                        }

                        chapter3.minutes = 0;
                        chapter3.seconds = 0;
                        lblTimeOut.Visible = true;
                        locklabels = true;
                        pnlGrade.Visible = true;
                        timer2.Enabled = false;
                        timer3.Enabled = true;
                        lblCorrect.Text = Convert.ToString(chapter3.score);
                        lblIncorrect.Text = Convert.ToString(chapter3.antiScore);

                        float grade = Convert.ToSingle(Decimal.Divide(chapter3.score, chapter3.questionsInGame)) * 100.0f;

                        switch (grade)
                        {
                            case float n when (n >= 90.0f):
                                {
                                    lblGrade.Text = "A";
                                    break;
                                }
                            case float n when (n >= 80.0f && n < 90.0f):
                                {
                                    lblGrade.Text = "B";
                                    break;
                                }
                            case float n when (n >= 70.0f && n < 80.0f):
                                {
                                    lblGrade.Text = "C";
                                    break;
                                }
                            case float n when (n >= 60.0f && n < 70.0f):
                                {
                                    lblGrade.Text = "D";
                                    break;
                                }
                            case float n when (n < 60.0f):
                                {
                                    lblGrade.Text = "F";
                                    break;
                                }
                        }
                    }
                }
                lbltime.Text = "Time: " + chapter3.minutes.ToString().PadLeft(2, '0') + ":" + chapter3.seconds.ToString().PadLeft(2, '0');
            }
            else if (chapter6game == true)
            {
                chapter6.seconds -= 1;

                if (chapter6.seconds < 0)
                {
                    if (chapter6.minutes > 0)
                    {
                        chapter6.minutes -= 1;
                        chapter6.seconds = 59;
                    }
                    else
                    {
                        if (soundEnabled == true)
                        {
                            wrong_voice = new SourceVoice(xaudio, wrong_waveFormat, true);
                            wrong_voice.SubmitSourceBuffer(wrong_buffer, wrong_soundstream.DecodedPacketsInfo);
                            wrong_voice.Start();
                        }

                        chapter6.minutes = 0;
                        chapter6.seconds = 0;
                        lblTimeOut.Visible = true;
                        locklabels = true;
                        pnlGrade.Visible = true;
                        timer2.Enabled = false;
                        timer3.Enabled = true;
                        lblCorrect.Text = Convert.ToString(chapter6.score);
                        lblIncorrect.Text = Convert.ToString(chapter6.antiScore);

                        float grade = Convert.ToSingle(Decimal.Divide(chapter6.score, chapter6.questionsInGame)) * 100.0f;

                        switch (grade)
                        {
                            case float n when (n >= 90.0f):
                                {
                                    lblGrade.Text = "A";
                                    break;
                                }
                            case float n when (n >= 80.0f && n < 90.0f):
                                {
                                    lblGrade.Text = "B";
                                    break;
                                }
                            case float n when (n >= 70.0f && n < 80.0f):
                                {
                                    lblGrade.Text = "C";
                                    break;
                                }
                            case float n when (n >= 60.0f && n < 70.0f):
                                {
                                    lblGrade.Text = "D";
                                    break;
                                }
                            case float n when (n < 60.0f):
                                {
                                    lblGrade.Text = "F";
                                    break;
                                }
                        }
                    }
                }
                lbltime.Text = "Time: " + chapter6.minutes.ToString().PadLeft(2, '0') + ":" + chapter6.seconds.ToString().PadLeft(2, '0');
            }
            else if (chapter7game == true)
            {
                chapter7.seconds -= 1;

                if (chapter7.seconds < 0)
                {
                    if (chapter7.minutes > 0)
                    {
                        chapter7.minutes -= 1;
                        chapter7.seconds = 59;
                    }
                    else
                    {
                        if (soundEnabled == true)
                        {
                            wrong_voice = new SourceVoice(xaudio, wrong_waveFormat, true);
                            wrong_voice.SubmitSourceBuffer(wrong_buffer, wrong_soundstream.DecodedPacketsInfo);
                            wrong_voice.Start();
                        }

                        chapter7.minutes = 0;
                        chapter7.seconds = 0;
                        lblTimeOut.Visible = true;
                        locklabels = true;
                        pnlGrade.Visible = true;
                        timer2.Enabled = false;
                        timer3.Enabled = true;
                        lblCorrect.Text = Convert.ToString(chapter7.score);
                        lblIncorrect.Text = Convert.ToString(chapter7.antiScore);

                        float grade = Convert.ToSingle(Decimal.Divide(chapter7.score, chapter7.questionsInGame)) * 100.0f;

                        switch (grade)
                        {
                            case float n when (n >= 90.0f):
                                {
                                    lblGrade.Text = "A";
                                    break;
                                }
                            case float n when (n >= 80.0f && n < 90.0f):
                                {
                                    lblGrade.Text = "B";
                                    break;
                                }
                            case float n when (n >= 70.0f && n < 80.0f):
                                {
                                    lblGrade.Text = "C";
                                    break;
                                }
                            case float n when (n >= 60.0f && n < 70.0f):
                                {
                                    lblGrade.Text = "D";
                                    break;
                                }
                            case float n when (n < 60.0f):
                                {
                                    lblGrade.Text = "F";
                                    break;
                                }
                        }
                    }
                }
                lbltime.Text = "Time: " + chapter7.minutes.ToString().PadLeft(2, '0') + ":" + chapter7.seconds.ToString().PadLeft(2, '0');
            }
            else if (chapter8game == true)
            {
                chapter8.seconds -= 1;

                if (chapter8.seconds < 0)
                {
                    if (chapter8.minutes > 0)
                    {
                        chapter8.minutes -= 1;
                        chapter8.seconds = 59;
                    }
                    else
                    {
                        if (soundEnabled == true)
                        {
                            wrong_voice = new SourceVoice(xaudio, wrong_waveFormat, true);
                            wrong_voice.SubmitSourceBuffer(wrong_buffer, wrong_soundstream.DecodedPacketsInfo);
                            wrong_voice.Start();
                        }

                        chapter8.minutes = 0;
                        chapter8.seconds = 0;
                        lblTimeOut.Visible = true;
                        locklabels = true;
                        pnlGrade.Visible = true;
                        timer2.Enabled = false;
                        timer3.Enabled = true;
                        lblCorrect.Text = Convert.ToString(chapter8.score);
                        lblIncorrect.Text = Convert.ToString(chapter8.antiScore);

                        float grade = Convert.ToSingle(Decimal.Divide(chapter8.score, chapter8.questionsInGame)) * 100.0f;

                        switch (grade)
                        {
                            case float n when (n >= 90.0f):
                                {
                                    lblGrade.Text = "A";
                                    break;
                                }
                            case float n when (n >= 80.0f && n < 90.0f):
                                {
                                    lblGrade.Text = "B";
                                    break;
                                }
                            case float n when (n >= 70.0f && n < 80.0f):
                                {
                                    lblGrade.Text = "C";
                                    break;
                                }
                            case float n when (n >= 60.0f && n < 70.0f):
                                {
                                    lblGrade.Text = "D";
                                    break;
                                }
                            case float n when (n < 60.0f):
                                {
                                    lblGrade.Text = "F";
                                    break;
                                }
                        }
                    }
                }
                lbltime.Text = "Time: " + chapter8.minutes.ToString().PadLeft(2, '0') + ":" + chapter8.seconds.ToString().PadLeft(2, '0');
            }
            else if (chapter9game == true)
            {
                chapter9.seconds -= 1;

                if (chapter9.seconds < 0)
                {
                    if (chapter9.minutes > 0)
                    {
                        chapter9.minutes -= 1;
                        chapter9.seconds = 59;
                    }
                    else
                    {
                        if (soundEnabled == true)
                        {
                            wrong_voice = new SourceVoice(xaudio, wrong_waveFormat, true);
                            wrong_voice.SubmitSourceBuffer(wrong_buffer, wrong_soundstream.DecodedPacketsInfo);
                            wrong_voice.Start();
                        }

                        chapter9.minutes = 0;
                        chapter9.seconds = 0;
                        lblTimeOut.Visible = true;
                        locklabels = true;
                        pnlGrade.Visible = true;
                        timer2.Enabled = false;
                        timer3.Enabled = true;
                        lblCorrect.Text = Convert.ToString(chapter9.score);
                        lblIncorrect.Text = Convert.ToString(chapter9.antiScore);

                        float grade = Convert.ToSingle(Decimal.Divide(chapter9.score, chapter9.questionsInGame)) * 100.0f;

                        switch (grade)
                        {
                            case float n when (n >= 90.0f):
                                {
                                    lblGrade.Text = "A";
                                    break;
                                }
                            case float n when (n >= 80.0f && n < 90.0f):
                                {
                                    lblGrade.Text = "B";
                                    break;
                                }
                            case float n when (n >= 70.0f && n < 80.0f):
                                {
                                    lblGrade.Text = "C";
                                    break;
                                }
                            case float n when (n >= 60.0f && n < 70.0f):
                                {
                                    lblGrade.Text = "D";
                                    break;
                                }
                            case float n when (n < 60.0f):
                                {
                                    lblGrade.Text = "F";
                                    break;
                                }
                        }
                    }
                }
                lbltime.Text = "Time: " + chapter9.minutes.ToString().PadLeft(2, '0') + ":" + chapter9.seconds.ToString().PadLeft(2, '0');
            }
            else if (midtermgame == true)
            {
                midterm.seconds -= 1;

                if (midterm.seconds < 0)
                {
                    if (midterm.minutes > 0)
                    {
                        midterm.minutes -= 1;
                        midterm.seconds = 59;
                    }
                    else
                    {
                        if (soundEnabled == true)
                        {
                            wrong_voice = new SourceVoice(xaudio, wrong_waveFormat, true);
                            wrong_voice.SubmitSourceBuffer(wrong_buffer, wrong_soundstream.DecodedPacketsInfo);
                            wrong_voice.Start();
                        }

                        midterm.minutes = 0;
                        midterm.seconds = 0;
                        lblTimeOut.Visible = true;
                        locklabels = true;
                        pnlGrade.Visible = true;
                        timer2.Enabled = false;
                        timer3.Enabled = true;
                        lblCorrect.Text = Convert.ToString(midterm.score);
                        lblIncorrect.Text = Convert.ToString(midterm.antiScore);

                        float grade = Convert.ToSingle(Decimal.Divide(midterm.score, midterm.questionsInGame)) * 100.0f;

                        switch (grade)
                        {
                            case float n when (n >= 90.0f):
                                {
                                    lblGrade.Text = "A";
                                    break;
                                }
                            case float n when (n >= 80.0f && n < 90.0f):
                                {
                                    lblGrade.Text = "B";
                                    break;
                                }
                            case float n when (n >= 70.0f && n < 80.0f):
                                {
                                    lblGrade.Text = "C";
                                    break;
                                }
                            case float n when (n >= 60.0f && n < 70.0f):
                                {
                                    lblGrade.Text = "D";
                                    break;
                                }
                            case float n when (n < 60.0f):
                                {
                                    lblGrade.Text = "F";
                                    break;
                                }
                        }
                    }
                }
                lbltime.Text = "Time: " + midterm.minutes.ToString().PadLeft(2, '0') + ":" + midterm.seconds.ToString().PadLeft(2, '0');
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            chapter1game = false;
            chapter2game = false;
            chapter3game = false;
            chapter6game = false;
            chapter7game = false;
            chapter8game = false;
            chapter9game = false;
            midtermgame = false;
            chapter1.questionNumber = 0;
            chapter2.questionNumber = 0;
            chapter3.questionNumber = 0;
            chapter6.questionNumber = 0;
            chapter7.questionNumber = 0;
            chapter8.questionNumber = 0;
            chapter9.questionNumber = 0;
            midterm.questionNumber = 0;
            pnlgame.Visible = false;
            panelchapters.Visible = true;
            locklabels = false;
            pnlGrade.Visible = false;
            timer3.Enabled = false;
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (pnlgame.Visible == true && pnlGrade.Visible == false)
                {
                    if (chapter1game == true || chapter2game == true || chapter3game == true || chapter6game == true || chapter7game == true || chapter8game == true || chapter9game == true || midtermgame == true)
                    {
                        chapter1game = false;
                        chapter2game = false;
                        chapter3game = false;
                        chapter6game = false;
                        chapter7game = false;
                        chapter8game = false;
                        chapter9game = false;
                        midtermgame = false;
                        chapter1.questionNumber = 0;
                        chapter2.questionNumber = 0;
                        chapter3.questionNumber = 0;
                        chapter6.questionNumber = 0;
                        chapter7.questionNumber = 0;
                        chapter8.questionNumber = 0;
                        chapter9.questionNumber = 0;
                        midterm.questionNumber = 0;
                        pnlgame.Visible = false;
                        panelchapters.Visible = true;
                        locklabels = false;
                        pnlGrade.Visible = false;
                        timer1.Enabled = false;
                        timer2.Enabled = false;
                        timer3.Enabled = false;
                        lblCorrectMessage.Visible = false;
                        lblWrong.Visible = false;
                        lblTimeOut.Visible = false;
                        lblA.ForeColor = Color.FromArgb(255, 255, 255);
                        lblB.ForeColor = Color.FromArgb(255, 255, 255);
                        lblC.ForeColor = Color.FromArgb(255, 255, 255);
                        lblD.ForeColor = Color.FromArgb(255, 255, 255);
                    }
                }
            }
        }
    }
}
