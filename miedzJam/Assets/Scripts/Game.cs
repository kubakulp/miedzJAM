using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public int miedzValue;
    public int srebroValue;
    public int zadowolenieValue;
    public int energiaValue;
    public int zanieczyszczenieValue;
    public int gornicyValue;
    public int robotyValue;
    public int wynagrodzenieValue;
    public int elektrownieWegloweValue;
    public int elektrownieWiatroweValue;
    public int zuzycieEnergiValue;
    public int poziomWydobyciaValue;

    public int miedzWin;
    public int srebroWin;
    public int zadowolenieWin;
    public int energiaWin;
    public int zanieczyszczenieWin;
    public int gornicyWin;
    public int robotyWin;
    public int wynagrodzenieWin;
    public int elektrownieWegloweWin;
    public int elektrownieWiatroweWin;
    public int zuzycieEnergiWin;
    public int poziomyWydobyciaWin;

    public int miedzLose;
    public int srebroLose;
    public int zadowolenieLose;
    public int energiaLose;
    public int zanieczyszczenieLose;
    public int gornicyLose;
    public int robotyLose;
    public int wynagrodzenieLose;
    public int elektrownieWegloweLose;
    public int elektrownieWiatroweLose;
    public int zuzycieEnergiLose;
    public int poziomyWydobyciaLose;

    public Text miedzText;
    public Text srebroText;
    public Text zadowolenieText;
    public Text energiaText;
    public Text zanieczyszczenieText;
    public Text gornicyText;
    public Text robotyText;
    public Text wynagrodzenieText;
    public Text elektrownieWegloweText;
    public Text elektrownieWiatroweText;
    public Text zuzycieEnergiText;
    public Text poziomWydobyciaText;

    public Talia talia;
    public GameObject lose;
    public Button winButton;

    public bool istniejePub;
    private float pomPoziomWydobycia;

    private void Start()
    {
        miedzText.text = miedzValue.ToString();
        srebroText.text = srebroValue.ToString();
        zadowolenieText.text = zadowolenieValue.ToString();
        energiaText.text = energiaValue.ToString();
        zanieczyszczenieText.text = zanieczyszczenieValue.ToString();
        gornicyText.text = gornicyValue.ToString();
        robotyText.text = robotyValue.ToString();
        elektrownieWegloweText.text = elektrownieWegloweValue.ToString();
        elektrownieWiatroweText.text = elektrownieWiatroweValue.ToString();
        zuzycieEnergiText.text = zuzycieEnergiValue.ToString();
        poziomWydobyciaText.text = poziomWydobyciaValue.ToString();
        WyswietlWynagrodzenie();
        WyswietlPoziomWydobycia();
        WyswietlZuzycieEnergii();
    }

    public void ZmienIloscMiedzi(int x)
    {
        miedzValue = miedzValue + x;
        miedzText.text = miedzValue.ToString();
    }

    public void ZmienIloscSrebra(int x)
    {
        srebroValue = srebroValue + x;
        srebroText.text = srebroValue.ToString();
    }

    public void ZmienIloscZadowolenia(int x)
    {
        zadowolenieValue = zadowolenieValue + x;
        zadowolenieText.text = zadowolenieValue.ToString();
    }

    public void ZmienIloscEnergii(int x)
    {
        energiaValue = energiaValue + x;
        energiaText.text = energiaValue.ToString();
    }

    public void ZmienIloscZanieczyszczenia(int x)
    {
        zanieczyszczenieValue = zanieczyszczenieValue + x;
        zanieczyszczenieText.text = zanieczyszczenieValue.ToString();
    }

    public void ZmienIloscGornikow(int x)
    {
        gornicyValue = gornicyValue + x;
        gornicyText.text = gornicyValue.ToString();
    }

    public void ZmienIloscRobotow(int x)
    {
        robotyValue = robotyValue + x;
        robotyText.text = robotyValue.ToString();
    }

    public void ZmienIloscWynagrodzenia(int x)
    {
        wynagrodzenieValue = wynagrodzenieValue + x;
    }

    public void ZmienIloscElektrowniWeglowych(int x)
    {
        elektrownieWegloweValue = elektrownieWegloweValue + x;
        elektrownieWegloweText.text = elektrownieWegloweValue.ToString();
    }

    public void ZmienIloscElektrowniWiatrowych(int x)
    {
        elektrownieWiatroweValue = elektrownieWiatroweValue + x;
        elektrownieWiatroweText.text = elektrownieWiatroweValue.ToString();
    }

    public void ZmienIloscZuzyciaEnergi(int x)
    {
        zuzycieEnergiValue = zuzycieEnergiValue + x;
        zuzycieEnergiText.text = zuzycieEnergiValue.ToString();
    }

    public void ZmienIloscPoziomuWydobycia(int x)
    {
        poziomWydobyciaValue = poziomWydobyciaValue + x;
        poziomWydobyciaText.text = poziomWydobyciaValue.ToString();
    }

    public void WyswietlWynagrodzenie()
    {
        wynagrodzenieText.text = (wynagrodzenieValue*gornicyValue).ToString();
    }

    public void WyswietlPoziomWydobycia()
    {
        poziomWydobyciaText.text = ((15 * robotyValue) + (poziomWydobyciaValue * gornicyValue)).ToString();
        pomPoziomWydobycia = (15 * robotyValue) + (poziomWydobyciaValue * gornicyValue);
    }

    public void WyswietlZuzycieEnergii()
    {
        zuzycieEnergiText.text = ((10 * elektrownieWegloweValue) + (5 * elektrownieWiatroweValue) + (2 * robotyValue)).ToString();
    }

    public bool CheckEndOrWin()
    {

        if ((miedzWin <= miedzValue) || (srebroWin <= srebroValue) || (zadowolenieWin <= zadowolenieValue) || 
            (energiaWin <= energiaValue) || (zanieczyszczenieWin <= zanieczyszczenieValue) || (gornicyWin <= gornicyValue) ||
            (robotyWin <= robotyValue) || (wynagrodzenieWin <= wynagrodzenieValue) || (elektrownieWegloweWin <= elektrownieWegloweValue) || 
            (elektrownieWiatroweWin <= elektrownieWiatroweValue) || (zuzycieEnergiWin <= zuzycieEnergiValue) || (poziomyWydobyciaWin <= poziomWydobyciaValue))
        {
            Win();
            return true;
        }
        else if ((miedzLose >= miedzValue) || (srebroLose >= srebroValue) || (zadowolenieLose >= zadowolenieValue) ||
            (energiaLose >= energiaValue) || (zanieczyszczenieLose >= zanieczyszczenieValue) ||
            (gornicyLose >= gornicyValue) || (robotyLose >= robotyValue) || (wynagrodzenieLose >= wynagrodzenieValue) || 
            (elektrownieWegloweLose >= elektrownieWegloweValue) || (elektrownieWiatroweLose >= elektrownieWiatroweValue) || 
            (zuzycieEnergiLose >= zuzycieEnergiValue) || (poziomyWydobyciaLose >= poziomWydobyciaValue))
        {
            Lose();
            return true;
        }
        return false;
    }

    private void Win()
    {
        winButton.gameObject.SetActive(true);
    }

    private void Lose()
    {
        lose.gameObject.SetActive(true);
    }

    public void Miesiac()
    {
        int pom = 0;
        int x = (int)(pomPoziomWydobycia * 2)/ 3;
        if(x != (pomPoziomWydobycia * 2)/ 3)
        {
            pom = 1;
        }
        ZmienIloscSrebra(x+pom);
        ZmienIloscMiedzi((int)(pomPoziomWydobycia/3));
        ZmienIloscEnergii((80*elektrownieWegloweValue)+(60*elektrownieWiatroweValue));
        ZmienIloscZanieczyszczenia(10*elektrownieWegloweValue);
        ZmienIloscEnergii(-zuzycieEnergiValue);
        ZmienIloscSrebra(-(wynagrodzenieValue * gornicyValue));
    }
}
