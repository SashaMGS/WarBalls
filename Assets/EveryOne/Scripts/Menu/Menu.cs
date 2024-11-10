using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Monetization;

public class Menu : MonoBehaviour
{
    [Header("Панель")]
    [Space(5)]
    [SerializeField] private GameObject Panel_Menu;
    [SerializeField] private GameObject Panel_Shop;
    [SerializeField] private GameObject ChangeName_Panel;
    [SerializeField] private GameObject AdsBanner;
    public Shop ShopScript;
    public Save SaveScript;
    public Text BestRecord;

    private void Awake()
    {
        SaveScript = GameObject.FindWithTag("Saves").GetComponent<Save>();
    }
    private void Start()
    {
        if (Monetization.isSupported)
            Monetization.Initialize("3261134", false);
        Panel_Menu.SetActive(true);
        Panel_Shop.SetActive(false);
        ShopScript.But_Menu.SetActive(true);
        ShopScript.But_Shop_Clothes.SetActive(false);
        ShopScript.But_Shop_Eat.SetActive(false);
        ShopScript.But_Shop_Map.SetActive(false);
        ChangeName_Panel.SetActive(false);
    }
    private void Update()
    {
        BestRecord.text = SaveScript.Best_Record.ToString();
        if (Monetization.IsReady("rewardedVideo"))
            AdsBanner.SetActive(true);
        else
            AdsBanner.SetActive(false);
    }
    public void Game()
    {
        SceneManager.LoadScene("Game");
    }
    public void Shop()
    {
        Panel_Menu.SetActive(false);
        Panel_Shop.SetActive(true);
        ChangeName_Panel.SetActive(false);
    }
    public void BackMenu()
    {
        Panel_Menu.SetActive(true);
        Panel_Shop.SetActive(false);
        ShopScript.But_Menu.SetActive(true);
        ShopScript.But_Shop_Clothes.SetActive(false);
        ShopScript.But_Shop_Eat.SetActive(false);
        ShopScript.But_Shop_Map.SetActive(false);
        ChangeName_Panel.SetActive(false);
    }
    public void ChaneNameVoid()
    {
        Panel_Menu.SetActive(false);
        Panel_Shop.SetActive(false);
        ShopScript.But_Menu.SetActive(true);
        ShopScript.But_Shop_Clothes.SetActive(false);
        ShopScript.But_Shop_Eat.SetActive(false);
        ShopScript.But_Shop_Map.SetActive(false);
        ChangeName_Panel.SetActive(true);
    }
    public void ShowAdsWithMoney()
    {
        if(Monetization .IsReady("rewardedVideo"))
        {
            ShowAdCallbacks options = new ShowAdCallbacks();
            options.finishCallback = HandleShowResult;
            ShowAdPlacementContent ad = Monetization.GetPlacementContent("rewardedVideo") as ShowAdPlacementContent;
            ad.Show(options);
        }
    }
    public void HandleShowResult(ShowResult result)
    {
        if(result == ShowResult.Finished)
        {
            SaveScript.Money += 500;
            SaveScript.SaveVoid();
        }
        else if( result == ShowResult.Skipped)
        {

        }
        else if (result == ShowResult.Failed)
        {

        }
    }
    public void Exit()
    {
        Application.Quit();
    }


    //Настройки
    public void LowQuality()
    {
        QualitySettings.SetQualityLevel(2, true);
    }
    public void MediumQuality()
    {
        QualitySettings.SetQualityLevel(3, true);
    }
    public void UltraQuality()
    {
        QualitySettings.SetQualityLevel(4, true);
    }
}