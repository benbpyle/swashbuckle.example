using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace API.Dtos
{
    /// <summary>
    /// Each club will have a type
    /// </summary>
    [DataContract]
    public enum ClubType
    {
        Iron,
        Wood,
        Putter
    }
    
    /// <summary>
    /// Represents a golf club
    /// </summary>
    [DataContract]
    public class ClubDto
    {
        /// <summary>
        /// The name of the club (1-iron, 2-iron) etc
        /// </summary>
        [DataMember]
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Description like "this is my favorite club"
        /// </summary>
        [DataMember]
        public string Description { get; set; }
        /// <summary>
        /// Iron, wood, putter
        /// </summary>
        [DataMember]
        [Required]
        public ClubType ClubType { get; set; }
    }
}