using System.Xml;

namespace D14_ovn_1_1_uppg_8t15
{
    internal class Program
    {
        // Uppg 8:
        class Land
        {
            public string namn, styrestyp, huvudstad;
            public int invånarantal;
        }
        static void Main(string[] args)
        {
            // Uppg 9:
            Land sverige = new Land()
            {
                namn = "Sverige",
                styrestyp = "monarki",
                huvudstad = "Stockholm",
                invånarantal = 10512820
            };
            Land tyskland = new Land()
            {
                namn = "Tyskland",
                styrestyp = "republik",
                huvudstad = "Berlin",
                invånarantal = 83783902
            };
            Land sanMarino = new Land()
            {
                namn = "San Marino",
                styrestyp = "republik",
                huvudstad = "San Marino",
                invånarantal = 33600
            };
        }
    }
}