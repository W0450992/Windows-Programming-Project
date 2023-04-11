﻿using System;
using System.Collections.Generic;

namespace PROG2500_AF_IMDB_Project.Models;

public partial class Name
{
    public string NameId { get; set; } = null!;

    public string? PrimaryName { get; set; }

    public int? BirthYear { get; set; }

    public int? DeathYear { get; set; }

    public string? PrimaryProfession { get; set; }

    public virtual ICollection<Principal> Principals { get; } = new List<Principal>();

    public virtual ICollection<Title> Titles { get; } = new List<Title>();

    public virtual ICollection<Title> Titles1 { get; } = new List<Title>();

    public virtual ICollection<Title> TitlesNavigation { get; } = new List<Title>();
}
