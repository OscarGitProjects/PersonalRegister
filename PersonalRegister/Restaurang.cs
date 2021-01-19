using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalRegister
{
    /// <summary>
    /// Klass med information om en restaurang och en lista med anställda
    /// </summary>
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
        /// Property som returnerar listan med anställda
        /// </summary>
        public List<Anstalld> Anstallda 
        {
            get 
            {
                return anstallda;
            } 
        }

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
                
                strBuilder.Append(System.Environment.NewLine);
                strBuilder.Append("Anställda");
                strBuilder.Append(System.Environment.NewLine);

                foreach (Anstalld ans in anstallda)
                {
                    strBuilder.Append(ans);
                    strBuilder.Append(System.Environment.NewLine);
                }
            }

            return strBuilder.ToString();
        }
    }
}
