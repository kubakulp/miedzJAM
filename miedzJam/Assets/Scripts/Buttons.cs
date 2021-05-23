using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public Animator animatorTla;
    public Animator animatorStatystyki;
    public Animator animatorPanelMenu;
    public Animator animatorZebatki1;
    public Animator animatorZebatki2;
    public Animator animatorZebatki3;
    public Animator animatorPierwszaKarta;
    public Animator animatorKartaWygrana;
    public Talia talia;
    public GameObject panelMenu;
    public GameObject tworcy;
    public GameObject jakGrac;

    public Animator animatorKoniecGry;
    public Animator animatorStatku;
    public GameObject statek;
    public GameObject wiatrak1;
    public GameObject wiatrak2;
    public GameObject kartaZwyciestwa;
    public GameObject statystyki;

    public void Menu()
    {
        SceneManager.LoadScene(1);
    }

    public void Game()
    {
        if(this.enabled==true)
        {
            animatorTla.Play("animacjaTla");
            animatorZebatki1.Play("animacjaZebatka");
            animatorZebatki2.Play("animacjaZebatka");
            animatorZebatki3.Play("animacjaZebatka");
            animatorPanelMenu.Play("animacjaPanelMenu");
            animatorStatystyki.Play("animacjaStatystyki");
            talia.LosujNowaKarte();
            animatorPierwszaKarta = GetComponentInChildren<Animator>();
            animatorPierwszaKarta.Play("animacjaPierwszaKarta");
        }

        this.enabled = false;
    }

    public void Tworcy()
    {
        panelMenu.SetActive(false);
        tworcy.SetActive(true);
    }

    public void JakGrac()
    {
        panelMenu.SetActive(false);
        jakGrac.SetActive(true);
    }

    public void Wyjdz()
    {
        Application.Quit();
    }

    public void Settings()
    {

    }

    public void ZagrajJeszczeRaz()
    {

    }

    public void KoniecGry()
    {
        statek.SetActive(true);
        wiatrak1.SetActive(true);
        wiatrak2.SetActive(true);
        animatorKoniecGry.Play("koniecGry");
        animatorZebatki1.Play("animacjaZebatka1");
        animatorZebatki2.Play("animacjaZebatka1");
        animatorZebatki3.Play("animacjaZebatka1");
        animatorStatku.Play("animacjaStatek");
        animatorStatystyki.Play("statystykiKoniecGry");
        animatorStatystyki.Play("statystykiKoniecGry");
        animatorKartaWygrana.Play("kartaWygranej");
    }
}
