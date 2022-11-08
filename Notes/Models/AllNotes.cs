using System.Collections.ObjectModel;

namespace Notes.Models
{
    internal class AllNotes
    {

        public ObservableCollection<Note> Notes { get; set; } = new ObservableCollection<Note>();

        public AllNotes() =>
            LoadNotes();

        public void LoadNotes()
        {
            Notes.Clear();

            // Caminho do diretorio das notas
            string appDataPath = FileSystem.AppDataDirectory;

            // Carrega todas as notas no diretorio
            IEnumerable<Note> notes = Directory
                                        .EnumerateFiles(appDataPath, "*.notes.txt")
                                        .Select(filename => new Note()
                                        {
                                            Filename = filename,
                                            Text = File.ReadAllText(filename),
                                            Date = File.GetCreationTime(filename)
                                        })
                                        .OrderBy(note => note.Date);

            // Adiciona as notas na coleção ObservableCollection
            foreach (Note note in notes)
                Notes.Add(note);
        }
    }
}
