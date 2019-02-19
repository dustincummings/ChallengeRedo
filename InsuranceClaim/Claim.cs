using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceClaim
{
    
    public class Claim
    {
        public int ClaimID { get; set; }
        public string ClaimType { get; set; }
        public string Description { get; set; }
        public decimal ClaimAmount { get; set; }
        public string DateOfIncident { get; set; }
        public string DateOfClaim { get; set; }
        public bool IsVaild { get; set; }

        public Claim(int claimID, string claimType, string description, decimal claimAmount, string dateOfIncident, string dateOfClaim, bool isVaild)
        {
            this.ClaimID = claimID;
            this.ClaimType = claimType;
            this.Description = description;
            this.ClaimAmount = claimAmount;
            this.DateOfIncident = dateOfIncident;
            this.DateOfClaim = dateOfClaim;
            this.IsVaild = isVaild;
        }
        public Claim() { }

        public override string ToString()
        {
            return $"Claim ID: {ClaimID}\n" +
                $"Type: {ClaimType}\n" +
                $"Description: {Description}\n" +
                $"Amount: {ClaimAmount}\n" +
                $"Date of Incident: {DateOfIncident}\n" +
                $"Date of Claim: {DateOfClaim}\n" +
                $"Vaild Claim: {IsVaild}";
        }
    }
}
