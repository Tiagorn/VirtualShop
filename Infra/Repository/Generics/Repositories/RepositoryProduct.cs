using Domain.Interfaces.InterfaceProduct;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repository.Generics.Repositories
{
    public class RepositoryProduct : RepositoryGenerics<Produto>, IProduct
    {
    }
}
