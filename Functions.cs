using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour {
//Scope of entire class/script. That's why class and file name must be same.

//An access modifier determines whether a variable is public or private.


//Functions with Parameters:
/* Functions can serve many different purposes. When a function is created, parameters must be established, such as
a variable. These parameters will allow the program to pass on values for use in the function, while arrguments can
be utilized in a function to express a value or variable. In each of the examples, parameters are used to provide
the program with a means of giving the function a result to return. Without the variables like "int num1" and "int
num2", int result, would not have any variables to sum up to have a result to return. */


//Functions with Returns:
/* Functions with parameters and returns can go hand in hand. As the previous paragraphs state, the parameters are
enabling the function to produce a result based upon the variables provided in the parameters or arguments, like the
sum of num1 and num2, or the difference between totalHealth and damageReceived. Conditionals can also be used with
return-based functions, but must be placed before the return is stated, or else the program will deem the loop or
statement unreachable, an error I discovered while first working on Example 4. Though the program will calculate the
value or result of the return, it will not print it in the console unless specified in a function like void Start().
Void Start() is also the site at which the values of an int or string in a parameter are defined, like the defined
parameters for Example 1:

	int result = AddNumbers (5 , 11);
	
The numbers with the parameters are established in the void function, so the program can pull from them later without
having to alter the entire script to accomodate for the new numbers. So instead of altering the parameters within
the AddNumbers function every time, they can alter them within void Start() and leave AddNumbers a blank template
for use in new generated results.

	int result = AddNumbers (6 , 12)

The script above would perform the same example as the former, but the values have now been changed within void Start(),
while the AddNumbers script remains unaltered. */


//Scope and Access Modifiers
/* Scope and Access modifiers are a fairly simple concept, as they allow the program to determine what can and cannot
be seen by the user within programs like Unity and other platforms. Private variables cannot be edited or altered
within the engine without full access to the script itself, while public variables can be altered at any time to do
almost anything from changing text or value of a variable or checking/unchecking a bool true or false within Unity.
Local integers are similar to private access variables, in that they cannot be altered within the game engine. However,
unlike private access variables, local variables are not accessible by all parts of the script, but is bound solely to
the function in which it was created. */

	public void DoStuff() {
		print ("I'm doing stuff...");
	}

	void Start() {

		DoStuff ();


		int result = AddNumbers (5 , 11);
		print (result);

		int result2 = MultiplyNumbers (5 , 10);
		print (result2);

		int bankResult = BankAccount (600 , 80 , 450);
		print ("$" + bankResult + " in your account");

		int maximumAffinity = CompanionAffinity (100 , 100);
		print ("Affinity: " + maximumAffinity + "%.");
		
		int minimumAffinity = CompanionAffinityLow (0 , 0);
		print ("Affinity: " + minimumAffinity + "&.");

		int health = PlayerHealth (100, 30);
		print ("Health: " + health + "%.");

		int shields = playerShieldsRecharge (30 , 60);
		print ("Shields: " + shields + "%.");

		int quests = QuestsMenu (11 , 4 , 6);
		print (" Menu > Quests ( " + quests + " ) ");

		string playlistSong = Playlist ( "Rise of the Eagles" , " - The Prodigy");
		print ("Now Playing: " + playlistSong);
		string playlistSong2 = NextPlaylist ( "Poison" , " - The Prodigy (Empurior Remix)");
		print ("Next Song: " + playlistSong2); 

		string groceriesNeeded = GroceryList ( "[ ] milk  [ ] eggs  [ ] butter " , " [ ] microwave  [ ] hand-blender");
		print ("Grocery List: " + groceriesNeeded);
		string groceriesGotten = GroceryListCompleted ("[x] milk  [x] eggs  [x] butter " , " [x] microwave  [x] hand-blender");
		print ("Grocery List" + groceriesGotten);
	}


//Example 1
	public int AddNumbers (int num1 , int num2) {

		int result = num1 + num2;
		return result;

	}

//Example 2

	public int MultiplyNumbers (int num1 , int num2) {

		int result2 = num1 * num2;
		return result2;
	}

//Example 3

	public int BankAccount (int paycheck , int spending , int bills) {

		int bankResult = paycheck - spending - bills;
		return bankResult;

	}

//Example 4

	public int CompanionAffinity (int affiliation, int friendship) {
 
		int maximumAffinity = affiliation + friendship;
	
		if (maximumAffinity == 200) {
			print ("Your companion trusts you completely!");
		}
		else {
			print ("Your companion is unsure how to feel about you.");
		}

		return maximumAffinity;
	}

//Example 5

	public int CompanionAffinityLow (int affiliation , int friendship) {

		int minimumAffinity = affiliation + friendship;

		if (minimumAffinity < 200 && minimumAffinity > 0) {
			print ("Your companion feels uneasy around you.");
		}
		else if (minimumAffinity == 0) {
			print ("Your companion despises you!");
		}
		else {
			print ("Your companion is unsure how to feel about you.");
		}

		return minimumAffinity;
	}

//Example 6

	public int PlayerHealth (int totalHealth , int damageReceived) {

		int health = totalHealth - damageReceived;
		return health;
	}

//Example 7

	public int playerShieldsRecharge (int totalShields , int recharge) {

		int shields = totalShields + recharge;

		if (shields < 50) {
			print ("Shield Capacity Critical!");
		}
		else if (shields > 50 || shields == 100) {
			print ("Shield Capacity Optimal!");
		}
		else {
			print ("No Shields Equipped.");
		}

		return shields;
	}

//Example 8

	public int QuestsMenu (int totalTasks , int tasksCompleted , int newTasks) {

		int quests = totalTasks - tasksCompleted + newTasks;
		return quests;
	}

//Example 9

	public string Playlist (string song , string artist) {

		string playlistSong = song + artist;
		return playlistSong;
	}

	public string NextPlaylist (string song2 , string artist2) {

		string playlistSong2 = song2 + artist2;
		return playlistSong2;
	}

//Example 10

	public string GroceryList (string foodNeeded , string appliancesNeeded) {

		string groceriesNeeded = foodNeeded + appliancesNeeded;
		return groceriesNeeded;
	}

	public string GroceryListCompleted (string foodGotten , string appliancesGotten) {

		string groceriesGotten = foodGotten + appliancesGotten;

		if (foodGotten != "[x] milk  [x] eggs  [x] butter ") {
			print ("You forgot something!");
		}

		else if (foodGotten == "[x] milk  [x] eggs  [x] butter " && appliancesGotten == " [x] microwave  [x] hand-blender") {
			print ("You've got everything!");
		}
		else {
			print ("That's not what you were supposed to buy!");
		}

		return groceriesGotten;
	}

		

}