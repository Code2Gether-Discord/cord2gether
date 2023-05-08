class MyAudioProcessor extends AudioWorkletProcessor {
    process(inputs, outputs, parameters) {
        // Get the input audio data from the first channel
        const inputData = inputs[0][0];

        // send the data to a blazor component
        console.log("****im in the audio processor!");
        console.log("****This is the inputdata! : ", inputData);
        DotNet.invokeMethodAsync('DiscordClone.BlazorWasm.Client', 'LogAudioData', inputData);

        return true;
    }
}


registerProcessor('audioProcessor', MyAudioProcessor);

