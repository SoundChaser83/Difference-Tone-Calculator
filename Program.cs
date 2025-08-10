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

Console.WriteLine("Which source notes should be played? Separate source numbers by spaces.");

string noteInput = Console.ReadLine();
noteInput = noteInput.Trim();
foreach (string str in noteInput.Split(" "))
{
    sourceList.Add(int.Parse(str));
}

for (int i = 0; i < sourceList.Count; i++) {
    for (int j = 0; j < harmonicList.Count; j++) {
        Note note = new Note(sourceList[i], harmonicList[j]);
        noteList.Add(note);
    }
}

// Source = inputted root notes
// Harmonic = inputted harmonics
// Note = stores a source note and all mappings of it times harmonics
// Difference = Absolute value of harmonic mapping - harmonic mapping, excludes own source note and previous source notes

for (int i = 0; i < noteList.Count; i++) {
    for (int j = i + 1; j < noteList.Count; j++) { // Start the inner loop at i + 1 to avoid duplicate comparisons
        Note fromNote = noteList[i];
        Note toNote = noteList[j];

        if (fromNote.Source != toNote.Source) { // Ensure the sources are different
            DifferenceRelation diff = new DifferenceRelation(
                fromNote,
                toNote,
                Math.Abs(fromNote.Mapping - toNote.Mapping)
            );
            differenceList.Add(diff);
        }
    }
}

List<DifferenceRelation> sortedDiffs = differenceList.OrderBy(diff => diff.Difference).ToList();

foreach (var difference in sortedDiffs)
{
    Console.WriteLine($"Difference {difference.Difference} [From: source {difference.From.Source}, harmonic {difference.From.Harmonic} | To: source {difference.To.Source}, harmonic {difference.To.Harmonic}]");
}

Console.WriteLine($"\nTotal differences: {sortedDiffs.Count}");