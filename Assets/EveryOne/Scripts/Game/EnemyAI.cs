using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAI : MonoBehaviour
{
    [Header("Характеристики врага")]
    [Space(5)]
    public TextMesh Bot_Name;
    public float mass;
    public float massUp;
    public float Speed;
    public float SpeedDown;
    public Transform Target;
    private Vector3 MassVec;

    public Vector2 RandVector;
    public Transform[] moveSpots;
    private int randomSpot;
    [Header("Характеристики массы")]
    [Space(5)]
    public float mass_int_lvl;
    public int Player_LVL;
    public float Mass_Need_To_Up_Lvl;
    public TextMesh Player_Lvl_Text;
    public LoadSaveScript LoadSaveScript;
    [Header("Рандомные характеристики врага")]
    [Space (5)]
    private int RandomInt;
    public TextMesh ImgPlNameColor;
    public string[] Bot_NameClass;
    public Sprite[] ImgPlTopSkin;
    public SpriteRenderer ImgPlTopSkinReal;
    public Sprite[] ImgPlBackSkin;
    public SpriteRenderer ImgPlBackSkinReal;
    private void Start()
    {
        RandomEnemy();
        massUp += LoadSaveScript.ShopCl.Mass_Eat_Lvl * 0.0001f;
    }
    void Update()
    {
        MassVec.Set(mass, mass, 1);
        transform.localScale = MassVec;
        if (Target)
            transform.position = Vector2.MoveTowards(transform.position, Target.position, (Speed - SpeedDown) * Time.deltaTime);
        if (!Target)
        {
            transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, Speed * Time.deltaTime);

            if (Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
            {
                randomSpot = Random.Range(0, moveSpots.Length);
            }
        }
        Mass_Lvl();
    }
    public void Mass_Lvl()
    {
        if (Player_LVL == 1)
        {
            mass = 0.3f;
            SpeedDown = 0.1f;
            Mass_Need_To_Up_Lvl = 0.02f;
}
        if (Player_LVL == 2)
        {
            mass = 0.4f;
            SpeedDown = 0.3f;
            Mass_Need_To_Up_Lvl = 0.03f;
        }
        if (Player_LVL == 3)
        {
            mass = 0.5f;
            SpeedDown = 0.5f;
            Mass_Need_To_Up_Lvl = 0.04f;
        }
        if (Player_LVL == 4)
        {
            mass = 0.6f;
            SpeedDown = 0.7f;
            Mass_Need_To_Up_Lvl = 0.06f;
        }
        if (Player_LVL == 5)
        {
            mass = 0.7f;
            SpeedDown = 1f;
            Mass_Need_To_Up_Lvl = 0.08f;
        }
        if (Player_LVL >= 6 && Player_LVL < 10)
        {
            mass = 0.9f;
            SpeedDown = 1.5f;
            Mass_Need_To_Up_Lvl = 0.1f;
        }
        if (Player_LVL >= 10 && Player_LVL < 15)
        {
            mass = 1f;
            SpeedDown = 2f;
            Mass_Need_To_Up_Lvl = 0.2f;
        }
        if (Player_LVL >= 15 && Player_LVL < 20)
        {
            mass = 1.2f;
            SpeedDown = 2.2f;
            Mass_Need_To_Up_Lvl = 0.3f;
        }
        if (Player_LVL >= 20 && Player_LVL < 30)
        {
            mass = 1.4f;
            SpeedDown = 2.4f;
            Mass_Need_To_Up_Lvl = 0.5f;
        }
        if (Player_LVL >= 30 && Player_LVL < 40)
        {
            mass = 1.6f;
            SpeedDown = 2.6f;
            Mass_Need_To_Up_Lvl = 1f;
        }
        if (Player_LVL >= 40 && Player_LVL < 50)
        {
            mass = 1.8f;
            SpeedDown = 2.8f;
            Mass_Need_To_Up_Lvl = 1.5f;
        }
        if (Player_LVL >= 50)
        {
            mass = 2f;
            SpeedDown = 3f;
            Mass_Need_To_Up_Lvl = 2f;
        }

        Player_Lvl_Text.text = Player_LVL.ToString();
        if (mass_int_lvl >= Mass_Need_To_Up_Lvl)
        {
            mass_int_lvl = 0;
            Player_LVL += 1;
        }
    }
    public void RandomEnemy()
    {
        RandomInt = Random.Range(0, Bot_NameClass.Length);
        Bot_Name.text = Bot_NameClass[RandomInt].ToString() + Random.Range(0,999);
        RandomInt = Random.Range(0, 6);
        if (RandomInt == 0)
            Bot_Name.color = Color.cyan;
        if (RandomInt == 1)
            Bot_Name.color = Color.green;
        if (RandomInt == 2)
            Bot_Name.color = Color.black;
        if (RandomInt == 3)
            Bot_Name.color = Color.red;
        if (RandomInt == 4)
            Bot_Name.color = Color.yellow;
        if (RandomInt == 5)
            Bot_Name.color = Color.blue;
        if (RandomInt == 6)
            Bot_Name.color = Color.magenta;
        RandomInt = Random.Range(0, ImgPlTopSkin.Length);
        ImgPlTopSkinReal.sprite = ImgPlTopSkin[RandomInt];
        RandomInt = Random.Range(0, 6);
        if (RandomInt == 0)
            ImgPlTopSkinReal.color = Color.cyan;
        if (RandomInt == 1)
            ImgPlTopSkinReal.color = Color.green;
        if (RandomInt == 2)
            ImgPlTopSkinReal.color = Color.black;
        if (RandomInt == 3)
            ImgPlTopSkinReal.color = Color.red;
        if (RandomInt == 4)
            ImgPlTopSkinReal.color = Color.yellow;
        if (RandomInt == 5)
            ImgPlTopSkinReal.color = Color.blue;
        if (RandomInt == 6)
            ImgPlTopSkinReal.color = Color.magenta;
        RandomInt = Random.Range(0, ImgPlBackSkin.Length);
        ImgPlBackSkinReal.sprite = ImgPlBackSkin[RandomInt];
        RandomInt = Random.Range(0, 6);
        if (RandomInt == 0)
            ImgPlBackSkinReal.color = Color.cyan;
        if (RandomInt == 1)
            ImgPlBackSkinReal.color = Color.green;
        if (RandomInt == 2)
            ImgPlBackSkinReal.color = Color.black;
        if (RandomInt == 3)
            ImgPlBackSkinReal.color = Color.red;
        if (RandomInt == 4)
            ImgPlBackSkinReal.color = Color.yellow;
        if (RandomInt == 5)
            ImgPlBackSkinReal.color = Color.blue;
        if (RandomInt == 6)
            ImgPlBackSkinReal.color = Color.magenta;
    }
}
