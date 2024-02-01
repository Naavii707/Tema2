using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{

    protected string Name = "Enemy";
    protected int Health = 100;
    protected List<string> Loot;

    // Start is called before the first frame update
    public virtual void Init()
    {
        Loot = new List<string>();
    }

    // Update is called once per frame
    public virtual void AddLoot(string Item)
    {
        Loot.Add(Item);
    }

    public virtual List<string> GetLoot() 
    { 
        return Loot;
    }

    public virtual int GetHealth() 
    { 
        return Health;
    }
}
