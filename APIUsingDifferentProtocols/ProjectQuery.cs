namespace APIUsingDifferentProtocols;

public class ProjectQuery
{
    public IEnumerable<Project> GetProjects =>
    [
        new() {
            Id = Guid.NewGuid(),
            Name = "Test Project One",
            CreationDate = new DateTime(2023, 1, 1),
            Description = "Test Project One Description"
        },
        new() {
            Id = Guid.NewGuid(),
            Name = "Test Project Two",
            CreationDate = new DateTime(2024, 1, 1),
            Description = "Test Project Two Description"
        }
    ];
}
