using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using CSharpCollections1;


#region Task_1

//Arrays for demonstration:
int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] arr3 = new int[] { 15, 13, 12, 9, 7, 5, 3, 6 };
int[] arr4 = new int[] { 12, 99, 9, 3, 4, 0, 999932};

//odd sort Array:
ExtractItemsByMod(arr4, 1);

//even sort Array:
ExtractItemsByMod(arr4, 0);

static int[] ExtractItemsByMod(int[] someArr, int mask)
{
    int[] extraArr = new int[someArr.Length];
    int count = 0;
    for (int i = 0; i < someArr.Length; i++)
    {
        if (someArr[i] % 2 == mask)
        {
            extraArr[count] = someArr[i];
            count++;
        }
    }
    var outArr = new int[count];
    Array.Copy(extraArr, 0, outArr, 0, count);
    Array.Sort(outArr);
    return outArr;
}

#endregion

#region Task_2

double[] arr2 = new double[10] { 199, 2, 9, 1.78, 7, 89, 1, 10.99, 970, 6 };

GetDifference(arr2);

static double GetDifference(double[] someArr)
{
    double diff = 0;
    double maxValue = int.MinValue;
    double minValue = int.MaxValue;

    for (int i = 0; i < someArr.Length; i++)
    {
        if (someArr[i] > maxValue)
        {
            maxValue = someArr[i];
        }

        if (someArr[i] < minValue)
        {
            minValue = someArr[i];
        }
    }
    diff = maxValue - minValue;

    return diff;
}

#endregion

#region Task_3

var people = new List<string>()
{
    "Felch",
    "Biffle",
    "Youtz",
    "Kitelinger",
    "Goleman",
    "Wisener",
    "Lakin",
    "Malich",
    "Easterlin",
    "Ridlehoover",
    "Strome",
    "Pershing"
};

people.Sort();

foreach (var person in people)
{
    Console.WriteLine(person);
}

#endregion

#region Task_4

var citizens = new List<Citizen>()
{
    new Citizen("Ilon","Mask","Putpurovich", "Canaletto", "12", new DateTime(2008, 5, 1)),
    new Citizen("Tor","Toric","Torchinski", "Stanisław Małachowski", "1", new DateTime(1990, 10, 11)),
    new Citizen("Kokuliy","Rick","Pukovich", "the Ossolinski family", "7", new DateTime(2000, 8, 21)),
    new Citizen("Olenna","Lanicter","Sonovna", "Stefan Wiechecki", "100", new DateTime(1998, 2, 13)),
    new Citizen("Judo","Tusklo","Tamarovich", "Julian Tuwim", "93", new DateTime(2005, 4, 10)),
    new Citizen("Sonic","Tractor","Alexeevna", "Romuald Traugutt", "322", new DateTime(2020, 1, 30)),
    new Citizen("Molly","Tractor","Sonicovna", "Romuald Traugutt", "322", new DateTime(2001, 2, 15)),
    new Citizen("Poka","Tractor","Babayavna", "Romuald Traugutt", "322", new DateTime(1990, 9, 3)),
    new Citizen("Number","Pi","Luludovich", "Romuald Traugutt", "302", new DateTime(1979, 12, 8))
};

Console.WriteLine("Enter the street of the voters:");
var streetV = Console.ReadLine();

var voters = new List<Citizen>();

foreach (var c in citizens)
{
    if (c.CanVote() && c.Street == streetV)
    {
        voters.Add(c);
    }
}

voters.Sort();

Console.WriteLine("List of voters:");

foreach (var v in voters)
{
    v.PrintInfo();
}

#endregion

#region Task_5

//Comments to fill in the console
//Belarus : Minsk
//Canada : Ottawa
//Czech : Prague
//Portugal : Lisbon
//Greece : Athens

char dotters = ':';
int numInputs = 5;

Dictionary<string, string> geofraphy = new Dictionary<string, string>();

for (int i = 0; i < numInputs; i++)
{
    Console.WriteLine("Enter the Country and Capital (Country : Capital)");
    var geoLine = Console.ReadLine();
    int indexDot = geoLine.IndexOf(dotters);
    geofraphy.Add(geoLine.Substring(0, indexDot - 1), geoLine.Substring(indexDot + 2));
}

Dictionary<string, string>  inverseGeofraphy = new Dictionary<string, string>();

foreach (var place in geofraphy)
{
    inverseGeofraphy.Add(place.Value, place.Key);
}

Console.WriteLine("Countries and capitals (Sourse Dictionary):");
PrintDictionary(geofraphy);

Console.WriteLine("Countries and capitals (Result Dictionary):");
PrintDictionary(inverseGeofraphy);

static void PrintDictionary(Dictionary<string,string> someDict)
{
    foreach (var place in someDict)
    {
        Console.WriteLine($"key: {place.Key}  value: {place.Value}");
    }
}

#endregion

Console.ReadLine();