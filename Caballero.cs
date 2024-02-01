using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caballero : EnemigoBase
{
    private int powerUp = Random.Range(10, 450);
    
    public int getPowerUp()
    {
        return damage + powerUp;
    }
}

public class Arquero : EnemigoBase
{

} 
public class Hechicero : EnemigoBase
{

}
public class Explorador : EnemigoBase
{

}
