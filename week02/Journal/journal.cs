using System.Security.Cryptography.X509Certificates;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry( Entry entry)
    {
        _entries.Add(entry);

    }
    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("There are no entries in your journal");
            return;

        }
        foreach (Entry entry in _entries)
        {
            entry.Display();

        }
    }
    public void SaveToFile(string filename)
    {
        try
        {

            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine($"{entry._date}| {entry._prompt}| {entry._response}");
                }
            }
            Console.WriteLine("Journal saved Successfully.");

        }
        catch(UnauthorizedAccessException)
        {
            Console.WriteLine("You do not have permission to access this file");
        }
        catch(IOException)
        {
            Console.WriteLine("There was a problem saving the journal");
        }
    }
    public void LoadFromFile(string filename)
    {
        try{

            _entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split ('|');
                    if (parts.Length >= 3)
                    {
                        Entry entry = new Entry(
                            parts[0],
                            parts[1],
                            parts[2]
                        );
                        _entries.Add(entry);
                    }
                }
            }
            Console.WriteLine("Journal loaded Succesfully");
        }
        catch(FileNotFoundException)
        {
            Console.WriteLine("The file could not be found");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You do not have permission to access this file");
        }
        catch (IOException)
        {
            Console.WriteLine("There was a problem reading the file");
        }
    }
}