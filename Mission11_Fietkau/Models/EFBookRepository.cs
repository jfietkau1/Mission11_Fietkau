
namespace Mission11_Fietkau.Models
{
    public class EFBookRepository : IBookRepository
    {
        private readonly BookContext _context;
        public EFBookRepository(BookContext temp) {
        _context = temp; 
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
