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

    //Statystyki po kliknieciu pierwszej opcji//
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

    //Statystyki po kliknieciu drugiej opcji//
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

    //Warunki//
    public int iloscMiedziWiekszaNiz;
    public int iloscMiedziMniejszaNiz;
    public int iloscSrebraWiekszaNiz;
    public int iloscSrebraMniejszaNiz;
    public int iloscZadowoleniaWiekszaNiz;
    public int iloscZadowoleniaMniejszaNiz;
    public int iloscEnergiWiekszaNiz;
    public int iloscEnergiMniejszaNiz;
    public int iloscZanieczyszczeniaWiekszaNiz;
    public int iloscZanieczyszczeniaMniejszaNiz;
    public int iloscGornikowWiekszaNiz;
    public int iloscGornikowMniejszaNiz;
    public int iloscRobotowWiekszaNiz;
    public int iloscRobotowMniejszaNiz;
    public int iloscWynagrodzeniaWiekszaNiz;
    public int iloscWynagrodzeniaMniejszaNiz;
    public int iloscElektrowniWeglowychWiekszaNiz;
    public int iloscElektrowniWeglowychMniejszaNiz;
    public int iloscElektrowniWiatrowychWiekszaNiz;
    public int iloscElektrowniWiatrowychMniejszaNiz;
    public int iloscZuzyciaEnergiWiekszaNiz;
    public int iloscZuzyciaEnergiMniejszaNiz;
    public int wymaganyPoziomWydobyciaWiekszyNiz;
    public int wymaganyPoziomWydobyciaMniejszyNiz;
    public bool wymagaPubu;

    public bool budujePub;

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
        if(game.CheckEndOrWin()==false)
        {
            talia.LosujNowaKarte();
        }

        if(budujePub==true)
        {
            game.istniejePub = true;
        }
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
        if (game.CheckEndOrWin() == false)
        {
            talia.LosujNowaKarte();
        }
    }

    private bool Porownaj(int x, int y, int z)
    {
        if(x>=y && (x<=z||z==0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool CzyMozliwa(Game game)
    {
        if(Porownaj(game.miedzValue,iloscMiedziMniejszaNiz,iloscMiedziWiekszaNiz) == true)
        {
            if (Porownaj(game.srebroValue, iloscSrebraMniejszaNiz, iloscSrebraWiekszaNiz) == true)
            {
                if (Porownaj(game.zadowolenieValue, iloscZadowoleniaMniejszaNiz, iloscZadowoleniaWiekszaNiz) == true)
                {
                    if (Porownaj(game.energiaValue, iloscEnergiMniejszaNiz, iloscEnergiWiekszaNiz) == true)
                    {
                        if (Porownaj(game.zanieczyszczenieValue, iloscZanieczyszczeniaMniejszaNiz, iloscZanieczyszczeniaWiekszaNiz) == true)
                        {
                            if (Porownaj(game.gornicyValue, iloscGornikowMniejszaNiz, iloscGornikowWiekszaNiz) == true)
                            {
                                if (Porownaj(game.robotyValue, iloscRobotowMniejszaNiz, iloscRobotowWiekszaNiz) == true)
                                {
                                    if (Porownaj(game.wynagrodzenieValue, iloscWynagrodzeniaMniejszaNiz, iloscWynagrodzeniaWiekszaNiz) == true)
                                    {
                                        if (Porownaj(game.elektrownieWegloweValue, iloscElektrowniWeglowychMniejszaNiz, iloscElektrowniWeglowychWiekszaNiz) == true)
                                        {
                                            if (Porownaj(game.elektrownieWiatroweValue, iloscElektrowniWiatrowychMniejszaNiz, iloscElektrowniWiatrowychWiekszaNiz) == true)
                                            {
                                                if (Porownaj(game.zuzycieEnergiValue, iloscZuzyciaEnergiMniejszaNiz, iloscZuzyciaEnergiWiekszaNiz) == true)
                                                {
                                                    if (Porownaj(game.poziomWydobyciaValue, wymaganyPoziomWydobyciaMniejszyNiz, wymaganyPoziomWydobyciaWiekszyNiz) == true)
                                                    {
                                                        if((wymagaPubu == true && game.istniejePub == true)||wymagaPubu == false)
                                                        {
                                                            return true;
                                                        }
                                                        else
                                                        {
                                                            return false;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        return false;
                                                    }
                                                }
                                                else
                                                {
                                                    return false;
                                                }
                                            }
                                            else
                                            {
                                                return false;
                                            }
                                        }
                                        else
                                        {
                                            return false;
                                        }
                                    }
                                    else
                                    {
                                        return false;
                                    }
                                }
                                else
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}
