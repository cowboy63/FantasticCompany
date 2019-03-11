using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Mission1 : MonoBehaviour {


    public Canvas remS;
    public Image REM;
    public Text  speech;
    public Button nextButton;

    int index = 0;

    string[] sp = { "Hey there brave adventurer \n my name is REM and I will be \n your tutor",
        "FC is a tower defense style game ",
        "Place units on the map \n by dragging and dropping  \n them on the map",
        "Move your camera around \n using your arrow keys",
        "You can upgrade those  \n units by beating enemy \n units",
        "Your goal is to survive \n the waves by keeping \n you base safe",
        "Good luck"
 };

    // Use this for initialization
    void Start () {
        remS = remS.GetComponent<Canvas>();
        REM = REM.GetComponent<Image>();
        speech = speech.GetComponent<Text>();
        nextButton = nextButton.GetComponent<Button>();

        remS.enabled = true;
        REM.enabled = true;
        speech.enabled = true;
        nextButton.enabled = true;

        speech.text = sp[index];
    }

    public void ButtonPress()
    {
        index++;
        if(index == sp.Length)
        {
            finish();
            return;
        }
        speech.text = sp[index];
    }

    public void finish()
    {
        remS.enabled = false;
        REM.enabled = false;
        speech.enabled = false;
        nextButton.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
