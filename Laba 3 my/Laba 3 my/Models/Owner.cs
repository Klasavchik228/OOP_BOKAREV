using System.ComponentModel.DataAnnotations.Schema;

namespace Laba_3_my.Data
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int BrandId { get; set; }
        [ForeignKey(nameof(BrandId))]
        public Year? Brand { get; set; }
    }
}
