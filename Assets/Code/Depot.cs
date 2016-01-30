using UnityEngine;
using System.Collections;

public class Depot : MonoBehaviour {
    public BoomObj[] _list;
    public BoomObj randomObj() {
        return _list[Random.Range(0, _list.Length)];
    }
}
