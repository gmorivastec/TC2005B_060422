using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeDummy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A)) {

            Manager.Instance.vidaDeJugador++;
        }

        if (Input.GetKeyDown(KeyCode.S)) {

            Manager.Instance.vidaDeJugador--;
        }

        if (Input.GetKeyDown(KeyCode.D)) {

            print(Manager.Instance.vidaDeJugador);
        }

        if (Input.GetKeyDown(KeyCode.F)) {

            Manager.Instance.GuardarEstado();
        }
    }
}
