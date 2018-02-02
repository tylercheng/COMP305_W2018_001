using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHandler : MonoBehaviour {

	//public int someNumber;
	public GameObject captFalcon;
	
	public Sprite newSprite;
	public Sprite secondSprite;
	
	public float speed = 10.0f;
	
	private Rigidbody2D rBody;
	private SpriteRenderer sRend;
	
	// Use this for initialization
	void Start () {
		//Debug.Log(someNumber);
		rBody = captFalcon.GetComponent<Rigidbody2D>();
		sRend = captFalcon.GetComponent<SpriteRenderer>();
		
		rBody.velocity = new Vector2(1, 0)*speed;
		
		//captFalcon.GetComponent<Rigidbody2D>().velocity = new Vector2(2, 0);
	}
	
	// Execute when a mouse down event is fired on the attached object
	void OnMouseDown(){
		//Debug.Log("Clicked!");
		//Rigidbody2D rBody = captFalcon.GetComponent<Rigidbody2D>();
		rBody.velocity *= -1;
		
		
		if(sRend.sprite == newSprite)
		{
			sRend.sprite = secondSprite;
		}
		else{
			sRend.sprite = newSprite;
		}
		
	}
	
}
