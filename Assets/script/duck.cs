using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duck : Pokemon13
{
    public override int atk()
    {
        return ((main_game.rand.Next() % 10) + (main_game.rand2.Next() % 5) + 1);
    }

    public override int def()
    {
        return ((main_game.rand.Next() % 8) + (main_game.rand2.Next() % 3) + 1);
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
