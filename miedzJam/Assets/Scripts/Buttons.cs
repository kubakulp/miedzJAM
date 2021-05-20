using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public Animator animatorTla;
    public Animator animatorStatystyki;
    public Animator animatorPanelMenu;
    public Talia talia;

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Game()
    {
        animatorTla.Play("animacjaTla");
        animatorPanelMenu.Play("animacjaPanelMenu");
        animatorStatystyki.Play("animacjaStatystyki");
        talia.LosujNowaKarte();
    }

    public void Tworcy()
    {

    }

    public void JakGrac()
    {

    }

    public void Wyjdz()
    {

    }

    public void Settings()
    {

    }
}
