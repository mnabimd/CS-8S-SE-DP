namespace Singleton._01;

sealed class SingletonObject {
    private static SingletonObject? instance;
    private bool isDarkTheme = false;

    private SingletonObject() {}

    public static SingletonObject GetInstance() {
        if (instance is null) {
            instance = new SingletonObject();
        }

        return instance;
    }

    public bool IsDarkTheme {
        get {
            return isDarkTheme;
        }
        set {
            isDarkTheme = value;
        }
    }
}