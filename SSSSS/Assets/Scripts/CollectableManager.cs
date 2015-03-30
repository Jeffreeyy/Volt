using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CollectableManager : MonoBehaviour {

	public Text collectableText;
	private int nrOfTotalCollectables;
	private int nrOfCollectedItems;

	void Start () {
		GameObject[] collectables = GameObject.FindGameObjectsWithTag("Collectable");
		nrOfCollectedItems = 0;
		UpdateUI();
	}

	public void AddCollectable()
	{
		nrOfCollectedItems++;
		//Debug.Log("Je hebt " + nrOfCollectedItems + " van de " + nrOfTotalCollectables + " verzameld.");
		UpdateUI();
		if (nrOfCollectedItems == nrOfTotalCollectables)
        {
			//Application.LoadLevel("win");
		}
	}
	void UpdateUI()
	{
		collectableText.text = "" + nrOfCollectedItems;
	}
}
