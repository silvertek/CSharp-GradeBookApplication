using GradeBook.Enums;
using GradeBook.GradeBooks;

namespace GradeBooks.GradeBook
{
  public class RankedGradebook : BaseGradeBook
  {
    public RankedGradebook(string name) : base(name)
    {
      Type = GradeBookType.Ranked;
    }
  }
}