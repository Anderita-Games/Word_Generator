/*  -----------------------
	Made by Andrew Friedman
	3/31/17 10:45 PM
	Shit is real
	-----------------------  */
	
#pragma strict
import System.IO;

var Export : UnityEngine.UI.Text;

var sr : StreamReader;
var line;
var level : TextAsset;
var number2 : int;

function Start () {
	level = Resources.Load("JustEveryWordEver", typeof(TextAsset));
}

function THEBUTTONDUMBASS () {
	sr = new StreamReader(new MemoryStream(level.bytes));
	var number = Random.Range(1,84100);
	while (number > number2) {
		line = sr.ReadLine();
		number2++;
	}
	number2 = 0;
	Export.text = line;
	sr.Close();
} //BEFORE