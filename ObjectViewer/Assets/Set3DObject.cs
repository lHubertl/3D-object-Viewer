using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEditor;

public class Set3DObject : MonoBehaviour {


    GameObject new3Dobj;

    public void Set(string text, GameObject _Obj )
    {
        Text textView = GetComponentInChildren<Text>();
        textView.text = text;

        GameObject _3DobjectView = GameObject.Find("ItemPosition");

        GameObject.Destroy(new3Dobj); // Destroy previos 3d object 

        new3Dobj = (GameObject)Instantiate(_Obj);

        if (_3DobjectView.transform != null && _Obj != null)
        {
            _3DobjectView.transform.parent = new3Dobj.transform.parent;
            new3Dobj.transform.parent = _3DobjectView.transform;
        }
     }
}
