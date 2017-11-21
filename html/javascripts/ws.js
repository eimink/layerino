var ws = null;

function initializeWebsocket()
{
    ws = new WebSocket("ws://localhost:14329/layerino");

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

function checkWebsocket(){
    if(!ws || ws.readyState === WebSocket.CLOSED) initializeWebsocket();
  }

function mainFadeIn() {
    $("#main").fadeIn();
}

function mainFadeOut() {
    $("#main").fadeOut();
}

function layerinoUpdate(socketInput) {
    if (socketInput === "MainFadeIn") mainFadeIn();
    else if (socketInput === "MainFadeOut") mainFadeOut();
    else {
        var data = JSON.parse(socketInput);
        $.each(data, function (element_id, value) {
            if (element_id != "HomeTeamLogo" && element_id != "AwayTeamLogo" && element_id != "TeamLeftLogo" && element_id != "TeamRightLogo" && element_id != "TopLogo" && element_id != "TopOverlay") {
                $("#"+element_id).html(value);
            } else {
                console.log("set logo");
                $("#"+element_id).css("background-image", "url("+value+")");
            }
            
        });
    }
}

setInterval(checkWebsocket, 5000);
