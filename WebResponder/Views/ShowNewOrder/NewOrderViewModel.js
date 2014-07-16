function NewOrderViewModel() {
    var me = this;

    me.placeAnOrder = function () {
        var cmd = new Command("/PlaceAnOrder/PlaceAnOrder", me);
        cmd.execute();
    }

    me.orderAdded = function (args) {
        alert("New order id: " + args.newOrderId);
    }

    me.orderBlocked = function () {
        alert("Order blocked");
    }
}

var viewModel = new NewOrderViewModel();
viewModel.placeAnOrder();