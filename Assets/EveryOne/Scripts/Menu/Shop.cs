using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public ShopSave ShopSaveScript;
    public Save SaveScript;
    public GameObject But_Menu;
    public GameObject But_Shop_Clothes;
    public GameObject But_Shop_Eat;
    public GameObject But_Shop_Map;
    public GameObject Scrol_Top_Skin;
    public GameObject Top_Color_Shop;
    public GameObject Scrol_Back_Skin;
    public GameObject Back_Color_Shop;
    public GameObject Upgrading_Shop;

    void Start()
    {
        But_Menu.SetActive(true);
        But_Shop_Clothes.SetActive(false);
        But_Shop_Eat.SetActive(false);
        But_Shop_Map.SetActive(false);
        Top_Color_Shop.SetActive(false);
        Back_Color_Shop.SetActive(true);
        Upgrading_Shop.SetActive(false);
    }
    public void But_Shop_Clothes_Void()
    {
        But_Menu.SetActive(false);
        But_Shop_Clothes.SetActive(true);
        But_Shop_Eat.SetActive(false);
        But_Shop_Map.SetActive(false);
        Upgrading_Shop.SetActive(false);
    }
    public void Back_ButMenu()
    {
        But_Menu.SetActive(true);
        But_Shop_Clothes.SetActive(false);
        But_Shop_Eat.SetActive(false);
        But_Shop_Map.SetActive(false);
        Upgrading_Shop.SetActive(false);
    }
    public void But_Shop_Eat_Void()
    {
        But_Menu.SetActive(false);
        But_Shop_Clothes.SetActive(false);
        But_Shop_Eat.SetActive(true);
        But_Shop_Map.SetActive(false);
        Upgrading_Shop.SetActive(false);
    }
    public void But_Shop_Map_Void()
    {
        But_Menu.SetActive(false);
        But_Shop_Clothes.SetActive(false);
        But_Shop_Eat.SetActive(false);
        But_Shop_Map.SetActive(true);
        Upgrading_Shop.SetActive(false);
    }
    public void BackSkin()
    {
        Scrol_Top_Skin.SetActive(false);
        Scrol_Back_Skin.SetActive(true);
        Top_Color_Shop.SetActive(false);
        Back_Color_Shop.SetActive(true);
        Upgrading_Shop.SetActive(false);
    }
    public void TopSkin()
    {
        Scrol_Top_Skin.SetActive(true);
        Scrol_Back_Skin.SetActive(false);
        Top_Color_Shop.SetActive(true);
        Back_Color_Shop.SetActive(false);
        Upgrading_Shop.SetActive(false);
    }
    public void Upgrading()
    {
        But_Menu.SetActive(false);
        But_Shop_Clothes.SetActive(false);
        But_Shop_Eat.SetActive(false);
        But_Shop_Map.SetActive(false);
        Upgrading_Shop.SetActive(true);
    }
}
