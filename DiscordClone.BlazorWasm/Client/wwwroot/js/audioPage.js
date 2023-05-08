let audioContext;
let micStreamAudioSourceNode;
let audioWorkletNode;

async function startAudio() {

    console.log('The button was clicked');
    // Check if the browser supports the required APIs
    if (!window.AudioContext ||
        !window.MediaStreamAudioSourceNode ||
        !window.AudioWorkletNode) {
        alert('Your browser does not support the required APIs');
        return;
    }

    // Request access to the user's microphone
    const micStream = await navigator
        .mediaDevices
        .getUserMedia({ audio: true });


    // Create the microphone stream
    audioContext = new AudioContext();
    mediaStreamAudioSourceNode = audioContext
        .createMediaStreamSource(micStream);

    console.log("This is the audio context: ", audioContext);
    // Create and connect AudioWorkletNode 
    // for processing the audio stream
    await audioContext
        .audioWorklet
        .addModule("js/audioProcessor.js");

    console.log("This is the audio context: ", audioContext);

    audioWorkletNode = new AudioWorkletNode(
        audioContext,
        'audioProcessor');

    console.log('This is the audio worklet node', audioWorkletNode);        
    audioContext.micStreamAudioSourceNode.connect(audioWorkletNode);
    
}

async function stopAudio() {
    console.log('Stopping Audio', audioWorkletNode);
    // Close audio stream
    audioContext.micStreamAudioSourceNode.disconnect();
    audioContext.close();
}

