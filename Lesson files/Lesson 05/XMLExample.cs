using UnityEngine;
using System.Collections;

public class XMLExample : MonoBehaviour {

	private void Start() {
		TextItem tmpTextItem = new TextItem (823, "Hallo daar mjensen!?");

		XMLManager.DebugTextItemPlox (tmpTextItem);
	}

}

public class TextItem {
	public int index;
	public string text;
	
	public TextItem() {}
	public TextItem(int index, string text) {
		this.index = index;
		this.text = text;
	}
}