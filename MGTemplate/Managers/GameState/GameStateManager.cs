namespace MGTemplate
{
    public static class GameStateManager
    {
        public enum GameState
        {
            Pause,

            EditMode,

            MainMenu,

            Options,

            Active,
        }
        public static GameState CurrentGameState { get; private set; } = new GameState ();

        public static void ChangeGameState (GameState DesiredGameState)
        {
            CurrentGameState = DesiredGameState;
        }
    }
}