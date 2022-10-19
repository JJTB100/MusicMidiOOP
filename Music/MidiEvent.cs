using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using NAudio.Midi;


namespace Music
{
    class MidiEvent
    {
        

        // the bytes that are sent as MIDI data
        protected byte[] buffer = new byte[3] { 0, 0, 0};

        // there are 16 channels to choose from. Channel 9 is percussion
        protected int Channel;

        /// <summary>
        /// Send MIDI data
        /// </summary>
        public virtual void Send(MidiOut midi)
        {
            Console.WriteLine("[{0}]", string.Join(", ", buffer));
            midi.SendBuffer(buffer);
            
        }
    }
}
