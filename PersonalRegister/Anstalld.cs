namespace PersonalRegister
{
    /// <summary>
    /// Klass med information om en anstalld
    /// </summary>
    public class Anstalld
    {
        /// <summary>
        /// Den anställdes förnamn
        /// </summary>
        public string ForNamn { get; set; }

        /// <summary>
        /// Den anställdes efternamn
        /// </summary>
        public string EfterNamn { get; set; }

        /// <summary>
        /// Den anställdes lön
        /// </summary>
        public double Lon { get; set; }

        public override string ToString()
        {
            return ForNamn + " " + EfterNamn + ", lön: " + Lon.ToString();
        }
    }
}
