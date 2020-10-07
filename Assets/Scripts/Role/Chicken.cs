using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Pokemon13
{
    public override int Atk()
    {
        return ((MainGame.rand.Next() % 10) + (MainGame.rand2.Next() % 5) + 1);
    }

    public override int Def()
    {
        return ((MainGame.rand.Next() % 8) + (MainGame.rand2.Next() % 3) + 1);
    }
}
