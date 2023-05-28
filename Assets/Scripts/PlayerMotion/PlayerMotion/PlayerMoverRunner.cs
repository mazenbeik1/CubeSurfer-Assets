using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
using TMPro;
using HmsPlugin;
using HuaweiMobileServices.Base;
using HuaweiMobileServices.IAP;
using HuaweiMobileServices.Utils;

public class PlayerMoverRunner : MonoBehaviour
{
    private bool canMotion = true;
    public bool CanMotion { get => canMotion; set => canMotion = value; }

    public float VelocityOfPlayer = 0;
    public int LocalScore = 0;  
    public int GlobalScore = 0;
    public int RemoveAds = 0;


    public TextMeshProUGUI GlobalScoreText ;
    public TextMeshProUGUI RemoveAdsText ;
    public TextMeshProUGUI LocalScoreMenuText ;
    public TextMeshProUGUI LocalScoreText ;


    public float GetVelocity { get => VelocityOfPlayer; }

    public GameObject Effect;
    public RectTransform WinUI;
    public RectTransform FailUILv1;
    public RectTransform StartUI;
    public RectTransform FailUILv2;



    public HMSManager HMSManager;
    private void Awake()
    {
        VelocityOfPlayer = 0;
        Debug.Log("StartActivated");
        StartUI.gameObject.SetActive(true);
        LocalScoreText.gameObject.SetActive(false);
        GlobalScoreText.gameObject.SetActive(true);

    }

    private void Start(){
        GlobalScoreText.text=PlayerPrefs.GetString("GlobalScoreText","0");
        GlobalScore=int.Parse(GlobalScoreText.text);        
        PlayerPrefs.SetString("GlobalScoreText", GlobalScore.ToString());

        HMSIAPManager.Instance.InitializeIAP();
        HMSIAPManager.Instance.OnBuyProductSuccess = OnBuyProductSuccess;
        HMSIAPManager.Instance.OnInitializeIAPSuccess = OnInitializeIAPSuccess;
        HMSIAPManager.Instance.OnInitializeIAPFailure = OnInitializeIAPFailure;
        HMSIAPManager.Instance.OnBuyProductFailure = OnBuyProductFailure;
    }

    private void Update()
    {
        if (!canMotion)
        {
            PlayerBehaviour.Instance.SuccessAnimation();
            return;
        }
        transform.position += new Vector3(0f, 0f, 1f) * Time.deltaTime * VelocityOfPlayer;

        if (transform.position.x > 0.166f)
        {
            transform.position = new Vector3(0.166f, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -0.176f)
        {
            transform.position = new Vector3(-0.176f, transform.position.y, transform.position.z);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FinalZone")
        {
            AccessEndPoint();
        }

        if (other.gameObject.tag == "Gem")
        {
            other.gameObject.SetActive(false);
            UpdateScore();
        }

        if (other.gameObject.tag == "Boost")
        {
            VelocityOfPlayer = VelocityOfPlayer * 2;
        }
    }

    public void AccessEndPoint()
    {
        DOTween.To(() => VelocityOfPlayer, x => VelocityOfPlayer = x, 0, 1f).OnUpdate(() =>
        {
            Debug.Log("Dotween update");
        }).OnComplete(() =>
        {
            canMotion = false;
            Effect.gameObject.SetActive(true);
            PlayerBehaviour.Instance.SuccessAnimation();
            RemoveAdsText.text=PlayerPrefs.GetString("RemoveAdsText","0");
            RemoveAds=int.Parse(RemoveAdsText.text);   
            if(RemoveAds > 0)  
            {   
                RemoveAds=RemoveAds-1;
                RemoveAdsText.text = (RemoveAds.ToString());
                PlayerPrefs.SetString("RemoveAdsText", RemoveAds.ToString());
            }
            else
            {
            HMSManager.ShowInterstitial();
            }
            ActivateWinUI();

        });
    }

    public void StartGame()
    {
        Debug.Log("game started");
        StartUI.gameObject.SetActive(false);
        LocalScoreText.gameObject.SetActive(true);
        GlobalScoreText.gameObject.SetActive(false);
        VelocityOfPlayer = 1;

    }

    public void NextLevel()
    {
        SceneManager.LoadScene("Level_02");
        //WinUI.gameObject.SetActive(false);
        canMotion = true;
    }

    public void PreviousLevel()
    {
        SceneManager.LoadScene("Level_01");
        //WinUI.gameObject.SetActive(false);
        canMotion = true;
    }

    private void ActivateWinUI()
	{
        Debug.Log("WinActivated");
        WinUI.gameObject.SetActive(true);
        LocalScoreMenuText.text=($"Score:{LocalScore.ToString()}");
        GlobalScoreText.text=PlayerPrefs.GetString("GlobalScoreText","0");
        GlobalScore=int.Parse(GlobalScoreText.text);        
        GlobalScore=GlobalScore+LocalScore;
        GlobalScoreText.text = (GlobalScore.ToString());
        LocalScoreText.gameObject.SetActive(false);
        GlobalScoreText.gameObject.SetActive(true);
        PlayerPrefs.SetString("GlobalScoreText", GlobalScore.ToString());


    }

    public void ActivateFailUI()
    {
        LocalScoreText.gameObject.SetActive(false);
        GlobalScoreText.gameObject.SetActive(true);
        if (SceneManager.GetActiveScene().name == "Level_01")
        {
            FailUILv1.gameObject.SetActive(true);
        }
        else
        {
            FailUILv2.gameObject.SetActive(true);
        }
    }

    public void RestartGame()
	{
        SceneManager.LoadScene("Level_01");
        if (SceneManager.GetActiveScene().name == "Level_01")
        {
            FailUILv1.gameObject.SetActive(false);
        }
        else
        {
            FailUILv2.gameObject.SetActive(false);
        }
        canMotion = true;
	}

    IEnumerator DecreaseSpeedOfPlayer()
    {
        var yieldReturn = new WaitForEndOfFrame();
        while (true)
        {

        }
    }

    public void UpdateScore()
	{
        LocalScore++;
        LocalScoreText.text = (LocalScore.ToString());
    }

    public void BuyProduct(string productID)
    {
        HMSIAPManager.Instance.PurchaseProduct(productID);

    }

    void OnInitializeIAPFailure(HMSException ex)
    {
        Debug.Log("initalise faaaaaaaaaaaiiiiiiilllllllllll " + ex);
    }
    void OnInitializeIAPSuccess()
    { 
        Debug.Log("initalise dooooooooooooooooooneeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee"  ); 
    }

    private void OnBuyProductSuccess(PurchaseResultInfo obj)
    {
        string myProductId = obj.InAppPurchaseData.ProductId;
        if (myProductId == "Gems")
        {
            GlobalScoreText.text=PlayerPrefs.GetString("GlobalScoreText","0");
            GlobalScore=int.Parse(GlobalScoreText.text);        
            GlobalScore=GlobalScore+50;
            GlobalScoreText.text = (GlobalScore.ToString());
            PlayerPrefs.SetString("GlobalScoreText", GlobalScore.ToString());
        }

        if (myProductId.Equals("RemoveAds"))
        {
            RemoveAdsText.text=PlayerPrefs.GetString("RemoveAdsText","0");
            RemoveAds=int.Parse(RemoveAdsText.text);        
            RemoveAds=RemoveAds+5;
            RemoveAdsText.text = (RemoveAds.ToString());
            PlayerPrefs.SetString("RemoveAdsText", RemoveAds.ToString());
        }


    }
    IEnumerator AfterBuyProductSuccess(PurchaseResultInfo obj)
    {
        yield return new WaitForSeconds(1f);
    }
    private void OnBuyProductFailure(int code)
    {
    if (code == OrderStatusCode.ORDER_PRODUCT_OWNED)
        {
            HMSIAPManager.Instance.OnObtainOwnedPurchasesSuccess = OnObtainOwnedPurchasesSuccess;
            HMSIAPManager.Instance.ObtainOwnedPurchases(PriceType.IN_APP_CONSUMABLE);
        }
    }

    private void OnObtainOwnedPurchasesSuccess(OwnedPurchasesResult result)
    {
        if (result != null)
        {
            foreach (var obj in result.InAppPurchaseDataList)
            {
                Debug.Log("[IAPManager]: OnObtainOwnedPurchasesSuccess : " + obj.ProductId);
                HMSIAPManager.Instance.ConsumePurchaseWithToken(obj.PurchaseToken);
            }
        }
    }


}


