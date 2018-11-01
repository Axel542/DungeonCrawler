using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCreator : MonoBehaviour {

    private GameObject playerCharacter;

    public InputField nameField;
    public InputField fortNameField;

    public List<Vector3> selectorPositions;

    public List<Image> hairList;
    public List<Image> bodyList;
    public List<Image> eyeList;
    public List<Image> accessoryList;
    public List<Image> shirtList;

    public GameObject starSignSelector;
    public Text starSignDescriptionText;
    public GameObject sexSelector;

    // Use this for initialization
    void Start() {
        starSignSelector.transform.localPosition = selectorPositions[0];
        sexSelector.transform.localPosition = selectorPositions[4];
    }

    // Update is called once per frame
    void Update() {

    }



    public void SwitchSex(string a_sex)
    {
        switch(a_sex)
        {
            case "male":
                sexSelector.transform.localPosition = selectorPositions[4];
                break;
            case "female":
                sexSelector.transform.localPosition = selectorPositions[5];
                break;
            default:
                break;

                }
    }

    public void SwitchSigns(string a_sign)
    {
        switch (a_sign)
        {
            case "hunter":
                starSignSelector.transform.localPosition = selectorPositions[0];
                break;
            case "miner":
                starSignSelector.transform.localPosition = selectorPositions[3];
                break;
            case "farmer":
                starSignSelector.transform.localPosition = selectorPositions[1];
                break;
            case "warrior":
                starSignSelector.transform.localPosition = selectorPositions[2];
                break;
            default:
                break;
        }
       
    }
}
