using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private Dictionary<string, int> _grades = new();
    public bool Add(string student, int grade) => _grades.TryAdd(student, grade);
    public IEnumerable<string> Roster() => _grades.OrderBy(g => g.Value).ThenBy(g => g.Key).Select(g => g.Key);
    public IEnumerable<string> Grade(int grade) => _grades.OrderBy(g => g.Key).Where(g => g.Value == grade).Select(g => g.Key);
}