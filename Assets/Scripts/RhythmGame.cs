using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class RhythmGame : MonoBehaviour
{
    [SerializeField] private AudioClip[] _audioClip;
    [SerializeField] private Toggle[] _answers;
    [SerializeField] private GameObject[] _questions;
    private int _currentQuestion;
    [SerializeField] private Text _textField;
    private AudioSource _audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _textField.text = "Listen and pick the correct answer.";
        _currentQuestion = 0;
    }

   public void AdvanceQuestion()
    {
        StartCoroutine(WaitForNextRoutine());
    }

    void NextQuestion()
    {
        switch (_currentQuestion)
        {
            case 0:
                _questions[0].SetActive(true);
                _currentQuestion++;
                break;
            case 1:
                _questions[1].SetActive(true);
                _questions[0].SetActive(false);
                break;
            case 2:
                _questions[2].SetActive(true);
                _questions[1].SetActive(false);
                break;
            case 3:
                _questions[3].SetActive(true);
                _questions[2].SetActive(false);
                break;
            case 4:
                _questions[4].SetActive(true);
                _questions[3].SetActive(false);
                break;
        }
    }

    IEnumerator WaitForNextRoutine()
    {
        yield return new WaitForSeconds(2f);
        _textField.text = "Next Question";
        yield return new WaitForSeconds(2f);
        _textField.text = "Listen and pick the correct answer.";
        NextQuestion();
    }

    public void PlaySample00()
    {
        _audioSource.clip = (_audioClip[0]);
        _audioSource.Play();
    }
    public void DisplayAnswer0()
    {
        SubmitAnswer0();
    }
    void SubmitAnswer0()
    {
        if (_answers[3].isOn == true)
        {
            _textField.text = "Correct";
            _currentQuestion++;
        }
        else
        {
            _textField.text = "Try Again";
        }
    }

    public void PlaySample01()
    {
        _audioSource.clip = (_audioClip[1]);
        _audioSource.Play();
    }
    public void DisplayAnswer1()
    {
        SubmitAnswer1();
    }
    void SubmitAnswer1()
    {
        if (_answers[5].isOn == true)
        {
            _textField.text = "Correct";
            _currentQuestion++;
        }
        else
        {
            _textField.text = "Try Again";
        }
    }

    public void PlaySample02()
    {
        _audioSource.clip = (_audioClip[2]);
        _audioSource.Play();
    }
    public void DisplayAnswer2()
    {
        SubmitAnswer2();
    }
    void SubmitAnswer2()
    {
        if (_answers[10].isOn == true)
        {
            _textField.text = "Correct";
            _currentQuestion++;
        }
        else
        {
            _textField.text = "Try Again";
        }
    }

    public void PlaySample03()
    {
        _audioSource.clip = (_audioClip[3]);
        _audioSource.Play();
    }
    public void DisplayAnswer3()
    {
        SubmitAnswer3();
    }
    void SubmitAnswer3()
    {
        if (_answers[12].isOn == true)
        {
            _textField.text = "Correct";
            _currentQuestion++;
        }
        else
        {
            _textField.text = "Try Again";
        }
    }

    public void PlaySample04()
    {
        _audioSource.clip = (_audioClip[4]);
        _audioSource.Play();
    }
    public void DisplayAnswer4()
    {
        SubmitAnswer4();
    }
    void SubmitAnswer4()
    {
        if (_answers[16].isOn == true)
        {
            _textField.text = "Correct";
            _currentQuestion++;
        }
        else
        {
            _textField.text = "Try Again";
        }
    }
}
