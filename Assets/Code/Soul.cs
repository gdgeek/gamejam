using UnityEngine;
using System.Collections;
using GDGeek;
public class Soul : MonoBehaviour {
    public Body _body;
    private bool isDown_ = false;
    private float time_ = 0.0f;
    private int grovel_ = 0;
    public ObjManager _objManager = null;
    void OnEnable() {
        EasyTouch.On_TouchDown += onTouchDown;
        EasyTouch.On_TouchUp += onTouchUp;
    }
    void Awake() {
        isDown_ = false;
    }
    void Update() {
        time_ += Time.deltaTime;
        if (time_ >= 0.5f && isDown_ == false && grovel_ >0) {
            Debug.Log("i am coming!");
            TaskManager.Run(_objManager.epiphanic());
            grovel_ = 0;
        }

    }
    private void onTouchDown(Gesture gesture)
    {
        if (!isDown_) {
            _body.grovel();
            grovel_++;
            time_ = 0.0f;
            isDown_ = true;
        }
    }
    private void onTouchUp(Gesture gesture)
    {
        if (isDown_)
        {

            _body.kneel();
            time_ = 0.0f;
            Debug.Log("i am up!");
            isDown_ = false;
        }
    }
}
