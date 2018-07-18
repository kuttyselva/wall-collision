using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {
    public GameObject[] exploPre;
    public int amou = 3;
    // Use this for initialization
    void Start() {
        for (int i = 0; i < amou; i++) {
            GameObject explopre = Instantiate(exploPre[Random.Range(0,exploPre.Length)]);
            explopre.transform.position = transform.position;
    }
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
