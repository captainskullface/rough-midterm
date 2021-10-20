using UnityEngine;

public class DialogueActivator : MonoBehaviour, IInteractable
{

    [SerializeField] private DialogueObject dialogueObject;

    private void OnTriggerEnter2D(Collider2D other)
    {
       // print("enter");
        if (other.CompareTag("Player") && other.TryGetComponent(out playerMove player))
        {
            //print("hello");
            player.Interactable = this;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && other.TryGetComponent(out playerMove player))
        {
            //print("hello");
            if(player.Interactable is DialogueActivator dialogueActivator && dialogueActivator == this)
            {
                player.Interactable = null;
            }
        }
    }


    public void Interact (playerMove player)
    {
        player.DialogueUI.ShowDialogue(dialogueObject);

       
    } 
}
