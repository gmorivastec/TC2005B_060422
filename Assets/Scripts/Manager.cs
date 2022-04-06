using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// en los juegos hay necesidad de centralizar recursos
// para manejar un tipo de recurso específico usamos un manager
// game manager
// siempre piensa - a quién pertenece esta info?


// EJEMPLOS DE RECURSOS CENTRALIZADOS:
// - estado del juego
// - acceso a recursos de juego (sprites, sonidos, etc)
// - mecanismo de guardado / cargado

public class Manager : MonoBehaviour
{

    public int vidaDeJugador;

    // recuerda hacerlo singleton
    public static Manager Instance {
        get;
        private set;
    }

    // Start is called before the first frame update
    void Start()
    {

        // en todos los singletons limitamos la creación de nuevos objetos
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else {
            Instance = this;
        }

        // evaluar seriamente la necesidad de registrarlo como objeto no destruible
        DontDestroyOnLoad(gameObject);

    }

    // los managers pueden tener métodos
    // ejemplo
    public void GuardarEstado() {
        // codigo dummy
        print("GUARDANDO ESTADO");
    }
}
