using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class menumanager : MonoBehaviour
{
    [SerializeField] GameObject MenuInicial;
    [SerializeField] GameObject opcions;
    public void Jogar()
    {
        SceneManager.LoadScene(1);
    }
    public void abriropcoes()
    {
        MenuInicial.SetActive(false);
        opcions.SetActive(true); 
    }
    public void fecharopcoes()
    {
        opcions.SetActive(false);
        MenuInicial.SetActive(true);
    }
    public void quit()
    {
        Debug.Log("Sair do jogo");
        Application.Quit();
    }





    
        
    
}
