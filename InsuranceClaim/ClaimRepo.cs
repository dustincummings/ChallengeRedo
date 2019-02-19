using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceClaim
{
    class ClaimRepo
    {
        Queue<Claim> _queueOfClaims = new Queue<Claim>();
        bool _isVaild;
        
        public void AddClaimToQueue(Claim claim)
        {
            _queueOfClaims.Enqueue(claim);
        }
        public Queue<Claim> ShowClaimsQueue()
        {
            return _queueOfClaims;
        }
        public Queue<Claim> RemoveClaim()
        {
            _queueOfClaims.Dequeue();
            return _queueOfClaims;
        }
        public bool GetBoolan(Claim claim)
        {
            TimeSpan TimeBetweenDates = Convert.ToDateTime(claim.DateOfClaim) - Convert.ToDateTime(claim.DateOfIncident);

            bool IsValid;
            if (TimeBetweenDates.Days <= 30)
                _isVaild = true;
            else
                _isVaild = false;

            IsValid = _isVaild;
            return IsValid;
        }
    }
}
