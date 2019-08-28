let timer = undefined;

window.soundAlert = () => {
    clearInterval(timer);
    var context = new AudioContext();
    var o = context.createOscillator();
    o.type = "sawtooth";
    o.connect(context.destination);
    o.start();
    setTimeout(function () {
        o.stop();
    }, 5000);
}