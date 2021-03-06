using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Com.Framework.Data
{
    [DataContract]
    public class EmployeeGroup : Entity<long>
    {
        #region Properties
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        #endregion

        #region Navigation Properties

        protected virtual ICollection<Premise> Premises { get; set; }

        #endregion


        public EmployeeGroup() : this("") { }

        public EmployeeGroup(string name)
        {
            Name = name;
        }
    }
}