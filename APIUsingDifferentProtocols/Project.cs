﻿namespace APIUsingDifferentProtocols;

public class Project
{
    public Guid Id { get; init; }
    public required string Name { get; init; }
    public required string Description { get; init; }
    public DateTime CreationDate { get; init; }
}
