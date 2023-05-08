using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    public bool isStacked = false;
	private RaycastHit hit;

	private void Update()
	{
		if (!isStacked) { return; }

		Debug.DrawRay(transform.position, Vector3.forward * 0.03f, Color.red);
		Debug.DrawRay(transform.position, Vector3.left * 0.04f, Color.red);
		Debug.DrawRay(transform.position, Vector3.right * 0.04f, Color.red);
		if (Physics.Raycast(transform.position, Vector3.forward, out hit, 0.03f) || Physics.Raycast(transform.position, Vector3.left, out hit, 0.03f) || Physics.Raycast(transform.position, Vector3.right, out hit, 0.03f))
		{ 
			if(hit.transform.gameObject.CompareTag("Obstacle"))
			{
				PlayerCubeManager.Instance.DropCube(this);
			}
		}



		/*
		if(Physics.Raycast(transform.position, Vector3.down, out hit, 0.03f))
		{
			if (hit.transform.gameObject.CompareTag("Lava"))
			{
				PlayerCubeManager.Instance.MeltCube(this);
				//Destroy(this);
				Debug.Log("CubeDestroyed");
			}
		}*/

	}
	/*
	private void OnTriggerEnter(Collider collider)
	{
			Debug.Log($"----------Collided ${collider.gameObject.name}--------");
		if (collider.gameObject.CompareTag("Obstacle"))
		{
			//PlayerCubeManager.Instance.DropCube(this);
		}
	}
	
	public void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Lava"))
		{
			PlayerCubeManager.Instance.MeltCube(this);
		}
	}*/

	public void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Lava"))
		{
			StartCoroutine(MeltCoroutine());
			Debug.Log("Trigger Lava");
		}
	}

	private IEnumerator MeltCoroutine()
	{
		yield return new WaitForSeconds(0.3f);

		PlayerCubeManager.Instance.MeltCube(this);
		Debug.Log("Melted Cube");
	}

}


