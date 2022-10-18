
using NAudio.Midi;
namespace Music
{
    class Music
    {

        

        List<Note> Notes = new List<Note>();
        public void Play()
        {
            Console.WriteLine($"Playing...");
            foreach (Note n in Notes)
            {
                n.Play();
            }
        }

        public Music(string Filename)
        {
            Console.WriteLine($"Loading file from {Filename}");
            foreach (string line in File.ReadAllLines(Filename))
            {
                string[] lineArr = new string[3];

                Console.WriteLine(line);
                lineArr = line.Split(" ");

                Notes.Add(new Note(int.Parse(lineArr[0]), int.Parse(lineArr[1])));

            }

        }
    }
}