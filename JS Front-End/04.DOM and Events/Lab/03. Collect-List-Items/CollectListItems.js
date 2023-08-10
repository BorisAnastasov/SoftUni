function extractText() {
    const list = document.querySelectorAll('li');
    const result = document.getElementById("result");
    for (const node of list) {
        result.value +=node.textContent+"\n";
    }
}