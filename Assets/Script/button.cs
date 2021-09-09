using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button : MonoBehaviour
{
    public Text textBox;
    private int _textBoxNumber;

    public void Dodaj()
    {
        _textBoxNumber++;
        textBox.text = _textBoxNumber.ToString();
    }
    
    public void Odejmij()
    {
        _textBoxNumber--;
        textBox.text = _textBoxNumber.ToString();
    }
    
}
