using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explopart : MonoBehaviour {
    public float exforce = 150f;
    public float life = 1f;
	// Use this for initialization
	void Start () {
        Vector3 ranDir = new Vector3(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f));
        float randfor = Random.Range(0f, exforce);
        GetComponent<Rigidbody>().AddForce(ranDir.normalized * randfor);
	}
	
	// Update is called once per frame
	void Update () {
        life -= Time.deltaTime;
        if (life < 0)
        {
            Destroy(gameObject);
        }
	}
}
