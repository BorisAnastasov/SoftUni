function attachEvents() {
    let inputName = document.querySelector("#controls div input");
    let inputContent = document.querySelector("#controls div:nth-child(2) input");
    let textarea = document.querySelector("#messages");



    let sendButton = document.querySelector("#submit");
    sendButton.addEventListener("click", function () { PostMehod(); });


    let refreshButton = document.querySelector("#refresh");
    refreshButton.addEventListener("click", function () { RefreshData(); })

    async function PostMehod() {
        await fetch("http://localhost:3030/jsonstore/messenger", {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({
                author: inputName.value,
                content: inputContent.value,
            })
        })
    }
    async function RefreshData() {
        let data = await (await fetch("http://localhost:3030/jsonstore/messenger")).json();
        textarea.textContent = "";
        let arr = [];
        for (const comment of Object.values(data)) {
            arr.push(`${comment.author}: ${comment.content}`);
        }
        textarea.textContent += arr.join("\n");
    }
}

attachEvents();