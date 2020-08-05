using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomSprite : MonoBehaviour {

	public Sprite[] sprites;
	
	void Start () {
		
		var myRenderer = GetComponent<SpriteRenderer> ();
		
		if (sprites.Length > 0) {
			
			myRenderer.sprite = sprites [Random.Range(0,sprites.Length)];
			myRenderer.sortingOrder = Random.Range(1,11);
			
		}
		
	}
}
