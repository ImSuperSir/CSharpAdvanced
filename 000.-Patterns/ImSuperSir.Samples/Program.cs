namespace ImSuperSir.Samples.Samples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Esta linea ejecutará el ejemplo de el patron factoria
            try
            {
                SampleRunnableFactory.GetInstance(PatternsTypes.PatternFactory).Run();


                SampleRunnableFactory.GetInstance(PatternsTypes.PatternSingleton).Run();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }




    }
}
