namespace CmdGame.Game
{
    public class RenderInfos
    {
        public List<RenderInfo> infos = new List<RenderInfo>();
        private List<object> extraInfos = new List<object>();
        public void AddExtInfo(object obj)
        {
            extraInfos.Add(obj);
        }
        public List<object> GetExtInfos()
        {
            return extraInfos;
        }
        public void AddInfo(RenderInfo info)
        {
            infos.Add(info);
        }
        public List<RenderInfo> GetInfos()
        {
            return infos;
        }
    }


}
