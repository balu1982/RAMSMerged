namespace MOL.EFDAL.Models
{
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Lookup_NewEconomicActivity
    {
		[DataMember]
        public int Id { get; set; }
		[DataMember]
        public string Name { get; set; }
    }
}
