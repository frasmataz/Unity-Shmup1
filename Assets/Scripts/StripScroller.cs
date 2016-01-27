using UnityEngine;
using System.Collections;

public class StripScroller : MonoBehaviour {
	
	public float scrollSpeed;
	
	void Update ()
	{
		Vector2 offset = GetComponent<Renderer> ().material.GetTextureOffset ("_MainTex");
		offset.x += (scrollSpeed/1000);
		GetComponent<Renderer> ().material.SetTextureOffset ("_MainTex", offset);
	}
}