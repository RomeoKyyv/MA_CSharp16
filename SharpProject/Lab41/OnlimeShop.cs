using System;

namespace SharpProject
{
    public class OnlimeShop
    {
        public event EventHandler<ShopGoodsEventArgs> ShopEvent;

        private string GoodsName;

        public OnlimeShop(string GoodsName)
        {
            this.GoodsName = GoodsName;
        }

        public void NewGoods()
        {
            if (ShopEvent != null)
            {
                ShopEvent(this, new ShopGoodsEventArgs(GoodsName));
            }
        }
    }
}