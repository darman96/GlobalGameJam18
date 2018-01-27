using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	[SerializeField]
	GameController controller;

	[SerializeField]
	GameObject[] syringePrefabs;

	[SerializeField]
	Transform syringeSocket;

	Syringe syringe;

	public void OnGrab()
	{
		syringe = Instantiate(syringePrefabs[Random.Range(0, syringePrefabs.Length)], syringeSocket).GetComponent<Syringe>();
	}

	public void OnTake()
	{
		if (syringe == null)
			return;

		controller.TakeSyringe(syringe);
	}

	public void OnThrow()
	{
		Destroy(syringe.gameObject);
		syringe = null;
	}

}
