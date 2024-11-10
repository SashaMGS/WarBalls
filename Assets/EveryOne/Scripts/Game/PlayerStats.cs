 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public TextMesh Player_Name;
    public Text Player_Lvl_Text;
    public float mass_int_lvl;
    public int Player_LVL;
    public float Mass_Need_To_Up_Lvl;
    public Slider Slider_Mass;
    public Save SaveScript;
    [SerializeField] private PlayerController PlayerControllerScript;
    [Header("Скины игрока")]
    public SpriteRenderer TopSkinObj;
    public LoadSaveScript LoadSaveScript;
    public Sprite[] TopSkins;
    public Sprite[] BackSkins;

    private void Start()
    {
        Player_LVL = SaveScript.Xp_Lvl;
        TopSkinObj.sprite = TopSkins[LoadSaveScript.ShopCl.Skin_Player_Top_Current];
        gameObject.GetComponent<SpriteRenderer>().sprite = BackSkins[LoadSaveScript.ShopCl.Skin_Player_Back_Current];
        if (LoadSaveScript.ShopCl.Top_Color_Current == 0)
        {
            TopSkinObj.color = Color.red;
        }
        if (LoadSaveScript.ShopCl.Top_Color_Current == 1)
        {
            TopSkinObj.color = Color.green;
        }
        if (LoadSaveScript.ShopCl.Top_Color_Current == 2)
        {
            TopSkinObj.color = Color.black;
        }
        if (LoadSaveScript.ShopCl.Top_Color_Current == 3)
        {
            TopSkinObj.color = Color.cyan;
        }
        if (LoadSaveScript.ShopCl.Top_Color_Current == 4)
        {
            TopSkinObj.color = Color.yellow;
        }
        if (LoadSaveScript.ShopCl.Top_Color_Current == 5)
        {
            TopSkinObj.color = Color.magenta;
        }
        if (LoadSaveScript.ShopCl.Top_Color_Current == 6)
        {
            TopSkinObj.color = Color.blue;
        }
        if (LoadSaveScript.ShopCl.Back_Color_Current == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }
        if (LoadSaveScript.ShopCl.Back_Color_Current == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }
        if (LoadSaveScript.ShopCl.Back_Color_Current == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.black;
        }
        if (LoadSaveScript.ShopCl.Back_Color_Current == 3)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.cyan;
        }
        if (LoadSaveScript.ShopCl.Back_Color_Current == 4)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
        }
        if (LoadSaveScript.ShopCl.Back_Color_Current == 5)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.magenta;
        }
        if (LoadSaveScript.ShopCl.Back_Color_Current == 6)
        {
            gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
        }
    }
    void Update()
    {
        if (!(Player_Name.text == SaveScript.SetClass.Name))
            Player_Name.text = SaveScript.SetClass.Name;
        if (SaveScript.SetClass.Name_Color == 0 && Player_Name.color == (Color.white))
            Player_Name.color = (Color.cyan);
        Mass_Lvl();
    }

    public void Mass_Lvl()
    {
        if (Player_LVL == 1)
        {
            PlayerControllerScript.massMax = 0.3f;
            PlayerControllerScript.CameraSizeMax = 4.5f;
            PlayerControllerScript.SpeedDown = 0.1f;
            Mass_Need_To_Up_Lvl = 0.02f;
        }
        if (Player_LVL == 2)
        {
            PlayerControllerScript.massMax = 0.4f;
            PlayerControllerScript.CameraSizeMax = 5;
            PlayerControllerScript.SpeedDown = 0.3f;
            Mass_Need_To_Up_Lvl = 0.03f;
        }
        if (Player_LVL == 3)
        {
            PlayerControllerScript.massMax = 0.5f;
            PlayerControllerScript.CameraSizeMax = 5.5f;
            PlayerControllerScript.SpeedDown = 0.5f;
            Mass_Need_To_Up_Lvl = 0.04f;
        }
        if (Player_LVL == 4)
        {
            PlayerControllerScript.massMax = 0.6f;
            PlayerControllerScript.CameraSizeMax = 6;
            PlayerControllerScript.SpeedDown = 0.7f;
            Mass_Need_To_Up_Lvl = 0.06f;
        }
        if (Player_LVL == 5)
        {
            PlayerControllerScript.massMax = 0.7f;
            PlayerControllerScript.CameraSizeMax = 6.5f;
            PlayerControllerScript.SpeedDown = 1f;
            Mass_Need_To_Up_Lvl = 0.08f;
        }
        if (Player_LVL >= 6 && Player_LVL < 10)
        {
            PlayerControllerScript.massMax = 0.9f;
            PlayerControllerScript.CameraSizeMax = 8;
            PlayerControllerScript.SpeedDown = 1.5f;
            Mass_Need_To_Up_Lvl = 0.1f;
        }
        if (Player_LVL >= 10 && Player_LVL < 15)
        {
            PlayerControllerScript.massMax = 1f;
            PlayerControllerScript.CameraSizeMax = 10;
            PlayerControllerScript.SpeedDown = 2f;
            Mass_Need_To_Up_Lvl = 0.2f;
        }
        if (Player_LVL >= 15 && Player_LVL < 20)
        {
            PlayerControllerScript.massMax = 1.2f;
            PlayerControllerScript.CameraSizeMax = 10;
            PlayerControllerScript.SpeedDown = 2.2f;
            Mass_Need_To_Up_Lvl = 0.3f;
        }
        if (Player_LVL >= 20 && Player_LVL < 30)
        {
            PlayerControllerScript.massMax = 1.4f;
            PlayerControllerScript.CameraSizeMax = 10;
            PlayerControllerScript.SpeedDown = 2.4f;
            Mass_Need_To_Up_Lvl = 0.5f;
        }
        if (Player_LVL >= 30 && Player_LVL < 40)
        {
            PlayerControllerScript.massMax = 1.6f;
            PlayerControllerScript.CameraSizeMax = 10;
            PlayerControllerScript.SpeedDown = 2.6f;
            Mass_Need_To_Up_Lvl = 1f;
        }
        if (Player_LVL >= 40 && Player_LVL < 50)
        {
            PlayerControllerScript.massMax = 1.8f;
            PlayerControllerScript.CameraSizeMax = 10;
            PlayerControllerScript.SpeedDown = 2.8f;
            Mass_Need_To_Up_Lvl = 1.5f;
        }
        if (Player_LVL >= 50)
        {
            PlayerControllerScript.massMax = 2f;
            PlayerControllerScript.CameraSizeMax = 10;
            PlayerControllerScript.SpeedDown = 3f;
            Mass_Need_To_Up_Lvl = 2f;
        }

        Slider_Mass.maxValue = Mass_Need_To_Up_Lvl;
        Slider_Mass.value = mass_int_lvl;
        Player_Lvl_Text.text = Player_LVL.ToString();
        if (mass_int_lvl >= Mass_Need_To_Up_Lvl)
        {
            mass_int_lvl = 0;
            Player_LVL += 1;
        }
    }
}
