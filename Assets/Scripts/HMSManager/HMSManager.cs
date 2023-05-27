using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HmsPlugin;
using HuaweiConstants;
using HuaweiMobileServices.Ads;
using System;
using System.Collections;
using static HuaweiConstants.UnityBannerAdPositionCode;
using UnityEngine.UI;
using TMPro;



public class HMSManager : MonoBehaviour
{
    // public RectTransform WinUI;
    public TextMeshProUGUI GlobalScoreText ;
    public int GlobalScore ;

    // Start is called before the first frame update
    void Start()
    {
        HMSAdsKitManager.Instance.OnRewarded=OnRewarded;

    }

    public void ShowInterstitial()
    {
        HMSAdsKitManager.Instance.ShowInterstitialAd();
    }


    public void ShowRewardedAd()
    {
        HMSAdsKitManager.Instance.ShowRewardedAd();
    }
    public void OnRewarded(Reward reward)
    {
        // WinUI.gameObject.SetActive(true);
        GlobalScoreText.text=PlayerPrefs.GetString("GlobalScoreText","0");
        GlobalScore=int.Parse(GlobalScoreText.text);        
        GlobalScore=GlobalScore+5;
        GlobalScoreText.text=GlobalScore.ToString();
        PlayerPrefs.SetString("GlobalScoreText", GlobalScore.ToString());

    }


  
}
