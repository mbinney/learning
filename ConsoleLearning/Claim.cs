using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLearning
{
    public class Claim : IClaim
    {
        private readonly IClaimant _claimant;

        public Claim(IClaimant claimant)
        {
            _claimant = claimant;
        }
        public double Amount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ClaimStatus PayClaim()
        {


           if (_claimant.Age > 0 && _claimant.Age < 18)
            {
                return ClaimStatus.Held;
            }
           else if (_claimant.Age >= 18 && _claimant.Age <= 65)
            {
                return ClaimStatus.Paid;
            }
            else if (_claimant.Age > 65)
            {
                return ClaimStatus.Held;
            }
            else
            {
                return ClaimStatus.Cancelled;
            }


        }
    }
}
