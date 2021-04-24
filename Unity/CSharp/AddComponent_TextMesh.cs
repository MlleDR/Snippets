using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class AddComponent_TextMesh : MonoBehaviour
{
    private TextMesh textmesh;
    private MeshRenderer rend;
    private string text = "Realtime TextMesh";
    private float characterSize = 0.16f;


    private void Start()
    {
        // Add a TextMesh Component in Realtime on a gameobject
        DisplayText(text, characterSize);
    }


    // Add a TextMesh Component in Realtime on a gameobject
    private void DisplayText(/*optional*/ string Text, float CharacterSize)
    {
        rend = transform.GetComponent<MeshRenderer>();
        textmesh = transform.gameObject.AddComponent<TextMesh>();

        // Optional
        textmesh.anchor = TextAnchor.MiddleCenter;
        textmesh.text = Text;
        textmesh.characterSize = CharacterSize;
    }
}
