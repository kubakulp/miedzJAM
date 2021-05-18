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

    private void Start()
    {
        miedzText.text = miedzValue.ToString();
        srebroText.text = srebroValue.ToString();
        zadowolenieText.text = zadowolenieValue.ToString();
        energiaText.text = energiaValue.ToString();
        zanieczyszczenieText.text = zanieczyszczenieValue.ToString();
        gornicyText.text = gornicyValue.ToString();
        robotyText.text = robotyValue.ToString();
        wynagrodzenieText.text = wynagrodzenieValue.ToString();
        elektrownieWegloweText.text = elektrownieWegloweValue.ToString();
        elektrownieWiatroweText.text = elektrownieWiatroweValue.ToString();
        zuzycieEnergiText.text = zuzycieEnergiValue.ToString();
        poziomWydobyciaText.text = poziomWydobyciaValue.ToString();
        talia.LosujNowaKarte();
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
        wynagrodzenieText.text = wynagrodzenieValue.ToString();
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
}
