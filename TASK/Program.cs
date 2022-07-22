string[]String={"Hello", "2", "world", ";)"};
for (int i = 0; i < String.Length; i++)
{
    int n=0;
    if (String[i].Length <= 3)
    {
       String[n]=String[i];
       Console.Write("'");
       Console.WriteLine(String[n]+ "'");
       Console.Write(" ");
       n++;
    }
}