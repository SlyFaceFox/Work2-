using System.Text;
using System.Threading.Tasks;

namespace Work2
{
    public class Buildings
    {
        private int height1;
        private int height2;
        private int height3;

        public int Height1 { get; set; }
        public int Height2 { get; set; }
        public int Height3 { get; set; }

        public Buildings(int height1, int height2, int height3)
        {
            Height1 = height1;
            Height2 = height2;
            Height3 = height3;
        }

        public override string ToString()
        {
            return $"There are three buildings on the street. One is {Height1} meters in high, the second is {Height2} meters, the third is {Height3} meters high";
        }
    }
}
