using System;

namespace SharpProject
{
    public class ShopGoodsEventArgs : EventArgs
    {
        private string GoodsName;
        
        public ShopGoodsEventArgs(string goodsName)
        {
            this.GoodsName = goodsName;
        }

        public string getGoodsName()
        {
            return GoodsName;
        }
    }
}