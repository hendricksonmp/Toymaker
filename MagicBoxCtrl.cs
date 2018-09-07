using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MagicBoxCtrl : MonoBehaviour
{
    public bool easy;
   
    public Transform Lvl1;
    public Text Lvl1CarsText;
    public Text Lvl1RocketsText;
    public Text Lvl1BearsText;

    public Transform Lvl2;
    public Text Lvl2PlanesText;
    public Text Lvl2JetsText;
    public Text Lvl2DragonsText;

    public Transform Lvl3;
    public Text Lvl3CarsText;
    public Text Lvl3RocketsText;
    public Text Lvl3BearsText;
    public Text Lvl3PlanesText;
    public Text Lvl3JetsText;
    public Text Lvl3DragonsText;

    public Transform Lvl4;
    public Text Lvl4TrainsText;
    public Text Lvl4ShuttlesText;

    public Transform Lvl5;
    public Text Lvl5CarsText;
    public Text Lvl5RocketsText;
    public Text Lvl5BearsText;
    public Text Lvl5TrainsText;
    public Text Lvl5ShuttlesText;

    public Transform Lvl6;
    public Text Lvl6BoatsText;
    public Text Lvl6SubsText;
    public Text Lvl6TugsText;

    public Transform Lvl7;
    public Text Lvl7TrainsText;
    public Text Lvl7ShuttlesText;
    public Text Lvl7BoatsText;
    public Text Lvl7SubsText;
    public Text Lvl7TugsText;

    public Transform Lvl8;
    public Text Lvl8PlanesText;
    public Text Lvl8JetsText;
    public Text Lvl8DragonsText;
    public Text Lvl8BoatsText;
    public Text Lvl8SubsText;
    public Text Lvl8TugsText;

    public Text AdventText;

    public Text BestL1Txt;
    public Text BestL2Txt;
    public Text BestL3Txt;
    public Text BestL4Txt;
    public Text BestL5Txt;
    public Text BestL6Txt;
    public Text BestL7Txt;
    public Text BestL8Txt;

    int BestL1;
    int BestL2;
    int BestL3;
    int BestL4;
    int BestL5;
    int BestL6;
    int BestL7;
    int BestL8;

    public Transform prefabBlockA;
    public Transform prefabBlockB;
    public Transform prefabBlockC;
    public Transform prefabTutorialBlock1;
    public Transform prefabTutorialBlock2;
    public Transform prefabTutorialBlock3;
    public Transform prefabTutorialBlock4;
    public Transform prefabTutorialBlock5;
    public Transform prefabTutorialBlock6;
    public Transform prefabTutorialBlock7;
    public Transform prefabTutorialBlock8;

    public float waitTime;
    public List<Transform> Wall;

    Transform cloneBlock;

    public int carsFound = 0;
    public int rocketsFound = 0;
    public int planesFound = 0;
    public int jetsFound = 0;
    public int dragonsFound = 0;
    public int trainsFound = 0;
    public int boatsFound = 0;
    public int shuttlesFound = 0;
    public int bearsFound = 0;
    public int tugsFound = 0;
    public int subsFound = 0;

    int redCarsFound = 0;
    int redRocketsFound = 0;
    int redPlanesFound = 0;
    int redJetsFound = 0;
    int redDragonsFound = 0;
    int redTrainsFound = 0;
    int redBoatsFound = 0;
    int redShuttlesFound = 0;
    int redBearsFound = 0;
    int redTugsFound = 0;
    int redSubsFound = 0;


    int cyanCarsFound = 0;
    int cyanRocketsFound = 0;
    int cyanPlanesFound = 0;
    int cyanJetsFound = 0;
    int cyanDragonsFound = 0;
    int cyanTrainsFound = 0;
    int cyanBoatsFound = 0;
    int cyanShuttlesFound = 0;
    int cyanBearsFound = 0;
    int cyanTugsFound = 0;
    int cyanSubsFound = 0;

    int yellowCarsFound = 0;
    int yellowRocketsFound = 0;
    int yellowPlanesFound = 0;
    int yellowJetsFound = 0;
    int yellowDragonsFound = 0;
    int yellowTrainsFound = 0;
    int yellowBoatsFound = 0;
    int yellowShuttlesFound = 0;
    int yellowBearsFound = 0;
    int yellowTugsFound = 0;
    int yellowSubsFound = 0;

    int greenCarsFound = 0;
    int greenRocketsFound = 0;
    int greenPlanesFound = 0;
    int greenJetsFound = 0;
    int greenDragonsFound = 0;
    int greenTrainsFound = 0;
    int greenBoatsFound = 0;
    int greenShuttlesFound = 0;
    int greenBearsFound = 0;
    int greenTugsFound = 0;
    int greenSubsFound = 0;


    int blueCarsFound = 0;
    int blueRocketsFound = 0;
    int bluePlanesFound = 0;
    int blueJetsFound = 0;
    int blueDragonsFound = 0;
    int blueTrainsFound = 0;
    int blueBoatsFound = 0;
    int blueShuttlesFound = 0;
    int blueBearsFound = 0;
    int blueTugsFound = 0;
    int blueSubsFound = 0;


    Transform cloneCar;
    Transform cloneRocket;
    Transform cloneAirplane;
    Transform cloneJet;
    Transform cloneDragon;
    Transform cloneTrain;
    Transform cloneBoat;
    Transform cloneShuttle;
    Transform cloneBear;
    Transform cloneTug;
    Transform cloneSub;


    Transform cloneElf;

    public Car car;
    public Rocket rocket;
    public Airplane airplane;
    public Jet jet;
    public Dragon dragon;
    public Train train;
    public Boat boat;
    public Shuttle shuttle;
    public Bear bear;
    public Tug tug;
    public Sub sub;


    public ToyCtrl toyCtrl;
    public Transform prefabElf;

    public Transform prefabRedCar;
    public Transform prefabRedRocket;
    public Transform prefabRedAirplane;
    public Transform prefabRedJet;
    public Transform prefabRedDragon;
    public Transform prefabRedTrain;
    public Transform prefabRedBoat;
    public Transform prefabRedShuttle;
    public Transform prefabRedBear;
    public Transform prefabRedTug;
    public Transform prefabRedSub;


    public Transform prefabCyanCar;
    public Transform prefabCyanRocket;
    public Transform prefabCyanAirplane;
    public Transform prefabCyanJet;
    public Transform prefabCyanDragon;
    public Transform prefabCyanTrain;
    public Transform prefabCyanBoat;
    public Transform prefabCyanShuttle;
    public Transform prefabCyanBear;
    public Transform prefabCyanTug;
    public Transform prefabCyanSub;


    public Transform prefabYellowCar;
    public Transform prefabYellowRocket;
    public Transform prefabYellowAirplane;
    public Transform prefabYellowJet;
    public Transform prefabYellowDragon;
    public Transform prefabYellowTrain;
    public Transform prefabYellowBoat;
    public Transform prefabYellowShuttle;
    public Transform prefabYellowBear;
    public Transform prefabYellowTug;
    public Transform prefabYellowSub;


    public Transform prefabGreenCar;
    public Transform prefabGreenRocket;
    public Transform prefabGreenAirplane;
    public Transform prefabGreenJet;
    public Transform prefabGreenDragon;
    public Transform prefabGreenTrain;
    public Transform prefabGreenBoat;
    public Transform prefabGreenShuttle;
    public Transform prefabGreenBear;
    public Transform prefabGreenTug;
    public Transform prefabGreenSub;


    public Transform prefabBlueCar;
    public Transform prefabBlueRocket;
    public Transform prefabBlueAirplane;
    public Transform prefabBlueJet;
    public Transform prefabBlueDragon;
    public Transform prefabBlueTrain;
    public Transform prefabBlueBoat;
    public Transform prefabBlueShuttle;
    public Transform prefabBlueBear;
    public Transform prefabBlueTug;
    public Transform prefabBlueSub;

    PlayerCtrl playerCtrl;

    int Level = 1;

 
    string color;
    float x, y, z;

    int daysUntilXmas;

    public Text timer;
    public Text timerText;
    float startTime;
    int time;

    bool once = true;
    bool starting;
    bool stopping;
    bool tutorialRequested;

    void Awake()
    {
        // Initialize best time
        // Overwrite w/saved values
        BestL1 = 599;
        BestL2 = 599;
        BestL3 = 599;
        BestL4 = 599;
        BestL5 = 599;
        BestL6 = 599;
        BestL7 = 599;
        BestL8 = 599;

        string minutes = ((int)BestL1 / 60).ToString();
        string seconds = ((int)BestL1 % 60).ToString("d2");
        BestL1Txt.text = minutes + ":" + seconds;
        BestL1Txt.color = Color.white;


        minutes = ((int)BestL2 / 60).ToString();
        seconds = ((int)BestL2 % 60).ToString("d2");
        BestL2Txt.text = minutes + ":" + seconds;
        BestL2Txt.color = Color.white;


        minutes = ((int)BestL3 / 60).ToString();
        seconds = ((int)BestL3 % 60).ToString("d2");
        BestL3Txt.text = minutes + ":" + seconds;
        BestL3Txt.color = Color.white;


        minutes = ((int)BestL4 / 60).ToString();
        seconds = ((int)BestL4 % 60).ToString("d2");
        BestL4Txt.text = minutes + ":" + seconds;
        BestL4Txt.color = Color.white;


        minutes = ((int)BestL5/ 60).ToString();
        seconds = ((int)BestL5 % 60).ToString("d2");
        BestL5Txt.text = minutes + ":" + seconds;
        BestL5Txt.color = Color.white;


        minutes = ((int)BestL6/ 60).ToString();
        seconds = ((int)BestL6 % 60).ToString("d2");
        BestL6Txt.text = minutes + ":" + seconds;
        BestL6Txt.color = Color.white;


        minutes = ((int)BestL7 / 60).ToString();
        seconds = ((int)BestL7 % 60).ToString("d2");
        BestL7Txt.text = minutes + ":" + seconds;
        BestL7Txt.color = Color.white;


        minutes = ((int)BestL8 / 60).ToString();
        seconds = ((int)BestL8 % 60).ToString("d2");
        BestL8Txt.text = minutes + ":" + seconds;
        BestL8Txt.color = Color.white;

        // Tutorial Request
        tutorialRequested = true;

        // Startup initialization init timer
        starting = true;

        // Throw Start/Stop Lever check best time
        stopping = false;

        //
        startTime = Time.time;

        playerCtrl = FindObjectOfType<PlayerCtrl>();

        //easy prevents continued selection of completed tasks
        easy = true;

        car = GetComponent<Car>();
        rocket = GetComponent<Rocket>();
        airplane = GetComponent<Airplane>();
        dragon = GetComponent<Dragon>();
        train = GetComponent<Train>();
        boat = GetComponent<Boat>();
        shuttle = GetComponent<Shuttle>();
        bear = GetComponent<Bear>();
        tug = GetComponent<Tug>();
        sub = GetComponent<Sub>();

        SetLevel(Level);

        toyCtrl = GetComponent<ToyCtrl>();

        StartCoroutine("WaitForIt");
        ResetCounts();

        //Advent count down
        daysUntilXmas = 365 - 6 - DateTime.Now.DayOfYear;
        if (daysUntilXmas < 0)
            daysUntilXmas = 365 + daysUntilXmas;

        //print(daysUntilXmas);
        AdventText.text = "" + daysUntilXmas;
    }

    // Update is called once per frame
    void Update()
    {
        // Update appears to only run once/second with IEnumerator active

        float t = Time.time - startTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = ((int)t % 60).ToString("d2");

        if (!starting && !stopping)
        {
            timer.text = minutes + ":" + seconds;
            time = (int) t;
        }
    }

    IEnumerator WaitForIt()
    {            
        while (true)
        {
            //Prestart...
            yield return new WaitForSeconds(.1f);

            //Elf asks about Tutorial

            if (tutorialRequested)
            {
                StartCoroutine(Tutorial());
                tutorialRequested = false;
            }
                else
            {

                if (playerCtrl.GetStart())
                {
                    if (starting)
                    {
                        startTime = Time.time;
                        starting = false;
                    }

                    // prefabA and prefabB have different speeds.  Prefab C has different numb colored blocks
                    // Wait time (between spawning blocks) is set here while speed is set in blockctrl.
                    if (Level == 1 || Level == 2)
                    {
                        waitTime = 1.5f;
                        cloneBlock = Instantiate(prefabBlockA, new Vector3(3.3f, 8.6f, 6.0f), Quaternion.identity);
                    }
                    else if (Level > 2 || Level < 9)
                    {
                        waitTime = 1;
                        cloneBlock = Instantiate(prefabBlockB, new Vector3(3.3f, 8.6f, 6.0f), Quaternion.identity);
                    }
                    else if (Level > 8)
                    {
                        waitTime = 1;
                        cloneBlock = Instantiate(prefabBlockC, new Vector3(3.3f, 8.6f, 6.0f), Quaternion.identity);
                    }

                    yield return new WaitForSeconds(waitTime);
                    Wall.Add(cloneBlock);


                    if (AngryElf())
                    {
                        Transform block;
                        BlockCtrl blockCtrl;
                        string loc;

                        //print("Angry Elf");

                        cloneElf = Instantiate(prefabElf, new Vector3(0f, 0f, 0f), new Quaternion(0f, 180f, 0f, 0f));
                        yield return new WaitForSeconds(10);

                        playerCtrl.SetStop();

                        for (int i = 0; i < Wall.Count; i++)
                        {
                            //Make sure the block we're looking at is in the wall (Race conditions make some blocks appear before they're part of the wall
                            if (Wall[i] != null && Wall[i].GetComponent<Transform>() != null)
                            {
                                block = Wall[i].GetComponent<Transform>();
                                blockCtrl = block.GetComponent<BlockCtrl>();
                                loc = blockCtrl.GetBlockLocation();


                                if (block.position.z > 6.1f || block.position.z < 5.9f || block.position.x < -5.0f ||
                                   (loc != null && loc != "" && loc[0] != 'R' && loc[2] != 'C'))
                                {
                                    Destroy(Wall[i].gameObject);
                                }
                            }

                        }

                        Destroy(cloneElf.gameObject);
                    }

                    /// Process each level
                    if (Level == 1)
                    {
                        // Look for bear
                        if (bearsFound < 3 || !easy)
                        {
                            color = bear.LookFor(Wall);
                            if (color != null)
                            {
                                FoundBear(color);
                                bearsFound++;
                            }
                        }

                        //Look for rocket
                        if (rocketsFound < 3 || !easy)
                        {
                            color = rocket.LookFor(Wall);
                            if (color != null)
                            {
                                FoundRocket(color);
                                rocketsFound++;
                            }
                        }

                        //Look car
                        if (carsFound < 3 || !easy)
                        {
                            color = car.LookFor(Wall);
                            if (color != null)
                            {
                                FoundCar(color);
                                carsFound++;
                            }
                        }

                        Lvl1CarsText.text = "" + carsFound;
                        Lvl1RocketsText.text = "" + rocketsFound;
                        Lvl1BearsText.text = "" + bearsFound;

                        if (carsFound > 2 && rocketsFound > 2 && bearsFound > 2)
                        {
                            if (!stopping)
                            {
                                playerCtrl.SetStop();
                                stopping = true;
                                if (time < BestL1)
                                {
                                    string minutes = ((int)time / 60).ToString();
                                    string seconds = ((int)time % 60).ToString("d2");
                                    BestL1Txt.text = minutes + ":" + seconds;
                                    BestL1Txt.color = Color.red;

                                    BestL1 = time;
                                    //Save Score
                                }
                            }
                            else
                            {
                                starting = true;
                                stopping = false;
                                ResetCounts();

                                //Next up 2
                                Level = 2;

                                // Update the menu
                                SetLevel(Level);

                                yield return null;
                            }
                        }
                    }

                    else if (Level == 2)
                    {
                        // Look for biplanes
                        if (planesFound < 3 || !easy)
                        {
                            color = airplane.LookFor(Wall);
                            if (color != null)
                            {
                                FoundAirplane(color);
                                planesFound++;
                            }
                        }

                        //Look for jets
                        if (jetsFound < 3 || !easy)
                        {
                            color = jet.LookFor(Wall);
                            if (color != null)
                            {
                                FoundJet(color);
                                jetsFound++;
                            }
                        }

                        //Look for Dragons
                        if (dragonsFound < 3 || !easy)
                        {
                            color = dragon.LookFor(Wall);
                            if (color != null)
                            {
                                FoundDragon(color);
                                dragonsFound++;
                            }
                        }

                        Lvl2PlanesText.text = "" + planesFound;
                        Lvl2JetsText.text = "" + jetsFound;
                        Lvl2DragonsText.text = "" + dragonsFound;


                        if (planesFound > 2 && jetsFound > 2 && dragonsFound > 2)
                        {
                            if (!stopping)
                            {
                                playerCtrl.SetStop();
                                stopping = true;
                                if (time < BestL2)
                                {
                                    string minutes = ((int)time / 60).ToString();
                                    string seconds = ((int)time % 60).ToString("d2");
                                    BestL2Txt.text = minutes + ":" + seconds;
                                    BestL2Txt.color = Color.red;

                                    BestL2 = time;
                                    //Save Score
                                }

                            }
                            else
                            {
                                starting = true;
                                stopping = false;
                                ResetCounts();

                                //Next up 3
                                Level = 3;

                                // Update the menu
                                SetLevel(Level);

                                // Give the last lvl 2 blocks time to clear before we speed things up
                                yield return new WaitForSeconds(7);

                            }

                        }

                    }

                    else if (Level == 3)
                    {
                        // Look for bear
                        if (bearsFound < 3 || !easy)
                        {
                            color = bear.LookFor(Wall);
                            if (color != null)
                            {
                                FoundBear(color);
                                bearsFound++;
                            }
                        }

                        //Look for biplanes
                        if (planesFound < 3 || !easy)
                        {
                            color = airplane.LookFor(Wall);
                            if (color != null)
                            {
                                FoundAirplane(color);
                                planesFound++;
                            }
                        }

                        //Look for jets
                        if (jetsFound < 3 || !easy)
                        {
                            color = jet.LookFor(Wall);
                            if (color != null)
                            {
                                FoundJet(color);
                                jetsFound++;
                            }
                        }

                        //Look for Dragons
                        if (dragonsFound < 3 || !easy)
                        {
                            color = dragon.LookFor(Wall);
                            if (color != null)
                            {
                                FoundDragon(color);
                                dragonsFound++;
                            }
                        }

                        // Look for rocket
                        if (rocketsFound < 3 || !easy)
                        {
                            color = rocket.LookFor(Wall);
                            if (color != null)
                            {
                                FoundRocket(color);
                                rocketsFound++;
                            }
                        }

                        //Look car
                        if (carsFound < 3 || !easy)
                        {
                            color = car.LookFor(Wall);
                            if (color != null)
                            {
                                FoundCar(color);
                                carsFound++;
                            }
                        }


                        Lvl3CarsText.text = "" + carsFound;
                        Lvl3RocketsText.text = "" + rocketsFound;
                        Lvl3BearsText.text = "" + bearsFound;
                        Lvl3PlanesText.text = "" + planesFound;
                        Lvl3JetsText.text = "" + jetsFound;
                        Lvl3DragonsText.text = "" + dragonsFound;


                        if (carsFound > 2 && rocketsFound > 2 && planesFound > 2 && jetsFound > 2 && dragonsFound > 2 && bearsFound > 2)
                        {
                            if (!stopping)
                            {
                                playerCtrl.SetStop();
                                stopping = true;
                                if (time < BestL3)
                                {
                                    string minutes = ((int)time / 60).ToString();
                                    string seconds = ((int)time % 60).ToString("d2");
                                    BestL3Txt.text = minutes + ":" + seconds;
                                    BestL3Txt.color = Color.red;

                                    BestL3 = time;
                                    //Save Score

                                }

                            }
                            else
                            {
                                starting = true;
                                stopping = false;
                                ResetCounts();

                                //Next up 4
                                Level = 4;

                                // Update the menu
                                SetLevel(Level);

                                yield return null;
                            }

                        }

                    }

                    else if (Level == 4)
                    {
                        //Look for train
                        if (trainsFound < 3 || !easy)
                        {
                            color = train.LookFor(Wall);
                            if (color != null)
                            {
                                FoundTrain(color);
                                trainsFound++;
                            }
                        }

                        //Look for shuttles
                        if (shuttlesFound < 3 || !easy)
                        {
                            color = shuttle.LookFor(Wall);
                            if (color != null)
                            {
                                FoundShuttle(color);
                                shuttlesFound++;
                            }
                        }

                        Lvl4TrainsText.text = "" + trainsFound;
                        Lvl4ShuttlesText.text = "" + shuttlesFound;

                        if (trainsFound > 2 && shuttlesFound > 2)
                        {
                            if (!stopping)
                            {
                                playerCtrl.SetStop();
                                stopping = true;
                                if (time < BestL4)
                                {
                                    string minutes = ((int)time / 60).ToString();
                                    string seconds = ((int)time % 60).ToString("d2");
                                    BestL4Txt.text = minutes + ":" + seconds;
                                    BestL4Txt.color = Color.red;

                                    BestL4 = time;
                                    //Save Score

                                }

                            }
                            else
                            {
                                starting = true;
                                stopping = false;
                                ResetCounts();

                                //Next up 5
                                Level = 5;

                                // Update the menu
                                SetLevel(Level);

                                yield return null;
                            }

                        }

                    }

                    else if (Level == 5)
                    {
                        // Look for bear
                        if (bearsFound < 3 || !easy)
                        {
                            color = bear.LookFor(Wall);
                            if (color != null)
                            {
                                FoundBear(color);
                                bearsFound++;
                            }
                        }

                        // Look for train
                        if (trainsFound < 3 || !easy)
                        {
                            color = train.LookFor(Wall);
                            if (color != null)
                            {
                                FoundTrain(color);
                                trainsFound++;
                            }
                        }

                        // Look for shuttle
                        if (shuttlesFound < 3 || !easy)
                        {
                            color = shuttle.LookFor(Wall);
                            if (color != null)
                            {
                                FoundShuttle(color);
                                shuttlesFound++;
                            }
                        }

                        // Look for rocket (once 3 rockets are found stop even on hard)
                        if (rocketsFound < 3)
                        {
                            color = rocket.LookFor(Wall);
                            if (color != null)
                            {
                                FoundRocket(color);
                                rocketsFound++;
                            }
                        }

                        // Look for car
                        if (carsFound < 3 || !easy)
                        {
                            color = car.LookFor(Wall);
                            if (color != null)
                            {
                                FoundCar(color);
                                carsFound++;
                            }
                        }

                        Lvl5CarsText.text = "" + carsFound;
                        Lvl5RocketsText.text = "" + rocketsFound;
                        Lvl5BearsText.text = "" + bearsFound;
                        Lvl5TrainsText.text = "" + trainsFound;
                        Lvl5ShuttlesText.text = "" + shuttlesFound;


                        if (carsFound > 2 && rocketsFound > 2 && bearsFound > 2 && shuttlesFound > 2 && trainsFound > 2)
                        {
                            if (!stopping)
                            {
                                playerCtrl.SetStop();
                                stopping = true;
                                if (time < BestL5)
                                {
                                    string minutes = ((int)time / 60).ToString();
                                    string seconds = ((int)time % 60).ToString("d2");
                                    BestL5Txt.text = minutes + ":" + seconds;
                                    BestL5Txt.color = Color.red;

                                    BestL5 = time;
                                    //Save Score
                                }

                            }
                            else
                            {
                                starting = true;
                                stopping = false;
                                ResetCounts();

                                //Next up 6
                                Level = 6;

                                // Update the menu
                                SetLevel(Level);

                                yield return null;
                            }
                        }
                    }

                    else if (Level == 6)
                    {
                        // Look for sub
                        if (subsFound < 3 || !easy)
                        {
                            color = sub.LookFor(Wall);
                            if (color != null)
                            {
                                FoundSub(color);
                                subsFound++;
                            }
                        }

                        // Look for pirate ship
                        if (boatsFound < 3 || !easy)
                        {
                            color = boat.LookFor(Wall);
                            if (color != null)
                            {
                                FoundBoat(color);
                                boatsFound++;
                            }
                        }

                        // Look for tug
                        if (tugsFound < 3 || !easy)
                        {
                            color = tug.LookFor(Wall);
                            if (color != null)
                            {
                                FoundTug(color);
                                tugsFound++;
                            }
                        }

                        Lvl6BoatsText.text = "" + boatsFound;
                        Lvl6SubsText.text = "" + subsFound;
                        Lvl6TugsText.text = "" + tugsFound;

                        if (boatsFound > 2 && tugsFound > 2 && subsFound > 2)
                        {
                            if (!stopping)
                            {
                                playerCtrl.SetStop();
                                stopping = true;
                                if (time < BestL6)
                                {
                                    string minutes = ((int)time / 60).ToString();
                                    string seconds = ((int)time % 60).ToString("d2");
                                    BestL6Txt.text = minutes + ":" + seconds;
                                    BestL6Txt.color = Color.red;

                                    BestL6 = time;
                                    //Save Score
                                }

                            }
                            else
                            {
                                starting = true;
                                stopping = false;
                                ResetCounts();

                                //Next up 7
                                Level = 7;

                                SetLevel(Level);

                                yield return null;
                            }
                        }
                    }

                    else if (Level == 7)
                    {
                        // Look for sub
                        if (subsFound < 3 || !easy)
                        {
                            color = sub.LookFor(Wall);
                            if (color != null)
                            {
                                FoundSub(color);
                                subsFound++;
                            }
                        }

                        // Look for pirate ship
                        if (boatsFound < 3 || !easy)
                        {
                            color = boat.LookFor(Wall);
                            if (color != null)
                            {
                                FoundBoat(color);
                                boatsFound++;
                            }
                        }

                        // Look for tug
                        if (tugsFound < 3 || !easy)
                        {
                            color = tug.LookFor(Wall);
                            if (color != null)
                            {
                                FoundTug(color);
                                tugsFound++;
                            }
                        }

                        //Look for train
                        if (trainsFound < 3 || !easy)
                        {
                            color = train.LookFor(Wall);
                            if (color != null)
                            {
                                FoundTrain(color);
                                trainsFound++;
                            }
                        }

                        //Look for shuttle
                        if (shuttlesFound < 3 || !easy)
                        {
                            color = shuttle.LookFor(Wall);
                            if (color != null)
                            {
                                FoundShuttle(color);
                                shuttlesFound++;
                            }
                        }

                        Lvl7TrainsText.text = "" + trainsFound;
                        Lvl7ShuttlesText.text = "" + shuttlesFound;
                        Lvl7BoatsText.text = "" + boatsFound;
                        Lvl7SubsText.text = "" + subsFound;
                        Lvl7TugsText.text = "" + tugsFound;


                        if (boatsFound > 2 && tugsFound > 2 && subsFound > 2 && trainsFound > 2 && shuttlesFound > 2)
                        {
                            if (!stopping)
                            {
                                playerCtrl.SetStop();
                                stopping = true;
                                if (time < BestL7)
                                {
                                    string minutes = ((int)time / 60).ToString();
                                    string seconds = ((int)time % 60).ToString("d2");
                                    BestL7Txt.text = minutes + ":" + seconds;
                                    BestL7Txt.color = Color.red;

                                    BestL7 = time;
                                    //Save Score
                                }

                            }
                            else
                            {
                                starting = true;
                                stopping = false;
                                ResetCounts();

                                //Next up 8
                                Level = 8;

                                SetLevel(Level);
                                yield return null;
                            }
                        }
                    }

                    else if (Level == 8)
                    {
                        // Look for sub
                        if (subsFound < 3 || !easy)
                        {
                            color = sub.LookFor(Wall);
                            if (color != null)
                            {
                                FoundSub(color);
                                subsFound++;
                            }
                        }

                        // Look for pirate ship
                        if (boatsFound < 3 || !easy)
                        {
                            color = boat.LookFor(Wall);
                            if (color != null)
                            {
                                FoundBoat(color);
                                boatsFound++;
                            }
                        }

                        // Look for tug
                        if (tugsFound < 3 || !easy)
                        {
                            color = tug.LookFor(Wall);
                            if (color != null)
                            {
                                FoundTug(color);
                                tugsFound++;
                            }
                        }

                        //Look for biplane
                        if (planesFound < 3 || !easy)
                        {
                            color = airplane.LookFor(Wall);
                            if (color != null)
                            {
                                FoundAirplane(color);
                                planesFound++;
                            }
                        }

                        //Look for jets
                        if (jetsFound < 3 || !easy)
                        {
                            color = jet.LookFor(Wall);
                            if (color != null)
                            {
                                FoundJet(color);
                                jetsFound++;
                            }
                        }

                        //Look for dragon
                        if (dragonsFound < 3 || !easy)
                        {
                            color = dragon.LookFor(Wall);
                            if (color != null)
                            {
                                FoundDragon(color);
                                dragonsFound++;
                            }
                        }

                        Lvl8PlanesText.text = "" + planesFound;
                        Lvl8JetsText.text = "" + jetsFound;
                        Lvl8DragonsText.text = "" + dragonsFound;
                        Lvl8BoatsText.text = "" + boatsFound;
                        Lvl8SubsText.text = "" + subsFound;
                        Lvl8TugsText.text = "" + tugsFound;

                        if (planesFound > 2 && jetsFound > 2 && dragonsFound > 2 && boatsFound > 2 && tugsFound > 2 && subsFound > 2)
                        {
                            if (!stopping)
                            {
                                playerCtrl.SetStop();
                                stopping = true;
                                if (time < BestL8)
                                {
                                    string minutes = ((int)time / 60).ToString();
                                    string seconds = ((int)time % 60).ToString("d2");
                                    BestL8Txt.text = minutes + ":" + seconds;
                                    BestL8Txt.color = Color.red;

                                    BestL8 = time;
                                    //Save Score
                                }

                            }
                            else
                            {
                                starting = true;
                                stopping = false;
                                ResetCounts();

                                //Next up 9
                                Level = 9;

                                SetLevel(Level);

                                yield return null;
                            }
                        }
                    }

                }
            }
        }
    }

    private void FoundSub(string color)
    {
        x = (int)UnityEngine.Random.Range(4.0f, 4.2f);
        y = (int)UnityEngine.Random.Range(4.8f, 5.2f);
        z = (int)UnityEngine.Random.Range(0f, -.4f);

        if (color == "Red")
            cloneSub = Instantiate(prefabRedSub, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Cyan")
            cloneSub = Instantiate(prefabCyanSub, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Yellow")
            cloneSub = Instantiate(prefabYellowSub, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Green")
            cloneSub = Instantiate(prefabGreenSub, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Blue")
            cloneSub = Instantiate(prefabBlueSub, new Vector3(x, y, z), Quaternion.identity);

        toyCtrl.Shrink(cloneSub);
        return;
    }

    private void FoundTug(string color)
    {
        x = (int)UnityEngine.Random.Range(4.0f, 4.2f);
        y = (int)UnityEngine.Random.Range(4.8f, 5.2f);
        z = (int)UnityEngine.Random.Range(0f, -.4f);

        if (color == "Red")
            cloneTug = Instantiate(prefabRedTug, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Cyan")
            cloneTug = Instantiate(prefabCyanTug, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Yellow")
            cloneTug = Instantiate(prefabYellowTug, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Green")
            cloneTug = Instantiate(prefabGreenTug, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Blue")
            cloneTug = Instantiate(prefabBlueTug, new Vector3(x, y, z), Quaternion.identity);

        toyCtrl.Shrink(cloneTug);
        return;
    }

    private void FoundBear(string color)
    {
        x = (int)UnityEngine.Random.Range(4.0f, 4.2f);
        y = (int)UnityEngine.Random.Range(4.8f, 5.2f);
        z = (int)UnityEngine.Random.Range(0f, -.4f);

        if (color == "Red")
            cloneBear = Instantiate(prefabRedBear, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Cyan")
            cloneBear = Instantiate(prefabCyanBear, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Yellow")
            cloneBear = Instantiate(prefabYellowBear, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Green")
            cloneBear = Instantiate(prefabGreenBear, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Blue")
            cloneBear = Instantiate(prefabBlueBear, new Vector3(x, y, z), Quaternion.identity);

        toyCtrl.Shrink(cloneBear);
        return;
    }

    private void FoundShuttle(string color)
    {
        x = (int)UnityEngine.Random.Range(4.0f, 4.2f);
        y = (int)UnityEngine.Random.Range(4.8f, 5.2f);
        z = (int)UnityEngine.Random.Range(0f, -.4f);

        if (color == "Red")
            cloneShuttle = Instantiate(prefabRedShuttle, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Cyan")
            cloneShuttle = Instantiate(prefabCyanShuttle, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Yellow")
            cloneShuttle = Instantiate(prefabYellowShuttle, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Green")
            cloneShuttle = Instantiate(prefabGreenShuttle, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Blue")
            cloneShuttle = Instantiate(prefabBlueShuttle, new Vector3(x, y, z), Quaternion.identity);

        toyCtrl.Shrink(cloneShuttle);
        return;
    }

    private void FoundBoat(string color)
    {
        x = (int)UnityEngine.Random.Range(4.0f, 4.2f);
        y = (int)UnityEngine.Random.Range(4.8f, 5.2f);
        z = (int)UnityEngine.Random.Range(0f, -.4f);

        if (color == "Red")
            cloneBoat = Instantiate(prefabRedBoat, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Cyan")
            cloneBoat = Instantiate(prefabCyanBoat, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Yellow")
            cloneBoat = Instantiate(prefabYellowBoat, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Green")
            cloneBoat = Instantiate(prefabGreenBoat, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Blue")
            cloneBoat = Instantiate(prefabBlueBoat, new Vector3(x, y, z), Quaternion.identity);

        toyCtrl.Shrink(cloneBoat);
        return;
    }

    private void FoundTrain(string color)
    {
        x = (int)UnityEngine.Random.Range(4.0f, 4.2f);
        y = (int)UnityEngine.Random.Range(4.8f, 5.2f);
        z = (int)UnityEngine.Random.Range(0f, -.4f);

        if (color == "Red")
            cloneTrain = Instantiate(prefabRedTrain, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Cyan")
            cloneTrain = Instantiate(prefabCyanTrain, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Yellow")
            cloneTrain = Instantiate(prefabYellowTrain, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Green")
            cloneTrain = Instantiate(prefabGreenTrain, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Blue")
            cloneTrain = Instantiate(prefabBlueTrain, new Vector3(x, y, z), Quaternion.identity);

        toyCtrl.Shrink(cloneTrain);
        return;
    }

    private void FoundJet(string color)
    {
        x = (int)UnityEngine.Random.Range(4.0f, 4.2f);
        y = (int)UnityEngine.Random.Range(4.8f, 5.2f);
        z = (int)UnityEngine.Random.Range(0f, -.4f);

        if (color == "Red")
            cloneJet = Instantiate(prefabRedJet, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Cyan")
            cloneJet = Instantiate(prefabCyanJet, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Yellow")
            cloneJet = Instantiate(prefabYellowJet, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Green")
            cloneJet = Instantiate(prefabGreenJet, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Blue")
            cloneJet = Instantiate(prefabGreenJet, new Vector3(x, y, z), Quaternion.identity);

        toyCtrl.Shrink(cloneJet);
        return;
    }

    private void FoundDragon(string color)
    {
        x = (int)UnityEngine.Random.Range(4.0f, 4.2f);
        y = (int)UnityEngine.Random.Range(4.8f, 5.2f);
        z = (int)UnityEngine.Random.Range(0f, -.4f);

        if (color == "Red")
            cloneDragon = Instantiate(prefabRedDragon, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Cyan")
            cloneDragon = Instantiate(prefabCyanDragon, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Yellow")
            cloneDragon = Instantiate(prefabYellowDragon, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Green")
            cloneDragon = Instantiate(prefabGreenDragon, new Vector3(x, y, z), Quaternion.identity);

        toyCtrl.Shrink(cloneDragon);
        return;
    }

    private void FoundAirplane(string color)
    {
        x = (int)UnityEngine.Random.Range(4.0f, 4.2f);
        y = (int)UnityEngine.Random.Range(4.8f, 5.2f); 
        z = (int)UnityEngine.Random.Range(0f, -.4f);

        if (color == "Red")
            cloneAirplane = Instantiate(prefabRedAirplane, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Cyan")
            cloneAirplane = Instantiate(prefabCyanAirplane, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Yellow")
            cloneAirplane = Instantiate(prefabYellowAirplane, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Green")
            cloneAirplane = Instantiate(prefabGreenAirplane, new Vector3(x, y, z), Quaternion.identity);

        toyCtrl.Shrink(cloneAirplane);
        return;
    }

    private void FoundCar(string color)
    {
        x = (int)UnityEngine.Random.Range(4.0f, 4.2f);
        y = (int)UnityEngine.Random.Range(4.8f, 5.2f);
        z = (int)UnityEngine.Random.Range(0f, -.4f);

        if (color == "Red")
            cloneCar = Instantiate(prefabRedCar, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Cyan")
            cloneCar = Instantiate(prefabCyanCar, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Yellow")
            cloneCar = Instantiate(prefabYellowCar, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Green")
            cloneCar = Instantiate(prefabGreenCar, new Vector3(x, y, z), Quaternion.identity);

        toyCtrl.Shrink(cloneCar);
        return;
    }

    private void FoundRocket(string color)
    {
        x = (int)UnityEngine.Random.Range(4.0f, 4.2f);
        y = (int)UnityEngine.Random.Range(4.8f, 5.2f);
        z = (int)UnityEngine.Random.Range(0f, -.4f);

        if (color == "Red")
            cloneRocket = Instantiate(prefabRedRocket, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Cyan")
            cloneRocket = Instantiate(prefabCyanRocket, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Yellow")
            cloneRocket = Instantiate(prefabYellowRocket, new Vector3(x, y, z), Quaternion.identity);
        if (color == "Green")
            cloneRocket = Instantiate(prefabGreenRocket, new Vector3(x, y, z), Quaternion.identity);

        toyCtrl.Shrink(cloneRocket);

        return;
    }

    void ResetCounts()
    {
        carsFound = 0;
        rocketsFound = 0;
        planesFound = 0;
        jetsFound = 0;
        dragonsFound = 0;
        trainsFound = 0;
        boatsFound = 0;
        shuttlesFound = 0;
        bearsFound = 0;
        tugsFound = 0;
        subsFound = 0;

        redCarsFound = 0;
        redRocketsFound = 0;
        redPlanesFound = 0;
        redJetsFound = 0;
        redDragonsFound = 0;
        redTrainsFound = 0;
        redBoatsFound = 0;
        redShuttlesFound = 0;
        redBearsFound = 0;

        cyanCarsFound = 0;
        cyanRocketsFound = 0;
        cyanPlanesFound = 0;
        cyanJetsFound = 0;
        cyanDragonsFound = 0;
        cyanTrainsFound = 0;
        cyanBoatsFound = 0;
        cyanShuttlesFound = 0;
        cyanBearsFound = 0;

        yellowCarsFound = 0;
        yellowRocketsFound = 0;
        yellowPlanesFound = 0;
        yellowJetsFound = 0;
        yellowDragonsFound = 0;
        yellowTrainsFound = 0;
        yellowBoatsFound = 0;
        yellowShuttlesFound = 0;
        yellowBearsFound = 0;

        greenCarsFound = 0;
        greenRocketsFound = 0;
        greenPlanesFound = 0;
        greenJetsFound = 0;
        greenDragonsFound = 0;
        greenTrainsFound = 0;
        greenBoatsFound = 0;
        greenShuttlesFound = 0;
        greenBearsFound = 0;


        blueCarsFound = 0;
        blueRocketsFound = 0;
        bluePlanesFound = 0;
        blueJetsFound = 0;
        blueDragonsFound = 0;
        blueTrainsFound = 0;
        blueBoatsFound = 0;
        blueShuttlesFound = 0;
        blueBearsFound = 0;

        return;
    }

    void SetLevel(int i)
    {
        // Update the menus
        Lvl1.gameObject.SetActive(false);
        Lvl2.gameObject.SetActive(false);
        Lvl3.gameObject.SetActive(false);
        Lvl4.gameObject.SetActive(false);
        Lvl5.gameObject.SetActive(false);
        Lvl6.gameObject.SetActive(false);
        Lvl7.gameObject.SetActive(false);
        Lvl8.gameObject.SetActive(false);

        timer.text = "0.00";
        startTime = Time.time;


        if (i == 1)
        {
            Lvl1.gameObject.SetActive(true);
            timerText.text = "Level I";
        }

        else if (i == 2)
        {
            Lvl2.gameObject.SetActive(true);
            timerText.text = "Level II";
        }

        else if (i == 3)
        {
            Lvl3.gameObject.SetActive(true);
            timerText.text = "Level III";
        }

        else if (i == 4)
        {
            Lvl4.gameObject.SetActive(true);
            timerText.text = "Level IV";
        }

        else if (i == 5)
        {
            Lvl5.gameObject.SetActive(true);
            timerText.text = "Level V";
        }

        else if (i == 6)
        {
            Lvl6.gameObject.SetActive(true);
            timerText.text = "Level VI";
        }

        else if (i == 7)
        {
            Lvl7.gameObject.SetActive(true);
            timerText.text = "Level VII";
        }

        else if (i == 8)
        {
            Lvl8.gameObject.SetActive(true);
            timerText.text = "Level VIII";
        }
    }

    IEnumerator Tutorial()
    {
        cloneElf = Instantiate(prefabElf, new Vector3(-5f, 0f, 2f), new Quaternion(0f, 180f, 0f, 0f));

        ///Blah, Blah, Blah.. teleporter, radio, start lever...



        /// Point out list of toys we need, blocks...
        cloneBlock = Instantiate(prefabTutorialBlock1, new Vector3(3.3f, 8.6f, 6.0f), Quaternion.identity);
        Wall.Add(cloneBlock);
        yield return new WaitForSeconds(3.0f);

        cloneBlock = Instantiate(prefabTutorialBlock2, new Vector3(3.3f, 8.6f, 6.0f), Quaternion.identity);
        Wall.Add(cloneBlock);
        yield return new WaitForSeconds(3.0f);

        cloneBlock = Instantiate(prefabTutorialBlock3, new Vector3(3.3f, 8.6f, 6.0f), Quaternion.identity);
        Wall.Add(cloneBlock);
        yield return new WaitForSeconds(3.0f);

        cloneBlock = Instantiate(prefabTutorialBlock4, new Vector3(3.3f, 8.6f, 6.0f), Quaternion.identity);
        Wall.Add(cloneBlock);
        yield return new WaitForSeconds(6.0f);

        color = car.LookFor(Wall);
        if (color != null)
        {
            FoundCar(color);
            carsFound++;
        }

        yield return new WaitForSeconds(3.0f);

        cloneBlock = Instantiate(prefabTutorialBlock5, new Vector3(3.3f, 8.6f, 6.0f), Quaternion.identity);
        Wall.Add(cloneBlock);
        yield return new WaitForSeconds(3.0f);

        cloneBlock = Instantiate(prefabTutorialBlock6, new Vector3(3.3f, 8.6f, 6.0f), Quaternion.identity);
        Wall.Add(cloneBlock);
        yield return new WaitForSeconds(3.0f);

        cloneBlock = Instantiate(prefabTutorialBlock7, new Vector3(3.3f, 8.6f, 6.0f), Quaternion.identity);
        Wall.Add(cloneBlock);
        yield return new WaitForSeconds(3.0f);

        cloneBlock = Instantiate(prefabTutorialBlock8, new Vector3(3.3f, 8.6f, 6.0f), Quaternion.identity);
        Wall.Add(cloneBlock);
        yield return new WaitForSeconds(3.0f);

        color = rocket.LookFor(Wall);
        if (color != null)
        {
            FoundRocket(color);
            rocketsFound++;
        }

        yield return new WaitForSeconds(3.0f);

        /// Now certified "Elf Trained" toymaker
        Destroy(cloneElf.gameObject);
    }

    Boolean AngryElf()
    {
        int badBlocks = 0;
        Transform block;

        for (int i = 0; i < Wall.Count; i++)
        {
            //Make sure the block we're looking at is in the wall (Race conditions make some blocks appear before they're part of the wall
            if (Wall[i] != null && Wall[i].GetComponent<Transform>() != null)
            {
                block = Wall[i].GetComponent<Transform>();

                if (block.position.z > 6.1f || block.position.z < 5.9f)
                {
                    badBlocks++;
                }

                if (badBlocks > 9)
                { 
                    return (true);
                }
            }
        }
        return (false);
    }
}








