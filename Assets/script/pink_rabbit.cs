using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pink_rabbit : Pokemon13
{
    public override int atk()
    {
        return (main_game.rand.Next() % 16 + 1);
    }

    public override int def()
    {
        return ((main_game.rand.Next() % 20 + 5) % 10 + 1);
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
