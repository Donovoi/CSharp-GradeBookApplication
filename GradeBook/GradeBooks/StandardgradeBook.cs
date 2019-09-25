
namespace GradeBook.GradeBooks
{
    public class StandardgradeBook : BaseGradeBook
    {
        public StandardgradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Standard;
        }
    }
}
