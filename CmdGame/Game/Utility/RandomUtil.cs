namespace CmdGame.Game
{
    public class RandomUtil
    {
        private static Random random = new Random();
        public static int Range(int minVal, int maxVal)
        {
            //沒+1區間會minVal~maxVal-1
            return random.Next(minVal, maxVal+1);
        }
    }


}
