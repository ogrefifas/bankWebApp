using bankWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankWebApp.Repository
{
    interface IClientRepository
    {
         List<clientTable> getAll();
         void delete(int? id);
         void insert(clientTable client);
         clientTable getById(int? id);
         void edit(clientTable client);
         clientTable getByPassportId(string id);
    }
}
