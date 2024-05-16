using Humanizer.Localisation;
using Laba_3_my.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Laba_3_my.Data
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int YearId { get; set; }
        [ForeignKey(nameof(YearId))]
        public Year? Year { get; set; }
        public int TelephoneId { get; set; }
        [ForeignKey(nameof(TelephoneId))]
        public Telephone? Telephone { get; set; }
    }
}