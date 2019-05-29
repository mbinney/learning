using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLearning
{
   public interface IClaim
    {
        double Amount { get; set; }

        ClaimStatus PayClaim();
        
    }
}
