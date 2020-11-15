using SQLite;

namespace CopyFilesToLocation.Models
{
    public class Documentheaders
    {
        #region Properties
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Path { get; set; }
        public string FileName { get; set; }
        public string Country { get; set; }
        public int Vendor { get; set; }
        #endregion Properties

        #region constructor

        public Documentheaders() { }

        public Documentheaders(int id, string path, string filename, string country, int vendor)
        {
            this.Id = id;
            this.Path = path;
            this.FileName = filename;
            this.Country = country;
            this.Vendor = vendor;
        }



        #endregion constructor
    }
}
