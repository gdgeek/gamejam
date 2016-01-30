using UnityEngine;
using System.Collections;

public class Body : MonoBehaviour {


    public GameObject _at1 = null;
    public GameObject _at2 = null;

    public void kneel() {
        _at1.gameObject.SetActive(true);
        _at2.gameObject.SetActive(false);
    }
    public void grovel() {

        _at1.gameObject.SetActive(false);
        _at2.gameObject.SetActive(true);
    }

    // Use this for initialization
    void Start ()
    {
        _at1.gameObject.SetActive(true);
        _at2.gameObject.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
