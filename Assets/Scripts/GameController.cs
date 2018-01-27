using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	int score;
	int syringesTaken;
	int syringesSkiped;
	float infectionRate;
	float highness;

	public void TakeSyringe(Syringe syringe)
	{
		if(syringe.clean)
		{
			highness = Mathf.Clamp(highness + Random.Range(0.02f, 0.08f), 0f, 1f);
		}
		else
		{
			infectionRate = Mathf.Clamp(infectionRate + Random.Range(0.1f, .3f), 0f, 1f);
			highness = Mathf.Clamp(highness + Random.Range(0.02f, 0.08f), 0f, 1f);
		}
	}

}
