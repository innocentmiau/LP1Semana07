namespace MyRPG
{
    public class Player
    {

        private int xp;
        private float health;
        
        // change xp if bigger.
        public int XP
        {
            get => xp;
            set
            {
                if (value > xp) xp = value;
            }
        }
        
        public int Level
        {
            get => 1 + (xp / 1000);
        }

        public float MaxHealth
        {
            get => 100f + (Level - 1) * 20f;
        }

        public Player(string name)
        {
            
        }

        public void TakeDamage(float damage)
        {
            
        }

    }
}