using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMenus : MonoBehaviour
{
    //Variables
    public GameObject menuPrincipal;
    public GameObject menuJugar;
    public GameObject menuOpciones;
    public GameObject menuCreditos;

    // Start is called before the first frame update
    void Start()
    {
        menuPrincipal.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void clickJugar()
    {
        menuJugar.SetActive(true);
        menuPrincipal.SetActive(false);
    }

    public void clickOpciones()
    {
        menuOpciones.SetActive(true);
        menuPrincipal.SetActive(false);
    }

    public void clickCreditos()
    {
        menuCreditos.SetActive(true);
        menuPrincipal.SetActive(false);
    }

    public void clickAtras()
    {
        menuPrincipal.SetActive(true);
        menuJugar.SetActive(false);
        menuOpciones.SetActive(false);
        menuCreditos.SetActive(false);
    }
}
