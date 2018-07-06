using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AspnetWebApi.Models
{
    [DataContract]
    public class PaginatedContatos
    {
        [DataMember(Name = "totalCount")]
        public int TotalCount { get; set; }

        [DataMember(Name = "totalPages")]
        public int TotalPages { get; set; }

        [DataMember(Name = "pageNumber")]
        public int PageNumber { get; set; }

        [DataMember(Name = "paginatedData")]
        public IList<Contato> PaginatedData { get; set; }
    }
}