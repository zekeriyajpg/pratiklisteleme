using pratiklisteleme;

MyList<string> davetliler = new MyList<string>();
davetliler.Add("Hülya Koçyiğit");
davetliler.Add("Zekeriya palabıyık");
davetliler.Add("Hakan Altun");
davetliler.Add("Zeki Müren");

Console.WriteLine("!!! DAVETLİLER !!!");

for  (int i = 0; i < davetliler.Count; i++)
{
    Console.WriteLine($"{i+1} - {davetliler[i]}");
}