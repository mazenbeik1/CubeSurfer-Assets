using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField]
    private Animator animatorOfPlayer;

	private void Awake()
	{
		Singleton();
	}


	#region Singelton

	public static PlayerBehaviour Instance;

	private void Singleton()
	{
		if (Instance != null && Instance != this)
		{
			Destroy(gameObject);
		}

		Instance = this;
	}

	#endregion


	public void SuccessAnimation()
	{
		animatorOfPlayer.SetTrigger("dance");
	}

	public void FailAnimation()
	{
		animatorOfPlayer.SetTrigger("death");
	}

}
