using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Save : MonoBehaviour
{
    public InputField InputField_Name;
    public SettingsClass SetClass;
    public Text Xp_Have_InMenu;  
    public Text MoneyText;
    public bool IsSceneMenu;
    public Events Events;
    public int Money;
    public int Xp_Lvl; // Текущий уровень опыта
    public float Xp_Have_ToUpLvl; // Текущее количество опыта, которое имеет игрок
    public int Best_Record;
    private void Awake()
    {
        LoadSave();
    }
    private void Update()
    {
        if(IsSceneMenu == true)
        {
            Xp_Have_InMenu.text = Xp_Lvl.ToString();
            MoneyText.text = Money.ToString();
        }
    }
    public void LoadSave()
    {
        Best_Record = PlayerPrefs.GetInt("BestRecord");
        Money = PlayerPrefs.GetInt("Game");
        Xp_Lvl = PlayerPrefs.GetInt("Xp_Lvl");
        Xp_Have_ToUpLvl = PlayerPrefs.GetFloat("Xp_Have");
        if (!PlayerPrefs.HasKey("Settings")) SetClass.Name = "Игрок";
        else
        {
            SetClass = JsonUtility.FromJson<SettingsClass>(PlayerPrefs.GetString("Settings"));
        }
        if (!PlayerPrefs.HasKey("Game"))
        {
            SaveVoid();
        }
    }
    public void SaveVoid()
    {
        PlayerPrefs.SetInt("BestRecord", Best_Record);
        PlayerPrefs.SetString("Settings", JsonUtility.ToJson(SetClass));
        PlayerPrefs.SetInt("Game", Money);
        PlayerPrefs.SetInt("Xp_Lvl", Xp_Lvl);
        PlayerPrefs.SetFloat("Xp_Have", Xp_Have_ToUpLvl); 
    }
    public void Check()
    {
        if (InputField_Name.text.Length > 1 && InputField_Name.text.Length < 15)
        {
            SetClass.Name = InputField_Name.text;
        }
    }
    public void MoneyEarn()
    {
        Money += Events.MoneyMax;
    }
}
[Serializable]
public class SettingsClass
{
    public string Name;
    public int Name_Color;
}