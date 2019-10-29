
public class Login{
private static Login user = null;

private Login{

}

private synchronized static void createInstance() {
		if (user == null) {
			user = new Login();
		}
	}

	public static Login getInstance() {
		createInstance();
		return user;
	}
}