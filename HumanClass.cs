namespace humanoop{
    public class Human{
        // * properties for human
        public string Name;
        public int strength;
        public int intelligence;
        public int dexterity;
        public int health;
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public  Human(string name){
            Name = name;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }
        public Human(string name,int s ,int i,int d, int h){
            Name = name;
            strength = s;
            intelligence = i;
            dexterity = d;
            health = h;
        }

    // Add a constructor to assign custom values to all fields
    // Build Attack method
    public int Attack(Human target){
        int damage  = strength * 5;
        target.health -= damage;
        return target.health;
    }
}
}