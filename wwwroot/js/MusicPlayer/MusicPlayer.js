var playButton;
var loopButton;
var playTimer;
var music;
var audio;
var door = 0;
var thisBg = 0;
var thisBgImg;
var isloop = 0;
var isload;


function playMusic() {
    if (audio.paused) {
        startPlaying();
    } else {
        stopPlaying(0);
    }
}

function startPlaying() {
    progressRun();
    playTimer = setInterval("progressRun()", 1000);
    audio.play();
    playButton.src = "/src/Image/MusicPlayer/play.png";
}

function stopPlaying(isended) {
    if (isended) progressRun();
    clearInterval(playTimer);
    audio.pause();
    playButton.src = "/src/Image/MusicPlayer/pause.png";
}

function progressRun() {
    setprogressLine();
    setCurrentTime();
}

function setprogressLine() {
    var setWidth = audio.currentTime / audio.duration;
    document.getElementById("currentprogress").style.width = setWidth * 100 + "%";
    document.getElementById("point").style.left = audio.currentTime / audio.duration * 100 + "%";
}

function loadprogressLine() {
    var timeRanges = audio.buffered;
    if (timeRanges.length > 0) {
        var timeBuffered = timeRanges.end(timeRanges.length - 1);
        var setWidth = timeBuffered / audio.duration;
        document.getElementById("loadprogress").style.width = setWidth * 100 + "%";
    }
}

function setCurrentTime() {
    var time = document.getElementById("currentTime");
    var cur = audio.currentTime;//秒数
    var minute = parseInt(cur / 60);
    if (minute < 10) {
        if (cur % 60 < 10) {
            time.innerHTML = "0" + minute + ": 0" + parseInt(cur % 60) + "";
        }
        else {
            time.innerHTML = "0" + minute + ": " + parseInt(cur % 60) + "";
        }
    }
    else {
        if (cur % 60 < 10) {
            time.innerHTML = "" + minute + ": 0" + parseInt(cur % 60) + "";
        }
        else {
            time.innerHTML = "" + minute + ": " + parseInt(cur % 60) + "";
        }
    }

}

function clearprogressLine() {
    document.getElementById("loadprogress").style.width = 0;
    document.getElementById("currentprogress").style.width = 0;
    document.getElementById("point").style.left = 0;
}

function setLoop() {
    isloop = (isloop + 1) % 3;
    switch (isloop) {
        case 0: {
            loopButton.src = "/src/Image/MusicPlayer/loop.png";
            loopButton.style.opacity = 0.4;
            audio.loop = false;
            audio.onended = function () {
                stopPlaying(1);
            };
            break;
        }
        case 1: {
            loopButton.style.opacity = 1;
            audio.onended = nextMusic;
            break;
        }
        case 2: {
            loopButton.src = "/src/Image/MusicPlayer/singleloop.png"
            audio.loop = true;
            audio.onended = null;
            break;
        }
    }
}

function showDescriptions(){
    document.getElementById("lyrics").style.display = "none";
    document.getElementById("descriptions").style.display = "block";
}

function showLyrics(){
    document.getElementById("descriptions").style.display = "none";
    document.getElementById("lyrics").style.display = "block";
}

function nextMusic() {
    changeMusic("Music/nextMusic");
}

function lastMusic() {
    changeMusic("Music/lastMusic");
} 

function changeMusic(url) {
    if (door == 1) return;
    door = 1;
    isload = 0;
    progress.onmousedown = null;
    document.onmousemove = null;
    document.onmouseup = null;
    clearInterval(playTimer);
    clearprogressLine();

    $.ajax({
        url: url,
        data: {
            "no": document.getElementById("no").innerHTML
        },
        type: "post",
        dataType: "text",
        success: function (response) {
            setNewMusic(response);
        },
        failure: function (response) {
            alert("Error");
        }
    });
}

function setNewMusic(newMusic) {
    music = JSON.parse(newMusic);
    document.getElementById("audio").src = "/src/Music/" + music.name;

    audio.oncanplay = function () {
        if (isload == 0) {
            progress.onmousedown = progressBarListener;
            setNewMessage();
            changeBgImg();
            showDescriptions();
            isload = 1;
            setTimeout(function () { door = 0; }, 1200);
        }
        clearbLink("point");
    }

    startPlaying();
}

function setNewMessage() {
    document.getElementById("title").innerHTML = music.title;
    document.getElementById("artist").innerHTML = music.artist + " · " + music.album;
    document.getElementById("no").innerHTML = music.no;
    document.getElementById("duration").innerHTML = music.duration;
    document.getElementById("descriptionTitle").innerHTML = music.musicDescription.title;
    document.getElementById("description").innerHTML = music.musicDescription.description;

    thisBgImg = "/src/Image/MusicPlayer/" + music.albumImg;
    document.getElementById("albumImg").src = thisBgImg;
}

function changeBgImg() {
    if (thisBg % 2 == 0) {
        document.getElementById("albumBg2").src = thisBgImg;
        $("#albumBg2")[0].style.display = "none";
        $("#albumBg2")[0].onload = function () {
            $("#albumBg2")[0].style.display = "block";
            $("#albumBg1").fadeTo(1000, 0);
            $("#albumBg2").fadeTo(800, 0.8);
        }
    }
    else {
        document.getElementById("albumBg1").src = thisBgImg;
        $("#albumBg1")[0].style.display = "none";
        $("#albumBg1")[0].onload = function () {
            $("#albumBg1")[0].style.display = "block";
            $("#albumBg2").fadeTo(1000, 0);
            $("#albumBg1").fadeTo(800, 0.8);
        }
    }
    thisBg++;
}

var progressBarListener = function (e) {
    var timePoint;
    var length = document.body.clientWidth * 0.75 - 120;

    clearInterval(playTimer);

    timePoint = (e.clientX - document.body.clientWidth * 0.125 - 70) / length;
    if (timePoint > 1) timePoint = 1;
    else if (timePoint < 0) timePoint = 0;
    document.getElementById("point").style.left = timePoint * 100 + "%";
    document.getElementById("currentprogress").style.width = timePoint * 100 + "%";

    document.onmousemove = function (e) {
        e.stopPropagation();

        timePoint = (e.clientX - document.body.clientWidth * 0.125 - 70) / length;
        if (timePoint > 1) timePoint = 1;
        else if (timePoint < 0) timePoint = 0;
        document.getElementById("point").style.left = timePoint * 100 + "%";
        document.getElementById("currentprogress").style.width = timePoint * 100 + "%";
    }

    document.onmouseup = function (e) {
        audio.pause();
        audio.currentTime = timePoint * audio.duration;
        startPlaying();

        onmousedown = null;
        document.onmousemove = null;
        document.onmouseup = null;
    }
    return false;
}

function showImg(ts) {
    ts.style.display = 'block';
}

