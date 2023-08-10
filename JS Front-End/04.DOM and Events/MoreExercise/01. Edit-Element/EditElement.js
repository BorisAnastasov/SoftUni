function editElement(text, match, replacer) {
    while(text.textContent.includes(match)){
        text.textContent = text.textContent.replace(match, replacer);
    }
}