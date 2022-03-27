using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace resala.core.Domain.Models
{
    public enum Position : byte
    {
        Member =1,
        TeamLeader =2,
        CommiteeViceManager =3,
        CommiteeBoard =4,
        CommitteeManager =5,
        DepartementBoard =6,
        DepartementViceManager =7,
        DepartementManager =8,
        GeneralViceManager =9,
        GeneralManager= 10
    }
}
