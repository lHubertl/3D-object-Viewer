using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnimActivateController : MonoBehaviour {

    Button button;
    Image imageButton;

	void Start () {
        button = GetComponent<Button>();
        imageButton = GetComponent<Image>();
        button.onClick.AddListener(() => 
        { 
            AnimationController.animOn = !AnimationController.animOn;
        });

        button.onClick.AddListener(() =>
        {
            switch (!AnimationController.animOn)
            {
                case true:
                    imageButton.color = new Color(5, 0, 0);
                    break;
                case false:
                    imageButton.color = new Color(0, 5, 0);
                    break;
            }
        });
	}
}
