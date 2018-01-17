using UnityEngine;

public class colorRed : MonoBehaviour {
	void Update (){
		if(Input.GetKeyDown(KeyCode.R)){
			GetComponent<Renderer>().material.color = Color.red;
		}
	}
}