using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour {

	public GameObject Boar;
	private Animator chuchuAnim;

	// Use this for initialization
	void Start () {		
		chuchuAnim = Boar.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetKeyDown( KeyCode.Space ) ) {
			chuchuAnim.Play ("chuchuAnim");
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Boar") {
			print (other + " is hitting , you fail!");
		}

	}

}
