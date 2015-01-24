using UnityEngine;
using System.Collections;

public class PlayerControllerGrid : MonoBehaviour {
	
	private Vector2 pos;
	private bool moving = false;
	public MonoBehaviour otherPlayer;
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
		//Use gameManager
		if (Mathf.Abs(dif) > 14 || dif == 0) {
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
