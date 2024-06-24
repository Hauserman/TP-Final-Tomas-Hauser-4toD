using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OBJECTSMANAGER : MonoBehaviour
{

    public GameObject[] objetos;
    int ActiveObject;

    // Start is called before the first frame update
    void Start()
    {
        DeactivateAll();
        objetos[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        ActivateNext();
        ActivatePrevious();
    }

    void ActivateNext()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            objetos[ActiveObject].SetActive(false);
            ActiveObject++;
            if (ActiveObject == objetos.Length)
            {
                ActiveObject = 0;
            }
            objetos[ActiveObject].SetActive(true);
        }
    }

    void ActivatePrevious()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            objetos[ActiveObject].SetActive(false);
            ActiveObject--;
            if (ActiveObject == -1)
            {
                ActiveObject = objetos.Length - 1;
            }
            objetos[ActiveObject].SetActive(true);
        }
    }

    void DeactivateAll()
    {
        for (int i = 0; i < objetos.Length; i++)
        {
            objetos[i].SetActive(false);
        }
    }
}
