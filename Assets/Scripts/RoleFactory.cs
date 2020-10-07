using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleFactory : MonoBehaviour
{
    [System.Serializable]
    public class RolePair
    {
        public string pokename;
        public Pokemon13 pokeobj;
    }
    public List<RolePair> list;

    public Pokemon13 rabbit;
    public Pokemon13 duck;


    public Pokemon13 Create(string pokename)
    {
        //switch (pokename)
        //{
        //    case "粉紅兔":
        //        return rabbit;
        //    case "黃色小鴨":
        //        return duck;
        //}
        RolePair pr = list.Find(el => el.pokename == pokename);
        return (Pokemon13)Object.Instantiate(pr.pokeobj);
    }
}
