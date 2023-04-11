﻿using System;
using System.Collections.Generic;

namespace PROG2500_AF_IMDB_Project.Models;

public partial class Episode
{
    public string TitleId { get; set; } = null!;

    public string? ParentTitleId { get; set; }

    public int? SeasonNumber { get; set; }

    public int? EpisodeNumber { get; set; }

    public virtual Title? ParentTitle { get; set; }

    public virtual Title Title { get; set; } = null!;
}
