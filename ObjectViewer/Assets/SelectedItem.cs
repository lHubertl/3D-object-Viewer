using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SelectedItem : MonoBehaviour {

    public GameObject[] items;

    private GameObject selected; 

    public void Select(GameObject gameObj)
    {
        selected = gameObj;

        GameObject prevue = GameObject.Find("PrevuesItem");
        Set3DObject set = prevue.GetComponent<Set3DObject>();
        if (set != null)
        {
            set.Set(gameObj.GetComponentInChildren<Text>().text, gameObj.GetComponent<Select>()._Obj);
        }
    }
}
