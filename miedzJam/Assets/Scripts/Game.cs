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

    private int displayMiedz;
    private int displaySrebro;
    private int displayZadowolenie;
    private int displayEnergia;
    private int displayZanieczyszczenie;
    private int displayRoboty;
    private int displayGornicy;
    private int displayWynagrodzenie;
    private int displayElektrownieWeglowe;
    private int displayElektrownieWiatrowe;
    private int displayZuzycieEnergi;
    private int displayPoziomWydobycia;

    public int miedzWin;
    public int srebroLose;
    public int zadowolenieLose;
    public int energiaLose;
    public int zanieczyszczenieLose;

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
    public GameObject win;
    public Text loseText;
    public Text pasekLadowaniaInfo;
    public int idNastepnejKarty;
    public KartaWydarzenia obecnaKarta;

    private float pomPoziomWydobycia;
    private int pomPoziomWydobyciaInt;
    private int pomWynagrodzenie;
    private int pomZuzycieEnergi;

    public GameObject zero;
    public GameObject dwadziescia;
    public GameObject czterdziesci;
    public GameObject szescdziesiat;
    public GameObject osiemdziesiat;
    public GameObject sto;

    public int pomSrebro;
    public int pomEnergia;
    public int pomSrebro1;
    public int pomEnergia1;
    int pom;

    public AudioSource audioSource;

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

        WyswietlWynagrodzenie();
        WyswietlPoziomWydobycia();
        WyswietlZuzycieEnergii();

        wynagrodzenieText.text = pomWynagrodzenie.ToString();
        poziomWydobyciaText.text = pomPoziomWydobyciaInt.ToString();
        zuzycieEnergiText.text = pomZuzycieEnergi.ToString();

        displayMiedz = miedzValue;
        displaySrebro = srebroValue;
        displayZadowolenie = zadowolenieValue;
        displayEnergia = energiaValue;
        displayZanieczyszczenie = zanieczyszczenieValue;
        displayGornicy = gornicyValue;
        displayRoboty = robotyValue;
        displayElektrownieWeglowe = elektrownieWegloweValue;
        displayElektrownieWiatrowe = elektrownieWiatroweValue;
        displayWynagrodzenie = pomWynagrodzenie;
        displayPoziomWydobycia = pomPoziomWydobyciaInt;
        displayZuzycieEnergi = pomZuzycieEnergi;
        StartCoroutine(ScoreUpdater());
    }

    private IEnumerator ScoreUpdater()
    {

        while (true)
        {
            if(talia.licznikKart % talia.coIleKartJestMiesiac == 0 && CheckEndOrWin() == false && talia.licznikKart!=0)
            {
                if (displayMiedz < miedzValue && pom<2)
                {
                    pom = 1;
                    zero.SetActive(true);
                    dwadziescia.SetActive(false);
                    czterdziesci.SetActive(false);
                    szescdziesiat.SetActive(false);
                    osiemdziesiat.SetActive(false);
                    sto.SetActive(false);
                    displayMiedz++;
                    miedzText.text = displayMiedz.ToString();
                    pasekLadowaniaInfo.text = "Wydobywanie miedzi";
                    if (obecnaKarta != null)
                    {
                        obecnaKarta.gameObject.SetActive(false);
                    }
                }
                else if (displaySrebro < pomSrebro && pom<3)
                {
                    pom = 2;
                    zero.SetActive(false);
                    dwadziescia.SetActive(true);
                    czterdziesci.SetActive(false);
                    szescdziesiat.SetActive(false);
                    osiemdziesiat.SetActive(false);
                    sto.SetActive(false);
                    displaySrebro++; //Increment the display score by 1
                    srebroText.text = displaySrebro.ToString(); //Write it to the UI
                    pasekLadowaniaInfo.text = "Wydobywanie srebra";
                    if (obecnaKarta != null)
                    {
                        obecnaKarta.gameObject.SetActive(false);
                    }
                }
                else if (displayEnergia < pomEnergia && pom < 4)
                {
                    pom = 3;
                    zero.SetActive(false);
                    dwadziescia.SetActive(false);
                    czterdziesci.SetActive(true);
                    szescdziesiat.SetActive(false);
                    osiemdziesiat.SetActive(false);
                    sto.SetActive(false);
                    displayEnergia++;
                    energiaText.text = displayEnergia.ToString();
                    pasekLadowaniaInfo.text = "Generowanie energii";
                    if (obecnaKarta != null)
                    {
                        obecnaKarta.gameObject.SetActive(false);
                    }
                }
                else if (displayZanieczyszczenie < zanieczyszczenieValue && pom < 5)
                {
                    pom = 4;
                    zero.SetActive(false);
                    dwadziescia.SetActive(false);
                    czterdziesci.SetActive(false);
                    szescdziesiat.SetActive(true);
                    osiemdziesiat.SetActive(false);
                    sto.SetActive(false);
                    displayZanieczyszczenie++;
                    zanieczyszczenieText.text = displayZanieczyszczenie.ToString();
                    pasekLadowaniaInfo.text = "Badanie poziomu zanieczyszczeń";
                    if (obecnaKarta != null)
                    {
                        obecnaKarta.gameObject.SetActive(false);
                    }
                }
                else if (displayEnergia > pomEnergia1 && pom < 6)
                {
                    pom = 5;
                    zero.SetActive(false);
                    dwadziescia.SetActive(false);
                    czterdziesci.SetActive(false);
                    szescdziesiat.SetActive(false);
                    osiemdziesiat.SetActive(true);
                    sto.SetActive(false);
                    displayEnergia--;
                    energiaText.text = displayEnergia.ToString();
                    pasekLadowaniaInfo.text = "Wykorzystanie energii";
                    if (obecnaKarta != null)
                    {
                        obecnaKarta.gameObject.SetActive(false);
                    }
                }
                else if(displaySrebro > pomSrebro1 && pom < 7)
                {
                    pom = 6;
                    zero.SetActive(false);
                    dwadziescia.SetActive(false);
                    czterdziesci.SetActive(false);
                    szescdziesiat.SetActive(false);
                    osiemdziesiat.SetActive(false);
                    sto.SetActive(true);
                    displaySrebro--;
                    srebroText.text = displaySrebro.ToString();
                    pasekLadowaniaInfo.text = "Wypłacanie pensji";
                    if (obecnaKarta != null)
                    {
                        obecnaKarta.gameObject.SetActive(false);
                    }
                }
                else
                {
                    pom = 7;
                    zero.SetActive(false);
                    dwadziescia.SetActive(false);
                    czterdziesci.SetActive(false);
                    szescdziesiat.SetActive(false);
                    osiemdziesiat.SetActive(false);
                    sto.SetActive(false);
                    pasekLadowaniaInfo.text = "";
                    if(obecnaKarta!=null)
                    {
                        obecnaKarta.gameObject.SetActive(true);
                    }
                }
            }
            else
            {
                    if (displayMiedz < miedzValue)
                    {
                        displayMiedz++; //Increment the display score by 1
                        miedzText.text = displayMiedz.ToString(); //Write it to the UI
                    }
                    else if (displayMiedz > miedzValue)
                    {
                        displayMiedz--;
                        miedzText.text = displayMiedz.ToString(); //Write it to the UI
                    }

                    if (displaySrebro < srebroValue)
                    {
                        displaySrebro++; //Increment the display score by 1
                        srebroText.text = displaySrebro.ToString(); //Write it to the UI
                    }
                    else if (displaySrebro > srebroValue)
                    {
                        displaySrebro--;
                        srebroText.text = displaySrebro.ToString(); //Write it to the UI
                    }

                    if (displayZadowolenie < zadowolenieValue)
                    {
                        displayZadowolenie++; //Increment the display score by 1
                        zadowolenieText.text = displayZadowolenie.ToString(); //Write it to the UI
                    }
                    else if (displayZadowolenie > zadowolenieValue)
                    {
                        displayZadowolenie--;
                        zadowolenieText.text = displayZadowolenie.ToString(); //Write it to the UI
                    }

                    if (displayEnergia < energiaValue)
                    {
                        displayEnergia++; //Increment the display score by 1
                        energiaText.text = displayEnergia.ToString(); //Write it to the UI
                    }
                    else if (displayEnergia > energiaValue)
                    {
                        displayEnergia--;
                        energiaText.text = displayEnergia.ToString(); //Write it to the UI
                    }

                    if (displayZanieczyszczenie < zanieczyszczenieValue)
                    {
                        displayZanieczyszczenie++; //Increment the display score by 1
                        zanieczyszczenieText.text = displayZanieczyszczenie.ToString(); //Write it to the UI
                    }
                    else if (displayZanieczyszczenie > zanieczyszczenieValue)
                    {
                        displayZanieczyszczenie--;
                        zanieczyszczenieText.text = displayZanieczyszczenie.ToString(); //Write it to the UI
                    }

                    if (displayGornicy < gornicyValue)
                    {
                        displayGornicy++; //Increment the display score by 1
                        gornicyText.text = displayGornicy.ToString(); //Write it to the UI
                    }
                    else if (displayGornicy > gornicyValue)
                    {
                        displayGornicy--;
                        gornicyText.text = displayGornicy.ToString(); //Write it to the UI
                    }

                    if (displayRoboty < robotyValue)
                    {
                        displayRoboty++; //Increment the display score by 1
                        robotyText.text = displayRoboty.ToString(); //Write it to the UI
                    }
                    else if (displayRoboty > robotyValue)
                    {
                        displayRoboty--;
                        robotyText.text = displayRoboty.ToString(); //Write it to the UI
                    }

                    if (displayElektrownieWeglowe < elektrownieWegloweValue)
                    {
                        displayElektrownieWeglowe++; //Increment the display score by 1
                        elektrownieWegloweText.text = displayElektrownieWeglowe.ToString(); //Write it to the UI
                    }
                    else if (displayElektrownieWeglowe > elektrownieWegloweValue)
                    {
                        displayElektrownieWeglowe--;
                        elektrownieWegloweText.text = displayElektrownieWeglowe.ToString(); //Write it to the UI
                    }

                    if (displayElektrownieWiatrowe < elektrownieWiatroweValue)
                    {
                        displayElektrownieWiatrowe++; //Increment the display score by 1
                        elektrownieWiatroweText.text = displayElektrownieWiatrowe.ToString(); //Write it to the UI
                    }
                    else if (displayElektrownieWiatrowe > elektrownieWiatroweValue)
                    {
                        displayElektrownieWiatrowe--;
                        elektrownieWiatroweText.text = displayElektrownieWiatrowe.ToString(); //Write it to the UI
                    }

                    if (displayWynagrodzenie < pomWynagrodzenie)
                    {
                        displayWynagrodzenie++; //Increment the display score by 1
                        wynagrodzenieText.text = displayWynagrodzenie.ToString(); //Write it to the UI
                    }
                    else if (displayWynagrodzenie > pomWynagrodzenie)
                    {
                        displayWynagrodzenie--;
                        wynagrodzenieText.text = displayWynagrodzenie.ToString(); //Write it to the UI
                    }

                    if (displayPoziomWydobycia < pomPoziomWydobyciaInt)
                    {
                        displayPoziomWydobycia++; //Increment the display score by 1
                        poziomWydobyciaText.text = displayPoziomWydobycia.ToString(); //Write it to the UI
                    }
                    else if (displayPoziomWydobycia > pomPoziomWydobyciaInt)
                    {
                        displayPoziomWydobycia--;
                        poziomWydobyciaText.text = displayPoziomWydobycia.ToString(); //Write it to the UI
                    }

                    if (displayZuzycieEnergi < pomZuzycieEnergi)
                    {
                        displayZuzycieEnergi++; //Increment the display score by 1
                        zuzycieEnergiText.text = displayZuzycieEnergi.ToString(); //Write it to the UI
                    }
                    else if (displayZuzycieEnergi > pomZuzycieEnergi)
                    {
                        displayZuzycieEnergi--;
                        zuzycieEnergiText.text = displayZuzycieEnergi.ToString(); //Write it to the UI
                    }
            }

            yield return new WaitForSeconds(0.01f); // I used .2 secs but you can update it as fast as you want
        }
    }

    public void ZmienIloscMiedzi(int x)
    {
        miedzValue = miedzValue + x;
    }

    public void ZmienIloscSrebra(int x)
    {
        srebroValue = srebroValue + x;
    }

    public void ZmienIloscZadowolenia(int x)
    {
        zadowolenieValue = zadowolenieValue + x;
    }

    public void ZmienIloscEnergii(int x)
    {
        energiaValue = energiaValue + x;
    }

    public void ZmienIloscZanieczyszczenia(int x)
    {
        zanieczyszczenieValue = zanieczyszczenieValue + x;
    }

    public void ZmienIloscGornikow(int x)
    {
        gornicyValue = gornicyValue + x;
    }

    public void ZmienIloscRobotow(int x)
    {
        robotyValue = robotyValue + x;
    }

    public void ZmienIloscWynagrodzenia(int x)
    {
        wynagrodzenieValue = wynagrodzenieValue + x;
    }

    public void ZmienIloscElektrowniWeglowych(int x)
    {
        elektrownieWegloweValue = elektrownieWegloweValue + x;
    }

    public void ZmienIloscElektrowniWiatrowych(int x)
    {
        elektrownieWiatroweValue = elektrownieWiatroweValue + x;
    }

    public void ZmienIloscZuzyciaEnergi(int x)
    {
        zuzycieEnergiValue = zuzycieEnergiValue + x;
    }

    public void ZmienIloscPoziomuWydobycia(int x)
    {
        poziomWydobyciaValue = poziomWydobyciaValue + x;
    }

    public void WyswietlWynagrodzenie()
    {
        pomWynagrodzenie = wynagrodzenieValue * gornicyValue;
    }

    public void WyswietlPoziomWydobycia()
    {
        pomPoziomWydobycia = (200 * robotyValue) + (poziomWydobyciaValue * gornicyValue);
        pomPoziomWydobyciaInt = (200 * robotyValue) + (poziomWydobyciaValue * gornicyValue);
    }

    public void WyswietlZuzycieEnergii()
    {
        pomZuzycieEnergi = (120 * elektrownieWegloweValue) + (150 * elektrownieWiatroweValue) + (100 * robotyValue);
    }

    public bool CheckEndOrWin()
    {
        if (miedzWin <= miedzValue)
        {
            Win();
            return true;
        }
        else if ((srebroLose >= srebroValue) || (zadowolenieLose >= zadowolenieValue) || (energiaLose >= energiaValue) || (zanieczyszczenieLose <= zanieczyszczenieValue))
        {
            Lose();
            return true;
        }
        return false;
    }

    private void Win()
    {
        if (win.gameObject != null)
        {
            win.gameObject.SetActive(true);
        }
    }

    private void Lose()
    {
        if(srebroLose >= srebroValue)
        {
            loseText.text = "Masz za mało srebra, żeby opłacić górników";
        }else if(zadowolenieLose>=zadowolenieValue)
        {
            loseText.text = "Górnicy buntują się przeciwko warunkom pracy";
        }
        else if(energiaLose>=energiaValue)
        {
            loseText.text = "Nie masz dość energii, żeby kontynuować wydobycie";
        }
        else if(zanieczyszczenieLose <= zanieczyszczenieValue)
        {
            loseText.text = "Poziom zanieczyszczenia jest zbyt wysoki";
        }
        lose.gameObject.SetActive(true);
        audioSource.mute = true;
    }

    public void Miesiac()
    {
        pom = 0;
        int pom1 = 0;
        int x = (int)(pomPoziomWydobycia * 0.666);
        if(x != (pomPoziomWydobycia * 0.666f))
        {
            pom1 = 1;
        }
        ZmienIloscSrebra(x+pom1);
        pomSrebro = srebroValue;
        ZmienIloscMiedzi((int)(pomPoziomWydobycia*0.334f));
        ZmienIloscEnergii((250*elektrownieWegloweValue)+(310*elektrownieWiatroweValue));
        pomEnergia = energiaValue;
        ZmienIloscZanieczyszczenia(10*elektrownieWegloweValue);
        ZmienIloscEnergii(-((120 * elektrownieWegloweValue) + (150 * elektrownieWiatroweValue) + (100 * robotyValue)));
        pomEnergia1 = energiaValue;
        ZmienIloscSrebra(-(wynagrodzenieValue * gornicyValue));
        pomSrebro1 = srebroValue;
    }
}
