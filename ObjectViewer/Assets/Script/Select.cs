using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEditor;

public class Select : MonoBehaviour
{
    public GameObject _Obj;

    SelectedItem father;
    Button button;

	void Start () {
        father = GetComponentInParent<SelectedItem>();
        button = GetComponent<Button>();
        button.onClick.AddListener(() => { OnClick(); });
	}

    public void OnClick()
    {
        father.Select(this.gameObject);
    }
}
