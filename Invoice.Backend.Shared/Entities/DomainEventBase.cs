using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Backend.Shared.Entities;

//
// Resumen:
//     A base type for domain events. Depends on MediatR INotification. Includes DateOccurred
//     which is set on creation.
public abstract class DomainEventBase : INotification
{
    public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;

}
#if false // Registro de descompilación
#endif
