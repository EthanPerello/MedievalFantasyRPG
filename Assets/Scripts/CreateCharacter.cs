using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateCharacter : MonoBehaviour
{
    public static string gender = "female";
    public GameObject maleBody;
    public GameObject femaleBody;

    public static int maleHair = 0;
    public static int femaleHair = 0;
    public GameObject femaleHair1;
    public GameObject femaleHair2;
    public GameObject maleHair1;
    public GameObject maleHair2;

    public static int maleSkin = 0;
    public static int femaleSkin = 0;
    public GameObject femaleSkin0;
    public GameObject femaleSkin1;
    public GameObject femaleSkin2;
    public GameObject maleSkin0;
    public GameObject maleSkin1;
    public GameObject maleSkin2;

    public static int facialHair = 0;
    public GameObject facialHair1;
    public GameObject facialHair2;

    public static int hairColor = 0;
    public Material Black;
    public Material Red;
    public Material Blonde;
    public Material Brown;

    public void ChangeFacialHair() {
        if (facialHair == 0) {
            facialHair1.SetActive(true);
            facialHair = 1;
        }
        else if (facialHair == 1) {
            facialHair1.SetActive(false);
            facialHair2.SetActive(true);
            facialHair = 2;
        }
        else if (facialHair == 2) {
            facialHair2.SetActive(false);
            facialHair = 0;
        }
    }

    public void ChangeSkin() {
        if (gender == "female") {
            if (femaleSkin == 0) {
                femaleSkin0.SetActive(false);
                femaleSkin1.SetActive(true);
                femaleSkin = 1;
            }
            else if (femaleSkin == 1) {
                femaleSkin1.SetActive(false);
                femaleSkin2.SetActive(true);
                femaleSkin = 2;
            }
            else if (femaleSkin == 2) {
                femaleSkin2.SetActive(false);
                femaleSkin0.SetActive(true);
                femaleSkin = 0;
            }
        }
        if (gender == "male") {
            if (maleSkin == 0) {
                maleSkin0.SetActive(false);
                maleSkin1.SetActive(true);
                maleSkin = 1;
            }
            else if (maleSkin == 1) {
                maleSkin1.SetActive(false);
                maleSkin2.SetActive(true);
                maleSkin = 2;
            }
            else if (maleSkin == 2) {
                maleSkin2.SetActive(false);
                maleSkin0.SetActive(true);
                maleSkin = 0;
            }
        }
    }

    public void ChangeGender() {
        if (gender == "female") {
            maleBody.SetActive(true);
            femaleBody.SetActive(false);
            gender = "male";
        }

        else if (gender == "male") {
            maleBody.SetActive(false);
            femaleBody.SetActive(true);
            gender = "female";
        }
    }

    public void ChangeHair() {
        if (gender == "female") {
            if (femaleHair == 0) {
                femaleHair1.SetActive(true);
                femaleHair = 1;
            }
            else if (femaleHair == 1) {
                femaleHair1.SetActive(false);
                femaleHair2.SetActive(true);
                femaleHair = 2;
            }
            else if (femaleHair == 2) {
                femaleHair2.SetActive(false);
                femaleHair = 0;
            }
        }
        if (gender == "male") {
            if (maleHair == 0) {
                maleHair1.SetActive(true);
                maleHair = 1;
            }
            else if (maleHair == 1) {
                maleHair1.SetActive(false);
                maleHair2.SetActive(true);
                maleHair = 2;
            }
            else if (maleHair == 2) {
                maleHair2.SetActive(false);
                maleHair = 0;
            }
        }
    }

    public void ChangeHairColor() {
        if (hairColor == 0) {
            maleHair1.GetComponent<Renderer>().material = Brown;
            maleHair2.GetComponent<Renderer>().material = Brown;
            femaleHair1.GetComponent<Renderer>().material = Brown;
            femaleHair2.GetComponent<Renderer>().material = Brown;
            facialHair1.GetComponent<Renderer>().material = Brown;
            facialHair2.GetComponent<Renderer>().material = Brown;
            hairColor = 1;
        }
        else if (hairColor == 1) {
            maleHair1.GetComponent<Renderer>().material = Blonde;
            maleHair2.GetComponent<Renderer>().material = Blonde;
            femaleHair1.GetComponent<Renderer>().material = Blonde;
            femaleHair2.GetComponent<Renderer>().material = Blonde;
            facialHair1.GetComponent<Renderer>().material = Blonde;
            facialHair2.GetComponent<Renderer>().material = Blonde;
            hairColor = 2;
        }
        else if (hairColor == 2) {
            maleHair1.GetComponent<Renderer>().material = Red;
            maleHair2.GetComponent<Renderer>().material = Red;
            femaleHair1.GetComponent<Renderer>().material = Red;
            femaleHair2.GetComponent<Renderer>().material = Red;
            facialHair1.GetComponent<Renderer>().material = Red;
            facialHair2.GetComponent<Renderer>().material = Red;
            hairColor = 3;
        }
        else if (hairColor == 3) {
            maleHair1.GetComponent<Renderer>().material = Black;
            maleHair2.GetComponent<Renderer>().material = Black;
            femaleHair1.GetComponent<Renderer>().material = Black;
            femaleHair2.GetComponent<Renderer>().material = Black;
            facialHair1.GetComponent<Renderer>().material = Black;
            facialHair2.GetComponent<Renderer>().material = Black;
            hairColor = 0;
        }
    }

    public void DoneCreating() {
        SceneManager.LoadScene("Village");
    }
}
