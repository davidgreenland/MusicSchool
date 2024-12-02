﻿using System.Text.Json.Serialization;

namespace MusicSchool.Models;

public class Instrument
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required int CategoryId { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public Category Category { get; } = null!;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public IEnumerable<Student> Students { get; set; } = null!;
}
