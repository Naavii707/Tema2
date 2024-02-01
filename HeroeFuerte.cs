using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroeFuerte : Heroe
{
    public float hability = 30f;

    public float getHability()
    {
        if (GetQuest().id == 2)
        {
            return hability - 2f;
        }

        return hability;
    }
}


public class HeroeAgil : Heroe
{

}
