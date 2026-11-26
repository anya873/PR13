using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface_Shapovalova.Models;

namespace Interface_Shapovalova.Interfaces
{
    public interface IUsers
    {
        void All(out List<Users> Users);
    }
}
