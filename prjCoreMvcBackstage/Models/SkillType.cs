using System;
using System.Collections.Generic;

namespace prjCoreMvcBackstage.Models;

public partial class SkillType
{
    public int SkillTypeId { get; set; }

    public string? SkillTypeName { get; set; }

    public virtual ICollection<Skill> Skills { get; set; } = new List<Skill>();
}
