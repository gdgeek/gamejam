using UnityEngine;
using System.Collections;
using GDGeek;

public class BoomObj : MonoBehaviour {
    public GameObject _obj = null;
    public VoxelEmitter _emitter = null;
    public void boom() {
        _obj.SetActive(false);
        _emitter.enabled = true;
    }
    public void reset() {
        _obj.SetActive(true);
        _emitter.enabled = false;
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
