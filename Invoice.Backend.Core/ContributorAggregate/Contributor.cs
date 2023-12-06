using Ardalis.GuardClauses;
using Invoice.Backend.Shared.Entities;
using Invoice.Backend.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Backend.Core.ContributorAggregate;

public class Contributor(string name) : EntityBase, IAggregateRoot
{
    public string Name { get; private set; } = Guard.Against.NullOrEmpty(name, nameof(name));
    public ContributorStatus Status { get; private set; } = ContributorStatus.NotSet;

    public void UpdateName(string newName)
    {
        Name = Guard.Against.NullOrEmpty(newName, nameof(newName));
    }
}
