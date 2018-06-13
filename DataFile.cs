using System;
using System.IO;

public class DataFile
{
    private string winDir;
    private List<int> lines;
    private string fileName;

    public DataFile(String fN) {
        lines = new List<int>();
        winDir = System.Environment.GetEnvironmentVariable("windir");
        fileName = fN;
    }
    private void addItem(String value){
        lines.add(Integer.parseInt(value));
    }
    private List<int> getList(){
        StreamReader reader = new StreamReader(winDir + fileName);
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
