﻿using NAudio.Midi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    class MusicalNotation
    {
        public int NoteNumber;

        public int Duration;

        protected MidiOut midi;
        public virtual void Play()
        {
            System.Threading.Thread.Sleep(Duration * 100);

        }
 

    }
}
