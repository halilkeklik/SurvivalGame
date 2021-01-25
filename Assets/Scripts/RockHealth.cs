using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockHealth : Health, IDamageAble<int>
{
    public SpriteRenderer spriteRenderer;

    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);

        HitFeedback();

        if (CheckIfWeDead())
        {
            onDeath();
        }
    }

    protected override void onDeath()
    {
        base.onDeath();
        Destroy(gameObject);
    }

    protected override void HitFeedback()
    {
        base.HitFeedback();
    }
}
