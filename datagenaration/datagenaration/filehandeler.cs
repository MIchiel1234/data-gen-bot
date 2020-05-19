using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace datagenaration
{
    class filehandeler
    {
        public void write(int moneyspend, int time, int location)
        {
            FileStream fs = new FileStream("demo.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(moneyspend+","+ time+","+location);
            sw.Close();
            fs.Dispose();
        }
    }
}
