function Command(url, viewModel) {
    var me = this;
    me.url = url;
    me.viewModel = viewModel;

    me.execute = function () {
        $.ajax({
            type: "POST",
            url: me.url,
            async: true,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (actions) {
                me._callActions(actions);
            }
        });
    }

    me._callActions = function (actions) {
        for (var i = 0; i < actions.length; i++) {
            var actionName = actions[i].name;
            var arguments = actions[i].arguments;

            if (typeof viewModel[actionName] == "function") {
                me.viewModel[actionName](arguments);
            }
        }
    }
}