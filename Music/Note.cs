using NAudio.Midi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    class Note : MusicalNotation
    {
        public Note(int notenum, int time, MidiOut midi)
        {
            NoteNumber = notenum;
            Time = time;
            base.midi = midi;
        }

        public override void Play()
        {
            NoteOn noteOn = new NoteOn(this);
            NoteOff noteOff = new NoteOff(this);    
            noteOn.Send(midi);
            System.Threading.Thread.Sleep(Time * 100);
            noteOff.Send(midi);
        }
    }
}
