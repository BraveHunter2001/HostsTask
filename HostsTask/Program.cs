
using HostsTask;

string[] B = new string[] 
{
    "visitwar",
    "card",
    "microvirus.md",
    "visitwar.de",
    "piratebay.co.uk",
    "list.stolen.credit.card.us"
};

string[] A = new string[]
{
    "unlock.microvirus.md", // 0
    "microvirus.unlock.md", // 1
    "visitwar.com",         // 2
    "visitwar.de",          // 3
    "fruonline.co.uk",      // 4
    "porn.piratebay.co.uk", // 5
    "australia.open.com",   // 6
    "credit.card.us",       // 7
    "yourcard.list.stolen.credit.card.us" //8
};


var res = Solution.solution(A, B);
Console.Write("[");
for(int i = 0; i < res.Length; i++)
{
    Console.Write(res[i]);
    if (i != res.Length - 1) Console.Write(",");

}
Console.WriteLine("]");

Console.ReadLine();