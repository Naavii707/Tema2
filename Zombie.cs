using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Enemigo
{
    // Start is called before the first frame update
    void Start()
    {
        Init();
        AddLoot("Pala");
        AddLoot("Zanahoria");
        AddLoot("Casco");
        AddLoot("Lingote de hierro");


        Health.GetHashCode();
        Debug.Log("Loot");
        for (int i = 0; i < GetLoot().Count ; i++)
        {
            Debug.Log(GetLoot()[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
