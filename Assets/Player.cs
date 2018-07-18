using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public GameObject bullpre;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulobj=Instantiate(bullpre);
            Bullet bullet = bulobj.GetComponent<Bullet>();
            Vector3 shootdi = new Vector3(
            
                Random.Range(-0.3f,0.3f),
                  Random.Range(0.10f, 0.30f),
                1
                );
            bullet.shootdi = shootdi.normalized;

        }
	}
}
