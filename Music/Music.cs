
using NAudio.Midi;
namespace Music
{
    class Music
    {

        

        List<MusicalNotation> Notes = new List<MusicalNotation>();
        public void Play()
        {
            Console.WriteLine($"Playing...");
            foreach (MusicalNotation n in Notes)
            {
                n.Play();
            }
        }

        public string[] lineArr = new string[2];
        public string[][] NoteArr = new string[2][];
       

        public Music(string Filename, MidiOut midi)
        {
            Console.WriteLine($"Loading file from {Filename}");
            foreach (string line in File.ReadAllLines(Filename))
            {
                

                Console.WriteLine(line);
                
                lineArr = line.Split(',');

                for (int t=0; t<lineArr.Length; t++)
                {
                    NoteArr[t] = lineArr[t].Split(" ");
                }
                
                    


                for (int n = 0; n < NoteArr.Length; n++)
                {
                    if (NoteArr[n][0] == "00")
                    {
                        Notes.Add(new Rest(int.Parse(NoteArr[n][1])));
                    }
                    else if (int.Parse(NoteArr[n][0]) > 21)
                    {
                        Notes.Add(new Note(int.Parse(NoteArr[n][0]), int.Parse(NoteArr[n][1]), midi));
                    }
                }






            }

        }
    }
}