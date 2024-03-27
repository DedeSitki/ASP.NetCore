namespace NLayer.Core.Models
{
    /*internal idi public yaptım başka class'lardan erişebilmek adına*/
    /*abstract ekledim new ile yeni nesne oluşturulamasın diye*/
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }


    }
}
