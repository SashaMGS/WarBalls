using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int EatCount = 3000;
    public GameObject Eat;
    public GameObject Enemy;
    public LoadSaveScript LoadSaveScript;
    private Vector2 RandVector;
    public SpriteRenderer[] Sprites_map;
    public Sprite[] Sprites_for_Map;

    private void Start()
    {
        for (int i = 0; i < EatCount; i++)
        {
            RandVector.Set(Random.Range(-99.0f, 99.0f), Random.Range(-99.0f, 99.0f));
            Instantiate(Eat, RandVector, Quaternion.identity);
            if (LoadSaveScript.ShopCl.Eat_Color_Current == 0)
                Eat.GetComponent<SpriteRenderer>().color = Color.cyan;
            if (LoadSaveScript.ShopCl.Eat_Color_Current == 1)
                Eat.GetComponent<SpriteRenderer>().color = Color.green;
            if (LoadSaveScript.ShopCl.Eat_Color_Current == 2)
                Eat.GetComponent<SpriteRenderer>().color = Color.black;
            if (LoadSaveScript.ShopCl.Eat_Color_Current == 3)
                Eat.GetComponent<SpriteRenderer>().color = Color.red;
            if (LoadSaveScript.ShopCl.Eat_Color_Current == 4)
                Eat.GetComponent<SpriteRenderer>().color = Color.yellow;
            if (LoadSaveScript.ShopCl.Eat_Color_Current == 5)
                Eat.GetComponent<SpriteRenderer>().color = Color.magenta;
            if (LoadSaveScript.ShopCl.Eat_Color_Current == 6)
                Eat.GetComponent<SpriteRenderer>().color = Color.blue;
        }
        for (int i = 0; i < Sprites_map.Length; i++)
        {
            Sprites_map[i].sprite = Sprites_for_Map[LoadSaveScript.ShopCl.Map_Current];
        }
    }
}
