using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Accountant
{
    public bool AskForBonus(string worker, int hours)
    {
        const int standardHours = 160;
        return hours > standardHours;
    }
}