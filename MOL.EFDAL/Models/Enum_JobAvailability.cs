namespace MOL.EFDAL.Models
{
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Enum_JobAvailability
    {
        public Enum_JobAvailability()
        {
        }

		[DataMember]
        public int Id { get; set; }
		[DataMember]
        public string Name { get; set; }
		[DataMember]
        public string Description { get; set; }
    }
}
