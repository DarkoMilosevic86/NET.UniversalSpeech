using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NET.UniversalSpeech;

namespace TextEditor
{
    public partial class TextEditor : Form
    {
        UniversalSpeech us;
        public TextEditor()
        {
            InitializeComponent();
            us = new UniversalSpeech();
        }

        private void Document_TextChanged(object sender, EventArgs e)
        {

        }

        private void speech_Speak_Click(object sender, EventArgs e)
        {
            us.SpeechSay(Document.Text, 0);
        }

        private void speech_StopSpeaking_Click(object sender, EventArgs e)
        {
            us.SpeechStop();
        }
    }
}
