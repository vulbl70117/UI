using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkRabbit : Pokemon13
{
    public override int Atk()
    {
        return (MainGame.rand.Next() % 16 + 1);
    }

    public override int Def()
    {
        return ((MainGame.rand.Next() % 20 + 5) % 10 + 1);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
