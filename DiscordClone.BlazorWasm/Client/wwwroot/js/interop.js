function giveMeRandomInt() {
    DotNet.invokeMethodAsync('DiscordClone.BlazorWasm.Client', 'GenerateRandomInt')
        .then(result => {
            setElementById('randomNumberSpan', result);
        });
}

function setElementById(id, text) {
    document.getElementById(id).innerText = text;
}

