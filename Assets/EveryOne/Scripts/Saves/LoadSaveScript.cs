using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadSaveScript : MonoBehaviour
{
    public ShopClassLoad ShopCl;
    public TextMesh Image_Text_Name_Color;
    void Awake()
    {
        if (PlayerPrefs.HasKey("Shop"))
            ShopCl = JsonUtility.FromJson<ShopClassLoad>(PlayerPrefs.GetString("Shop"));
        if (ShopCl.Skin_Player_Name_Color_Current == 0)
            Image_Text_Name_Color.color = Color.cyan;
        if (ShopCl.Skin_Player_Name_Color_Current == 1)
            Image_Text_Name_Color.color = Color.green;
        if (ShopCl.Skin_Player_Name_Color_Current == 2)
            Image_Text_Name_Color.color = Color.black;
        if (ShopCl.Skin_Player_Name_Color_Current == 3)
            Image_Text_Name_Color.color = Color.red;
        if (ShopCl.Skin_Player_Name_Color_Current == 4)
            Image_Text_Name_Color.color = Color.yellow;
        if (ShopCl.Skin_Player_Name_Color_Current == 5)
            Image_Text_Name_Color.color = Color.magenta;
        if (ShopCl.Skin_Player_Name_Color_Current == 6)
            Image_Text_Name_Color.color = Color.blue;
    }
}
[System.Serializable]
public class ShopClassLoad
{
    [Header("Текущие выбранные скины")]
    [Space(5)]
    public int Skin_Player_Name_Color_Current;
    public int Skin_Player_Top_Current;
    public int Skin_Player_Back_Current;
    public int Eat_Color_Current;
    public int Top_Color_Current;
    public int Back_Color_Current;
    public int Map_Current;
    [Header("Цвета для имени игрока")]
    [Space(5)]
    public int Skin_Player_Name_Color_1;
    public int Skin_Player_Name_Color_2;
    public int Skin_Player_Name_Color_3;
    public int Skin_Player_Name_Color_4;
    public int Skin_Player_Name_Color_5;
    public int Skin_Player_Name_Color_6;
    [Header("Верхние скины для игрока")]
    [Space(5)]
    public int Skin_Player_Top_1;
    public int Skin_Player_Top_2;
    public int Skin_Player_Top_3;
    public int Skin_Player_Top_4;
    public int Skin_Player_Top_5;
    public int Skin_Player_Top_6;
    public int Skin_Player_Top_7;
    public int Skin_Player_Top_8;
    [Header("Нижние скины для игрока")]
    [Space(5)]
    public int Skin_Player_Back_1;
    public int Skin_Player_Back_2;
    public int Skin_Player_Back_3;
    public int Skin_Player_Back_4;
    [Header("Цвета для ягоды")]
    [Space(5)]
    public int Eat_Color_1;
    public int Eat_Color_2;
    public int Eat_Color_3;
    public int Eat_Color_4;
    public int Eat_Color_5;
    public int Eat_Color_6;
    [Header("Цвета для верхних скинов")]
    [Space(5)]
    public int Top_Color_1;
    public int Top_Color_2;
    public int Top_Color_3;
    public int Top_Color_4;
    public int Top_Color_5;
    public int Top_Color_6;
    [Header("Цвета для задних скинов")]
    [Space(5)]
    public int Back_Color_1;
    public int Back_Color_2;
    public int Back_Color_3;
    public int Back_Color_4;
    public int Back_Color_5;
    public int Back_Color_6;
    [Header("Купленные карты")]
    [Space(5)]
    public int Map_1;
    public int Map_2;
    public int Map_3;
    public int Map_4;
    public int Map_5;
    public int Map_6;
    [Header("Улучшения")]
    [Space(5)]
    public int Mass_Eat_Lvl;
    public int Speed_Pl_Lvl;
    public int Earning_Money_Lvl;
    public int Earning_XP_LVl;
}