async function attachEvents() {

    let postPlace = document.querySelector("#posts");
    let postTitle = document.querySelector("#post-title");
    let postBody = document.querySelector("#post-body");
    let commentPlace = document.querySelector("#post-comments");

    let objectsPosts = await (await fetch("http://localhost:3030/jsonstore/blog/posts")).json()


    let comments = await (await fetch("http://localhost:3030/jsonstore/blog/comments")).json()

    const loadPostsButton = document.querySelector("#btnLoadPosts");
    loadPostsButton.addEventListener("click", function () { AddPosts(); });

    const viewPostButton = document.querySelector("#btnViewPost");
    viewPostButton.addEventListener("click", function () { displayInfo(); });



    async function AddPosts() {

        for (const post of Object.values(objectsPosts)) {
            let option = document.createElement("option");
            option.textContent = `${post.title}`;
            option.setAttribute("value", post.id);
            postPlace.appendChild(option)
        }
    }
    async function displayInfo() {
        let select = document.querySelector("#posts");
        let title = select.options[select.selectedIndex].text;
        let id = "";
        let body = "";
        for (const post of Object.values(objectsPosts)) {
            if (post.title === title) {
                id = post.id;
                body = post.body;
                break;
            }
        }
        let count = 0;
        for (const comm of Object.values(comments)) {
            if (comm.postId === id && count === 0) {
                count++;
                postTitle.textContent = title;
                postBody.textContent = body;
                let li = document.createElement("li");
                li.textContent = comm.text;
                commentPlace.appendChild(li);
            }
        }
    }
}

attachEvents();