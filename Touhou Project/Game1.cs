using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Touhou_Project
{
    public class Game1 : Game
    {
        /*
            Variables
                    Texture 1
         */
        Texture2D player;
        Vector2 playerPosition;
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            player = Content.Load<Texture2D>("potato scratches");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            #region Movimentation
            var kstate = Keyboard.GetState();
            // VERTICAL

            if (kstate.IsKeyDown(Keys.W)) playerPosition.Y -= 10;
            if (kstate.IsKeyDown(Keys.S)) playerPosition.Y += 10;
            // HORIZONTAL

            if (kstate.IsKeyDown(Keys.D)) playerPosition.X += 10;
            if (kstate.IsKeyDown(Keys.A)) playerPosition.X -= 10;
            #endregion


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            _spriteBatch.Draw(player, playerPosition, Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
