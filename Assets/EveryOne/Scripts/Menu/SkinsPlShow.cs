using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinsPlShow : MonoBehaviour
{
    public ShopSave ShopSaveScript;
    public Save SaveScript;
    public Text PlayerName;
    public Image TopSkin;
    public Image BackSkin;
    public Sprite[] TopSkinsPack;
    public Sprite[] BackSkinsPack;
    public SpriteRenderer[] Map;
    public Sprite[] Sprite_For_Map;

    private void Update()
    {
        for (int i = 0; i < Map.Length; i++)
        {
            Map[i].sprite = Sprite_For_Map[ShopSaveScript.ShopCl.Map_Current];
        }
        PlayerName.text = SaveScript.SetClass.Name;

        if (ShopSaveScript.ShopCl.Skin_Player_Name_Color_Current == 0)
            PlayerName.color = Color.cyan;
        if (ShopSaveScript.ShopCl.Skin_Player_Name_Color_Current == 1)
            PlayerName.color = Color.green;
        if (ShopSaveScript.ShopCl.Skin_Player_Name_Color_Current == 2)
            PlayerName.color = Color.black;
        if (ShopSaveScript.ShopCl.Skin_Player_Name_Color_Current == 3)
            PlayerName.color = Color.red;
        if (ShopSaveScript.ShopCl.Skin_Player_Name_Color_Current == 4)
            PlayerName.color = Color.yellow;
        if (ShopSaveScript.ShopCl.Skin_Player_Name_Color_Current == 5)
            PlayerName.color = Color.magenta;
        if (ShopSaveScript.ShopCl.Skin_Player_Name_Color_Current == 6)
            PlayerName.color = Color.blue;

        TopSkin.sprite = TopSkinsPack[ShopSaveScript.ShopCl.Skin_Player_Top_Current];
        BackSkin.sprite = BackSkinsPack[ShopSaveScript.ShopCl.Skin_Player_Back_Current];

        if(ShopSaveScript.ShopCl.Top_Color_Current == 0)
            TopSkin.color = Color.red;
        if (ShopSaveScript.ShopCl.Top_Color_Current == 1)
            TopSkin.color = Color.green;
        if (ShopSaveScript.ShopCl.Top_Color_Current == 2)
            TopSkin.color = Color.black;
        if (ShopSaveScript.ShopCl.Top_Color_Current == 3)
            TopSkin.color = Color.cyan;
        if (ShopSaveScript.ShopCl.Top_Color_Current == 4)
            TopSkin.color = Color.yellow;
        if (ShopSaveScript.ShopCl.Top_Color_Current == 5)
            TopSkin.color = Color.magenta;
        if (ShopSaveScript.ShopCl.Top_Color_Current == 6)
            TopSkin.color = Color.blue;

        if (ShopSaveScript.ShopCl.Back_Color_Current == 0)
            BackSkin.color = Color.white;
        if (ShopSaveScript.ShopCl.Back_Color_Current == 1)
            BackSkin.color = Color.green;
        if (ShopSaveScript.ShopCl.Back_Color_Current == 2)
            BackSkin.color = Color.black;
        if (ShopSaveScript.ShopCl.Back_Color_Current == 3)
            BackSkin.color = Color.cyan;
        if (ShopSaveScript.ShopCl.Back_Color_Current == 4)
            BackSkin.color = Color.yellow;
        if (ShopSaveScript.ShopCl.Back_Color_Current == 5)
            BackSkin.color = Color.magenta;
        if (ShopSaveScript.ShopCl.Back_Color_Current == 6)
            BackSkin.color = Color.blue;
    }
}
