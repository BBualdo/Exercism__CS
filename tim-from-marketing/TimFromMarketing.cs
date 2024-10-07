using System.Text;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        var builder = new StringBuilder();

        if (id is not null) builder.Append($"[{id}] - ");
        builder.Append(name + " - ");
        if (department is not null) builder.Append(department.ToUpper());
        else builder.Append("OWNER");
        return builder.ToString();
    }
}
