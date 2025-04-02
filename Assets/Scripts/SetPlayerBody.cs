using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayerBody : MonoBehaviour
{
    public GameObject maleBody;
    public GameObject femaleBody;

    public GameObject femaleHair1;
    public GameObject femaleHair2;
    public GameObject maleHair1;
    public GameObject maleHair2;

    public GameObject facialHair1;
    public GameObject facialHair2;

    public GameObject femaleSkin0;
    public GameObject femaleSkin1;
    public GameObject femaleSkin2;
    public GameObject maleSkin0;
    public GameObject maleSkin1;
    public GameObject maleSkin2;

    public GameObject bronzeSword;
    public GameObject silverSword;
    public GameObject goldSword;
    public GameObject bow;

    public GameObject ironHelmetM;
    public GameObject ironHelmetF;

    public GameObject ironArmorM;
    public GameObject torso1M;
    public GameObject torso2M;
    public GameObject torso3M;
    public GameObject ironArmorF;
    public GameObject torso1F;
    public GameObject torso2F;
    public GameObject torso3F;

    public GameObject dog;

    public Material Black;
    public Material Red;
    public Material Blonde;
    public Material Brown;
    
    void Update()
    {
        //gender
        if (CreateCharacter.gender == "male") {
            maleBody.SetActive(true);
            femaleBody.SetActive(false);
        }

        //hair
        if (CreateCharacter.gender == "female") {
            if (CreateCharacter.femaleHair == 1) {
                femaleHair1.SetActive(true);
            }
            else if (CreateCharacter.femaleHair == 2) {
                femaleHair2.SetActive(true);
            }
        }
        if (CreateCharacter.gender == "male") {
            if (CreateCharacter.maleHair == 1) {
                maleHair1.SetActive(true);
            }
            else if (CreateCharacter.maleHair == 2) {
                maleHair2.SetActive(true);
            }
        }

        //hair color
        if (CreateCharacter.hairColor == 1) {
            maleHair1.GetComponent<Renderer>().material = Brown;
            maleHair2.GetComponent<Renderer>().material = Brown;
            femaleHair1.GetComponent<Renderer>().material = Brown;
            femaleHair2.GetComponent<Renderer>().material = Brown;
            facialHair1.GetComponent<Renderer>().material = Brown;
            facialHair2.GetComponent<Renderer>().material = Brown;
        }
        else if (CreateCharacter.hairColor == 2) {
            maleHair1.GetComponent<Renderer>().material = Blonde;
            maleHair2.GetComponent<Renderer>().material = Blonde;
            femaleHair1.GetComponent<Renderer>().material = Blonde;
            femaleHair2.GetComponent<Renderer>().material = Blonde;
            facialHair1.GetComponent<Renderer>().material = Blonde;
            facialHair2.GetComponent<Renderer>().material = Blonde;
        }
        else if (CreateCharacter.hairColor == 3) {
            maleHair1.GetComponent<Renderer>().material = Red;
            maleHair2.GetComponent<Renderer>().material = Red;
            femaleHair1.GetComponent<Renderer>().material = Red;
            femaleHair2.GetComponent<Renderer>().material = Red;
            facialHair1.GetComponent<Renderer>().material = Red;
            facialHair2.GetComponent<Renderer>().material = Red;
        }
        else if (CreateCharacter.hairColor == 0) {
            maleHair1.GetComponent<Renderer>().material = Black;
            maleHair2.GetComponent<Renderer>().material = Black;
            femaleHair1.GetComponent<Renderer>().material = Black;
            femaleHair2.GetComponent<Renderer>().material = Black;
            facialHair1.GetComponent<Renderer>().material = Black;
            facialHair2.GetComponent<Renderer>().material = Black;
        }

        //facial hair
        if (CreateCharacter.facialHair == 1) {
            facialHair1.SetActive(true);
        }
        else if (CreateCharacter.facialHair == 2) {
            facialHair2.SetActive(true);
        }

        //skin
        if (CreateCharacter.gender == "female") {
            if (CreateCharacter.femaleSkin == 1) {
                femaleSkin0.SetActive(false);
                femaleSkin1.SetActive(true);
            }
            else if (CreateCharacter.femaleSkin == 2) {
                femaleSkin0.SetActive(false);
                femaleSkin2.SetActive(true);
            }
        }
        if (CreateCharacter.gender == "male") {
            if (CreateCharacter.maleSkin == 1) {
                maleSkin0.SetActive(false);
                maleSkin1.SetActive(true);
            }
            else if (CreateCharacter.maleSkin == 2) {
                maleSkin0.SetActive(false);
                maleSkin2.SetActive(true);
            }
        }

        //weapon
        if (Inventory.weapon == "BronzeSword") {
            bronzeSword.SetActive(true);
            silverSword.SetActive(false);
            goldSword.SetActive(false);
            bow.SetActive(false);
        }
        if (Inventory.weapon == "SilverSword") {
            bronzeSword.SetActive(false);
            silverSword.SetActive(true);
            goldSword.SetActive(false);
            bow.SetActive(false);
        }
        if (Inventory.weapon == "GoldSword") {
            bronzeSword.SetActive(false);
            silverSword.SetActive(false);
            goldSword.SetActive(true);
            bow.SetActive(false);
        }
        if (Inventory.weapon == "Bow") {
            bronzeSword.SetActive(false);
            silverSword.SetActive(false);
            goldSword.SetActive(false);
            bow.SetActive(true);
        }

        //helmet
        if (Inventory.helmet == "IronHelmet") {
            if (CreateCharacter.gender == "male"){
                ironHelmetM.SetActive(true);
                maleHair1.SetActive(false);
                maleHair2.SetActive(false);
                facialHair1.SetActive(false);
                facialHair2.SetActive(false);
            }
            if (CreateCharacter.gender == "female"){
                ironHelmetF.SetActive(true);
                femaleHair1.SetActive(false);
                femaleHair2.SetActive(false);
            }
        }
        else {
            ironHelmetM.SetActive(false);
            ironHelmetF.SetActive(false);
        }

        //armor
        if (Inventory.armor == "IronArmor") {
            if (CreateCharacter.gender == "male"){
                ironArmorM.SetActive(true);
                torso1M.SetActive(false);
                torso2M.SetActive(false);
                torso3M.SetActive(false);
                facialHair2.SetActive(false);
            }
            else if (CreateCharacter.gender == "female"){
                ironArmorF.SetActive(true);
                torso1F.SetActive(false);
                torso2F.SetActive(false);
                torso3F.SetActive(false);
            }
        }
        else {
                ironArmorF.SetActive(false);
                ironArmorM.SetActive(false);
                torso1M.SetActive(true);
                torso2M.SetActive(true);
                torso3M.SetActive(true);
                torso1F.SetActive(true);
                torso2F.SetActive(true);
                torso3F.SetActive(true);
            }

        //pets
        if (Inventory.pet == "Dog") {
            dog.SetActive(true);
        }
        else {
            dog.SetActive(false);
        }
    }
}
