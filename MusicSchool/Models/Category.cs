﻿namespace MusicSchool.Models;

public class Category
{
    public required int Id { get; set; }
    public required string CategoryName { get; set; }
    public IEnumerable<Instrument>? Instruments { get; }
}
