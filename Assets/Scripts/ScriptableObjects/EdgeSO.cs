﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Edge SO", menuName = "Egde SO", order = 53)]
public class EdgeSO : ScriptableObject
{
    [SerializeField]
    private bool isSpecial;

    [SerializeField]
    private int heal;

    [SerializeField]
    private int defense;

    [SerializeField]
    private int damage;

    public int getHeal()
    {
        return heal;
    }

    public int getDefense()
    {
        return defense;
    }

    public int getDamage()
    {
        return damage;
    }

    public bool isEdgeSpecial()
    {
        return isSpecial;
    }
}
