using UnityEngine;

public class colorGreen : MonoBehaviour {
	void Update (){
		if(Input.GetKeyDown(KeyCode.G)){
			GetComponent<Renderer>().material.color = Color.green;
		}
	}
}