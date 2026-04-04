using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace Mandatory2DGameFramework.Logging
{
    public sealed class MyLogger
    {
        /// <summary>
        /// Den eneste myLogger, der bliver lavet ( privat statisk instans)
        /// </summary>
        private static readonly MyLogger _instance = new MyLogger(); 

        /// <summary>
        /// måden at tilgå loggeren på, da den er privat og statisk.
        /// </summary>
        /// 
        public static MyLogger Instance => _instance; 
        /// <summary>
        /// privat constructor, så ingen andre kan lave en instans af MyLogger uden for klassen. Dette sikrer, at der kun er én instans af MyLogger i hele applikationen, og at den kan tilgås via Instance-egenskaben.
        /// </summary>
        private MyLogger() 
        {
        }

        /// <summary>
        /// metode til at tilføje en TraceListener, som er en komponent, der modtager og håndterer de logbeskeder, der genereres af Trace-klassen. Ved at tilføje en TraceListener
        /// </summary>
        /// <param name="listener"></param>
        public void AddListener(TraceListener listener) // metode til at tilføje en TraceListener
        {
            Trace.Listeners.Add(listener);
        }

        /// <summary>
        /// Metode til at fjerne en TraceListener
        /// </summary>
        /// <param name="listener"></param>
        public void RemoveListener(TraceListener listener) 
        {
            Trace.Listeners.Remove(listener);
        }


        /// <summary>
        /// Metoder til at logge forskellige niveauer af beskeder
        /// </summary>
        /// <param name="message"></param>
        public void LogInfo(string message)
        {
            Trace.TraceInformation(message);
        }

        /// <summary>
        /// metode til at logge advarsler, som indikerer potentielle problemer eller vigtige begivenheder.
        /// </summary>
        /// <param name="message"></param>
        public void LogWarning(string message)
        {
            Trace.TraceWarning(message);
        }

        /// <summary>
        /// metode til at logge fejl, som indikerer alvorlige problemer, der kræver opmærksomhed.
        /// </summary>
        /// <param name="message"></param>
        public void LogError(string message)
        {
            Trace.TraceError(message);
        }

      

    }
}

