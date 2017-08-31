function initializeWebsocket()
{
    var ws = new WebSocket("ws://localhost:14329/layerino");

    ws.onopen = function () {
        ws.send("FRONT_CONNECT");
    };

    ws.onmessage = function (evt) {
        var received_msg = evt.data;
        console.dir(received_msg);
        layerinoUpdate(received_msg);
    };

    ws.onclose = function () {
    };
}


function layerinoUpdate(json_input) {
    var data = JSON.parse(json_input);
    $.each(data, function (element_id, value) {
        $("#"+element_id).html(value);
    });
}
