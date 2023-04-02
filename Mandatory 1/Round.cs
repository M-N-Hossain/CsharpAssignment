namespace Mandatory_1;

public class Round
{
    public String clubName;
    public String m;
    public String w;
    public String d;
    public String l;
    public String gf;
    public String ga;
    public String gd;
    public String pts;


    public Round(String rowData)
    {
        String[] data = rowData.Split(",");
        this.clubName = data[0];
        this.m = data[1];
        this.w = data[2];
        this.d = data[3];
        this.l = data[4];
        this.gf = data[5];
        this.ga = data[6];
        this.gd = data[7];
        this.pts = data[8];
    }
    
    public override string ToString()
    {
        return clubName + "\t\t" + m + w + d + l + gf  + ga + gd + pts;
    }

}