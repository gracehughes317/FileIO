using System;
using System.IO;

public class DataFile
{
    private string winDir;
    private List<int> lines;

    public DataFile() {
        lines = new List<int>();
        winDir = System.Environment.GetEnvironmentVariable("windir");
    }
    private void addItem(String value){
        lines.add(Integer.parseInt(value));
    }
    private List<int> getList(String name){
        StreamReader reader = new StreamReader(winDir + name);
        try
        {
            do
            {
                addItem(reader.ReadLine());
            }
            while (reader.Peek() != -1);
        }

        catch
        {
            Console.WriteLine("File is empty");
        }

        finally
        {
            reader.Close();
        }
        return lines;
    }

}
