namespace CmdGame.Game
{
    public class Actor
    {
        public virtual int Type => 0;

        public bool isHurt;
        public World world;
        public Vector2 _pos;
        public Vector2 pos
        {
            get => _pos;
            set
            {
                value = world.GetValidPos(value);
                _pos = value;
            }
        }
        public int damage;
        public int health;
        private List<Component> components = new List<Component>();
        public void AddComponent(Component comp)
        {
            components.Add(comp);
            comp.Bind(this);
            comp.Awake();
        }
        public void Awake()
        {
            Debug.Log($" {GetType().Name} Awake");
        }
        public void Update()
        {
            Debug.Log($"\t {GetType().Name} Update");
            foreach (var item in components)
            {
                item.Update(Time.deltaTime);
            }
        }
        public override string ToString()
        {
            return $" pos {pos} h:{health} type: {Type} isHurt:{ isHurt}";
        }
    }


}
