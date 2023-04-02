// See https://aka.ms/new-console-template for more information


using Mandatory_1;

    // Teams
String filePathForTeam = @"C:\Users\nhnah\CSV\Teams.txt";
List<String> linesOfTeams = File.ReadLines(filePathForTeam).ToList();
List<Teams> teamsList = new List<Teams>();

foreach (String lineOfTeam in linesOfTeams)
{
    Teams team = new Teams(lineOfTeam);
    teamsList.Add(team);
}
Console.WriteLine("The participating teams are: ");
Console.WriteLine("");
Console.WriteLine("Abbreviation \t" + " FullName \n" );
foreach (Teams team in teamsList)
{
    Console.WriteLine(team);
}


//  // Round 1 points table
Console.WriteLine("");
Console.WriteLine("After first round the standings of the teams in the point table");

String filePathForRound1 = @"C:\Users\nhnah\CSV\Round1.txt";
List<String> round1Lines = File.ReadLines(filePathForRound1).ToList();
List<Round> round1PointTable = new List<Round>();

foreach (String line in round1Lines)
{
    Round round1Line = new Round(line);
    round1PointTable.Add(round1Line);
}

Console.WriteLine("");
Console.WriteLine("\tClub\t\t" + " M\t" + "W\t"+ "D\t"+ "L\t"+ "GF\t"+ "GA\t"+ "GD\t"+ "PTS\t");
foreach (Round round1 in round1PointTable)
{
    Console.WriteLine(round1);
}

// Round 2 points table
Console.WriteLine("");
Console.WriteLine("After Second round the standings of the teams in the point table");

String filePathForRound2 = @"C:\Users\nhnah\CSV\Round2.txt";
List<String> round2Lines = File.ReadLines(filePathForRound2).ToList();
List<Round> round2PointTable = new List<Round>();

foreach (String line in round2Lines)
{
    Round round2Line = new Round(line);
    round2PointTable.Add(round2Line);
}

Console.WriteLine("");
Console.WriteLine("\tClub\t\t" + " M\t" + "W\t"+ "D\t"+ "L\t"+ "GF\t"+ "GA\t"+ "GD\t"+ "PTS\t");
foreach (Round round2 in round2PointTable)
{
    Console.WriteLine(round2);
}