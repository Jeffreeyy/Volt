using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

public string playButtonText;
public Texture playButtonTexture;
public string quitButtonText;
public Texture quitButtonTexture;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0))
		{
			AutoFade.LoadLevel(1 ,3,1,Color.black);
		}
	}
}
