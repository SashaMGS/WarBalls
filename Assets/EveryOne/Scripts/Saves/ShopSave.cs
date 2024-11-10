using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopSave : MonoBehaviour
{
    public ShopClass ShopCl;
    public Save SaveScript;
    public Image Image_Text_Name_Color;
    public GameObject Text_Name_Color_1_Price;
    public GameObject Text_Name_Color_2_Price;
    public GameObject Text_Name_Color_3_Price;
    public GameObject Text_Name_Color_4_Price;
    public GameObject Text_Name_Color_5_Price;
    public GameObject Text_Name_Color_6_Price;
    public Image Eat_Image_Color;
    public GameObject Text_Eat_Color_1_Price;
    public GameObject Text_Eat_Color_2_Price;
    public GameObject Text_Eat_Color_3_Price;
    public GameObject Text_Eat_Color_4_Price;
    public GameObject Text_Eat_Color_5_Price;
    public GameObject Text_Eat_Color_6_Price;
    public GameObject Text_Top_Skin_1_Price;
    public GameObject Text_Top_Skin_2_Price;
    public GameObject Text_Top_Skin_3_Price;
    public GameObject Text_Top_Skin_4_Price;
    public GameObject Text_Top_Skin_5_Price;
    public GameObject Text_Top_Skin_6_Price;
    public GameObject Text_Top_Skin_7_Price;
    public GameObject Text_Top_Skin_8_Price;
    public GameObject Text_Back_Skin_1_Price;
    public GameObject Text_Back_Skin_2_Price;
    public GameObject Text_Back_Skin_3_Price;
    public GameObject Text_Back_Skin_4_Price;
    public GameObject Text_Top_Color_1_Price;
    public GameObject Text_Top_Color_2_Price;
    public GameObject Text_Top_Color_3_Price;
    public GameObject Text_Top_Color_4_Price;
    public GameObject Text_Top_Color_5_Price;
    public GameObject Text_Top_Color_6_Price;
    public GameObject Text_Back_Color_1_Price;
    public GameObject Text_Back_Color_2_Price;
    public GameObject Text_Back_Color_3_Price;
    public GameObject Text_Back_Color_4_Price;
    public GameObject Text_Back_Color_5_Price;
    public GameObject Text_Back_Color_6_Price;
    public GameObject Text_Map_1_Price;
    public GameObject Text_Map_2_Price;
    public GameObject Text_Map_3_Price;
    public GameObject Text_Map_4_Price;
    public GameObject Text_Map_5_Price;
    public GameObject Text_Map_6_Price;
    [Header("Прокачка игрока")]
    [Space(5)]
    public Slider Eat_Mass_Slider;
    public Slider Speed_Pl_Slider;
    public Slider Earn_Money_Slider;
    public Slider Earn_XP_Slider;
    public GameObject Eat_Mass_Price;
    public GameObject Speed_Pl_Price;
    public GameObject Earn_Money_Price;
    public GameObject Earn_XP_Price;

    private void Start()
    {
        SaveScript = gameObject.GetComponent<Save>();
        SaveLoad();
    }
    private void Update()
    {
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

        if (ShopCl.Eat_Color_Current == 0)
            Eat_Image_Color.color = Color.cyan;
        if (ShopCl.Eat_Color_Current == 1)
            Eat_Image_Color.color = Color.green;
        if (ShopCl.Eat_Color_Current == 2)
            Eat_Image_Color.color = Color.black;
        if (ShopCl.Eat_Color_Current == 3)
            Eat_Image_Color.color = Color.red;
        if (ShopCl.Eat_Color_Current == 4)
            Eat_Image_Color.color = Color.yellow;
        if (ShopCl.Eat_Color_Current == 5)
            Eat_Image_Color.color = Color.magenta;
        if (ShopCl.Eat_Color_Current == 6)
            Eat_Image_Color.color = Color.blue;

        if (ShopCl.Skin_Player_Name_Color_1 == 1)
        {
            Text_Name_Color_1_Price.SetActive(false);
        }
        if (ShopCl.Skin_Player_Name_Color_2 == 1)
        {
            Text_Name_Color_2_Price.SetActive(false);
        }
        if (ShopCl.Skin_Player_Name_Color_3 == 1)
        {
            Text_Name_Color_3_Price.SetActive(false);
        }
        if (ShopCl.Skin_Player_Name_Color_4 == 1)
        {
            Text_Name_Color_4_Price.SetActive(false);
        }
        if (ShopCl.Skin_Player_Name_Color_5 == 1)
        {
            Text_Name_Color_5_Price.SetActive(false);
        }
        if (ShopCl.Skin_Player_Name_Color_6 == 1)
        {
            Text_Name_Color_6_Price.SetActive(false);
        }

        if (ShopCl.Eat_Color_1 == 1)
        {
            Text_Eat_Color_1_Price.SetActive(false);
        }
        if (ShopCl.Eat_Color_2 == 1)
        {
            Text_Eat_Color_2_Price.SetActive(false);
        }
        if (ShopCl.Eat_Color_3 == 1)
        {
            Text_Eat_Color_3_Price.SetActive(false);
        }
        if (ShopCl.Eat_Color_4 == 1)
        {
            Text_Eat_Color_4_Price.SetActive(false);
        }
        if (ShopCl.Eat_Color_5 == 1)
        {
            Text_Eat_Color_5_Price.SetActive(false);
        }
        if (ShopCl.Eat_Color_6 == 1)
        {
            Text_Eat_Color_6_Price.SetActive(false);
        }
        if (ShopCl.Skin_Player_Top_1 == 1)
        {
            Text_Top_Skin_1_Price.SetActive(false);
        }
        if (ShopCl.Skin_Player_Top_2 == 1)
        {
            Text_Top_Skin_2_Price.SetActive(false);
        }
        if (ShopCl.Skin_Player_Top_3 == 1)
        {
            Text_Top_Skin_3_Price.SetActive(false);
        }
        if (ShopCl.Skin_Player_Top_4 == 1)
        {
            Text_Top_Skin_4_Price.SetActive(false);
        }
        if (ShopCl.Skin_Player_Top_5 == 1)
        {
            Text_Top_Skin_5_Price.SetActive(false);
        }
        if (ShopCl.Skin_Player_Top_6 == 1)
        {
            Text_Top_Skin_6_Price.SetActive(false);
        }
        if (ShopCl.Skin_Player_Top_7 == 1)
        {
            Text_Top_Skin_7_Price.SetActive(false);
        }
        if (ShopCl.Skin_Player_Top_8 == 1)
        {
            Text_Top_Skin_8_Price.SetActive(false);
        }
        if (ShopCl.Skin_Player_Back_1 == 1)
        {
            Text_Back_Skin_1_Price.SetActive(false);
        }
        if (ShopCl.Skin_Player_Back_2 == 1)
        {
            Text_Back_Skin_2_Price.SetActive(false);
        }
        if (ShopCl.Skin_Player_Back_3 == 1)
        {
            Text_Back_Skin_3_Price.SetActive(false);
        }
        if (ShopCl.Skin_Player_Back_4 == 1)
        {
            Text_Back_Skin_4_Price.SetActive(false);
        }
        if(ShopCl.Top_Color_1 == 1)
        {
            Text_Top_Color_1_Price.SetActive(false);
        }
        if (ShopCl.Top_Color_2 == 1)
        {
            Text_Top_Color_2_Price.SetActive(false);
        }
        if (ShopCl.Top_Color_3 == 1)
        {
            Text_Top_Color_3_Price.SetActive(false);
        }
        if (ShopCl.Top_Color_4 == 1)
        {
            Text_Top_Color_4_Price.SetActive(false);
        }
        if (ShopCl.Top_Color_5 == 1)
        {
            Text_Top_Color_5_Price.SetActive(false);
        }
        if (ShopCl.Top_Color_6 == 1)
        {
            Text_Top_Color_6_Price.SetActive(false);
        }
        if (ShopCl.Back_Color_1 == 1)
        {
            Text_Back_Color_1_Price.SetActive(false);
        }
        if (ShopCl.Back_Color_2 == 1)
        {
            Text_Back_Color_2_Price.SetActive(false);
        }
        if (ShopCl.Back_Color_3 == 1)
        {
            Text_Back_Color_3_Price.SetActive(false);
        }
        if (ShopCl.Back_Color_4 == 1)
        {
            Text_Back_Color_4_Price.SetActive(false);
        }
        if (ShopCl.Back_Color_5 == 1)
        {
            Text_Back_Color_5_Price.SetActive(false);
        }
        if (ShopCl.Back_Color_6 == 1)
        {
            Text_Back_Color_6_Price.SetActive(false);
        }
        if (ShopCl.Map_1 == 1)
            Text_Map_1_Price.SetActive(false);
        if (ShopCl.Map_2 == 1)
            Text_Map_2_Price.SetActive(false);
        if (ShopCl.Map_3 == 1)
            Text_Map_3_Price.SetActive(false);
        if (ShopCl.Map_4 == 1)
            Text_Map_4_Price.SetActive(false);
        if (ShopCl.Map_5 == 1)
            Text_Map_5_Price.SetActive(false);
        if (ShopCl.Map_6 == 1)
            Text_Map_6_Price.SetActive(false);
        Eat_Mass_Slider.value = ShopCl.Mass_Eat_Lvl;
        Speed_Pl_Slider.value = ShopCl.Speed_Pl_Lvl;
        Earn_Money_Slider.value = ShopCl.Earning_Money_Lvl;
        Earn_XP_Slider.value = ShopCl.Earning_XP_LVl;
        // Вилимость ценников на улучшениях
        if (ShopCl.Mass_Eat_Lvl == Eat_Mass_Slider.maxValue)
            Eat_Mass_Price.SetActive(false);

        if (ShopCl.Speed_Pl_Lvl == Speed_Pl_Slider.maxValue)
            Speed_Pl_Price.SetActive(false);

        if (ShopCl.Earning_Money_Lvl == Earn_Money_Slider.maxValue)
            Earn_Money_Price.SetActive(false);

        if (ShopCl.Earning_XP_LVl == Earn_XP_Slider.maxValue)
            Earn_XP_Price.SetActive(false);
    }
    public void SaveLoad()
    {
        if (PlayerPrefs.HasKey("Shop"))
            ShopCl = JsonUtility.FromJson<ShopClass>(PlayerPrefs.GetString("Shop"));
        else
        {
            Save();
            SaveLoad();
        }
    }
    public void Save()
    {
        PlayerPrefs.SetString("Shop", JsonUtility.ToJson(ShopCl));
    }
    public void Name_Color_cyan_0()
    {
        ShopCl.Skin_Player_Name_Color_Current = 0;
        Save();
    }
    public void Name_Color_Green_1()
    {
        if (ShopCl.Skin_Player_Name_Color_1 == 1)
        {
            ShopCl.Skin_Player_Name_Color_Current = 1;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 50)
            {
                SaveScript.Money -= 50;
                SaveScript.SaveVoid();
                ShopCl.Skin_Player_Name_Color_1 = 1;
                ShopCl.Skin_Player_Name_Color_Current = 1;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Name_Color_Black_2()
    {
        if (ShopCl.Skin_Player_Name_Color_2 == 1)
        {
            ShopCl.Skin_Player_Name_Color_Current = 2;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 50)
            {
                SaveScript.Money -= 50;
                SaveScript.SaveVoid();
                ShopCl.Skin_Player_Name_Color_2 = 1;
                ShopCl.Skin_Player_Name_Color_Current = 2;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Name_Color_Red_3()
    {
        if (ShopCl.Skin_Player_Name_Color_3 == 1)
        {
            ShopCl.Skin_Player_Name_Color_Current = 3;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 50)
            {
                SaveScript.Money -= 50;
                SaveScript.SaveVoid();
                ShopCl.Skin_Player_Name_Color_3 = 1;
                ShopCl.Skin_Player_Name_Color_Current = 3;
                SaveScript.SaveVoid();
                Save();
            }
        }

    }
    public void Name_Color_Yellow_4()
    {
        if (ShopCl.Skin_Player_Name_Color_4 == 1)
        {
            ShopCl.Skin_Player_Name_Color_Current = 4;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 50)
            {
                SaveScript.Money -= 50;
                SaveScript.SaveVoid();
                ShopCl.Skin_Player_Name_Color_4 = 1;
                ShopCl.Skin_Player_Name_Color_Current = 4;
                SaveScript.SaveVoid();
                Save();
            }
        }

    }
    public void Name_Color_magenta_5()
    {
        if (ShopCl.Skin_Player_Name_Color_5 == 1)
        {
            ShopCl.Skin_Player_Name_Color_Current = 5;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 50)
            {
                SaveScript.Money -= 50;
                SaveScript.SaveVoid();
                ShopCl.Skin_Player_Name_Color_5 = 1;
                ShopCl.Skin_Player_Name_Color_Current = 5;
                SaveScript.SaveVoid();
                Save();
            }
        }

    }
    public void Name_Color_Blue_6()
    {
        if (ShopCl.Skin_Player_Name_Color_6 == 1)
        {
            ShopCl.Skin_Player_Name_Color_Current = 6;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 50)
            {
                SaveScript.Money -= 50;
                SaveScript.SaveVoid();
                ShopCl.Skin_Player_Name_Color_6 = 1;
                ShopCl.Skin_Player_Name_Color_Current = 6;
                SaveScript.SaveVoid();
                Save();
            }
        }

    }
    public void Eat_Color_cyan_0()
    {
        ShopCl.Eat_Color_Current = 0;
        Save();
    }
    public void Eat_Color_Green_1()
    {
        if (ShopCl.Eat_Color_1 == 1)
        {
            ShopCl.Eat_Color_Current = 1;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 100)
            {
                SaveScript.Money -= 100;
                SaveScript.SaveVoid();
                ShopCl.Eat_Color_1 = 1;
                ShopCl.Eat_Color_Current = 1;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Eat_Color_Black_2()
    {
        if (ShopCl.Eat_Color_2 == 1)
        {
            ShopCl.Eat_Color_Current = 2;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 100)
            {
                SaveScript.Money -= 100;
                SaveScript.SaveVoid();
                ShopCl.Eat_Color_2 = 1;
                ShopCl.Eat_Color_Current = 2;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Eat_Color_Red_3()
    {
        if (ShopCl.Eat_Color_3 == 1)
        {
            ShopCl.Eat_Color_Current = 3;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 100)
            {
                SaveScript.Money -= 100;
                SaveScript.SaveVoid();
                ShopCl.Eat_Color_3 = 1;
                ShopCl.Eat_Color_Current = 3;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Eat_Color_Yellow_4()
    {
        if (ShopCl.Eat_Color_4 == 1)
        {
            ShopCl.Eat_Color_Current = 4;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 100)
            {
                SaveScript.Money -= 100;
                SaveScript.SaveVoid();
                ShopCl.Eat_Color_4 = 1;
                ShopCl.Eat_Color_Current = 4;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Eat_Color_Maganeta_5()
    {
        if (ShopCl.Eat_Color_5 == 1)
        {
            ShopCl.Eat_Color_Current = 5;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 100)
            {
                SaveScript.Money -= 100;
                SaveScript.SaveVoid();
                ShopCl.Eat_Color_5 = 1;
                ShopCl.Eat_Color_Current = 5;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Eat_Color_Blue_6()
    {
        if (ShopCl.Eat_Color_6 == 1)
        {
            ShopCl.Eat_Color_Current = 6;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 100)
            {
                SaveScript.Money -= 100;
                SaveScript.SaveVoid();
                ShopCl.Eat_Color_6 = 1;
                ShopCl.Eat_Color_Current = 6;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Top_Skin_Pl_0()
    {
        ShopCl.Skin_Player_Top_Current = 0;
        Save();
    }
    public void Top_Skin_Pl_1()
    {
        if (ShopCl.Skin_Player_Top_1 == 1)
        {
            ShopCl.Skin_Player_Top_Current = 1;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 400)
            {
                SaveScript.Money -= 400;
                ShopCl.Skin_Player_Top_1 = 1;
                ShopCl.Skin_Player_Top_Current = 1;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Top_Skin_Pl_2()
    {
        if (ShopCl.Skin_Player_Top_2 == 1)
        {
            ShopCl.Skin_Player_Top_Current = 2;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 400)
            {
                SaveScript.Money -= 400;
                ShopCl.Skin_Player_Top_2 = 1;
                ShopCl.Skin_Player_Top_Current = 2;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Top_Skin_Pl_3()
    {
        if (ShopCl.Skin_Player_Top_3 == 1)
        {
            ShopCl.Skin_Player_Top_Current = 3;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 400)
            {
                SaveScript.Money -= 400;
                ShopCl.Skin_Player_Top_3 = 1;
                ShopCl.Skin_Player_Top_Current = 3;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Top_Skin_Pl_4()
    {
        if (ShopCl.Skin_Player_Top_4 == 1)
        {
            ShopCl.Skin_Player_Top_Current = 4;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 400)
            {
                SaveScript.Money -= 400;
                ShopCl.Skin_Player_Top_4 = 1;
                ShopCl.Skin_Player_Top_Current = 4;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Top_Skin_Pl_5()
    {
        if (ShopCl.Skin_Player_Top_5 == 1)
        {
            ShopCl.Skin_Player_Top_Current = 5;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 400)
            {
                SaveScript.Money -= 400;
                ShopCl.Skin_Player_Top_5 = 1;
                ShopCl.Skin_Player_Top_Current = 5;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Top_Skin_Pl_6()
    {
        if (ShopCl.Skin_Player_Top_6 == 1)
        {
            ShopCl.Skin_Player_Top_Current = 6;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 400)
            {
                SaveScript.Money -= 400;
                ShopCl.Skin_Player_Top_6 = 1;
                ShopCl.Skin_Player_Top_Current = 6;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Top_Skin_Pl_7()
    {
        if (ShopCl.Skin_Player_Top_7 == 1)
        {
            ShopCl.Skin_Player_Top_Current = 7;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 400)
            {
                SaveScript.Money -= 400;
                ShopCl.Skin_Player_Top_7 = 1;
                ShopCl.Skin_Player_Top_Current = 7;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Top_Skin_Pl_8()
    {
        if (ShopCl.Skin_Player_Top_8 == 1)
        {
            ShopCl.Skin_Player_Top_Current = 8;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 400)
            {
                SaveScript.Money -= 400;
                ShopCl.Skin_Player_Top_8 = 1;
                ShopCl.Skin_Player_Top_Current = 8;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Back_Skin_Pl_0()
    {
        ShopCl.Skin_Player_Back_Current = 0;
        Save();
    }
    public void Back_Skin_Pl_1()
    {
        if (ShopCl.Skin_Player_Back_1 == 1)
        {
            ShopCl.Skin_Player_Back_Current = 1;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 400)
            {
                SaveScript.Money -= 400;
                ShopCl.Skin_Player_Back_1 = 1;
                ShopCl.Skin_Player_Back_Current = 1;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Back_Skin_Pl_2()
    {
        if (ShopCl.Skin_Player_Back_2 == 1)
        {
            ShopCl.Skin_Player_Back_Current = 2;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 400)
            {
                SaveScript.Money -= 400;
                ShopCl.Skin_Player_Back_2 = 1;
                ShopCl.Skin_Player_Back_Current = 2;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Back_Skin_Pl_3()
    {
        if (ShopCl.Skin_Player_Back_3 == 1)
        {
            ShopCl.Skin_Player_Back_Current = 3;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 400)
            {
                SaveScript.Money -= 400;
                ShopCl.Skin_Player_Back_3 = 1;
                ShopCl.Skin_Player_Back_Current = 3;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Back_Skin_Pl_4()
    {
        if (ShopCl.Skin_Player_Back_4 == 1)
        {
            ShopCl.Skin_Player_Back_Current = 4;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 400)
            {
                SaveScript.Money -= 400;
                ShopCl.Skin_Player_Back_4 = 1;
                ShopCl.Skin_Player_Back_Current = 4;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Top_Color_Red_0()
    {
        ShopCl.Top_Color_Current = 0;
        Save();
    }
    public void Top_Color_Green_1()
    {
        if (ShopCl.Top_Color_1 == 1)
        {
            ShopCl.Top_Color_Current = 1;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 50)
            {
                SaveScript.Money -= 50;
                SaveScript.SaveVoid();
                ShopCl.Top_Color_1 = 1;
                ShopCl.Top_Color_Current = 1;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Top_Color_Black_2()
    {
        if (ShopCl.Top_Color_2 == 1)
        {
            ShopCl.Top_Color_Current = 2;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 50)
            {
                SaveScript.Money -= 50;
                SaveScript.SaveVoid();
                ShopCl.Top_Color_2 = 1;
                ShopCl.Top_Color_Current = 2;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Top_Color_cyan_3()
    {
        if (ShopCl.Top_Color_3 == 1)
        {
            ShopCl.Top_Color_Current = 3;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 50)
            {
                SaveScript.Money -= 50;
                SaveScript.SaveVoid();
                ShopCl.Top_Color_3 = 1;
                ShopCl.Top_Color_Current = 3;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Top_Color_Yellow_4()
    {
        if (ShopCl.Top_Color_4 == 1)
        {
            ShopCl.Top_Color_Current = 4;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 50)
            {
                SaveScript.Money -= 50;
                SaveScript.SaveVoid();
                ShopCl.Top_Color_4 = 1;
                ShopCl.Top_Color_Current = 4;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Top_Color_Maganeta_5()
    {
        if (ShopCl.Top_Color_5 == 1)
        {
            ShopCl.Top_Color_Current = 5;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 50)
            {
                SaveScript.Money -= 50;
                SaveScript.SaveVoid();
                ShopCl.Top_Color_5 = 1;
                ShopCl.Top_Color_Current = 5;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Top_Color_Blue_6()
    {
        if (ShopCl.Top_Color_6 == 1)
        {
            ShopCl.Top_Color_Current = 6;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 50)
            {
                SaveScript.Money -= 50;
                SaveScript.SaveVoid();
                ShopCl.Top_Color_6 = 1;
                ShopCl.Top_Color_Current = 6;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Back_Color_White_0()
    {
        ShopCl.Back_Color_Current = 0;
        Save();
    }
    public void Back_Color_Green_1()
    {
        if (ShopCl.Back_Color_1 == 1)
        {
            ShopCl.Back_Color_Current = 1;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 50)
            {
                SaveScript.Money -= 50;
                SaveScript.SaveVoid();
                ShopCl.Back_Color_1 = 1;
                ShopCl.Back_Color_Current = 1;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Back_Color_Black_2()
    {
        if (ShopCl.Back_Color_2 == 1)
        {
            ShopCl.Back_Color_Current = 2;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 50)
            {
                SaveScript.Money -= 50;
                SaveScript.SaveVoid();
                ShopCl.Back_Color_2 = 1;
                ShopCl.Back_Color_Current = 2;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Back_Color_cyan_3()
    {
        if (ShopCl.Back_Color_3 == 1)
        {
            ShopCl.Back_Color_Current = 3;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 50)
            {
                SaveScript.Money -= 50;
                SaveScript.SaveVoid();
                ShopCl.Back_Color_3 = 1;
                ShopCl.Back_Color_Current = 3;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Back_Color_Yellow_4()
    {
        if (ShopCl.Back_Color_4 == 1)
        {
            ShopCl.Back_Color_Current = 4;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 50)
            {
                SaveScript.Money -= 50;
                SaveScript.SaveVoid();
                ShopCl.Back_Color_4 = 1;
                ShopCl.Back_Color_Current = 4;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Back_Color_Maganeta_5()
    {
        if (ShopCl.Back_Color_5 == 1)
        {
            ShopCl.Back_Color_Current = 5;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 50)
            {
                SaveScript.Money -= 50;
                SaveScript.SaveVoid();
                ShopCl.Back_Color_5 = 1;
                ShopCl.Back_Color_Current = 5;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Back_Color_Blue_6()
    {
        if (ShopCl.Back_Color_6 == 1)
        {
            ShopCl.Back_Color_Current = 6;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 50)
            {
                SaveScript.Money -= 50;
                SaveScript.SaveVoid();
                ShopCl.Back_Color_6 = 1;
                ShopCl.Back_Color_Current = 6;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Map_Sprite_0()
    {
        ShopCl.Map_Current = 0;
        Save();
    }
    public void Map_Sprite_1()
    {
        if (ShopCl.Map_1 == 1)
        {
            ShopCl.Map_Current = 1;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 500)
            {
                SaveScript.Money -= 500;
                ShopCl.Map_1 = 1;
                ShopCl.Map_Current = 1;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Map_Sprite_2()
    {
        if (ShopCl.Map_2 == 1)
        {
            ShopCl.Map_Current = 2;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 500)
            {
                SaveScript.Money -= 500;
                ShopCl.Map_2 = 1;
                ShopCl.Map_Current = 2;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Map_Sprite_3()
    {
        if (ShopCl.Map_3 == 1)
        {
            ShopCl.Map_Current = 3;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 500)
            {
                SaveScript.Money -= 500;
                ShopCl.Map_3 = 1;
                ShopCl.Map_Current = 3;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Map_Sprite_4()
    {
        if (ShopCl.Map_4 == 1)
        {
            ShopCl.Map_Current = 4;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 500)
            {
                SaveScript.Money -= 500;
                ShopCl.Map_4 = 1;
                ShopCl.Map_Current = 4;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Map_Sprite_5()
    {
        if (ShopCl.Map_5 == 1)
        {
            ShopCl.Map_Current = 5;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 500)
            {
                SaveScript.Money -= 500;
                ShopCl.Map_5 = 1;
                ShopCl.Map_Current = 5;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Map_Sprite_6()
    {
        if (ShopCl.Map_6 == 1)
        {
            ShopCl.Map_Current = 6;
            Save();
        }
        else
        {
            if (SaveScript.Money >= 500)
            {
                SaveScript.Money -= 500;
                ShopCl.Map_6 = 1;
                ShopCl.Map_Current = 6;
                SaveScript.SaveVoid();
                Save();
            }
        }
    }
    public void Eat_Mass_Void()
    {
        if(ShopCl.Mass_Eat_Lvl < Eat_Mass_Slider.maxValue)
        {
            if(SaveScript.Money >= 250)
            {
                SaveScript.Money -= 250;
                SaveScript.SaveVoid();
                ShopCl.Mass_Eat_Lvl++;
                Save();
            }
        }
    }
    public void Speed_Pl_Void()
    {
        if (ShopCl.Speed_Pl_Lvl < Speed_Pl_Slider.maxValue)
        {
            if (SaveScript.Money >= 300)
            {
                SaveScript.Money -= 300;
                SaveScript.SaveVoid();
                ShopCl.Speed_Pl_Lvl++;
                Save();
            }
        }
    }
    public void Earn_Money_Void()
    {
        if (ShopCl.Earning_Money_Lvl < Earn_Money_Slider.maxValue)
        {
            if (SaveScript.Money >= 10000)
            {
                SaveScript.Money -= 10000;
                SaveScript.SaveVoid();
                ShopCl.Earning_Money_Lvl++;
                Save();
            }
        }
    }
    public void Earn_XP_Void()
    {
        if (ShopCl.Earning_XP_LVl < Earn_XP_Slider.maxValue)
        {
            if (SaveScript.Money >= 10000)
            {
                SaveScript.Money -= 10000;
                SaveScript.SaveVoid();
                ShopCl.Earning_XP_LVl = 2;
                Save();
            }
        }
    }
    public void Delete_Saves_Keys()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.DeleteKey("Shop");
        SceneManager.LoadScene("Menu");
    }
}
[System.Serializable]
public class ShopClass
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
