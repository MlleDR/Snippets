using UnityEngine;

// AddComponent_TextMesh script //
/* 26.04.2021 - Simplify code
 * 25.04.2021 - Added script */

[RequireComponent(typeof(MeshRenderer))] // TesxtMesh needs MeshRenderer. Here I force its creation, but you can add it manually or make sure your gameobject has one.
public class AddComponent_TextMesh : MonoBehaviour
{
    public string text = "My realtime text";

    /* Tips : 
     * Decrease Character Size and 
     * increase FontSize to get a nice text render */
    public float characterSize = 0.01f;
    public int fontSize = 80;


    private TextMesh textmesh;



    private void Start()
    {
        // Add a TextMesh Component in Realtime on a gameobject
        DisplayText(text, characterSize, fontSize);
    }



    // Add a TextMesh Component in Realtime on a gameobject
    private void DisplayText(/*optional*/ string Text, float CharacterSize, int FontSize)
    {
        textmesh = transform.gameObject.AddComponent<TextMesh>();

        // Optional
        textmesh.anchor = TextAnchor.MiddleCenter;
        textmesh.text = Text;
        textmesh.characterSize = CharacterSize;
        textmesh.fontSize = FontSize;
    }
}
