using ImSuperSir.Patterns;
using ImSuperSir.Samples.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImSuperSir.Samples
{
    public static class SampleRunnableFactory
    {
        public static IPatternSampleRunnable GetInstance(PatternsTypes pPatternsTypes)
        {
            IPatternSampleRunnable lPatternRunnable = null;


            switch (pPatternsTypes)
            {
                case PatternsTypes.PatternFactory:
                    lPatternRunnable = FactoryPattern<IPatternSampleRunnable, FactoryPatternSample>.GetInstance();
                    break;
                case PatternsTypes.PatternSingleton:
                    break;
                default:
                    break;
            }
            if (lPatternRunnable == null)
            {
                throw new Exception($"No existe la implementacion del patron: { pPatternsTypes.ToString() }");
            }


            return lPatternRunnable;
        }
    }
}
