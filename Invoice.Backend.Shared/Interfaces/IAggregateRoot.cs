using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.Backend.Shared.Interfaces;

//
// Resumen:
//     Apply this marker interface only to aggregate root entities in your domain model
//     Your repository implementation can use constraints to ensure it only operates
//     on aggregate roots
public interface IAggregateRoot
{
}
#if false // Registro de descompilación
#endif