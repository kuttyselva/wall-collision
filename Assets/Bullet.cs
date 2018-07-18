using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public float shootf = 10f;
    public Vector3 shootdi;
    public float life = 3f;
    public GameObject exploPre;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().AddForce(shootdi*shootf);

	}
    private void Update()
    {
        life -= Time.deltaTime;
        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "trigger")
        {
            GameObject expobj = Instantiate(exploPre);
            expobj.transform.position = transform.position;
        }
    }

}
