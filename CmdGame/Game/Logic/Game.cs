using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmdGame.Game
{
    public partial class Game : ILifeCycle
    {
        public World world;
        public EGameState state;
        public void Awake()
        {
            Debug.Log($" {GetType().Name} Awake");
            world = new World();
            world.Awake();
            //TODO Create Actor
            world.AddActor(CreatePlayer(1000, 40));
            world.AddActor(CreateEnemy(300, 10));
            world.AddActor(CreateEnemy(300, 10));
            world.AddActor(CreateEnemy(300, 10));

        }
        Actor CreatePlayer(int health, int damage)
        {
            var player = new Player();
            InitActor(health, damage, player);
            player.AddComponent(new PlayerAI());
            return player;
        }
        Actor CreateEnemy(int health, int damage)
        {
            var enemy = new Enemy();
            InitActor(health, damage, enemy);
            enemy.AddComponent(new EnemyAI());

            return enemy;
        }
        private void InitActor(int health, int damage, Actor actor)
        {
            actor.world = world;
            actor.health = health;
            actor.damage = damage;
            actor.pos = world.GetRandomPos();
            actor.AddComponent(new HurtEffect());
            actor.AddComponent(new Skill());
        }

        public void Update()
        {
            Time.deltaTime = 0.1f;
            Debug.Log($" {GetType().Name} Update  FrameCount  {Time.FramCount}");
            world.Update();
            Time.FramCount++;
        }
        public bool OnUpdate(double timeSinceStart, double deltaTime)
        {
            Time.deltaTime = (float)deltaTime;
            Update();
            return false;
        }
        
        public void OnGetInput(char inputCh)
        {
            switch (inputCh)
            {
                case 'w': InputManager.inputVec = new Vector2(0, 1); break;
                case 's': InputManager.inputVec = new Vector2(0, -1); break;
                case 'a': InputManager.inputVec = new Vector2(-1, 0); break;
                case 'd': InputManager.inputVec = new Vector2(1, 0); break;
            }
        }
    }
}
