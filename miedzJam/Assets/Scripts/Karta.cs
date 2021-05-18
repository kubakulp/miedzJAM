using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Karta : MonoBehaviour
{
    public Game game;
    public Talia talia;

    public int id;
    public int iloscWTalii;
    public bool czyUsuwanaZTali;

    public Text nazwa;
    public Text opis;
    public Text opis1;
    public Text opis2;
    public string PodajNazwe;
    public string PodajOpis;
    public string PodajOpis1;
    public string PodajOpis2;

    public int miedz1;
    public int srebro1;
    public int zadowolenie1;
    public int energia1;
    public int zanieczyszczenie1;
    public int gornicy1;
    public int roboty1;
    public int wynagrodzenie1;
    public int elektrownieWeglowe1;
    public int elektrownieWiatrowe1;
    public int zuzycieEnergi1;
    public int poziomWydobycia1;

    public int miedz2;
    public int srebro2;
    public int zadowolenie2;
    public int energia2;
    public int zanieczyszczenie2;
    public int gornicy2;
    public int roboty2;
    public int wynagrodzenie2;
    public int elektrownieWeglowe2;
    public int elektrownieWiatrowe2;
    public int zuzycieEnergi2;
    public int poziomWydobycia2;

    private void Start()
    {
        transform.position = new Vector3(430, 300, 0);
        nazwa.text = PodajNazwe;
        opis.text = PodajOpis;
        opis1.text = PodajOpis1;
        opis2.text = PodajOpis2;
        game = GetComponentInParent<Game>();
        talia = GetComponentInParent<Talia>();
    }

    public void OpcjaA()
    {
        game.ZmienIloscMiedzi(miedz1);
        game.ZmienIloscSrebra(srebro1);
        game.ZmienIloscZadowolenia(zadowolenie1);
        game.ZmienIloscEnergii(energia1);
        game.ZmienIloscZanieczyszczenia(zanieczyszczenie1);
        game.ZmienIloscGornikow(gornicy1);
        game.ZmienIloscRobotow(roboty1);
        game.ZmienIloscWynagrodzenia(wynagrodzenie1);
        game.ZmienIloscElektrowniWeglowych(elektrownieWeglowe1);
        game.ZmienIloscElektrowniWiatrowych(elektrownieWiatrowe1);
        game.ZmienIloscZuzyciaEnergi(zuzycieEnergi1);
        game.ZmienIloscPoziomuWydobycia(poziomWydobycia1);
        Destroy(gameObject);
        talia.LosujNowaKarte();
    }

    public void OpcjaB()
    {
        game.ZmienIloscMiedzi(miedz2);
        game.ZmienIloscSrebra(srebro2);
        game.ZmienIloscZadowolenia(zadowolenie2);
        game.ZmienIloscEnergii(energia2);
        game.ZmienIloscZanieczyszczenia(zanieczyszczenie2);
        game.ZmienIloscGornikow(gornicy2);
        game.ZmienIloscRobotow(roboty2);
        game.ZmienIloscWynagrodzenia(wynagrodzenie2);
        game.ZmienIloscElektrowniWeglowych(elektrownieWeglowe2);
        game.ZmienIloscElektrowniWiatrowych(elektrownieWiatrowe2);
        game.ZmienIloscZuzyciaEnergi(zuzycieEnergi2);
        game.ZmienIloscPoziomuWydobycia(poziomWydobycia2);
        Destroy(gameObject);
        talia.LosujNowaKarte();
    }
}
