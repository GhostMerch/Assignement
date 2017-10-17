using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrisonBreak : MonoBehaviour {

    public Text myText;

    void start()
    {
        myText.text = "Press SPACE to start";

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myStates = States.cell;
        }
    }

    void cell()
    {
        myText.text = "You are in a prison cell, and you want to escape. There are " +
                "some dirty sheets on the bed, a mirror on the wall, and the door " +
                "is locked from the outside.\n\n" +
                "Press S to view Sheets, M to view Mirror and L to view Lock";

        if (Input.GetKeyDown(KeyCode.S))
        {
            myStates = States.sheets_0;
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            myStates = States.mirror;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myStates = States.lock_0;
        }
    }

    void sheets_0()
    {
        myText.text = "You can't believe you sleep in these things. Surely it's " + "time somebody changed them. The pleasures of prison life " +
    "I guess!\n\n" + "Press R to Return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = States.cell;
        }
    }

    void mirror()
    {
        myText.text = "You are still in your cell, and you STILL want to escape! There are " +
    "some dirty sheets on the bed, a mirror , " +
    "and that pesky door is still there, and firmly locked!\n\n" +
    "Press R to go back Cell or T to Take the Mirror";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = States.cell;
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            myStates = States.cell_mirror;
        }
    }

    void cell_mirror()

    {
        myText.text = "You are still in your cell, and you STILL want to escape! There are " +
                      "some dirty sheets on the bed, a mark where the mirror was, " +
                      "and that pesky door is still there, and firmly locked!\n\n" +
                      "Press S to view Sheets, or L to view Lock";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myStates = States.sheets_1;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myStates = States.lock_1;
        }
    }

    void sheets_1()
    {
        myText.text = "Holding a mirror in your hand doesn't make the sheets look " +
                     "any better.\n\n" +
                     "Press R to Return to roaming your cell";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = States.cell_mirror;
        }
    }

    void lock_1()
    {
        myText.text = "You carefully put the mirror through the bars, and turn it round " +
      "so you can see the lock. You can just make out fingerprints around " +
      "the buttons. You press the dirty buttons, and hear a click.\n\n" +
      "Press O to Open, or R to Return to your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = States.cell_mirror;
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            myStates = States.freedom;
        }
    }

    void freedom()
    {
        myText.text = "YOU ARE FREE!! " +
		"Press P to Play again." ;

        if (Input.GetKeyDown(KeyCode.P))
        {
            myStates = States.start;
        }
    }

    void lock_0()
    {
       myText.text = "This is one of those button locks. You have no idea what the " +
      "combination is. You wish you could somehow see where the dirty " +
    "fingerprints were, maybe that would help.\n\n" +
    "Press R to Return to roaming your cell";

        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = States.cell;
        }
    }


    private enum States
    {
        start, cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom
    };

    private States myStates;

	// Use this for initialization
	void Start () {
        myText.text = "Press SPACE to Start";
	}
	
	// Update is called once per frame
	void Update ()
    {
        print(myStates);

        if (myStates == States.start)
        {
            start();
        }
        else if (myStates == States.cell)
        {
            cell();
        }
        else if(myStates == States.sheets_0)
        {
            sheets_0();
        }
        else if (myStates == States.mirror)
        {
            mirror();
        }
        else if (myStates == States.lock_0)
        {
            lock_0();
        }
        else if (myStates == States.cell_mirror)
        {
            cell_mirror();
        }
        else if (myStates == States.lock_1)
        {
            lock_1();
        }
        else if (myStates == States.sheets_1)
        {
            sheets_1();
        }
        else if (myStates == States.freedom)
        {
            freedom();
        }
	}
}
