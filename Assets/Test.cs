using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start (){
		int[] array = { 70, 50, 20, 40, 90,  };

		 
		for (int i = 0; i < 5; i++) {
			Debug.Log (array [i]);
		}

		for(int d =4;d>=0;d--){
			Debug.Log (array [d]);

		}
	}






	// Update is called once per fram
     void Update () {
		
	}

}