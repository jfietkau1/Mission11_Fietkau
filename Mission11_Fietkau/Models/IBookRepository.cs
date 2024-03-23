namespace Mission11_Fietkau.Models
{
    public interface IBookRepository
    {

        public IQueryable<Book> Books { get; }




    }
}
