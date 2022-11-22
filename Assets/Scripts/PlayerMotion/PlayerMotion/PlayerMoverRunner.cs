using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerMoverRunner : MonoBehaviour
{
    private bool canMotion = true;
    public bool CanMotion { get => canMotion; set => canMotion = value; }

    public float VelocityOfPlayer = 1;
    public int Score = 0;
    public TextMeshProUGUI ScoreText;
    public float GetVelocity { get => VelocityOfPlayer; }

    public GameObject Effect;
    public RectTransform WinUI;
    public RectTransform FailUI;
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
            VelocityOfPlayer = 2;
        }
    }

    public void AccessEndPoint()
    {
        //float angle = 0;
        DOTween.To(() => VelocityOfPlayer, x => VelocityOfPlayer = x, 0, 1f).OnUpdate(() =>
        {
            Debug.Log("Dotween update");
        }).OnComplete(() =>
        {
            canMotion = false;
            Effect.gameObject.SetActive(true);
            ActivateWinUI();
            PlayerBehaviour.Instance.SuccessAnimation();

        });
    }

    private void ActivateWinUI()
	{
        Debug.Log("WinActivated");
        WinUI.gameObject.SetActive(true);
        
    }

    public void ActivateFailUI()
    {
        Debug.Log("WinActivated");
        FailUI.gameObject.SetActive(true);
       
    }

    public void RestartGame()
	{
        SceneManager.LoadScene("MainScene");
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
        Score++;
        ScoreText.text = ($"Score: {Score.ToString()}");
    }
}


