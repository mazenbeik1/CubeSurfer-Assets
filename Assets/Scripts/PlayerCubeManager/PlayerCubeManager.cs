using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerCubeManager : MonoBehaviour
{
	private float stepLength = 0.695f;
	private float groundValue = 0.100f;

	public List<CubeBehaviour> listOfCubeBehaviour = new List<CubeBehaviour>();
	public PlayerMoverRunner PlayerMoverRunner;

	private void Awake()
	{
		Singleton();
	}


	#region Singleton

	public static PlayerCubeManager Instance;


	private void Singleton()
	{
		if (Instance != null && Instance != this)
		{
			Destroy(gameObject);
		}

		Instance = this;
	}

	#endregion


	public void GetCube(CubeBehaviour cubeBehaviour)
	{
		listOfCubeBehaviour.Add(cubeBehaviour);
		cubeBehaviour.isStacked = true;
		cubeBehaviour.transform.parent = transform;
		ReorderCubes();
		RelocatePlayer(1);
	}


	public void RelocatePlayer(int type)
	{
		var playerTransform = PlayerBehaviour.Instance.transform;
		var yValue = (listOfCubeBehaviour.Count - type) * stepLength;
		Debug.Log("RELOCATEPLAYER Cubes: " + listOfCubeBehaviour.Count);

		var playerTarget = new Vector3(0f, yValue, 0f);
		playerTransform.DOLocalMove(playerTarget, 0.35f);
		Debug.Log("RELOCATEPLAYER Player relocated to: " + playerTarget);
	}

	public void MeltCube(CubeBehaviour cubeBehaviour)
	{

		cubeBehaviour.isStacked = false;
		cubeBehaviour.transform.parent = null;
		Destroy(cubeBehaviour.gameObject);
		listOfCubeBehaviour.Remove(cubeBehaviour);

		if (listOfCubeBehaviour.Count < 1)
		{
			Debug.Log("Game Over");

			PlayerBehaviour.Instance.FailAnimation();

			var playerTransformX = PlayerBehaviour.Instance.transform;
			Vector3 groundPosition = new Vector3(0f, -0.61f, -2.14f);
			playerTransformX.DOLocalJump(groundPosition, 0.10f, 1, 0.5f);
			PlayerMoverRunner.CanMotion = false;
			PlayerMoverRunner.ActivateFailUI();
			return;
		}

		Debug.Log("MeltCube Removed");
		RelocatePlayer(1);
		Debug.Log("Melted PlayerRelocated");
		ReorderCubes();
	}


	public void DropCube(CubeBehaviour cubeBehaviour)
	{
		cubeBehaviour.transform.parent = null;
		cubeBehaviour.isStacked = false;
		listOfCubeBehaviour.Remove(cubeBehaviour);

		if (listOfCubeBehaviour.Count < 1)
		{
			Debug.Log("Game Over");

			PlayerBehaviour.Instance.FailAnimation();

			var playerTransformX = PlayerBehaviour.Instance.transform;
			Vector3 groundPosition = new Vector3(0f, -0.61f, -2.14f);
			playerTransformX.DOLocalJump(groundPosition, 0.10f, 1, 0.5f);
			PlayerMoverRunner.CanMotion = false;
			PlayerMoverRunner.ActivateFailUI();
			return;
		}
		Debug.Log("DropCube Removed");
		RelocatePlayer(0);
		Debug.Log("DropCube Player Relocated");
	}

	private void ReorderCubes()
	{
		int index = listOfCubeBehaviour.Count - 1;

		foreach (var cube in listOfCubeBehaviour)
		{
			Vector3 target = new Vector3(0f, index * stepLength, 0f);
			cube.transform.DOLocalMove(target, 0.11f);
			index--;
		}
	}



}