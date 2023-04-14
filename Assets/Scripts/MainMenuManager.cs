using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MainMenuManager : MonoBehaviour
{
    private WaitForSeconds waitforSeconds = new WaitForSeconds(2f);
    
    
    void Awake()
    {
        Debug.Log("Cargando..");
    }
    
    
    void Start()
    {
        Debug.Log("Sistema Cargando..");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("ø");
        }
    }

    public void OnStartButtonClick()
    {
        Debug.Log("Empezando juego...");
        StartCoroutine(this.StartingMessageTimer());
    }

    public IEnumerator StartingMessageTimer()
    {
        yield return this.waitforSeconds;
        Debug.Log("¡Empezamos!");
    }

    public void OnCloseButtonClick()
    {
        Debug.Log("Cerrando aplicación...");
        StartCoroutine(this.ClosingApplicationMessageTimer());
    }

    public IEnumerator ClosingApplicationMessageTimer()
    {
        yield return this.waitforSeconds;
        Debug.Log("Aplicación cerrada");
    }
}
