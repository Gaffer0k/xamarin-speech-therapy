using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework_Babych_Speech_Therapy
{

    public class MainSTMasterMenuItem
    {
        public MainSTMasterMenuItem()
        {
            TargetType = typeof(MainSTMasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}