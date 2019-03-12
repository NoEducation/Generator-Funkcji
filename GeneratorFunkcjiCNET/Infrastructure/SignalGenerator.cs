using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorFunkcjiCNET.Infrastructure
{
    public static class SignalGenerator
    {
        public static void GeneratingSignalSinus(this Signal target)
        {
            target.SignalValues =(double[])Array.CreateInstance(typeof(double), target.ResolutionPattern);
            for (int i = 0; i < target.ResolutionPattern; i++)
            {
                target.SignalValues[i] = Math.Sin(target._kwant * i);
            }
        }

        public static void GeneratingSignalCosinus(this Signal target)
        {
            target.SignalValues = (double[])Array.CreateInstance(typeof(double), target.ResolutionPattern);
            for (int i = 0; i < target.ResolutionPattern; i++)
            {
                target.SignalValues[i] = Math.Cos(target._kwant * i);
            }
        }
        public static void GeneratingSignalRectangle(this Signal target)
        {
            target.SignalValues = (double[])Array.CreateInstance(typeof(double), target.ResolutionPattern);
           
            for (int i = 0; i < target.ResolutionPattern; i++)
            {
                if(Math.Sin(target._kwant * i) >= 0)
                    target.SignalValues[i] = 1;
                else
                    target.SignalValues[i] = -1;
            }
            
        }
        public static void GeneratingSignalTriangle(this Signal target)
        {
            target.SignalValues = (double[])Array.CreateInstance(typeof(double), target.ResolutionPattern);
            double lengthSection = target.ResolutionPattern / (target.LenghtSignal * 4); 
            double lengthBetweenSamples = 1 / lengthSection;
            double value = 0;
            bool increase = true;

            int j = 0;

            for (int i = 0; i < target.ResolutionPattern; i++,j++)
            {
                if(j >= lengthSection)
                {
                    j = 0;
                }
                if (value >= 1)
                    increase = false;
                else if (value <= -1)
                    increase = true;
                if (increase)
                    value += lengthBetweenSamples;

                else if (!increase)
                    value -= lengthBetweenSamples;

                target.SignalValues[i] = value;
            }
        }
        public static void GeneratingSignalSawtooth(this Signal target)
        {
            target.SignalValues = (double[])Array.CreateInstance(typeof(double), target.ResolutionPattern);
            double lengthSection = target.ResolutionPattern / (target.LenghtSignal * 2);
            double lengthBetweenSamples = 1 / lengthSection;
            double value = 0;

            for (int i = 0; i < target.ResolutionPattern; i++)
            {

                if (value >= 1)
                    value = -1;
                else
                    value += lengthBetweenSamples;

                target.SignalValues[i] = value;
            }
        }
        public static void GeneratingSignalTangent(this Signal target)
        {
            target.SignalValues = (double[])Array.CreateInstance(typeof(double), target.ResolutionPattern);
            for (int i = 0; i < target.ResolutionPattern; i++)
            {
                target.SignalValues[i] = Math.Tan(target._kwant * i);
            }
        }
    }
}
