using System;
using System.Collections.Generic;
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
        lines.Add(int.Parse(value));
    }
    public List<int> GetList(){
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
