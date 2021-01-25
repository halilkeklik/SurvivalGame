﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour, IDamageAble<int>
{
    public int health;

    public virtual void TakeDamage(int damage)
    {
        health -= damage;
    }

    protected virtual void HitFeedback()
    {
        Debug.Log("Hit feedback is playing");
    }

    protected virtual void onDeath()
    {
        Debug.Log("You are die");
    }

    protected bool CheckIfWeDead()
    {
        if (health <= 0)
        {
            health = 0;
            return true;
        }
        return false;
    }
}
