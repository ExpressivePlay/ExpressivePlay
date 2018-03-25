using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;
using UnityEngine;

public class MyFireBase : MonoBehaviour {
	void Start() {
		// Set up the Editor before calling into the realtime database.
		FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://firstproject-a814b.firebaseio.com/");

		// Get the root reference location of the database.
		DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;

		writeNewUser ("1", "Jordan", "jordan@gmail.com");
	}

	private void writeNewUser(string userId, string name, string email) {
		User user = new User (name, email);
		string json = JsonUtility.ToJson (user);
		print (json);
	}

}

public class User {
	public string username;
	public string email;

	public User() {
	}

	public User(string username, string email) {
		this.username = username;
		this.email = email;
	}
}
