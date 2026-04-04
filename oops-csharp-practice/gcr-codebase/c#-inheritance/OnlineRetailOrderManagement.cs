using System;

class Order{
    protected int orderId;
    protected DateTime orderDate;

    public Order(int orderId, DateTime orderDate){
        this.orderId = orderId;
        this.orderDate = orderDate;
    }

    public virtual string GetOrderStatus(){
        return "Order Placed";
    }
}

class ShippedOrder : Order{
    protected string trackingNumber;

    public ShippedOrder(int orderId, DateTime orderDate, string trackingNumber): base(orderId, orderDate){
        this.trackingNumber = trackingNumber;
    }

    public override string GetOrderStatus(){
        return "Order Shipped";
    }
}

class DeliveredOrder : ShippedOrder{
    private DateTime deliveryDate;

    public DeliveredOrder(int orderId, DateTime orderDate, string trackingNumber, DateTime deliveryDate): base(orderId, orderDate, trackingNumber){
        this.deliveryDate = deliveryDate;
    }

    public override string GetOrderStatus(){
        return "Order Delivered";
    }
}

class OnlineRetailOrderManagement{
    static void Main(string[] args){
        Order order = new Order(101, DateTime.Now);
        ShippedOrder shipped = new ShippedOrder(102, DateTime.Now, "TRK12345");
        DeliveredOrder delivered = new DeliveredOrder(103, DateTime.Now, "TRK67890", DateTime.Now);

        Console.WriteLine(order.GetOrderStatus());
        Console.WriteLine(shipped.GetOrderStatus());
        Console.WriteLine(delivered.GetOrderStatus());
    }
}

