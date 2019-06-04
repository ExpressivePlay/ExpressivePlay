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

		//writeNewUser ("2", "Jordan", "jordan@gmail.com", "19");

		print(reference.Database.GetReference ("users").GetValueAsync ().ContinueWith(task => {
			if(task.IsFaulted){
				print("Erroui");
			} else if(task.IsCompleted){
				DataSnapshot snapshot = task.Result;
				foreach(DataSnapshot user in snapshot.Children){
					string json = user.GetRawJsonValue();
					User meuUser = JsonUtility.FromJson<User>(json);
					print(meuUser.username + " - " + meuUser.email);
				}
			}
		}));


	}

	private void writeNewUser(string userId, string name, string email, string idade) {
		DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
		User user = new User (name, email, idade);
		string json = JsonUtility.ToJson (user);

		reference.Child("users2").Child(userId).SetRawJsonValueAsync(json);
	}

}

public class User {
	public string username;
	public string email;
	public string idade;

	public User() {
	}

	public User(string username, string email, string idade) {
		this.username = username;
		this.idade = idade;
		this.email = email;
	}
}
