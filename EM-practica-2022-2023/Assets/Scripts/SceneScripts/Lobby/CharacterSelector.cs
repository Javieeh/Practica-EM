using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterSelector : MonoBehaviour
{
    public GameObject[] characters;
    private int cont = 0;



    // Start is called before the first frame update
    void Start()
    {
        characters[0].SetActive(true);
    }

    public void nextCharacter()
    {
        Debug.Log(cont);
        characters[cont].SetActive(false);
        if(cont == 2) cont = 0;
        else cont++;
        characters[cont].SetActive(true);



    }
}
