namespace hafta_3
{
    class program
    {
        static void Main(string[]args)
        {
            Product product = new Product() { ProductName = "tavuk dürüm", ProductId=1,Price=40 };
            Product product1 = new Product() { ProductName="adana kebap",ProductId=2,Price=50};
            Product product2 = new Product() { ProductName="urfa kebap",ProductId=3,Price=50};

            CartItem cartItem = new CartItem() {Product=product,Quantity=2,CartId=1 };
            CartItem cartItem1= new CartItem() { Product=product1,Quantity=3,CartId=2};
            CartItem cartItem2= new CartItem(){ Product=product2,Quantity=1,CartId=3};
            ShoppingCart shoppingCart= new ShoppingCart();

            shoppingCart.Add(cartItem);
            shoppingCart.Add(cartItem1);
            shoppingCart.Add(cartItem2);

            //shoppingCart.Remove(3);
            shoppingCart.Remove(4);
            shoppingCart.GetList();
            shoppingCart.GetBalance();
        }
    }
}