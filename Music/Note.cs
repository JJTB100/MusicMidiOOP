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
        public Note(int notenum, int duration, MidiOut midi)
        {
            NoteNumber = notenum;
            Duration = duration;
            base.midi = midi;
        }

        public override void Play()
        {
            NoteOn noteOn = new NoteOn(this);
            NoteOff noteOff = new NoteOff(this);    
            noteOn.Send(midi);
            System.Threading.Thread.Sleep(Duration * 200);
            noteOff.Send(midi);
        }
    }
}
