﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagableObj : MonoBehaviour
{
    // Start is called before the first frame update
    public int hp;
    public int maxHp;
    public int regenAmount;

    virtual public void takeDamage(int damage)
    {
        hp -= damage;
        Debug.Log(damage);
        if (hp <= 0) {
            hp = 0;
            Debug.Log("death");
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
