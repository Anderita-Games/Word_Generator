using System.IO;
using UnityEngine;
using System.Collections;

[System.Serializable]
public partial class Finder : MonoBehaviour
{
    /*  -----------------------
	Made by Andrew Friedman
	3/31/17 10:45 PM
	Shit is real
	-----------------------  */
    public UnityEngine.UI.Text Export;
    public StreamReader sr;
    public object line;
    public TextAsset level;
    public int number2;
    public virtual void Start()
    {
        this.level = (TextAsset) Resources.Load("JustEveryWordEver", typeof(TextAsset));
    }

    public virtual void THEBUTTONDUMBASS() //BEFORE
    {
        this.sr = new StreamReader(new MemoryStream(this.level.bytes));
        int number = Random.Range(1, 84100);
        while (number > this.number2)
        {
            this.line = this.sr.ReadLine();
            this.number2++;
        }
        this.number2 = 0;
        this.Export.text = (string) this.line;
        this.sr.Close();
    }

}