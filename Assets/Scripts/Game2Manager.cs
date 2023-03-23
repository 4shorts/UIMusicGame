using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class Game2Manager : MonoBehaviour
{
    [SerializeField] private Sprite[] _cardFaces;
    [SerializeField] private Sprite _cardBack;
    [SerializeField] private GameObject[] _cards;
    [SerializeField] private Text _matchText;
    [SerializeField] private Text _youWonText;
    [SerializeField] private Button _playAgain;
    [SerializeField] private Button _mainMenu;

    private bool _init = false;
    private int _matches = 18;

    void Update()
    {
        if (!_init)
        {
            initializeCards();
        }

        if (Input.GetMouseButtonUp (0))
        {
            checkCards();
        }
    }

    void initializeCards()
    {
        for (int id=0; id < 2; id ++)
        {
            for (int i = 1; i < 19; i++)
            {
                bool test = false;
                int choice = 0;

                while(!test)
                {
                    choice = Random.Range (0, _cards.Length);
                    test = !(_cards[choice].GetComponent<Game2Card>().initialized);
                }
                _cards[choice].GetComponent<Game2Card>().cardValue = i;
                _cards[choice].GetComponent<Game2Card>().initialized = true;
            }
        }
        foreach(GameObject c in _cards)
        {
            c.GetComponent<Game2Card>().setupGraphics();
        }

        if (!_init)
        {
            _init = true;
        }
    }

    public Sprite GetCardBack()
    {
        return _cardBack;
    }

    public Sprite GetCardFace(int i)
    {
        return _cardFaces[i - 1];
    }

    void checkCards()
    {
        List<int> c = new List<int>();

        for (int i = 0; i < _cards.Length; i ++)
        {
            if (_cards[i].GetComponent<Game2Card>().state == 1)
            {
                c.Add (i);
            }
        }
        if (c.Count == 2)
        {
            cardComparison(c);
        }
    }

    void cardComparison(List<int> c)
    {
        Game2Card.DO_NOT = true;

        int x = 0;

        if (_cards[c[0]].GetComponent<Game2Card>().cardValue == _cards[c[1]].GetComponent<Game2Card>().cardValue)
        {
            x = 2;
            _matches--;
            _matchText.text = "Matches Left: " + _matches;
            if (_matches == 0)
            {
                _youWonText.enabled = true;
                _playAgain.enabled = true;
                _mainMenu.enabled = true;
            }
        }
        for (int i = 0; i < c.Count; i ++)
        {
            _cards[c[i]].GetComponent<Game2Card>().state = x;
            _cards[c[i]].GetComponent<Game2Card>().falseCheck();
        }
    }

}
