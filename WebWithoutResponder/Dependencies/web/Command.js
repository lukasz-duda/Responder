function Command(url, viewModel) {
    var me = this;
    me.url = url;
    me.viewModel = viewModel;
    me.onSuccessCallback = null

    me.execute = function () {
        $.ajax({
            type: "POST",
            url: me.url,
            async: true,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (response) {
                me.onSuccessCallback(response)
            }
        });
    }

    me.onSuccess = function (onSuccessCallback) {
        me.onSuccessCallback = onSuccessCallback;
    }
}