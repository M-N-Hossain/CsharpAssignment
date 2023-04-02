namespace Mandatory_1;

public class Teams
{
    public String abbreviation { set; get; }
    public String fullname { set; get; }
    
    
    public Teams(String rowData)
    {
        String[] data = rowData.Split(",");
        this.abbreviation = data[0];
        this.fullname = data[1];
    }
    
    public override string ToString()
    {
        return abbreviation + "\t" +  fullname;
    }
}

