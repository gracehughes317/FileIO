using System;
using System.IO;

public class DataFile
{
    private string winDir = System.Environment.GetEnvironmentVariable("windir");
    private List<int> lines = new List<int>();

    public DataFile() {

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
            addListItem("File is empty");
        }

        finally
        {
            reader.Close();
        }
        return getList<int>;
    }

}
