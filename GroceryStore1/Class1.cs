
    public class Product
       
        
    {
       
        public int _ProductId { get; set; }
        public string _Name { get; set; }
        public int _Price { get; set; }
        public int _InventoryLevel { get; set; }
        public int _MiniInventoryLevel { get; set; }
        public int _RequisitionAmount { get; set; }
        
        public Product(int ProductId, string Name, int Price, int InventoryLevel, int MiniInventoryLevel, int RequisitionAmount)

        {
            this._ProductId = ProductId;
            this._Name = Name;
            this._Price = Price;
            this._InventoryLevel = InventoryLevel;
            this._MiniInventoryLevel = MiniInventoryLevel;
            this._RequisitionAmount = RequisitionAmount;


        }
        public void AddQuantity(int amount)
        {
            _InventoryLevel = _InventoryLevel + amount;
        }

        


    }
}