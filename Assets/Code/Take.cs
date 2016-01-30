using UnityEngine;
using System.Collections;
using GDGeek;

public class Take : MonoBehaviour {
    public BoomObj _bobj = null;
    public Tween.Method _method;
    public Task epiphanic()
    {
        TaskList tl = new TaskList();
        Task task = new TweenTask(delegate {
            Tween tween = TweenLocalPosition.Begin(_bobj.gameObject, 1.0f, new Vector3(0.0f, 45, 0));
            tween.method = _method;
            return tween;
        });

        TaskManager.PushFront(tl, delegate
        {

            _bobj.reset();
            _bobj.gameObject.transform.localPosition = Vector3.zero;
            _bobj.gameObject.SetActive(true);

        });
        TaskManager.PushBack(tl, delegate
        {
            _bobj.boom();
            //_bobj.gameObject.SetActive(false);
        });
        tl.push(task);
        tl.push(new TaskWait(0.5f));
        return tl;
    }

}
