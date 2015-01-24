using UnityEngine;
using System.Collections;

public class PlayerControllerGrid : MonoBehaviour {
	
	public Vector2 pos;
	public bool moving = false;
	public PlayerControllerGrid otherPlayer;
	public int playerId;

	
	void Start () {
		// First store our current position when the
		// script is initialized.
		pos = transform.position;
	}
	
	void Update () {

		CheckInput();
		
		if(moving && ValidateMovement()) {
			// pos is changed when there's input from the player
			transform.position = pos;
			moving = false;
		}
	}
	private bool ValidateMovement(){
		float dif = pos.x - otherPlayer.transform.position.x;
		//Use gameManager para separacion de 
		if(dif == 0){
			if(transform.position.x - otherPlayer.transform.position.x <= 0){
				pos -= Vector2.right*6;
				otherPlayer.pos += Vector2.right*6;
				otherPlayer.moving = true;
			}else{
				pos += Vector2.right*6;
				otherPlayer.pos -= Vector2.right*6;
				otherPlayer.moving = true;
			}
			return true;
		}

		else if (Mathf.Abs(dif) > 14 ) {
			pos = transform.position;
			return false;

		}
		return true;
	}
	private void CheckInput() {
		
		// WASD control
		// We add the direction to our position,
		// this moves the character 1 unit (32 pixels)
		if (Input.GetButtonUp("Player" + playerId + "Right")) {
			pos += Vector2.right;
			moving = true;
		}
		
		// For left, we have to subtract the direction
		else if (Input.GetButtonUp("Player" + playerId + "Left")){
			pos -= Vector2.right;
			moving = true;
		}
		
	}
}
