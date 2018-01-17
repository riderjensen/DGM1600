using UnityEngine;

public class colorBlue : MonoBehaviour {
	void Update (){
		if(Input.GetKeyDown(KeyCode.B)){
			GetComponent<Renderer>().material.color = Color.blue;
		}
	}
}