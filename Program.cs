using Difference_Tone_Calculator;

List<int> harmonicList = new List<int>();
List<int> sourceList = new List<int>();
List<Note> noteList = new List<Note>();
List<DifferenceRelation> differenceList = new List<DifferenceRelation>();

Console.WriteLine("Which harmonics should be present? Separate harmonic numbers by spaces.");

string harmonicInput = Console.ReadLine();
harmonicInput = harmonicInput.Trim();
foreach (string str in harmonicInput.Split(" "))
{
    harmonicList.Add(int.Parse(str));
}

Console.WriteLine(harmonicList.Count);

Console.WriteLine("Which notes should be played? Separate note numbers by spaces.");

string noteInput = Console.ReadLine();
noteInput = noteInput.Trim();
foreach (string str in noteInput.Split(" "))
{
    sourceList.Add(int.Parse(str));
}

Console.WriteLine(sourceList.Count);

foreach (int source in sourceList)
{
    Note note = new Note(source, harmonicList);
    noteList.Add(note);
    Console.WriteLine($"Source: {note.Source}");
    foreach (int mapping in note.HarmonicMappings)
    {
        Console.WriteLine(mapping);
    }
    Console.WriteLine();
}

for (int i = 0; i < sourceList.Count - 1; i++)
{
    for (int k = 0; k < noteList[i].HarmonicMappings.Count; k++)
    {
        for (int j = 0; j < noteList[i].HarmonicMappings.Count; j++)
        {
            differenceList.Add(new DifferenceRelation(noteList[i].HarmonicMappings[j], noteList[i].HarmonicMappings[k], Math.Abs(noteList[i].HarmonicMappings[j] - noteList[i].HarmonicMappings[k])));
        }
    }
    

    
}

foreach (var difference in differenceList)
{
    Console.WriteLine($"{difference.Difference} - from: source {difference.Source}, harmonic {difference.Harmonic}");
}