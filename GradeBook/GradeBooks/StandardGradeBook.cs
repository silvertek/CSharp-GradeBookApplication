using GradeBook.Enums;
using GradeBook.GradeBooks;
namespace GradeBooks.GradeBook
{
  public class StandardGradebook : BaseGradeBook
  {
    public StandardGradebook(string name) : base(name)
    {
      Type = GradeBookType.Standard;
    }
  }
}