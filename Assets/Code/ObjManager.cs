using UnityEngine;
using System.Collections;
using GDGeek;
public class ObjManager : MonoBehaviour {

    public Depot _depot;
  //  public GameObject _bear;
    public Tween.Method _method;
    public Take _take = null;
    public bool isBusy_ = false;
    // Use this for initialization
 
    public Task epiphanic() {
        if (isBusy_) {
            return new Task();
        }
        else { 
            Task task= _take.epiphanic();
            TaskManager.PushFront(task, delegate {
                isBusy_ = true;
                _take._bobj = _depot.randomObj();

            });

            TaskManager.PushBack(task, delegate {
                isBusy_ = false;
            });
            return task;
        }
    }
    // Update is called once per frame
    void Update () {
	
	}
}
