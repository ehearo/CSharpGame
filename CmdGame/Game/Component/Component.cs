namespace CmdGame.Game
{
    public class Component
    {
        protected Actor actor;
        public void Bind(Actor actor)
        {
            this.actor = actor;
        }
        public virtual void Awake() {
            Debug.Log($" {GetType().Name} Awake");
        }
        public virtual void Update(float dt) {
            Debug.Log($" {GetType().Name} Update");
        }
    }
   

}
