using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalRegister
{
    public class Restaurang
    {
        /// <summary>
        /// Restaurangens namn
        /// </summary>
        public string Namn { get; set; }

        /// <summary>
        /// Lista med restaurangens anställda
        /// </summary>
        private List<Anstalld> anstallda = null;


        /// <summary>
        /// Metoden lägger till anställd till listan med anställda
        /// </summary>
        /// <param name="anstalld"></param>
        public void AddAnstalld(Anstalld anstalld)
        {
            if (anstalld == null)
                throw new ArgumentNullException("Restaurang -> AddAnstalld(). Referensen till Anstalld är null");

            if (anstallda == null)
                anstallda = new List<Anstalld>();

            anstallda.Add(anstalld);
        }

        public override string ToString()
        {
            StringBuilder strBuilder = new StringBuilder(Namn);

            if(anstallda != null && anstallda.Count > 0)
            {// Vi har anställda
                foreach(Anstalld ans in anstallda)
                {
                    strBuilder.Append(ans);
                }
            }

            return strBuilder.ToString();
        }
    }
}
