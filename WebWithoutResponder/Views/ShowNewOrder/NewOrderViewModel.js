function NewOrderViewModel() {
    var me = this;

    me.placeAnOrder = function () {
        var cmd = new Command("/PlaceAnOrder/PlaceAnOrder", me);
        cmd.onSuccess(me.handlePlaceAnOrderResponse);// Not needed with responder.
        cmd.execute();
    }

    me.handlePlaceAnOrderResponse = function (response) {// Not needed with responder, but instead controller needs simple implementation of responder interface.
        if (response.orderBlocked) {
            me.orderBlocked();
            return;
        } else {
            me.orderAdded(response.newOrderId);
        }
    }

    me.orderAdded = function (newOrderId) {// Better arguments than with responder.
        alert("New order id: " + newOrderId);
    }

    me.orderBlocked = function () {
        alert("Order blocked");
    }
}

var viewModel = new NewOrderViewModel();
viewModel.placeAnOrder();