using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Backend.Core.ContributorAggregate;

public class ContributorStatus : SmartEnum<ContributorStatus>
{
    public static readonly ContributorStatus CoreTeam = new(nameof(CoreTeam), 1);
    public static readonly ContributorStatus Community = new(nameof(Community), 2);
    public static readonly ContributorStatus NotSet = new(nameof(NotSet), 3);

    protected ContributorStatus(string name, int value) : base(name, value) { }
}