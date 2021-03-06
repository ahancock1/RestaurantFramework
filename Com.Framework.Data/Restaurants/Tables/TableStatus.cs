using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Com.Framework.Data.Restaurants.Tables
{
    [DataContract]
    public class TableStatus : Entity<long>
    {
        [DataMember]
        public string Name { get; set; }

        protected virtual ICollection<Table> Tables { get; set; }
    }
}