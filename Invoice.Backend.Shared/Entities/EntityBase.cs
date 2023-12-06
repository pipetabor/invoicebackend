using Invoice.Backend.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Backend.Shared.Entities;

//
// Resumen:
//     A base class for DDD Entities. Includes support for domain events dispatched
//     post-persistence. If you prefer GUID Ids, change it here. If you need to support
//     both GUID and int IDs, change to EntityBase<TId> and use TId as the type for
//     Id.
public abstract class EntityBase : HasDomainEventsBase
{
    public int Id { get; set; }
}
#if false // Registro de descompilación
#endif
