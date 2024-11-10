using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Monetization;

public class Events : MonoBehaviour
{
    [SerializeField] private Save SaveScript;
    [SerializeField] private PlayerStats PlayerStatsScript;
    [SerializeField] private GameObject Player;
    public GameObject Cam_Pause;
    public GameObject Pause_Panel;
    public GameObject Dead_Panel;
    public bool IsDead;
    public Text MoneyText;
    public int Money;
    public int MoneyMax;
    public LoadSaveScript LoadSaveScript;
    public Text Current_Record;
    public Text Best_Record;
    public Text Earn_Xp;
    public int Best_Record_Update;
    public int Player_Lvl_Update;
    private static int Dead_Count = 0;

    public Text Xp_Lvl_Text;
    public Slider Xp_Slider;
    public int Xp_Need_ToUpLvl;
    public int Xp_Current_InSlider;
    public float Xp_Have_Max; // Графичская переменная (имеет тоже значение что и SaveScript.Xp_Have_ToUpLvl)
    private void Start()
    {
        if (SaveScript.Xp_Lvl <= 0)
            Xp_Slider.maxValue = 120;
        else
            Xp_Slider.maxValue = SaveScript.Xp_Lvl * 500;
        if (Monetization.isSupported)
        {
            Monetization.Initialize("3261134", false);
        }
        Player.SetActive(true);
        Cam_Pause.SetActive(false);
        Pause_Panel.SetActive(false);
        Dead_Panel.SetActive(false);
    }
    private void Update()
    {
        Xp_Slider.value = Xp_Current_InSlider;
        if (IsDead == true)
        {
            if (Xp_Slider.value >= Xp_Slider.maxValue)
            {
                SaveScript.Xp_Lvl++;
                Xp_Current_InSlider = 0;
                SaveScript.Xp_Have_ToUpLvl -= Xp_Slider.maxValue;
                SaveScript.SaveVoid();
            }
            if (Xp_Have_Max > 0 && Xp_Slider.value < Xp_Slider.maxValue)
            {
                Xp_Current_InSlider++;
                Xp_Have_Max--;
            }
            Xp_Lvl_Text.text = SaveScript.Xp_Lvl.ToString();
            if (Money < MoneyMax)
                Money++;
            if (Money > MoneyMax)
                Money = MoneyMax;

            if (Player_Lvl_Update < PlayerStatsScript.Player_LVL)
                Player_Lvl_Update++;
            if (Player_Lvl_Update > PlayerStatsScript.Player_LVL)
                Player_Lvl_Update = PlayerStatsScript.Player_LVL;

            if (Best_Record_Update < SaveScript.Best_Record)
                Best_Record_Update++;
            if (Best_Record_Update > SaveScript.Best_Record)
                Best_Record_Update = SaveScript.Best_Record;

            MoneyText.text = Money.ToString("0");
            Current_Record.text = Player_Lvl_Update.ToString();
            Best_Record.text = Best_Record_Update.ToString();
        }
    }
    public void Pause()
    {
        Player.SetActive(false);
        Cam_Pause.SetActive(true);
        Pause_Panel.SetActive(true);
        Dead_Panel.SetActive(false);
        Time.timeScale = 0f;
    }
    public void Load()
    {
        Player.SetActive(true);
        Cam_Pause.SetActive(false);
        Pause_Panel.SetActive(false);
        Dead_Panel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void InMain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
    public void OneMoreTime()
    {
        SceneManager.LoadScene("Game");
    }
    public void Dead()
    {
        if (IsDead == false)
        {
            Dead_Count++;
            if (Dead_Count % 2 == 0 && Dead_Count > 0 && Monetization.IsReady("video"))
            {
                ShowAdPlacementContent ad = Monetization.GetPlacementContent("video") as ShowAdPlacementContent;
                ad.Show();
            }
            if (PlayerStatsScript.Player_LVL > 0)
            {
                if (LoadSaveScript.ShopCl.Earning_XP_LVl <= 1)
                    SaveScript.Xp_Have_ToUpLvl += PlayerStatsScript.Player_LVL * 10;
                else
                    SaveScript.Xp_Have_ToUpLvl += PlayerStatsScript.Player_LVL * 10 * LoadSaveScript.ShopCl.Earning_XP_LVl;
                Xp_Have_Max = SaveScript.Xp_Have_ToUpLvl;
                if (PlayerStatsScript.Player_LVL > SaveScript.Best_Record)
                {
                    SaveScript.Best_Record = PlayerStatsScript.Player_LVL;
                    SaveScript.SaveVoid();
                }
                if (PlayerStatsScript.Player_LVL <= 5)
                {
                    if (LoadSaveScript.ShopCl.Earning_Money_Lvl > 0)
                        MoneyMax = PlayerStatsScript.Player_LVL * 5 * 2;
                    else
                        MoneyMax = PlayerStatsScript.Player_LVL * 5;
                }
                if (PlayerStatsScript.Player_LVL <= 10 && PlayerStatsScript.Player_LVL > 5)
                {
                    if (LoadSaveScript.ShopCl.Earning_Money_Lvl > 0)
                        MoneyMax = PlayerStatsScript.Player_LVL * 10 * 2;
                    else
                        MoneyMax = PlayerStatsScript.Player_LVL * 10;
                }
                if (PlayerStatsScript.Player_LVL <= 15 && PlayerStatsScript.Player_LVL > 10)
                {
                    if (LoadSaveScript.ShopCl.Earning_Money_Lvl > 0)
                        MoneyMax = PlayerStatsScript.Player_LVL * 12 * 2;
                    else
                        MoneyMax = PlayerStatsScript.Player_LVL * 12;
                }
                if (PlayerStatsScript.Player_LVL <= 20 && PlayerStatsScript.Player_LVL > 15)
                {
                    if (LoadSaveScript.ShopCl.Earning_Money_Lvl > 0)
                        MoneyMax = PlayerStatsScript.Player_LVL * 15 * 2;
                    else
                        MoneyMax = PlayerStatsScript.Player_LVL * 15;
                }
                if (PlayerStatsScript.Player_LVL <= 25 && PlayerStatsScript.Player_LVL > 20)
                {
                    if (LoadSaveScript.ShopCl.Earning_Money_Lvl > 0)
                        MoneyMax = PlayerStatsScript.Player_LVL * 17 * 2;
                    else
                        MoneyMax = PlayerStatsScript.Player_LVL * 17;
                }
                if (PlayerStatsScript.Player_LVL <= 30 && PlayerStatsScript.Player_LVL > 25)
                {
                    if (LoadSaveScript.ShopCl.Earning_Money_Lvl > 0)
                        MoneyMax = PlayerStatsScript.Player_LVL * 20 * 2;
                    else
                        MoneyMax = PlayerStatsScript.Player_LVL * 20;
                }
                if (PlayerStatsScript.Player_LVL > 30)
                {
                    if (LoadSaveScript.ShopCl.Earning_Money_Lvl > 0)
                        MoneyMax = PlayerStatsScript.Player_LVL * 25 * 2;
                    else
                        MoneyMax = PlayerStatsScript.Player_LVL * 25;
                }
            }
            SaveScript.MoneyEarn();
            SaveScript.SaveVoid();
            IsDead = true;
            Player.SetActive(false);
            Cam_Pause.SetActive(true);
            Pause_Panel.SetActive(false);
            Dead_Panel.SetActive(true);
        }
    }
}
