namespace D04
{
    internal class Program
    {
        //Dev01
        //implement the interface
        public static void ProcessSeries(ISeries series)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{series.Current}, ");
                series.GetNext();

            }
            Console.WriteLine("");
            series.Reset();
        }
        static void Main(string[] args)
        {
            #region Interface
            ////Console.WriteLine("Hello, World!");
            //SeriesByTwo series01 = new SeriesByTwo();
            //ProcessSeries(series01);
            //ISeries series02;//valid , reference to any class \struct Implementing ISeries Interface 
            ////series01=new ISeries(); //not valid 
            //series02 = new FebSeries();
            //ProcessSeries(series02); 
            #endregion

        }
    }
}
