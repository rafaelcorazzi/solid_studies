public class FileStorage
{
    public string WorkingDirectory {get;set;}
    public string Save(int id, string message)
    {
        var path = this.GetFileName(id);
        File.WriteAllText(path, message);
        return path;

    }
    public void Read(int id)
    {
        var path = this.GetFileName(id);
        var msg = File.ReadAllText(path);
        return msg;
    }

    public string GetFileName(int id){
        return Path.Combine(this.WorkingDirectory, $"{id}.txt");
    }
}