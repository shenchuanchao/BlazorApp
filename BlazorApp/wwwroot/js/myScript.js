window.myFunctions = {
    showPrompt: function (message) {
        return prompt(message, 'Type something');
    }
};
window.changeElementStyle = (element) => {
    element.style.background = 'blue';
    element.style.width = '200px';
};