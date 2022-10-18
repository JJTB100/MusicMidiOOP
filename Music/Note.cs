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
        public Note(int notenum, int volume)
        {
            NoteNumber = notenum; 
            Volume = volume;
        }

        public int NoteNumber;
        
        public int Volume;
        public override void Play()
        {
            NoteOn noteOn = new NoteOn(this);
            NoteOff noteOff = new NoteOff(this);    
            noteOn.Send();
            noteOff.Send();
        }
    }
}
