using GradeBook.Enums;
using GradeBook.GradeBooks;
namespace GradeBook.GradeBooks
{
  public class StandardGradebook : BaseGradeBook
  {
    public StandardGradebook(string name) : base(name)
    {
      Type = GradeBookType.Standard;
    }
  }
}