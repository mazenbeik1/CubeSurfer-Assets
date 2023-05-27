using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HmsPlugin;
using HuaweiConstants;
using HuaweiMobileServices.Ads;
using System;
using System.Collections;
using static HuaweiConstants.UnityBannerAdPositionCode;



public class HMSManager : MonoBehaviour
{

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
        Debug.Log("H");
    }


  
}
