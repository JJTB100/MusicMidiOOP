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
        MidiOut midi;
        public Note(int notenum, int time, MidiOut midi)
        {
            NoteNumber = notenum; 
            Time = time;
            this.midi = midi;
        }

        public int NoteNumber;
        
        public int Time;
        public override void Play()
        {
            NoteOn noteOn = new NoteOn(this);
            NoteOff noteOff = new NoteOff(this);    
            noteOn.Send(midi);
            System.Threading.Thread.Sleep(Time * 1000);
            noteOff.Send(midi);
        }
    }
}
