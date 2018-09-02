using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace API.Dtos
{
    /// <summary>
    /// Represents a Golf ball
    /// </summary>
    [DataContract]
    public class GolfBallDto
    {
        /// <summary>
        /// The brand of the ball you are playing
        /// </summary>
        [DataMember]
        [Required]
        public string Brand { get;set; }
        /// <summary>
        /// The number of the ball ie. 1, 2, 3 ...
        /// </summary>
        [DataMember]
        [Required]
        public int Number { get; set; }
    }
}