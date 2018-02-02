using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler_Lab2Green : MonoBehaviour {

	public GameObject char1;
	
	public Sprite firstSprite;
	public Sprite secondSprite;
	public Sprite thirdSprite;
	
	private SpriteRenderer sRend;
	
	// Use this for initialization
	void Start () {
		sRend = char1.GetComponent<SpriteRenderer>();
	}
	
	void OnMouseDown(){
		sRend.sprite = secondSprite;
	}
}
