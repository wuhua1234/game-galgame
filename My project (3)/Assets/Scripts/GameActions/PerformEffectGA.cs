using UnityEngine;
using System.Collections.Generic;

public class PerformEffectGA : GameAction
{
    public Effect Effect {get; set; }
    public List<CombatantView> Targets {get; set; }
    public PerformEffectGA(Effect effect,List<CombatantView> target)
    {
        Effect = effect;
        Targets = target == null ? null : new(target);
    }
}
