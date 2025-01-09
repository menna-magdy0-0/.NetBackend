namespace Task6
{
    internal class Program
    {
        delegate void Del1();
        static void Main(string[] args)
        {
            Del1 o1=new Del1 (Employee.add);
            o1 += Club.addinclub;
            o1 += Socialensurance.beingSocialensurance;
            o1?.Invoke();
        }
    }
}
