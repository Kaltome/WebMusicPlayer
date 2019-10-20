var bLinkMap = new Map();

function setbLink(id, time) {
    if (!bLinkMap.get(id)) bLinkMap.set(id, setInterval(function () {
        bLink(id, time);
    }, time * 2));
}

function clearbLink(id) {
    if (bLinkMap.get(id)) {
        clearInterval(bLinkMap.get(id));
        bLinkMap.set(id, null);
        $("#" + id).fadeTo(0, 1.0);
    }
}

function bLink(id, time) {
    setTimeout(function () {
        $("#" + id).fadeTo(time, 1.0);
    }, time);
    $("#" + id).fadeTo(time, 0.2);
}
    