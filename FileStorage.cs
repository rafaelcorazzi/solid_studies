public class FileStorage
{
    public FileStorage(string workingDirectory)
    {
        if (workingDirectory == null)
            throw new ArgumentNullException("is null"); 
            
        this.WorkingDirectory = workingDirectory;
    }
    public string WorkingDirectory {get;private set;}
    public string Save(int id, string message)
    {
        var path = this.GetFileName(id);
        File.WriteAllText(path, message);
        return path;

    }
    public void Read(int id)
    {

        var path = this.GetFileName(id);
        if (!File.Exists(path))
            return new Maybe<string>();

        var msg = File.ReadAllText(path);
        return new Maybe<string>(msg);
    }

    public string GetFileName(int id){
        return Path.Combine(this.WorkingDirectory, $"{id}.txt");
    }
}